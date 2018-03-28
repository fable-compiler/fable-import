// ts2fable 0.5.2
module rec Geojson

open System
open Fable.Core
open Fable.Import.JS


type [<StringEnum>] [<RequireQualifiedAccess>] GeoJsonGeometryTypes =
    | [<CompiledName "Point">] Point
    | [<CompiledName "LineString">] LineString
    | [<CompiledName "MultiPoint">] MultiPoint
    | [<CompiledName "Polygon">] Polygon
    | [<CompiledName "MultiLineString">] MultiLineString
    | [<CompiledName "MultiPolygon">] MultiPolygon
    | [<CompiledName "GeometryCollection">] GeometryCollection

type GeoJsonTypes =
    U3<string, string, GeoJsonGeometryTypes>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module GeoJsonTypes =
    let ofCase1 v: GeoJsonTypes = v |> U3.Case1
    let isCase1 (v: GeoJsonTypes) = match v with U3.Case1 _ -> true | _ -> false
    let asCase1 (v: GeoJsonTypes) = match v with U3.Case1 o -> Some o | _ -> None
    let ofCase2 v: GeoJsonTypes = v |> U3.Case2
    let isCase2 (v: GeoJsonTypes) = match v with U3.Case2 _ -> true | _ -> false
    let asCase2 (v: GeoJsonTypes) = match v with U3.Case2 o -> Some o | _ -> None
    let ofGeoJsonGeometryTypes v: GeoJsonTypes = v |> U3.Case3
    let isGeoJsonGeometryTypes (v: GeoJsonTypes) = match v with U3.Case3 _ -> true | _ -> false
    let asGeoJsonGeometryTypes (v: GeoJsonTypes) = match v with U3.Case3 o -> Some o | _ -> None

type BBox =
    U2<float * float * float * float, float * float * float * float * float * float>

[<RequireQualifiedAccess; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module BBox =
    let ofCase1 v: BBox = v |> U2.Case1
    let isCase1 (v: BBox) = match v with U2.Case1 _ -> true | _ -> false
    let asCase1 (v: BBox) = match v with U2.Case1 o -> Some o | _ -> None
    let ofCase2 v: BBox = v |> U2.Case2
    let isCase2 (v: BBox) = match v with U2.Case2 _ -> true | _ -> false
    let asCase2 (v: BBox) = match v with U2.Case2 o -> Some o | _ -> None

type Position =
    ResizeArray<float>

/// The base GeoJSON object.
/// https://tools.ietf.org/html/rfc7946#section-3
/// The GeoJSON specification also allows foreign members
/// (https://tools.ietf.org/html/rfc7946#section-6.1)
/// Developers should use "&" type in TypeScript or extend the interface
/// to add these foreign members.
type [<AllowNullLiteral>] GeoJsonObject =
    /// Specifies the type of GeoJSON object.
    abstract ``type``: GeoJsonTypes with get, set
    /// Bounding box of the coordinate range of the object's Geometries, Features, or Feature Collections.
    /// https://tools.ietf.org/html/rfc7946#section-5
    abstract bbox: BBox option with get, set

/// A geometry object.
/// https://tools.ietf.org/html/rfc7946#section-3
type [<AllowNullLiteral>] GeometryObject =
    inherit GeoJsonObject
    abstract ``type``: GeoJsonGeometryTypes with get, set

/// Point geometry object.
/// https://tools.ietf.org/html/rfc7946#section-3.1.2
type [<AllowNullLiteral>] Point =
    inherit GeometryObject
    abstract ``type``: string with get, set
    abstract coordinates: Position with get, set

/// MultiPoint geometry object.
///   https://tools.ietf.org/html/rfc7946#section-3.1.3
type [<AllowNullLiteral>] MultiPoint =
    inherit GeometryObject
    abstract ``type``: string with get, set
    abstract coordinates: ResizeArray<Position> with get, set

/// LineString geometry object.
/// https://tools.ietf.org/html/rfc7946#section-3.1.4
type [<AllowNullLiteral>] LineString =
    inherit GeometryObject
    abstract ``type``: string with get, set
    abstract coordinates: ResizeArray<Position> with get, set

/// MultiLineString geometry object.
/// https://tools.ietf.org/html/rfc7946#section-3.1.5
type [<AllowNullLiteral>] MultiLineString =
    inherit GeometryObject
    abstract ``type``: string with get, set
    abstract coordinates: ResizeArray<ResizeArray<Position>> with get, set

/// Polygon geometry object.
/// https://tools.ietf.org/html/rfc7946#section-3.1.6
type [<AllowNullLiteral>] Polygon =
    inherit GeometryObject
    abstract ``type``: string with get, set
    abstract coordinates: ResizeArray<ResizeArray<Position>> with get, set

/// MultiPolygon geometry object.
/// https://tools.ietf.org/html/rfc7946#section-3.1.7
type [<AllowNullLiteral>] MultiPolygon =
    inherit GeometryObject
    abstract ``type``: string with get, set
    abstract coordinates: ResizeArray<ResizeArray<ResizeArray<Position>>> with get, set

/// Geometry Collection
/// https://tools.ietf.org/html/rfc7946#section-3.1.8
type [<AllowNullLiteral>] GeometryCollection =
    inherit GeometryObject
    abstract ``type``: string with get, set
    abstract geometries: Array<U6<Point, LineString, Polygon, MultiPoint, MultiLineString, MultiPolygon>> with get, set

type GeoJsonProperties =
    obj option

/// A feature object which contains a geometry and associated properties.
/// https://tools.ietf.org/html/rfc7946#section-3.2
type [<AllowNullLiteral>] Feature<'G, 'P> =
    inherit GeoJsonObject
    abstract ``type``: string with get, set
    /// The feature's geometry
    abstract geometry: 'G with get, set
    /// A value that uniquely identifies this feature in a
    /// https://tools.ietf.org/html/rfc7946#section-3.2.
    abstract id: U2<string, float> option with get, set
    /// Properties associated with this feature.
    abstract properties: 'P with get, set

/// A collection of feature objects.
///   https://tools.ietf.org/html/rfc7946#section-3.3
type [<AllowNullLiteral>] FeatureCollection<'G, 'P> =
    inherit GeoJsonObject
    abstract ``type``: string with get, set
    abstract features: Array<Feature<'G, 'P>> with get, set
