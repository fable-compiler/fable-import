// ts2fable 0.5.2
module rec Leaflet
open System
open Fable.Core
open Fable.Import.JS
open Fable.Import.Browser

let [<Import("LineUtil","leaflet")>] lineUtil: LineUtil.IExports = jsNative
let [<Import("PolyUtil","leaflet")>] polyUtil: PolyUtil.IExports = jsNative
let [<Import("DomUtil","leaflet")>] domUtil: DomUtil.IExports = jsNative
let [<Import("CRS","leaflet")>] cRS: CRS.IExports = jsNative
let [<Import("Projection","leaflet")>] projection: Projection.IExports = jsNative
let [<Import("TileLayer","leaflet")>] tileLayer: TileLayer.IExports = jsNative
let [<Import("SVG","leaflet")>] sVG: SVG.IExports = jsNative
let [<Import("Control","leaflet")>] control: Control.IExports = jsNative
let [<Import("DomEvent","leaflet")>] domEvent: DomEvent.IExports = jsNative
let [<Import("Icon","leaflet")>] icon: Icon.IExports = jsNative
let [<Import("Browser","leaflet")>] browser: Browser.IExports = jsNative
let [<Import("Util","leaflet")>] util: Util.IExports = jsNative

type [<AllowNullLiteral>] IExports =
    abstract Class: ClassStatic
    abstract Transformation: TransformationStatic
    abstract LatLng: LatLngStatic
    abstract latLng: latitude: float * longitude: float * ?altitude: float -> LatLng
    abstract latLng: coords: U4<LatLngTuple, float * float * float, LatLngLiteral, obj> -> LatLng
    abstract LatLngBounds: LatLngBoundsStatic
    abstract latLngBounds: southWest: LatLngExpression * northEast: LatLngExpression -> LatLngBounds
    abstract latLngBounds: latlngs: ResizeArray<LatLngExpression> -> LatLngBounds
    abstract Point: PointStatic
    abstract point: x: float * y: float * ?round: bool -> Point
    abstract point: coords: U2<PointTuple, obj> -> Point
    abstract Bounds: BoundsStatic
    abstract bounds: topLeft: PointExpression * bottomRight: PointExpression -> Bounds
    abstract bounds: points: U2<ResizeArray<Point>, BoundsLiteral> -> Bounds
    abstract Evented: EventedStatic
    abstract Draggable: DraggableStatic
    abstract Layer: LayerStatic
    abstract GridLayer: GridLayerStatic
    abstract gridLayer: ?options: GridLayerOptions -> GridLayer
    abstract TileLayer: TileLayerStatic
    abstract tileLayer: urlTemplate: string * ?options: TileLayerOptions -> TileLayer
    abstract ImageOverlay: ImageOverlayStatic
    abstract imageOverlay: imageUrl: string * bounds: LatLngBoundsExpression * ?options: ImageOverlayOptions -> ImageOverlay
    abstract Path: PathStatic
    abstract Polyline: PolylineStatic
    abstract polyline: latlngs: ResizeArray<LatLngExpression> * ?options: PolylineOptions -> Polyline<_,_>
    abstract Polygon: PolygonStatic
    abstract polygon: latlngs: U2<ResizeArray<LatLngExpression>, ResizeArray<ResizeArray<LatLngExpression>>> * ?options: PolylineOptions -> Polygon<_>
    abstract Rectangle: RectangleStatic
    abstract rectangle: latLngBounds: LatLngBoundsExpression * ?options: PolylineOptions -> Rectangle<_>
    abstract CircleMarker: CircleMarkerStatic
    abstract circleMarker: latlng: LatLngExpression * ?options: CircleMarkerOptions -> CircleMarker<_>
    abstract Circle: CircleStatic
    abstract circle: latlng: LatLngExpression * ?options: CircleMarkerOptions -> Circle<_>
    abstract circle: latlng: LatLngExpression * radius: float * ?options: CircleMarkerOptions -> Circle<_>
    abstract Renderer: RendererStatic
    abstract SVG: SVGStatic
    abstract svg: ?options: RendererOptions -> SVG
    abstract Canvas: CanvasStatic
    abstract canvas: ?options: RendererOptions -> Canvas
    abstract LayerGroup: LayerGroupStatic
    /// Create a layer group, optionally given an initial set of layers and an `options` object.
    abstract layerGroup: ?layers: ResizeArray<Layer> * ?options: LayerOptions -> LayerGroup<_>
    abstract FeatureGroup: FeatureGroupStatic
    /// Create a feature group, optionally given an initial set of layers.
    abstract featureGroup: ?layers: ResizeArray<Layer> -> FeatureGroup<_>
    abstract GeoJSON: GeoJSONStatic
    /// Creates a GeoJSON layer.
    ///
    /// Optionally accepts an object in GeoJSON format to display on the
    /// map (you can alternatively add it later with addData method) and
    /// an options object.
    abstract geoJSON: ?geojson: Geojson.GeoJsonObject * ?options: GeoJSONOptions<'P> -> GeoJSON<'P>
    abstract Control: ControlStatic
    abstract Popup: PopupStatic
    abstract popup: ?options: PopupOptions * ?source: Layer -> Popup
    abstract Tooltip: TooltipStatic
    abstract tooltip: ?options: TooltipOptions * ?source: Layer -> Tooltip
    abstract Handler: HandlerStatic
    abstract Map: MapStatic
    /// ID of a HTML-Element as string or the HTML-ELement itself
    abstract map: element: U2<string, HTMLElement> * ?options: MapOptions -> Map
    abstract Icon: IconStatic
    abstract icon: options: IconOptions -> Icon<_>
    abstract DivIcon: DivIconStatic
    abstract divIcon: ?options: DivIconOptions -> DivIcon
    abstract Marker: MarkerStatic
    abstract marker: latlng: LatLngExpression * ?options: MarkerOptions -> Marker<_>

type [<AllowNullLiteral>] Class =
    interface end

type [<AllowNullLiteral>] ClassStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Class
    abstract extend: props: obj option -> obj option
    abstract ``include``: props: obj option -> obj option
    abstract mergeOptions: props: obj option -> obj option
    abstract addInitHook: initHookFn: (unit -> unit) -> obj option

type [<AllowNullLiteral>] Transformation =
    abstract transform: point: Point * ?scale: float -> Point
    abstract untransform: point: Point * ?scale: float -> Point

type [<AllowNullLiteral>] TransformationStatic =
    [<Emit "new $0($1...)">] abstract Create: a: float * b: float * c: float * d: float -> Transformation

module LineUtil =

    type [<AllowNullLiteral>] IExports =
        abstract simplify: points: ResizeArray<Point> * tolerance: float -> ResizeArray<Point>
        abstract pointToSegmentDistance: p: Point * p1: Point * p2: Point -> float
        abstract closestPointOnSegment: p: Point * p1: Point * p2: Point -> Point
        abstract isFlat: latlngs: ResizeArray<LatLngExpression> -> bool

module PolyUtil =

    type [<AllowNullLiteral>] IExports =
        abstract clipPolygon: points: ResizeArray<Point> * bounds: BoundsExpression * ?round: bool -> ResizeArray<Point>

module DomUtil =

    type [<AllowNullLiteral>] IExports =
        /// Get Element by its ID or with the given HTML-Element
        abstract get: element: U2<string, HTMLElement> -> HTMLElement option
        abstract getStyle: el: HTMLElement * styleAttrib: string -> string option
        abstract create: tagName: string * ?className: string * ?container: HTMLElement -> HTMLElement
        abstract remove: el: HTMLElement -> unit
        abstract empty: el: HTMLElement -> unit
        abstract toFront: el: HTMLElement -> unit
        abstract toBack: el: HTMLElement -> unit
        abstract hasClass: el: HTMLElement * name: string -> bool
        abstract addClass: el: HTMLElement * name: string -> unit
        abstract removeClass: el: HTMLElement * name: string -> unit
        abstract setClass: el: HTMLElement * name: string -> unit
        abstract getClass: el: HTMLElement -> string
        abstract setOpacity: el: HTMLElement * opacity: float -> unit
        abstract testProp: props: ResizeArray<string> -> U2<string, obj>
        abstract setTransform: el: HTMLElement * offset: Point * ?scale: float -> unit
        abstract setPosition: el: HTMLElement * position: Point -> unit
        abstract getPosition: el: HTMLElement -> Point
        abstract disableTextSelection: unit -> unit
        abstract enableTextSelection: unit -> unit
        abstract disableImageDrag: unit -> unit
        abstract enableImageDrag: unit -> unit
        abstract preventOutline: el: HTMLElement -> unit
        abstract restoreOutline: unit -> unit
        abstract TRANSFORM: string
        abstract TRANSITION: string
        abstract TRANSITION_END: string

