#load "Fable.Import.WebWorker.fs"
#load "Fable.Helpers.WebWorker.fs"

open Fable.Import.WebWorker
open Fable.Import.WebWorker.ServiceWorker
open Fable.Helpers.WebWorker.Notification


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
            emptyNotification()
            |> withBody "Body text"
            |> withIcon "/assets/android-chrome-192x192.png"
            |> withBadge "/assets/android-chrome-192x192.png"
            |> withData myInfo
            
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