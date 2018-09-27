module Fable.Helpers.GoogleMaps

open Fable.Import.GoogleMaps
open Fable.Core.JsInterop

    module Literal =

        let createLatLng lat lng : LatLngLiteral =
            jsOptions (fun latLngLiteral ->
                latLngLiteral.lat <- lat
                latLngLiteral.lng <- lng
            )

        let createLatLngBounds north east south west : LatLngBoundsLiteral =
            jsOptions (fun latLngBoundsLiteral ->
                latLngBoundsLiteral.north <- north
                latLngBoundsLiteral.east <- east
                latLngBoundsLiteral.south <- south
                latLngBoundsLiteral.west <- west
            )