type [<AllowNullLiteral>] CRS =
    abstract latLngToPoint: latlng: LatLngExpression * zoom: float -> Point
    abstract pointToLatLng: point: PointExpression * zoom: float -> LatLng
    abstract project: latlng: U2<LatLng, LatLngLiteral> -> Point
    abstract unproject: point: PointExpression -> LatLng
    abstract scale: zoom: float -> float
    abstract zoom: scale: float -> float
    abstract getProjectedBounds: zoom: float -> Bounds
    abstract distance: latlng1: LatLngExpression * latlng2: LatLngExpression -> float
    abstract wrapLatLng: latlng: U2<LatLng, LatLngLiteral> -> LatLng
    abstract code: string option with get, set
    abstract wrapLng: float * float option with get, set
    abstract wrapLat: float * float option with get, set
    abstract infinite: bool with get, set

module CRS =

    type [<AllowNullLiteral>] IExports =
        abstract EPSG3395: CRS
        abstract EPSG3857: CRS
        abstract EPSG4326: CRS
        abstract Earth: CRS
        abstract Simple: CRS

type [<AllowNullLiteral>] Projection =
    abstract project: latlng: U2<LatLng, LatLngLiteral> -> Point
    abstract unproject: point: PointExpression -> LatLng
    abstract bounds: Bounds with get, set

module Projection =

    type [<AllowNullLiteral>] IExports =
        abstract LonLat: Projection
        abstract Mercator: Projection
        abstract SphericalMercator: Projection

type [<AllowNullLiteral>] LatLng =
    abstract equals: otherLatLng: LatLngExpression * ?maxMargin: float -> bool
    abstract toString: unit -> string
    abstract distanceTo: otherLatLng: LatLngExpression -> float
    abstract wrap: unit -> LatLng
    abstract toBounds: sizeInMeters: float -> LatLngBounds
    abstract lat: float with get, set
    abstract lng: float with get, set
    abstract alt: float option with get, set

type [<AllowNullLiteral>] LatLngStatic =
    [<Emit "new $0($1...)">] abstract Create: latitude: float * longitude: float * ?altitude: float -> LatLng

type [<AllowNullLiteral>] LatLngLiteral =
    abstract lat: float with get, set
    abstract lng: float with get, set

type LatLngTuple =
    float * float

type LatLngExpression =
    U3<LatLng, LatLngLiteral, LatLngTuple>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module LatLngExpression =
    let ofLatLng v: LatLngExpression = v |> U3.Case1
    let isLatLng (v: LatLngExpression) = match v with U3.Case1 _ -> true | _ -> false
    let asLatLng (v: LatLngExpression) = match v with U3.Case1 o -> Some o | _ -> None
    let ofLatLngLiteral v: LatLngExpression = v |> U3.Case2
    let isLatLngLiteral (v: LatLngExpression) = match v with U3.Case2 _ -> true | _ -> false
    let asLatLngLiteral (v: LatLngExpression) = match v with U3.Case2 o -> Some o | _ -> None
    let ofLatLngTuple v: LatLngExpression = v |> U3.Case3
    let isLatLngTuple (v: LatLngExpression) = match v with U3.Case3 _ -> true | _ -> false
    let asLatLngTuple (v: LatLngExpression) = match v with U3.Case3 o -> Some o | _ -> None

type [<AllowNullLiteral>] LatLngBounds =
    abstract extend: latlngOrBounds: U2<LatLngExpression, LatLngBoundsExpression> -> LatLngBounds
    abstract pad: bufferRatio: float -> LatLngBounds
    abstract getCenter: unit -> LatLng
    abstract getSouthWest: unit -> LatLng
    abstract getNorthEast: unit -> LatLng
    abstract getNorthWest: unit -> LatLng
    abstract getSouthEast: unit -> LatLng
    abstract getWest: unit -> float
    abstract getSouth: unit -> float
    abstract getEast: unit -> float
    abstract getNorth: unit -> float
    abstract contains: otherBoundsOrLatLng: U2<LatLngBoundsExpression, LatLngExpression> -> bool
    abstract intersects: otherBounds: LatLngBoundsExpression -> bool
    abstract overlaps: otherBounds: BoundsExpression -> bool
    abstract toBBoxString: unit -> string
    abstract equals: otherBounds: LatLngBoundsExpression -> bool
    abstract isValid: unit -> bool

type [<AllowNullLiteral>] LatLngBoundsStatic =
    [<Emit "new $0($1...)">] abstract Create: southWest: LatLngExpression * northEast: LatLngExpression -> LatLngBounds
    [<Emit "new $0($1...)">] abstract Create: latlngs: LatLngBoundsLiteral -> LatLngBounds

type LatLngBoundsLiteral =
    ResizeArray<LatLngTuple>

type LatLngBoundsExpression =
    U2<LatLngBounds, LatLngBoundsLiteral>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module LatLngBoundsExpression =
    let ofLatLngBounds v: LatLngBoundsExpression = v |> U2.Case1
    let isLatLngBounds (v: LatLngBoundsExpression) = match v with U2.Case1 _ -> true | _ -> false
    let asLatLngBounds (v: LatLngBoundsExpression) = match v with U2.Case1 o -> Some o | _ -> None
    let ofLatLngBoundsLiteral v: LatLngBoundsExpression = v |> U2.Case2
    let isLatLngBoundsLiteral (v: LatLngBoundsExpression) = match v with U2.Case2 _ -> true | _ -> false
    let asLatLngBoundsLiteral (v: LatLngBoundsExpression) = match v with U2.Case2 o -> Some o | _ -> None

type PointTuple =
    float * float

type [<AllowNullLiteral>] Point =
    abstract clone: unit -> Point
    abstract add: otherPoint: PointExpression -> Point
    abstract subtract: otherPoint: PointExpression -> Point
    abstract divideBy: num: float -> Point
    abstract multiplyBy: num: float -> Point
    abstract scaleBy: scale: PointExpression -> Point
    abstract unscaleBy: scale: PointExpression -> Point
    abstract round: unit -> Point
    abstract floor: unit -> Point
    abstract ceil: unit -> Point
    abstract distanceTo: otherPoint: PointExpression -> float
    abstract equals: otherPoint: PointExpression -> bool
    abstract contains: otherPoint: PointExpression -> bool
    abstract toString: unit -> string
    abstract x: float with get, set
    abstract y: float with get, set

type [<AllowNullLiteral>] PointStatic =
    [<Emit "new $0($1...)">] abstract Create: x: float * y: float * ?round: bool -> Point

type [<AllowNullLiteral>] Coords =
    inherit Point
    abstract z: float with get, set

type PointExpression =
    U2<Point, PointTuple>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module PointExpression =
    let ofPoint v: PointExpression = v |> U2.Case1
    let isPoint (v: PointExpression) = match v with U2.Case1 _ -> true | _ -> false
    let asPoint (v: PointExpression) = match v with U2.Case1 o -> Some o | _ -> None
    let ofPointTuple v: PointExpression = v |> U2.Case2
    let isPointTuple (v: PointExpression) = match v with U2.Case2 _ -> true | _ -> false
    let asPointTuple (v: PointExpression) = match v with U2.Case2 o -> Some o | _ -> None

type BoundsLiteral =
    PointTuple * PointTuple

type [<AllowNullLiteral>] Bounds =
    abstract extend: point: PointExpression -> Bounds
    abstract getCenter: ?round: bool -> Point
    abstract getBottomLeft: unit -> Point
    abstract getTopRight: unit -> Point
    abstract getSize: unit -> Point
    abstract contains: pointOrBounds: U2<BoundsExpression, PointExpression> -> bool
    abstract intersects: otherBounds: BoundsExpression -> bool
    abstract overlaps: otherBounds: BoundsExpression -> bool
    abstract min: Point option with get, set
    abstract max: Point option with get, set

type [<AllowNullLiteral>] BoundsStatic =
    [<Emit "new $0($1...)">] abstract Create: topLeft: PointExpression * bottomRight: PointExpression -> Bounds
    [<Emit "new $0($1...)">] abstract Create: points: U2<ResizeArray<Point>, BoundsLiteral> -> Bounds

type BoundsExpression =
    U2<Bounds, BoundsLiteral>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module BoundsExpression =
    let ofBounds v: BoundsExpression = v |> U2.Case1
    let isBounds (v: BoundsExpression) = match v with U2.Case1 _ -> true | _ -> false
    let asBounds (v: BoundsExpression) = match v with U2.Case1 o -> Some o | _ -> None
    let ofBoundsLiteral v: BoundsExpression = v |> U2.Case2
    let isBoundsLiteral (v: BoundsExpression) = match v with U2.Case2 _ -> true | _ -> false
    let asBoundsLiteral (v: BoundsExpression) = match v with U2.Case2 o -> Some o | _ -> None

type LeafletEventHandlerFn =
    (LeafletEvent -> unit)

type [<AllowNullLiteral>] LeafletEventHandlerFnMap =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: ``type``: string -> LeafletEventHandlerFn with get, set

