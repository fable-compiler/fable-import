module Fable.Helpers.WebWorker

open Fable.Import.WebWorker
    
    module Notification =
        let emptyNotification() = Fable.Core.JsInterop.createEmpty<NotificationOptions>
        
        let withActions actions (notification : NotificationOptions) =
            notification.actions <- (Some actions)
            notification
        
        let withBadge badge (notification : NotificationOptions) = 
            notification.badge <- Some badge
            notification
            
        let withBody body (notification:NotificationOptions) =
            notification.body <- Some body
            notification
            
        let withData data (notification:NotificationOptions) =
            notification.data <- Some data
            notification
            
        let withDir dir (notification:NotificationOptions) =
            notification.dir <- Some dir
            notification
            
        let withIcon icon (notification:NotificationOptions) =
            notification.icon <- Some icon
            notification        
            
        let withImage image (notification:NotificationOptions) =
            notification.image <- Some image
            notification
            
        let withLang lang (notification:NotificationOptions) =
            notification.lang <- Some lang
            notification
            
        let withRenotify renotify (notification:NotificationOptions) =
            notification.renotify <- Some renotify
            notification
            
        let withRequireInteraction requireInteraction (notification:NotificationOptions) =
            notification.requireInteraction <- Some requireInteraction
            
        let withSilent silent (notification:NotificationOptions) =
            notification.silent <- Some silent
            notification
            
        let withTag tag (notification:NotificationOptions) =
            notification.tag <- Some tag
            notification
            
        let withTimestamp timestamp (notification:NotificationOptions) =
            notification.timestamp <- Some timestamp
            notification
            
        let withVibrate vibratePattern (notification:NotificationOptions) =
            notification.vibrate <- Some vibratePattern
            notification        
