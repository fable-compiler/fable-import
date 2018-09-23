#load "Fable.Import.WebWorker.fs"

open Fable.Import.WebWorker
open Fable.Import.WebWorker.ServiceWorker

self.addEventListener_install(fun installEvent ->
    printfn "service worker installed, %A" installEvent
    installEvent.waitUntil(self.skipWaiting())
)

self.addEventListener_activate(fun activateEvent ->
    printfn "service worker activated, %A" activateEvent
    activateEvent.waitUntil(self.clients.claim())
)

type MyPushNotificationInfo = unit

self.addEventListener_push (fun ev ->
    let json = 
        ev.data
        |> Option.map (fun data -> data.json())

    match json with
    | Some payload ->
        let myInfo = payload :?> MyPushNotificationInfo
        
        let title = "My title"
        let options:NotificationOptions =
            { new NotificationOptions with 
              member x.body 
                with get () = Some"Body text"
                and set (value) = ()
              member x.icon
                with get() = Some "/assets/android-chrome-192x192.png"
                and set (value) = ()
              member x.badge
                with get() = Some "/assets/android-chrome-192x192.png"
                and set (value) = ()
              member x.data
                with get() =  Some (box myInfo)
                and set (value) = ()
              member x.actions
                with get() = None
                and set (value) = () 
              member x.dir
                with get() = None
                and set (value) = ()
              member x.image
                with get() = None
                and set (value) = () 
              member x.lang
                with get() = None
                and set (value) = () 
              member x.renotify
                with get() = None
                and set (value) = () 
              member x.requireInteraction
                with get() = None
                and set (value) = ()
              member x.silent
                with get() = None
                and set (value) = () 
              member x.tag
                with get() = None
                and set (value) = () 
              member x.timestamp
                with get() = None
                and set (value) = () 
              member x.vibrate
                with get() = None
                and set (value) = () }
            
        ev.waitUntil(self.registration.showNotification (title, options))
        
    | None ->
        printfn "no payload"
)

self.addEventListener_notificationclick(fun ev ->
    ev.notification.close()
    let payload =  
        ev.notification.data
        
    let nwi = payload :?> MyPushNotificationInfo
    
    ()
)