/// A set of methods shared between event-powered classes (like Map and Marker).
/// Generally, events allow you to execute some function when something happens
/// with an object (e.g. the user clicks on the map, causing the map to fire
/// 'click' event).
type [<AllowNullLiteral>] Evented =
    inherit Class
    /// Adds a listener function (fn) to a particular event type of the object.
    /// You can optionally specify the context of the listener (object the this
    /// keyword will point to). You can also pass several space-separated types
    /// (e.g. 'click dblclick').
    abstract on: ``type``: string * fn: LeafletEventHandlerFn * ?context: obj option -> Evented
    /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
    abstract on: eventMap: LeafletEventHandlerFnMap -> Evented
    /// Removes a previously added listener function. If no function is specified,
    /// it will remove all the listeners of that particular event from the object.
    /// Note that if you passed a custom context to on, you must pass the same context
    /// to off in order to remove the listener.
    abstract off: ``type``: string * ?fn: LeafletEventHandlerFn * ?context: obj option -> Evented
    /// Removes a set of type/listener pairs.
    abstract off: eventMap: LeafletEventHandlerFnMap -> Evented
    /// Removes all listeners to all events on the object.
    abstract off: unit -> Evented
    /// Fires an event of the specified type. You can optionally provide a data
    /// object — the first argument of the listener function will contain its properties.
    /// The event might can optionally be propagated to event parents.
    abstract fire: ``type``: string * ?data: obj option * ?propagate: bool -> Evented
    /// Returns true if a particular event type has any listeners attached to it.
    abstract listens: ``type``: string -> bool
    /// Behaves as on(...), except the listener will only get fired once and then removed.
    abstract once: ``type``: string * fn: LeafletEventHandlerFn * ?context: obj option -> Evented
    /// Behaves as on(...), except the listener will only get fired once and then removed.
    abstract once: eventMap: LeafletEventHandlerFnMap -> Evented
    /// Adds an event parent - an Evented that will receive propagated events
    abstract addEventParent: obj: Evented -> Evented
    /// Removes an event parent, so it will stop receiving propagated events
    abstract removeEventParent: obj: Evented -> Evented
    /// Alias for on(...)
    ///
    /// Adds a listener function (fn) to a particular event type of the object.
    /// You can optionally specify the context of the listener (object the this
    /// keyword will point to). You can also pass several space-separated types
    /// (e.g. 'click dblclick').
    abstract addEventListener: ``type``: string * fn: LeafletEventHandlerFn * ?context: obj option -> Evented
    /// Alias for on(...)
    ///
    /// Adds a set of type/listener pairs, e.g. {click: onClick, mousemove: onMouseMove}
    abstract addEventListener: eventMap: LeafletEventHandlerFnMap -> Evented
    /// Alias for off(...)
    ///
    /// Removes a previously added listener function. If no function is specified,
    /// it will remove all the listeners of that particular event from the object.
    /// Note that if you passed a custom context to on, you must pass the same context
    /// to off in order to remove the listener.
    abstract removeEventListener: ``type``: string * fn: LeafletEventHandlerFn * ?context: obj option -> Evented
    /// Alias for off(...)
    ///
    /// Removes a set of type/listener pairs.
    abstract removeEventListener: eventMap: LeafletEventHandlerFnMap -> Evented
    /// Alias for off()
    ///
    /// Removes all listeners to all events on the object.
    abstract clearAllEventListeners: unit -> Evented
    /// Alias for once(...)
    ///
    /// Behaves as on(...), except the listener will only get fired once and then removed.
    abstract addOneTimeEventListener: ``type``: string * fn: LeafletEventHandlerFn * ?context: obj option -> Evented
    /// Alias for once(...)
    ///
    /// Behaves as on(...), except the listener will only get fired once and then removed.
    abstract addOneTimeEventListener: eventMap: LeafletEventHandlerFnMap -> Evented
    /// Alias for fire(...)
    ///
    /// Fires an event of the specified type. You can optionally provide a data
    /// object — the first argument of the listener function will contain its properties.
    /// The event might can optionally be propagated to event parents.
    abstract fireEvent: ``type``: string * ?data: obj option * ?propagate: bool -> Evented
    /// Alias for listens(...)
    ///
    /// Returns true if a particular event type has any listeners attached to it.
    abstract hasEventListeners: ``type``: string -> bool

/// A set of methods shared between event-powered classes (like Map and Marker).
/// Generally, events allow you to execute some function when something happens
/// with an object (e.g. the user clicks on the map, causing the map to fire
/// 'click' event).
type [<AllowNullLiteral>] EventedStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Evented

/// A class for making DOM elements draggable (including touch support).
/// Used internally for map and marker dragging. Only works for elements
/// that were positioned with [`L.DomUtil.setPosition`](#domutil-setposition).
type [<AllowNullLiteral>] Draggable =
    inherit Evented
    abstract enable: unit -> unit
    abstract disable: unit -> unit
    abstract finishDrag: unit -> unit

/// A class for making DOM elements draggable (including touch support).
/// Used internally for map and marker dragging. Only works for elements
/// that were positioned with [`L.DomUtil.setPosition`](#domutil-setposition).
type [<AllowNullLiteral>] DraggableStatic =
    [<Emit "new $0($1...)">] abstract Create: element: HTMLElement * ?dragStartTarget: HTMLElement * ?preventOutline: bool -> Draggable

type [<AllowNullLiteral>] LayerOptions =
    abstract pane: string option with get, set
    abstract attribution: string option with get, set

type [<AllowNullLiteral>] InteractiveLayerOptions =
    inherit LayerOptions
    abstract interactive: bool option with get, set

type [<AllowNullLiteral>] Layer =
    inherit Evented
    abstract addTo: map: U2<Map, LayerGroup<_>> -> Layer
    abstract remove: unit -> Layer
    abstract removeFrom: map: Map -> Layer
    abstract getPane: ?name: string -> HTMLElement option
    abstract bindPopup: content: U3<(Layer -> Content), Content, Popup> * ?options: PopupOptions -> Layer
    abstract unbindPopup: unit -> Layer
    abstract openPopup: ?latlng: LatLngExpression -> Layer
    abstract closePopup: unit -> Layer
    abstract togglePopup: unit -> Layer
    abstract isPopupOpen: unit -> bool
    abstract setPopupContent: content: U2<Content, Popup> -> Layer
    abstract getPopup: unit -> Popup option
    abstract bindTooltip: content: U3<(Layer -> Content), Tooltip, Content> * ?options: TooltipOptions -> Layer
    abstract unbindTooltip: unit -> Layer
    abstract openTooltip: ?latlng: LatLngExpression -> Layer
    abstract closeTooltip: unit -> Layer
    abstract toggleTooltip: unit -> Layer
    abstract isTooltipOpen: unit -> bool
    abstract setTooltipContent: content: U2<Content, Tooltip> -> Layer
    abstract getTooltip: unit -> Tooltip option
    abstract onAdd: map: Map -> Layer
    abstract onRemove: map: Map -> Layer
    abstract getEvents: unit -> obj
    abstract getAttribution: unit -> string option
    abstract beforeAdd: map: Map -> Layer
    abstract _map: Map with get, set

type [<AllowNullLiteral>] LayerStatic =
    [<Emit "new $0($1...)">] abstract Create: ?options: LayerOptions -> Layer

type [<AllowNullLiteral>] GridLayerOptions =
    abstract tileSize: U2<float, Point> option with get, set
    abstract opacity: float option with get, set
    abstract updateWhenIdle: bool option with get, set
    abstract updateWhenZooming: bool option with get, set
    abstract updateInterval: float option with get, set
    abstract attribution: string option with get, set
    abstract zIndex: float option with get, set
    abstract bounds: LatLngBoundsExpression option with get, set
    abstract minZoom: float option with get, set
    abstract maxZoom: float option with get, set
    abstract noWrap: bool option with get, set
    abstract pane: string option with get, set
    abstract className: string option with get, set
    abstract keepBuffer: float option with get, set

type DoneCallback =
    (Error -> HTMLElement -> unit)

type [<AllowNullLiteral>] InternalTiles =
    [<Emit "$0[$1]{{=$2}}">] abstract Item: key: string -> obj with get, set

type [<AllowNullLiteral>] GridLayer =
    inherit Layer
    abstract bringToFront: unit -> GridLayer
    abstract bringToBack: unit -> GridLayer
    abstract getContainer: unit -> HTMLElement option
    abstract setOpacity: opacity: float -> GridLayer
    abstract setZIndex: zIndex: float -> GridLayer
    abstract isLoading: unit -> bool
    abstract redraw: unit -> GridLayer
    abstract getTileSize: unit -> Point
    abstract createTile: coords: Coords * ``done``: DoneCallback -> HTMLElement
    abstract _tileCoordsToKey: coords: Coords -> string
    abstract _tiles: InternalTiles with get, set
    abstract _tileZoom: float option with get, set

type [<AllowNullLiteral>] GridLayerStatic =
    [<Emit "new $0($1...)">] abstract Create: ?options: GridLayerOptions -> GridLayer

type [<AllowNullLiteral>] TileLayerOptions =
    inherit GridLayerOptions
    abstract minZoom: float option with get, set
    abstract maxZoom: float option with get, set
    abstract maxNativeZoom: float option with get, set
    abstract minNativeZoom: float option with get, set
    abstract subdomains: U2<string, ResizeArray<string>> option with get, set
    abstract errorTileUrl: string option with get, set
    abstract zoomOffset: float option with get, set
    abstract tms: bool option with get, set
    abstract zoomReverse: bool option with get, set
    abstract detectRetina: bool option with get, set
    abstract crossOrigin: bool option with get, set
    [<Emit "$0[$1]{{=$2}}">] abstract Item: name: string -> obj option with get, set

type [<AllowNullLiteral>] TileLayer =
    inherit GridLayer
    abstract setUrl: url: string * ?noRedraw: bool -> TileLayer
    abstract _abortLoading: unit -> unit
    abstract _getZoomForUrl: unit -> float
    abstract options: TileLayerOptions with get, set

type [<AllowNullLiteral>] TileLayerStatic =
    [<Emit "new $0($1...)">] abstract Create: urlTemplate: string * ?options: TileLayerOptions -> TileLayer

module TileLayer =

    type [<AllowNullLiteral>] IExports =
        abstract WMS: WMSStatic

    type [<AllowNullLiteral>] WMS =
        inherit TileLayer
        abstract setParams: ``params``: WMSParams * ?noRedraw: bool -> WMS
        abstract wmsParams: WMSParams with get, set
        abstract options: WMSOptions with get, set

    type [<AllowNullLiteral>] WMSStatic =
        [<Emit "new $0($1...)">] abstract Create: baseUrl: string * options: WMSOptions -> WMS

type [<AllowNullLiteral>] WMSOptions =
    inherit TileLayerOptions
    abstract layers: string option with get, set
    abstract styles: string option with get, set
    abstract format: string option with get, set
    abstract transparent: bool option with get, set
    abstract version: string option with get, set
    abstract crs: CRS option with get, set
    abstract uppercase: bool option with get, set

type [<AllowNullLiteral>] WMSParams =
    abstract format: string option with get, set
    abstract layers: string with get, set
    abstract request: string option with get, set
    abstract service: string option with get, set
    abstract styles: string option with get, set
    abstract version: string option with get, set
    abstract transparent: bool option with get, set
    abstract width: float option with get, set
    abstract height: float option with get, set

// module TileLayer =

//     type [<AllowNullLiteral>] IExports =
//         abstract wms: baseUrl: string * ?options: WMSOptions -> TileLayer.WMS

type [<AllowNullLiteral>] ImageOverlayOptions =
    inherit LayerOptions
    abstract opacity: float option with get, set
    abstract alt: string option with get, set
    abstract interactive: bool option with get, set
    abstract attribution: string option with get, set
    abstract crossOrigin: bool option with get, set

type [<AllowNullLiteral>] ImageOverlay =
    inherit Layer
    abstract setOpacity: opacity: float -> ImageOverlay
    abstract bringToFront: unit -> ImageOverlay
    abstract bringToBack: unit -> ImageOverlay
    abstract setUrl: url: string -> ImageOverlay
    /// Update the bounds that this ImageOverlay covers
    abstract setBounds: bounds: LatLngBounds -> ImageOverlay
    /// Get the bounds that this ImageOverlay covers
    abstract getBounds: unit -> LatLngBounds
    /// Get the img element that represents the ImageOverlay on the map
    abstract getElement: unit -> HTMLImageElement option
    abstract options: ImageOverlayOptions with get, set

type [<AllowNullLiteral>] ImageOverlayStatic =
    [<Emit "new $0($1...)">] abstract Create: imageUrl: string * bounds: LatLngBoundsExpression * ?options: ImageOverlayOptions -> ImageOverlay

type [<StringEnum>] [<RequireQualifiedAccess>] LineCapShape =
    | Butt
    | Round
    | Square
    | Inherit

type [<StringEnum>] [<RequireQualifiedAccess>] LineJoinShape =
    | Miter
    | Round
    | Bevel
    | Inherit

type [<StringEnum>] [<RequireQualifiedAccess>] FillRule =
    | Nonzero
    | Evenodd
    | Inherit

type [<AllowNullLiteral>] PathOptions =
    inherit InteractiveLayerOptions
    abstract stroke: bool option with get, set
    abstract color: string option with get, set
    abstract weight: float option with get, set
    abstract opacity: float option with get, set
    abstract lineCap: LineCapShape option with get, set
    abstract lineJoin: LineJoinShape option with get, set
    abstract dashArray: string option with get, set
    abstract dashOffset: string option with get, set
    abstract fill: bool option with get, set
    abstract fillColor: string option with get, set
    abstract fillOpacity: float option with get, set
    abstract fillRule: FillRule option with get, set
    abstract renderer: Renderer option with get, set
    abstract className: string option with get, set

type [<AllowNullLiteral>] Path =
    inherit Layer
    abstract redraw: unit -> Path
    abstract setStyle: style: PathOptions -> Path
    abstract bringToFront: unit -> Path
    abstract bringToBack: unit -> Path
    abstract getElement: unit -> Element option
    abstract options: PathOptions with get, set

type [<AllowNullLiteral>] PathStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Path

type [<AllowNullLiteral>] PolylineOptions =
    inherit PathOptions
    abstract smoothFactor: float option with get, set
    abstract noClip: bool option with get, set

type [<AllowNullLiteral>] Polyline<'T, 'P> =
    inherit Path
    abstract toGeoJSON: unit -> Geojson.Feature<'T, 'P>
    abstract getLatLngs: unit -> ResizeArray<LatLng>
    abstract setLatLngs: latlngs: ResizeArray<LatLngExpression> -> Polyline<'T, 'P>
    abstract isEmpty: unit -> bool
    abstract getCenter: unit -> LatLng
    abstract getBounds: unit -> LatLngBounds
    abstract addLatLng: latlng: U2<LatLngExpression, ResizeArray<LatLngExpression>> -> Polyline<'T, 'P>
    abstract feature: Geojson.Feature<'T, 'P> option with get, set
    abstract options: PolylineOptions with get, set

type [<AllowNullLiteral>] PolylineStatic =
    [<Emit "new $0($1...)">] abstract Create: latlngs: ResizeArray<LatLngExpression> * ?options: PolylineOptions -> Polyline<'T, 'P>

type [<AllowNullLiteral>] Polygon<'P> =
    inherit Polyline<U2<Geojson.Polygon, Geojson.MultiPolygon>, 'P>

type [<AllowNullLiteral>] PolygonStatic =
    [<Emit "new $0($1...)">] abstract Create: latlngs: U2<ResizeArray<LatLngExpression>, ResizeArray<ResizeArray<LatLngExpression>>> * ?options: PolylineOptions -> Polygon<'P>

type [<AllowNullLiteral>] Rectangle<'P> =
    inherit Polygon<'P>
    abstract setBounds: latLngBounds: LatLngBoundsExpression -> Rectangle<'P>

type [<AllowNullLiteral>] RectangleStatic =
    [<Emit "new $0($1...)">] abstract Create: latLngBounds: LatLngBoundsExpression * ?options: PolylineOptions -> Rectangle<'P>

type [<AllowNullLiteral>] CircleMarkerOptions =
    inherit PathOptions
    abstract radius: float option with get, set

type [<AllowNullLiteral>] CircleMarker<'P> =
    inherit Path
    abstract toGeoJSON: unit -> Geojson.Feature<Geojson.Point, 'P>
    abstract setLatLng: latLng: LatLngExpression -> CircleMarker<'P>
    abstract getLatLng: unit -> LatLng
    abstract setRadius: radius: float -> CircleMarker<'P>
    abstract getRadius: unit -> float
    abstract options: CircleMarkerOptions with get, set
    abstract feature: Geojson.Feature<Geojson.Point, 'P> option with get, set

type [<AllowNullLiteral>] CircleMarkerStatic =
    [<Emit "new $0($1...)">] abstract Create: latlng: LatLngExpression * ?options: CircleMarkerOptions -> CircleMarker<'P>

type [<AllowNullLiteral>] Circle<'P> =
    inherit CircleMarker<'P>
    abstract getBounds: unit -> LatLngBounds

type [<AllowNullLiteral>] CircleStatic =
    [<Emit "new $0($1...)">] abstract Create: latlng: LatLngExpression * ?options: CircleMarkerOptions -> Circle<'P>
    [<Emit "new $0($1...)">] abstract Create: latlng: LatLngExpression * radius: float * ?options: CircleMarkerOptions -> Circle<'P>

type [<AllowNullLiteral>] RendererOptions =
    inherit LayerOptions
    abstract padding: float option with get, set

type [<AllowNullLiteral>] Renderer =
    inherit Layer
    abstract options: RendererOptions with get, set

type [<AllowNullLiteral>] RendererStatic =
    [<Emit "new $0($1...)">] abstract Create: ?options: RendererOptions -> Renderer

type [<AllowNullLiteral>] SVG =
    inherit Renderer

type [<AllowNullLiteral>] SVGStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> SVG

module SVG =

    type [<AllowNullLiteral>] IExports =
        abstract create: name: string -> SVGElement
        abstract pointsToPath: rings: ResizeArray<PointExpression> * close: bool -> string

type [<AllowNullLiteral>] Canvas =
    inherit Renderer

type [<AllowNullLiteral>] CanvasStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> Canvas

/// Used to group several layers and handle them as one.
/// If you add it to the map, any layers added or removed from the group will be
/// added/removed on the map as well. Extends Layer.
type [<AllowNullLiteral>] LayerGroup<'P> =
    inherit Layer
    /// Returns a GeoJSON representation of the layer group (as a GeoJSON GeometryCollection, GeoJSONFeatureCollection or Multipoint).
    abstract toGeoJSON: unit -> U3<Geojson.FeatureCollection<Geojson.GeometryObject, 'P>, Geojson.Feature<Geojson.MultiPoint, 'P>, Geojson.GeometryCollection>
    /// Adds the given layer to the group.
    abstract addLayer: layer: Layer -> LayerGroup<'P>
    /// Removes the layer with the given internal ID or the given layer from the group.
    abstract removeLayer: layer: U2<float, Layer> -> LayerGroup<'P>
    /// Returns true if the given layer is currently added to the group.
    abstract hasLayer: layer: Layer -> bool
    /// Removes all the layers from the group.
    abstract clearLayers: unit -> LayerGroup<'P>
    /// Calls methodName on every layer contained in this group, passing any additional parameters.
    /// Has no effect if the layers contained do not implement methodName.
    abstract invoke: methodName: string * [<ParamArray>] ``params``: ResizeArray<obj option> -> LayerGroup<'P>
    /// Iterates over the layers of the group,
    /// optionally specifying context of the iterator function.
    abstract eachLayer: fn: (Layer -> unit) * ?context: obj option -> LayerGroup<'P>
    /// Returns the layer with the given internal ID.
    abstract getLayer: id: float -> Layer option
    /// Returns an array of all the layers added to the group.
    abstract getLayers: unit -> ResizeArray<Layer>
    /// Calls setZIndex on every layer contained in this group, passing the z-index.
    abstract setZIndex: zIndex: float -> LayerGroup<'P>
    /// Returns the internal ID for a layer
    abstract getLayerId: layer: Layer -> float
    abstract feature: U3<Geojson.FeatureCollection<Geojson.GeometryObject, 'P>, Geojson.Feature<Geojson.MultiPoint, 'P>, Geojson.GeometryCollection> option with get, set

/// Used to group several layers and handle them as one.
/// If you add it to the map, any layers added or removed from the group will be
/// added/removed on the map as well. Extends Layer.
type [<AllowNullLiteral>] LayerGroupStatic =
    [<Emit "new $0($1...)">] abstract Create: ?layers: ResizeArray<Layer> * ?options: LayerOptions -> LayerGroup<'P>

/// Extended LayerGroup that also has mouse events (propagated from
/// members of the group) and a shared bindPopup method.
type [<AllowNullLiteral>] FeatureGroup<'P> =
    inherit LayerGroup<'P>
    /// Sets the given path options to each layer of the group that has a setStyle method.
    abstract setStyle: style: PathOptions -> FeatureGroup<'P>
    /// Brings the layer group to the top of all other layers
    abstract bringToFront: unit -> FeatureGroup<'P>
    /// Brings the layer group to the top [sic] of all other layers
    abstract bringToBack: unit -> FeatureGroup<'P>
    /// Returns the LatLngBounds of the Feature Group (created from
    /// bounds and coordinates of its children).
    abstract getBounds: unit -> LatLngBounds

/// Extended LayerGroup that also has mouse events (propagated from
/// members of the group) and a shared bindPopup method.
type [<AllowNullLiteral>] FeatureGroupStatic =
    [<Emit "new $0($1...)">] abstract Create: unit -> FeatureGroup<'P>

type StyleFunction<'P> =
    (Geojson.Feature<Geojson.GeometryObject, 'P> -> PathOptions)

type [<AllowNullLiteral>] GeoJSONOptions<'P> =
    inherit LayerOptions
    /// A Function defining how GeoJSON points spawn Leaflet layers.
    /// It is internally called when data is added, passing the GeoJSON point
    /// feature and its LatLng.
    ///
    /// The default is to spawn a default Marker:
    ///
    /// ```
    /// function(geoJsonPoint, latlng) {
    ///      return L.marker(latlng);
    /// }
    /// ```
    abstract pointToLayer: geoJsonPoint: Geojson.Feature<Geojson.Point, 'P> * latlng: LatLng -> Layer
    /// A Function defining the Path options for styling GeoJSON lines and polygons,
    /// called internally when data is added.
    ///
    /// The default value is to not override any defaults:
    ///
    /// ```
    /// function (geoJsonFeature) {
    ///      return {}
    /// }
    /// ```
    abstract style: StyleFunction<'P> option with get, set
    /// A Function that will be called once for each created Feature, after it
    /// has been created and styled. Useful for attaching events and popups to features.
    ///
    /// The default is to do nothing with the newly created layers:
    ///
    /// ```
    /// function (feature, layer) {}
    /// ```
    abstract onEachFeature: feature: Geojson.Feature<Geojson.GeometryObject, 'P> * layer: Layer -> unit
    /// A Function that will be used to decide whether to show a feature or not.
    ///
    /// The default is to show all features:
    ///
    /// ```
    /// function (geoJsonFeature) {
    ///      return true;
    /// }
    /// ```
    abstract filter: geoJsonFeature: Geojson.Feature<Geojson.GeometryObject, 'P> -> bool
    /// A Function that will be used for converting GeoJSON coordinates to LatLngs.
    /// The default is the coordsToLatLng static method.
    abstract coordsToLatLng: coords: U2<float * float, float * float * float> -> LatLng

/// Represents a GeoJSON object or an array of GeoJSON objects.
/// Allows you to parse GeoJSON data and display it on the map. Extends FeatureGroup.
type [<AllowNullLiteral>] GeoJSON<'P> =
    inherit FeatureGroup<'P>
    /// Adds a GeoJSON object to the layer.
    abstract addData: data: Geojson.GeoJsonObject -> Layer
    /// Resets the given vector layer's style to the original GeoJSON style,
    /// useful for resetting style after hover events.
    abstract resetStyle: layer: Layer -> Layer
    abstract options: GeoJSONOptions<'P> with get, set

/// Represents a GeoJSON object or an array of GeoJSON objects.
/// Allows you to parse GeoJSON data and display it on the map. Extends FeatureGroup.
type [<AllowNullLiteral>] GeoJSONStatic =
    /// Creates a Layer from a given GeoJSON feature. Can use a custom pointToLayer
    /// and/or coordsToLatLng functions if provided as options.
    abstract geometryToLayer: featureData: Geojson.Feature<Geojson.GeometryObject, 'P> * ?options: GeoJSONOptions<'P> -> Layer
    /// Creates a LatLng object from an array of 2 numbers (longitude, latitude) or
    /// 3 numbers (longitude, latitude, altitude) used in GeoJSON for points.
    abstract coordsToLatLng: coords: U2<float * float, float * float * float> -> LatLng
    /// Creates a multidimensional array of LatLngs from a GeoJSON coordinates array.
    /// levelsDeep specifies the nesting level (0 is for an array of points, 1 for an array of
    /// arrays of points, etc., 0 by default).
    /// Can use a custom coordsToLatLng function.
    abstract coordsToLatLngs: coords: ResizeArray<obj option> * ?levelsDeep: float * ?coordsToLatLng: (U2<float * float, float * float * float> -> LatLng) -> ResizeArray<obj option>
    /// Reverse of coordsToLatLng
    abstract latLngToCoords: latlng: LatLng -> U2<float * float, float * float * float>
    /// Reverse of coordsToLatLngs closed determines whether the first point should be
    /// appended to the end of the array to close the feature, only used when levelsDeep is 0.
    /// False by default.
    abstract latLngsToCoords: latlngs: ResizeArray<obj option> * ?levelsDeep: float * ?closed: bool -> ResizeArray<obj option>
    /// Normalize GeoJSON geometries/features into GeoJSON features.
    abstract asFeature: geojson: U2<Geojson.Feature<Geojson.GeometryObject, 'P>, Geojson.GeometryObject> -> Geojson.Feature<Geojson.GeometryObject, 'P>
    [<Emit "new $0($1...)">] abstract Create: ?geojson: Geojson.GeoJsonObject * ?options: GeoJSONOptions<'P> -> GeoJSON<'P>

type Zoom =
    U2<bool, string>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module Zoom =
    let ofBool v: Zoom = v |> U2.Case1
    let isBool (v: Zoom) = match v with U2.Case1 _ -> true | _ -> false
    let asBool (v: Zoom) = match v with U2.Case1 o -> Some o | _ -> None
    let ofCase2 v: Zoom = v |> U2.Case2
    let isCase2 (v: Zoom) = match v with U2.Case2 _ -> true | _ -> false
    let asCase2 (v: Zoom) = match v with U2.Case2 o -> Some o | _ -> None

type [<AllowNullLiteral>] MapOptions =
    abstract preferCanvas: bool option with get, set
    abstract attributionControl: bool option with get, set
    abstract zoomControl: bool option with get, set
    abstract closePopupOnClick: bool option with get, set
    abstract zoomSnap: float option with get, set
    abstract zoomDelta: float option with get, set
    abstract trackResize: bool option with get, set
    abstract boxZoom: bool option with get, set
    abstract doubleClickZoom: Zoom option with get, set
    abstract dragging: bool option with get, set
    abstract crs: CRS option with get, set
    abstract center: LatLngExpression option with get, set
    abstract zoom: float option with get, set
    abstract minZoom: float option with get, set
    abstract maxZoom: float option with get, set
    abstract layers: ResizeArray<Layer> option with get, set
    abstract maxBounds: LatLngBoundsExpression option with get, set
    abstract renderer: Renderer option with get, set
    abstract fadeAnimation: bool option with get, set
    abstract markerZoomAnimation: bool option with get, set
    abstract transform3DLimit: float option with get, set
    abstract zoomAnimation: bool option with get, set
    abstract zoomAnimationThreshold: float option with get, set
    abstract inertia: bool option with get, set
    abstract inertiaDeceleration: float option with get, set
    abstract inertiaMaxSpeed: float option with get, set
    abstract easeLinearity: float option with get, set
    abstract worldCopyJump: bool option with get, set
    abstract maxBoundsViscosity: float option with get, set
    abstract keyboard: bool option with get, set
    abstract keyboardPanDelta: float option with get, set
    abstract scrollWheelZoom: Zoom option with get, set
    abstract wheelDebounceTime: float option with get, set
    abstract wheelPxPerZoomLevel: float option with get, set
    abstract tap: bool option with get, set
    abstract tapTolerance: float option with get, set
    abstract touchZoom: Zoom option with get, set
    abstract bounceAtZoomLimits: bool option with get, set

type [<StringEnum>] [<RequireQualifiedAccess>] ControlPosition =
    | Topleft
    | Topright
    | Bottomleft
    | Bottomright

type [<AllowNullLiteral>] ControlOptions =
    abstract position: ControlPosition option with get, set

type [<AllowNullLiteral>] Control =
    inherit Class
    abstract getPosition: unit -> ControlPosition
    abstract setPosition: position: ControlPosition -> Control
    abstract getContainer: unit -> HTMLElement option
    abstract addTo: map: Map -> Control
    abstract remove: unit -> Control
    abstract onAdd: map: Map -> HTMLElement
    abstract onRemove: map: Map -> unit
    abstract options: ControlOptions with get, set

type [<AllowNullLiteral>] ControlStatic =
    [<Emit "new $0($1...)">] abstract Create: ?options: ControlOptions -> Control

module Control =

    type [<AllowNullLiteral>] IExports =
        abstract Zoom: ZoomStatic
        abstract Attribution: AttributionStatic
        abstract Layers: LayersStatic
        abstract Scale: ScaleStatic

    type [<AllowNullLiteral>] ZoomOptions =
        inherit ControlOptions
        abstract zoomInText: string option with get, set
        abstract zoomInTitle: string option with get, set
        abstract zoomOutText: string option with get, set
        abstract zoomOutTitle: string option with get, set

    type [<AllowNullLiteral>] Zoom =
        inherit Control
        abstract options: ZoomOptions with get, set

    type [<AllowNullLiteral>] ZoomStatic =
        [<Emit "new $0($1...)">] abstract Create: ?options: ZoomOptions -> Zoom

    type [<AllowNullLiteral>] AttributionOptions =
        inherit ControlOptions
        abstract prefix: U2<string, bool> option with get, set

    type [<AllowNullLiteral>] Attribution =
        inherit Control
        abstract setPrefix: prefix: string -> Attribution
        abstract addAttribution: text: string -> Attribution
        abstract removeAttribution: text: string -> Attribution
        abstract options: AttributionOptions with get, set

    type [<AllowNullLiteral>] AttributionStatic =
        [<Emit "new $0($1...)">] abstract Create: ?options: AttributionOptions -> Attribution

    type [<AllowNullLiteral>] LayersOptions =
        inherit ControlOptions
        abstract collapsed: bool option with get, set
        abstract autoZIndex: bool option with get, set
        abstract hideSingleBase: bool option with get, set

    type [<AllowNullLiteral>] LayersObject =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: name: string -> Layer with get, set

    type [<AllowNullLiteral>] Layers =
        inherit Control
        abstract addBaseLayer: layer: Layer * name: string -> Layers
        abstract addOverlay: layer: Layer * name: string -> Layers
        abstract removeLayer: layer: Layer -> Layers
        abstract expand: unit -> Layers
        abstract collapse: unit -> Layers
        abstract options: LayersOptions with get, set

    type [<AllowNullLiteral>] LayersStatic =
        [<Emit "new $0($1...)">] abstract Create: ?baseLayers: LayersObject * ?overlays: LayersObject * ?options: LayersOptions -> Layers

    type [<AllowNullLiteral>] ScaleOptions =
        inherit ControlOptions
        abstract maxWidth: float option with get, set
        abstract metric: bool option with get, set
        abstract imperial: bool option with get, set
        abstract updateWhenIdle: bool option with get, set

    type [<AllowNullLiteral>] Scale =
        inherit Control
        abstract options: ScaleOptions with get, set

    type [<AllowNullLiteral>] ScaleStatic =
        [<Emit "new $0($1...)">] abstract Create: ?options: ScaleOptions -> Scale

// module Control =

//     type [<AllowNullLiteral>] IExports =
//         abstract zoom: ?options: Control.ZoomOptions -> Control.Zoom
//         abstract attribution: ?options: Control.AttributionOptions -> Control.Attribution
//         abstract layers: ?baseLayers: Control.LayersObject * ?overlays: Control.LayersObject * ?options: Control.LayersOptions -> Control.Layers
//         abstract scale: ?options: Control.ScaleOptions -> Control.Scale

type [<AllowNullLiteral>] DivOverlayOptions =
    abstract offset: PointExpression option with get, set
    abstract zoomAnimation: bool option with get, set
    abstract className: string option with get, set
    abstract pane: string option with get, set

type [<AllowNullLiteral>] PopupOptions =
    inherit DivOverlayOptions
    abstract maxWidth: float option with get, set
    abstract minWidth: float option with get, set
    abstract maxHeight: float option with get, set
    abstract autoPan: bool option with get, set
    abstract autoPanPaddingTopLeft: PointExpression option with get, set
    abstract autoPanPaddingBottomRight: PointExpression option with get, set
    abstract autoPanPadding: PointExpression option with get, set
    abstract keepInView: bool option with get, set
    abstract closeButton: bool option with get, set
    abstract autoClose: bool option with get, set
    abstract closeOnClick: bool option with get, set

type Content =
    U2<string, HTMLElement>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module Content =
    let ofString v: Content = v |> U2.Case1
    let isString (v: Content) = match v with U2.Case1 _ -> true | _ -> false
    let asString (v: Content) = match v with U2.Case1 o -> Some o | _ -> None
    let ofHTMLElement v: Content = v |> U2.Case2
    let isHTMLElement (v: Content) = match v with U2.Case2 _ -> true | _ -> false
    let asHTMLElement (v: Content) = match v with U2.Case2 o -> Some o | _ -> None

type [<AllowNullLiteral>] Popup =
    inherit Layer
    abstract getLatLng: unit -> LatLng option
    abstract setLatLng: latlng: LatLngExpression -> Popup
    abstract getContent: unit -> U2<Content, (Layer -> Content)> option
    abstract setContent: htmlContent: U2<(Layer -> Content), Content> -> Popup
    abstract getElement: unit -> HTMLElement option
    abstract update: unit -> unit
    abstract isOpen: unit -> bool
    abstract bringToFront: unit -> Popup
    abstract bringToBack: unit -> Popup
    abstract openOn: map: Map -> Popup
    abstract options: PopupOptions with get, set

type [<AllowNullLiteral>] PopupStatic =
    [<Emit "new $0($1...)">] abstract Create: ?options: PopupOptions * ?source: Layer -> Popup

type [<StringEnum>] [<RequireQualifiedAccess>] Direction =
    | Right
    | Left
    | Top
    | Bottom
    | Center
    | Auto

type [<AllowNullLiteral>] TooltipOptions =
    inherit DivOverlayOptions
    abstract pane: string option with get, set
    abstract offset: PointExpression option with get, set
    abstract direction: Direction option with get, set
    abstract permanent: bool option with get, set
    abstract sticky: bool option with get, set
    abstract interactive: bool option with get, set
    abstract opacity: float option with get, set

type [<AllowNullLiteral>] Tooltip =
    inherit Layer
    abstract setOpacity: ``val``: float -> unit
    abstract getLatLng: unit -> LatLng option
    abstract setLatLng: latlng: LatLngExpression -> Tooltip
    abstract getContent: unit -> Content option
    abstract setContent: htmlContent: U2<(Layer -> Content), Content> -> Tooltip
    abstract getElement: unit -> HTMLElement option
    abstract update: unit -> unit
    abstract isOpen: unit -> bool
    abstract bringToFront: unit -> Tooltip
    abstract bringToBack: unit -> Tooltip
    abstract options: TooltipOptions with get, set

type [<AllowNullLiteral>] TooltipStatic =
    [<Emit "new $0($1...)">] abstract Create: ?options: TooltipOptions * ?source: Layer -> Tooltip

type [<AllowNullLiteral>] ZoomOptions =
    abstract animate: bool option with get, set

type [<AllowNullLiteral>] PanOptions =
    abstract animate: bool option with get, set
    abstract duration: float option with get, set
    abstract easeLinearity: float option with get, set
    abstract noMoveStart: bool option with get, set

type [<AllowNullLiteral>] ZoomPanOptions =
    inherit ZoomOptions
    inherit PanOptions

type [<AllowNullLiteral>] FitBoundsOptions =
    inherit ZoomOptions
    inherit PanOptions
    abstract paddingTopLeft: PointExpression option with get, set
    abstract paddingBottomRight: PointExpression option with get, set
    abstract padding: PointExpression option with get, set
    abstract maxZoom: float option with get, set

type [<AllowNullLiteral>] LocateOptions =
    abstract watch: bool option with get, set
    abstract setView: bool option with get, set
    abstract maxZoom: float option with get, set
    abstract timeout: float option with get, set
    abstract maximumAge: float option with get, set
    abstract enableHighAccuracy: bool option with get, set

type [<AllowNullLiteral>] Handler =
    inherit Class
    abstract enable: unit -> Handler
    abstract disable: unit -> Handler
    abstract enabled: unit -> bool
    abstract addHooks: unit -> unit
    abstract removeHooks: unit -> unit

type [<AllowNullLiteral>] HandlerStatic =
    [<Emit "new $0($1...)">] abstract Create: map: Map -> Handler

type [<AllowNullLiteral>] LeafletEvent =
    abstract ``type``: string with get, set
    abstract target: obj option with get, set

type [<AllowNullLiteral>] LeafletMouseEvent =
    inherit LeafletEvent
    abstract latlng: LatLng with get, set
    abstract layerPoint: Point with get, set
    abstract containerPoint: Point with get, set
    abstract originalEvent: MouseEvent with get, set

type [<AllowNullLiteral>] LeafletKeyboardEvent =
    inherit LeafletEvent
    abstract originalEvent: KeyboardEvent with get, set

type [<AllowNullLiteral>] LocationEvent =
    inherit LeafletEvent
    abstract latlng: LatLng with get, set
    abstract bounds: LatLngBounds with get, set
    abstract accuracy: float with get, set
    abstract altitude: float with get, set
    abstract altitudeAccuracy: float with get, set
    abstract heading: float with get, set
    abstract speed: float with get, set
    abstract timestamp: float with get, set

type [<AllowNullLiteral>] ErrorEvent =
    inherit LeafletEvent
    abstract message: string with get, set
    abstract code: float with get, set

type [<AllowNullLiteral>] LayerEvent =
    inherit LeafletEvent
    abstract layer: Layer with get, set

type [<AllowNullLiteral>] LayersControlEvent =
    inherit LayerEvent
    abstract name: string with get, set

type [<AllowNullLiteral>] TileEvent =
    inherit LeafletEvent
    abstract tile: HTMLImageElement with get, set
    abstract coords: Point with get, set

type [<AllowNullLiteral>] TileErrorEvent =
    inherit TileEvent
    abstract error: Error with get, set

type [<AllowNullLiteral>] ResizeEvent =
    inherit LeafletEvent
    abstract oldSize: Point with get, set
    abstract newSize: Point with get, set

type [<AllowNullLiteral>] GeoJSONEvent =
    inherit LeafletEvent
    abstract layer: Layer with get, set
    abstract properties: obj option with get, set
    abstract geometryType: string with get, set
    abstract id: string with get, set

type [<AllowNullLiteral>] PopupEvent =
    inherit LeafletEvent
    abstract popup: Popup with get, set

type [<AllowNullLiteral>] TooltipEvent =
    inherit LeafletEvent
    abstract tooltip: Tooltip with get, set

type [<AllowNullLiteral>] DragEndEvent =
    inherit LeafletEvent
    abstract distance: float with get, set

type [<AllowNullLiteral>] ZoomAnimEvent =
    inherit LeafletEvent
    abstract center: LatLng with get, set
    abstract zoom: float with get, set
    abstract noUpdate: bool with get, set

module DomEvent =

    type [<AllowNullLiteral>] IExports =
        abstract on: el: HTMLElement * types: string * fn: EventHandlerFn * ?context: obj option -> obj
        abstract on: el: HTMLElement * eventMap: OnEventMap * ?context: obj option -> obj
        abstract off: el: HTMLElement * types: string * fn: EventHandlerFn * ?context: obj option -> obj
        abstract off: el: HTMLElement * eventMap: OffEventMap * ?context: obj option -> obj
        abstract stopPropagation: ev: Event -> obj
        abstract disableScrollPropagation: el: HTMLElement -> obj
        abstract disableClickPropagation: el: HTMLElement -> obj
        abstract preventDefault: ev: Event -> obj
        abstract stop: ev: Event -> obj
        abstract getMousePosition: ev: MouseEvent * ?container: HTMLElement -> Point
        abstract getWheelDelta: ev: Event -> float
        abstract addListener: el: HTMLElement * types: string * fn: EventHandlerFn * ?context: obj option -> obj
        abstract addListener: el: HTMLElement * eventMap: AddListenerEventMap * ?context: obj option -> obj
        abstract removeListener: el: HTMLElement * types: string * fn: EventHandlerFn * ?context: obj option -> obj
        abstract removeListener: el: HTMLElement * eventMap: RemoveListenerEventMap * ?context: obj option -> obj

    type [<AllowNullLiteral>] OnEventMap =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: eventName: string -> EventHandlerFn with get, set

    type [<AllowNullLiteral>] OffEventMap =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: eventName: string -> EventHandlerFn with get, set

    type [<AllowNullLiteral>] AddListenerEventMap =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: eventName: string -> EventHandlerFn with get, set

    type [<AllowNullLiteral>] RemoveListenerEventMap =
        [<Emit "$0[$1]{{=$2}}">] abstract Item: eventName: string -> EventHandlerFn with get, set

    type EventHandlerFn =
        (Event -> unit)

type [<AllowNullLiteral>] DefaultMapPanes =
    abstract mapPane: HTMLElement with get, set
    abstract tilePane: HTMLElement with get, set
    abstract overlayPane: HTMLElement with get, set
    abstract shadowPane: HTMLElement with get, set
    abstract markerPane: HTMLElement with get, set
    abstract tooltipPane: HTMLElement with get, set
    abstract popupPane: HTMLElement with get, set

type [<AllowNullLiteral>] Map =
    inherit Evented
    abstract getRenderer: layer: Path -> Renderer
    abstract addControl: control: Control -> Map
    abstract removeControl: control: Control -> Map
    abstract addLayer: layer: Layer -> Map
    abstract removeLayer: layer: Layer -> Map
    abstract hasLayer: layer: Layer -> bool
    abstract eachLayer: fn: (Layer -> unit) * ?context: obj option -> Map
    abstract openPopup: popup: Popup -> Map
    abstract openPopup: content: Content * latlng: LatLngExpression * ?options: PopupOptions -> Map
    abstract closePopup: ?popup: Popup -> Map
    abstract openTooltip: tooltip: Tooltip -> Map
    abstract openTooltip: content: Content * latlng: LatLngExpression * ?options: TooltipOptions -> Map
    abstract closeTooltip: ?tooltip: Tooltip -> Map
    abstract setView: center: LatLngExpression * zoom: float * ?options: ZoomPanOptions -> Map
    abstract setZoom: zoom: float * ?options: ZoomPanOptions -> Map
    abstract zoomIn: ?delta: float * ?options: ZoomOptions -> Map
    abstract zoomOut: ?delta: float * ?options: ZoomOptions -> Map
    abstract setZoomAround: position: U2<Point, LatLngExpression> * zoom: float * ?options: ZoomOptions -> Map
    abstract fitBounds: bounds: LatLngBoundsExpression * ?options: FitBoundsOptions -> Map
    abstract fitWorld: ?options: FitBoundsOptions -> Map
    abstract panTo: latlng: LatLngExpression * ?options: PanOptions -> Map
    abstract panBy: offset: PointExpression -> Map
    abstract setMaxBounds: bounds: LatLngBoundsExpression -> Map
    abstract setMinZoom: zoom: float -> Map
    abstract setMaxZoom: zoom: float -> Map
    abstract panInsideBounds: bounds: LatLngBoundsExpression * ?options: PanOptions -> Map
    /// Boolean for animate or advanced ZoomPanOptions
    abstract invalidateSize: ?options: U2<bool, ZoomPanOptions> -> Map
    abstract stop: unit -> Map
    abstract flyTo: latlng: LatLngExpression * ?zoom: float * ?options: ZoomPanOptions -> Map
    abstract flyToBounds: bounds: LatLngBoundsExpression * ?options: FitBoundsOptions -> Map
    abstract addHandler: name: string * HandlerClass: obj -> Map
    abstract remove: unit -> Map
    abstract createPane: name: string * ?container: HTMLElement -> HTMLElement
    /// Name of the pane or the pane as HTML-Element
    abstract getPane: pane: U2<string, HTMLElement> -> HTMLElement option
    abstract getPanes: unit -> obj
    abstract getContainer: unit -> HTMLElement
    abstract whenReady: fn: (unit -> unit) * ?context: obj option -> Map
    abstract getCenter: unit -> LatLng
    abstract getZoom: unit -> float
    abstract getBounds: unit -> LatLngBounds
    abstract getMinZoom: unit -> float
    abstract getMaxZoom: unit -> float
    abstract getBoundsZoom: bounds: LatLngBoundsExpression * ?inside: bool -> float
    abstract getSize: unit -> Point
    abstract getPixelBounds: unit -> Bounds
    abstract getPixelOrigin: unit -> Point
    abstract getPixelWorldBounds: ?zoom: float -> Bounds
    abstract getZoomScale: toZoom: float * fromZoom: float -> float
    abstract getScaleZoom: scale: float * fromZoom: float -> float
    abstract project: latlng: LatLngExpression * zoom: float -> Point
    abstract unproject: point: PointExpression * zoom: float -> LatLng
    abstract layerPointToLatLng: point: PointExpression -> LatLng
    abstract latLngToLayerPoint: latlng: LatLngExpression -> Point
    abstract wrapLatLng: latlng: LatLngExpression -> LatLng
    abstract wrapLatLngBounds: bounds: LatLngBounds -> LatLngBounds
    abstract distance: latlng1: LatLngExpression * latlng2: LatLngExpression -> float
    abstract containerPointToLayerPoint: point: PointExpression -> Point
    abstract containerPointToLatLng: point: PointExpression -> LatLng
    abstract layerPointToContainerPoint: point: PointExpression -> Point
    abstract latLngToContainerPoint: latlng: LatLngExpression -> Point
    abstract mouseEventToContainerPoint: ev: MouseEvent -> Point
    abstract mouseEventToLayerPoint: ev: MouseEvent -> Point
    abstract mouseEventToLatLng: ev: MouseEvent -> LatLng
    abstract locate: ?options: LocateOptions -> Map
    abstract stopLocate: unit -> Map
    abstract boxZoom: Handler with get, set
    abstract doubleClickZoom: Handler with get, set
    abstract dragging: Handler with get, set
    abstract keyboard: Handler with get, set
    abstract scrollWheelZoom: Handler with get, set
    abstract tap: Handler option with get, set
    abstract touchZoom: Handler with get, set
    abstract options: MapOptions with get, set

type [<AllowNullLiteral>] MapStatic =
    [<Emit "new $0($1...)">] abstract Create: element: U2<string, HTMLElement> * ?options: MapOptions -> Map

type [<AllowNullLiteral>] BaseIconOptions =
    inherit LayerOptions
    abstract iconUrl: string option with get, set
    abstract iconRetinaUrl: string option with get, set
    abstract iconSize: PointExpression option with get, set
    abstract iconAnchor: PointExpression option with get, set
    abstract popupAnchor: PointExpression option with get, set
    abstract tooltipAnchor: PointExpression option with get, set
    abstract shadowUrl: string option with get, set
    abstract shadowRetinaUrl: string option with get, set
    abstract shadowSize: PointExpression option with get, set
    abstract shadowAnchor: PointExpression option with get, set
    abstract className: string option with get, set

type [<AllowNullLiteral>] IconOptions =
    inherit BaseIconOptions
    abstract iconUrl: string with get, set

type [<AllowNullLiteral>] Icon<'T> =
    inherit Layer
    abstract createIcon: ?oldIcon: HTMLElement -> HTMLElement
    abstract createShadow: ?oldIcon: HTMLElement -> HTMLElement
    abstract options: 'T with get, set

type [<AllowNullLiteral>] IconStatic =
    [<Emit "new $0($1...)">] abstract Create: options: 'T -> Icon<'T>

module Icon =

    type [<AllowNullLiteral>] IExports =
        abstract Default: DefaultStatic

    type [<AllowNullLiteral>] DefaultIconOptions =
        inherit BaseIconOptions
        abstract imagePath: string option with get, set

    type [<AllowNullLiteral>] Default =
        inherit Icon<DefaultIconOptions>
        abstract imagePath: string option with get, set

    type [<AllowNullLiteral>] DefaultStatic =
        [<Emit "new $0($1...)">] abstract Create: ?options: DefaultIconOptions -> Default

type [<AllowNullLiteral>] DivIconOptions =
    inherit BaseIconOptions
    abstract html: U2<string, obj> option with get, set
    abstract bgPos: PointExpression option with get, set
    abstract iconSize: PointExpression option with get, set
    abstract iconAnchor: PointExpression option with get, set
    abstract popupAnchor: PointExpression option with get, set
    abstract className: string option with get, set

type [<AllowNullLiteral>] DivIcon =
    inherit Icon<DivIconOptions>

type [<AllowNullLiteral>] DivIconStatic =
    [<Emit "new $0($1...)">] abstract Create: ?options: DivIconOptions -> DivIcon

type [<AllowNullLiteral>] MarkerOptions =
    inherit InteractiveLayerOptions
    abstract icon: U2<Icon<_>, DivIcon> option with get, set
    abstract clickable: bool option with get, set
    abstract draggable: bool option with get, set
    abstract keyboard: bool option with get, set
    abstract title: string option with get, set
    abstract alt: string option with get, set
    abstract zIndexOffset: float option with get, set
    abstract opacity: float option with get, set
    abstract riseOnHover: bool option with get, set
    abstract riseOffset: float option with get, set

type [<AllowNullLiteral>] Marker<'P> =
    inherit Layer
    abstract toGeoJSON: unit -> Geojson.Feature<Geojson.Point, 'P>
    abstract getLatLng: unit -> LatLng
    abstract setLatLng: latlng: LatLngExpression -> Marker<'P>
    abstract setZIndexOffset: offset: float -> Marker<'P>
    abstract setIcon: icon: U2<Icon<_>, DivIcon> -> Marker<'P>
    abstract setOpacity: opacity: float -> Marker<'P>
    abstract getElement: unit -> HTMLElement option
    abstract options: MarkerOptions with get, set
    abstract dragging: Handler option with get, set
    abstract feature: Geojson.Feature<Geojson.Point, 'P> option with get, set

type [<AllowNullLiteral>] MarkerStatic =
    [<Emit "new $0($1...)">] abstract Create: latlng: LatLngExpression * ?options: MarkerOptions -> Marker<'P>

module Browser =

    type [<AllowNullLiteral>] IExports =
        abstract ie: bool
        abstract ielt9: bool
        abstract edge: bool
        abstract webkit: bool
        abstract gecko: bool
        abstract android: bool
        abstract android23: bool
        abstract chrome: bool
        abstract safari: bool
        abstract win: bool
        abstract ie3d: bool
        abstract webkit3d: bool
        abstract gecko3d: bool
        abstract opera12: bool
        abstract any3d: bool
        abstract mobile: bool
        abstract mobileWebkit: bool
        abstract mobileWebkit3d: bool
        abstract mobileOpera: bool
        abstract mobileGecko: bool
        abstract touch: bool
        abstract msPointer: bool
        abstract pointer: bool
        abstract retina: bool
        abstract canvas: bool
        abstract vml: bool
        abstract svg: bool

module Util =

    type [<AllowNullLiteral>] IExports =
        abstract extend: dest: obj option * ?src: obj option -> obj option
        abstract create: proto: obj option * ?properties: obj option -> obj option
        abstract bind: fn: (unit -> unit) * [<ParamArray>] obj: ResizeArray<obj option> -> (unit -> unit)
        abstract stamp: obj: obj option -> float
        abstract throttle: fn: (unit -> unit) * time: float * context: obj option -> (unit -> unit)
        abstract wrapNum: num: float * range: ResizeArray<float> * ?includeMax: bool -> float
        abstract falseFn: unit -> obj
        abstract formatNum: num: float * ?digits: float -> float
        abstract trim: str: string -> string
        abstract splitWords: str: string -> ResizeArray<string>
        abstract setOptions: obj: obj option * options: obj option -> obj option
        abstract getParamString: obj: obj option * ?existingUrl: string * ?uppercase: bool -> string
        abstract template: str: string * data: obj option -> string
        abstract isArray: obj: obj option -> bool
        abstract indexOf: array: ResizeArray<obj option> * el: obj option -> float
        abstract requestAnimFrame: fn: (unit -> unit) * ?context: obj option * ?immediate: bool -> float
        abstract cancelAnimFrame: id: float -> unit
        abstract lastId: float
        abstract emptyImageUrl: string
