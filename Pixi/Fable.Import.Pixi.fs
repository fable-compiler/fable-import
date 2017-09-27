namespace rec Fable.Import.Pixi 
//namespace Fable.Import.Pixi 

open System
open System.Text.RegularExpressions
open Fable.Core
open Fable.Import.JS
open Fable.Import.Browser

module PIXI =

  module ticker =
      type [<AllowNullLiteral>] [<Import("TickerListener","PIXI.ticker")>] TickerListener(fn: float->unit, ?context: obj, ?priority: float, ?once: bool) =
          member __.fn with get(): float->unit = jsNative and set(v: float->unit): unit = jsNative
          member __.context with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.priority with get(): float = jsNative and set(v: float): unit = jsNative
          member __.once with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.next with get(): TickerListener = jsNative and set(v: TickerListener): unit = jsNative
          member __.previous with get(): TickerListener = jsNative and set(v: TickerListener): unit = jsNative
          member __._destroyed with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.``match``(fn: float->unit, ?context: obj): bool = jsNative
          member __.emit(deltaTime: float): TickerListener = jsNative
          member __.connect(previous: TickerListener): unit = jsNative
          member __.destroy(?hard: bool): unit = jsNative

      and [<AllowNullLiteral>] [<Import("Ticker","PIXI.ticker")>] Ticker() =
          member __._tick with get(): float->unit = jsNative and set(v: float->unit): unit = jsNative
          member __._head with get(): TickerListener = jsNative and set(v: TickerListener): unit = jsNative
          member __._requestId with get(): U2<float, obj> = jsNative and set(v: U2<float, obj>): unit = jsNative
          member __._maxElapsedMS with get(): float = jsNative and set(v: float): unit = jsNative
          member __.autoStart with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.deltaTime with get(): float = jsNative and set(v: float): unit = jsNative
          member __.elapsedMS with get(): float = jsNative and set(v: float): unit = jsNative
          member __.lastTime with get(): float = jsNative and set(v: float): unit = jsNative
          member __.speed with get(): float = jsNative and set(v: float): unit = jsNative
          member __.started with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.FPS with get(): float = jsNative and set(v: float): unit = jsNative
          member __.minFPS with get(): float = jsNative and set(v: float): unit = jsNative
          member __._requestIfNeeded(): unit = jsNative
          member __._cancelIfNeeded(): unit = jsNative
          member __._startIfPossible(): unit = jsNative
          member __.add(fn: float->unit, ?context: obj, ?priority: float): Ticker = jsNative
          member __.addOnce(fn: float->unit, ?context: obj, ?priority: float): Ticker = jsNative
          member __.remove(fn: Function, ?context: obj, ?priority: float): Ticker = jsNative
          member __._addListener(listener: TickerListener): Ticker = jsNative
          member __.start(): unit = jsNative
          member __.stop(): unit = jsNative
          member __.destroy(): unit = jsNative
          member __.update(?currentTime: float): unit = jsNative

      type [<Import("ticker","PIXI")>] Globals =
          static member shared with get(): Ticker = jsNative and set(v: Ticker): unit = jsNative

  type [<AllowNullLiteral>] DecomposedDataUri =
      abstract mediaType: string with get, set
      abstract subType: string with get, set
      abstract encoding: string with get, set
      abstract data: obj with get, set


  module utils =
      type [<AllowNullLiteral>] [<Import("EventEmitter","PIXI.utils")>] EventEmitter() =
          member __.prefixed with get(): U2<string, bool> = jsNative and set(v: U2<string, bool>): unit = jsNative
          member __.EventEmitter with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.eventNames(): ResizeArray<U2<string, Symbol>> = jsNative
          member __.listeners(``event``: U2<string, Symbol>): ResizeArray<Function> = jsNative
          member __.listeners(``event``: U2<string, Symbol>, exists: bool): bool = jsNative
          member __.emit(``event``: U2<string, Symbol>, [<ParamArray>] args: obj[]): bool = jsNative
          member __.on(``event``: U2<string, Symbol>, fn: Function, ?context: obj): obj = jsNative
          member __.once(``event``: U2<string, Symbol>, fn: Function, ?context: obj): obj = jsNative
          member __.removeListener(``event``: U2<string, Symbol>, ?fn: Function, ?context: obj, ?once: bool): obj = jsNative
          member __.removeAllListeners(?``event``: U2<string, Symbol>): obj = jsNative
          member __.off(``event``: U2<string, Symbol>, ?fn: Function, ?context: obj, ?once: bool): obj = jsNative
          member __.addListener(``event``: U2<string, Symbol>, fn: Function, ?context: obj): obj = jsNative
          member __.setMaxListeners(): obj = jsNative

      type [<Import("utils","PIXI")>] Globals =
          static member premultiplyBlendMode with get(): ResizeArray<ResizeArray<float>> = jsNative and set(v: ResizeArray<ResizeArray<float>>): unit = jsNative
          static member TextureCache with get(): obj = jsNative and set(v: obj): unit = jsNative
          static member BaseTextureCache with get(): obj = jsNative and set(v: obj): unit = jsNative
          static member uid(): float = jsNative
          static member hex2rgb(hex: float, ?out: ResizeArray<float>): ResizeArray<float> = jsNative
          static member hex2string(hex: float): string = jsNative
          static member rgb2hex(rgb: ResizeArray<float>): float = jsNative
          static member canUseNewCanvasBlendModes(): bool = jsNative
          static member getResolutionOfUrl(url: string, ?defaultValue: float): float = jsNative
          static member getSvgSize(svgString: string): obj = jsNative
          static member decomposeDataUri(dataUri: string): U2<DecomposedDataUri, unit> = jsNative
          static member getUrlFileExtension(url: string): U2<string, unit> = jsNative
          static member sayHello(``type``: string): unit = jsNative
          static member skipHello(): unit = jsNative
          static member isWebGLSupported(): bool = jsNative
          static member sign(n: float): float = jsNative
          static member removeItems(arr: ResizeArray<'T>, startIdx: float, removeCount: float): unit = jsNative
          static member correctBlendMode(blendMode: float, premultiplied: bool): float = jsNative
          static member premultiplyTint(tint: float, alpha: float): float = jsNative
          static member premultiplyRgba(rgb: U2<Float32Array, ResizeArray<float>>, alpha: float, ?out: Float32Array, ?premultiply: bool): Float32Array = jsNative
          static member premultiplyTintToRgba(tint: float, alpha: float, ?out: Float32Array, ?premultiply: bool): Float32Array = jsNative

      module isMobile =
          type [<AllowNullLiteral>] appleType =
              abstract phone: bool with get, set
              abstract ipod: bool with get, set
              abstract tablet: bool with get, set
              abstract device: bool with get, set

          and [<AllowNullLiteral>] androidType =
              abstract phone: bool with get, set
              abstract tablet: bool with get, set
              abstract device: bool with get, set

          and [<AllowNullLiteral>] amazonType =
              abstract phone: bool with get, set
              abstract tablet: bool with get, set
              abstract device: bool with get, set

          and [<AllowNullLiteral>] windowsType =
              abstract phone: bool with get, set
              abstract tablet: bool with get, set
              abstract device: bool with get, set

          and [<AllowNullLiteral>] otherType =
              abstract blackberry10: bool with get, set
              abstract blackberry: bool with get, set
              abstract opera: bool with get, set
              abstract firefox: bool with get, set
              abstract chrome: bool with get, set
              abstract device: bool with get, set

          type [<Import("isMobile","PIXI.utils")>] Globals =
              static member apple with get(): appleType = jsNative and set(v: appleType): unit = jsNative
              static member android with get(): androidType = jsNative and set(v: androidType): unit = jsNative
              static member amazon with get(): amazonType = jsNative and set(v: amazonType): unit = jsNative
              static member windows with get(): windowsType = jsNative and set(v: windowsType): unit = jsNative
              static member seven_inch with get(): bool = jsNative and set(v: bool): unit = jsNative
              static member other with get(): otherType = jsNative and set(v: otherType): unit = jsNative
              static member any with get(): bool = jsNative and set(v: bool): unit = jsNative
              static member phone with get(): bool = jsNative and set(v: bool): unit = jsNative
              static member tablet with get(): bool = jsNative and set(v: bool): unit = jsNative

  type [<AllowNullLiteral>] [<Import("TransformBase","PIXI")>] TransformBase() =
      member __.IDENTITY with get(): TransformBase = jsNative and set(v: TransformBase): unit = jsNative
      member __.worldTransform with get(): Matrix = jsNative and set(v: Matrix): unit = jsNative
      member __.localTransform with get(): Matrix = jsNative and set(v: Matrix): unit = jsNative
      member __._worldID with get(): float = jsNative and set(v: float): unit = jsNative
      member __.updateLocalTransform(): unit = jsNative
      member __.updateTransform(parentTransform: TransformBase): unit = jsNative
      member __.updateWorldTransform(parentTransform: TransformBase): unit = jsNative

  and [<AllowNullLiteral>] [<Import("TransformStatic","PIXI")>] TransformStatic() =
      inherit TransformBase()
      member __.position with get(): ObservablePoint = jsNative and set(v: ObservablePoint): unit = jsNative
      member __.scale with get(): ObservablePoint = jsNative and set(v: ObservablePoint): unit = jsNative
      member __.pivot with get(): ObservablePoint = jsNative and set(v: ObservablePoint): unit = jsNative
      member __.skew with get(): ObservablePoint = jsNative and set(v: ObservablePoint): unit = jsNative
      member __._rotation with get(): float = jsNative and set(v: float): unit = jsNative
      member __._sr with get(): float option = jsNative and set(v: float option): unit = jsNative
      member __._cr with get(): float option = jsNative and set(v: float option): unit = jsNative
      member __._cy with get(): float option = jsNative and set(v: float option): unit = jsNative
      member __._sy with get(): float option = jsNative and set(v: float option): unit = jsNative
      member __._nsx with get(): float option = jsNative and set(v: float option): unit = jsNative
      member __._cx with get(): float option = jsNative and set(v: float option): unit = jsNative
      member __._currentLocalID with get(): float = jsNative and set(v: float): unit = jsNative
      member __.rotation with get(): float = jsNative and set(v: float): unit = jsNative
      member __.onChange(): unit = jsNative
      member __.updateSkew(): unit = jsNative
      member __.updateLocalTransform(): unit = jsNative
      member __.updateTransform(parentTransform: TransformBase): unit = jsNative
      member __.setFromMatrix(matrix: Matrix): unit = jsNative

  and [<AllowNullLiteral>] [<Import("Transform","PIXI")>] Transform() =
      inherit TransformBase()
      member __.position with get(): Point = jsNative and set(v: Point): unit = jsNative
      member __.scale with get(): Point = jsNative and set(v: Point): unit = jsNative
      member __.skew with get(): ObservablePoint = jsNative and set(v: ObservablePoint): unit = jsNative
      member __.pivot with get(): Point = jsNative and set(v: Point): unit = jsNative
      member __._rotation with get(): float = jsNative and set(v: float): unit = jsNative
      member __._sr with get(): float option = jsNative and set(v: float option): unit = jsNative
      member __._cr with get(): float option = jsNative and set(v: float option): unit = jsNative
      member __._cy with get(): float option = jsNative and set(v: float option): unit = jsNative
      member __._sy with get(): float option = jsNative and set(v: float option): unit = jsNative
      member __._sx with get(): float option = jsNative and set(v: float option): unit = jsNative
      member __._cx with get(): float option = jsNative and set(v: float option): unit = jsNative
      member __.rotation with get(): float = jsNative and set(v: float): unit = jsNative
      member __.updateSkew(): unit = jsNative
      member __.setFromMatrix(matrix: Matrix): unit = jsNative

  and [<AllowNullLiteral>] [<Import("Matrix","PIXI")>] Matrix(?a: float, ?b: float, ?c: float, ?d: float, ?tx: float, ?ty: float) =
      member __.a with get(): float = jsNative and set(v: float): unit = jsNative
      member __.b with get(): float = jsNative and set(v: float): unit = jsNative
      member __.c with get(): float = jsNative and set(v: float): unit = jsNative
      member __.d with get(): float = jsNative and set(v: float): unit = jsNative
      member __.tx with get(): float = jsNative and set(v: float): unit = jsNative
      member __.ty with get(): float = jsNative and set(v: float): unit = jsNative
      member __.IDENTITY with get(): Matrix = jsNative and set(v: Matrix): unit = jsNative
      member __.TEMP_MATRIX with get(): Matrix = jsNative and set(v: Matrix): unit = jsNative
      member __.fromArray(array: ResizeArray<float>): unit = jsNative
      member __.set(a: float, b: float, c: float, d: float, tx: float, ty: float): Matrix = jsNative
      member __.toArray(?transpose: bool, ?out: ResizeArray<float>): ResizeArray<float> = jsNative
      member __.apply(pos: Point, ?newPos: Point): Point = jsNative
      member __.applyInverse(pos: Point, ?newPos: Point): Point = jsNative
      member __.translate(x: float, y: float): Matrix = jsNative
      member __.scale(x: float, y: float): Matrix = jsNative
      member __.rotate(angle: float): Matrix = jsNative
      member __.append(matrix: Matrix): Matrix = jsNative
      member __.setTransform(x: float, y: float, pivotX: float, pivotY: float, scaleX: float, scaleY: float, rotation: float, skewX: float, skewY: float): Matrix = jsNative
      member __.prepend(matrix: Matrix): Matrix = jsNative
      member __.invert(): Matrix = jsNative
      member __.identity(): Matrix = jsNative
      member __.decompose(transform: TransformBase): TransformBase = jsNative
      member __.clone(): Matrix = jsNative
      member __.copy(matrix: Matrix): Matrix = jsNative

  and [<AllowNullLiteral>] [<Import("PointLike","PIXI")>] PointLike() =
      member __.x with get(): float = jsNative and set(v: float): unit = jsNative
      member __.y with get(): float = jsNative and set(v: float): unit = jsNative
      member __.set(?x: float, ?y: float): unit = jsNative
      member __.copy(point: PointLike): unit = jsNative

  and [<AllowNullLiteral>] [<Import("ObservablePoint","PIXI")>] ObservablePoint(cb: unit->obj, ?scope: obj, ?x: float, ?y: float) =
      inherit PointLike()
      member __.cb with get(): unit->obj = jsNative and set(v: unit->obj): unit = jsNative
      member __.scope with get(): obj = jsNative and set(v: obj): unit = jsNative

  and [<AllowNullLiteral>] [<Import("Point","PIXI")>] Point(?x: float, ?y: float) =
      inherit PointLike()
      member __.clone(): Point = jsNative
      member __.equals(p: PointLike): bool = jsNative

  and [<AllowNullLiteral>] HitArea =
      abstract contains: x: float * y: float -> bool
  
  and RendererOptions =
    | Width of float
    | Height of float 
    | View of HTMLCanvasElement 
    | Transparent of bool 
    | Antialias of bool 
    | PreserveDrawingBuffer of bool 
    | Resolution of float 
    | ForceCanvas of bool 
    | BackgroundColor of int // float 
    | ClearBeforeRender of bool 
    | RoundPixels of bool 
    | ForceFXAA of bool 
    | Legacy of bool 
    | Context of WebGLRenderingContext 
    | AutoResize of bool 
    | PowerPreference of string 

  and WebGLRendererOptions = RendererOptions

  and [<AllowNullLiteral>] [<Import("Rectangle","PIXI")>] Rectangle(?x: float, ?y: float, ?width: float, ?height: float) =
      member __.x with get(): float = jsNative and set(v: float): unit = jsNative
      member __.y with get(): float = jsNative and set(v: float): unit = jsNative
      member __.width with get(): float = jsNative and set(v: float): unit = jsNative
      member __.height with get(): float = jsNative and set(v: float): unit = jsNative
      member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
      member __.left with get(): float = jsNative and set(v: float): unit = jsNative
      member __.right with get(): float = jsNative and set(v: float): unit = jsNative
      member __.top with get(): float = jsNative and set(v: float): unit = jsNative
      member __.bottom with get(): float = jsNative and set(v: float): unit = jsNative
      member __.EMPTY with get(): Rectangle = jsNative and set(v: Rectangle): unit = jsNative
      member __.clone(): Rectangle = jsNative
      member __.copy(rectangle: Rectangle): Rectangle = jsNative
      member __.contains(x: float, y: float): bool = jsNative
      member __.pad(paddingX: float, paddingY: float): unit = jsNative
      member __.fit(rectangle: Rectangle): unit = jsNative
      member __.enlarge(rectangle: Rectangle): unit = jsNative

  and [<AllowNullLiteral>] [<Import("BaseRenderTexture","PIXI")>] BaseRenderTexture(?width: float, ?height: float, ?scaleMode: float, ?resolution: float) =
      inherit BaseTexture()
      member __.height with get(): float = jsNative and set(v: float): unit = jsNative
      member __.width with get(): float = jsNative and set(v: float): unit = jsNative
      member __.realHeight with get(): float = jsNative and set(v: float): unit = jsNative
      member __.realWidth with get(): float = jsNative and set(v: float): unit = jsNative
      member __.resolution with get(): float = jsNative and set(v: float): unit = jsNative
      member __.scaleMode with get(): float = jsNative and set(v: float): unit = jsNative
      member __.hasLoaded with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __._glRenderTargets with get(): obj = jsNative and set(v: obj): unit = jsNative
      member __._canvasRenderTarget with get(): obj = jsNative and set(v: obj): unit = jsNative
      member __.valid with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.resize(width: float, height: float): unit = jsNative
      member __.destroy(): unit = jsNative
      [<Emit("$0.on('update',$1...)")>] member __.on_update(fn: BaseRenderTexture->unit, ?context: obj): obj = jsNative
      [<Emit("$0.once('update',$1...)")>] member __.once_update(fn: BaseRenderTexture->unit, ?context: obj): obj = jsNative
      [<Emit("$0.removeListener('update',$1...)")>] member __.removeListener_update(?fn: BaseRenderTexture->unit, ?context: obj): obj = jsNative
      [<Emit("$0.removeAllListeners('update')")>] member __.removeAllListeners_update(): obj = jsNative
      [<Emit("$0.off('update',$1...)")>] member __.off_update(?fn: BaseRenderTexture->unit, ?context: obj): obj = jsNative
      [<Emit("$0.addListener('update',$1...)")>] member __.addListener_update(fn: BaseRenderTexture->unit, ?context: obj): obj = jsNative

  and [<AllowNullLiteral>] [<Import("BaseTexture","PIXI")>] BaseTexture(?source: U3<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement>, ?scaleMode: float, ?resolution: float) =
      inherit utils.EventEmitter()
      member __.uuid with get(): float option = jsNative and set(v: float option): unit = jsNative
      member __.touched with get(): float = jsNative and set(v: float): unit = jsNative
      member __.resolution with get(): float = jsNative and set(v: float): unit = jsNative
      member __.width with get(): float = jsNative and set(v: float): unit = jsNative
      member __.height with get(): float = jsNative and set(v: float): unit = jsNative
      member __.realWidth with get(): float = jsNative and set(v: float): unit = jsNative
      member __.realHeight with get(): float = jsNative and set(v: float): unit = jsNative
      member __.scaleMode with get(): float = jsNative and set(v: float): unit = jsNative
      member __.hasLoaded with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.isLoading with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.wrapMode with get(): float = jsNative and set(v: float): unit = jsNative
      member __.source with get(): U4<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement, obj> = jsNative and set(v: U4<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement, obj>): unit = jsNative
      member __.origSource with get(): U2<HTMLImageElement, obj> = jsNative and set(v: U2<HTMLImageElement, obj>): unit = jsNative
      member __.imageType with get(): U2<string, obj> = jsNative and set(v: U2<string, obj>): unit = jsNative
      member __.sourceScale with get(): float = jsNative and set(v: float): unit = jsNative
      member __.premultipliedAlpha with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.imageUrl with get(): U2<string, obj> = jsNative and set(v: U2<string, obj>): unit = jsNative
      member __.isPowerOfTwo with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.mipmap with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.wrap with get(): bool option = jsNative and set(v: bool option): unit = jsNative
      member __._glTextures with get(): obj = jsNative and set(v: obj): unit = jsNative
      member __._enabled with get(): float = jsNative and set(v: float): unit = jsNative
      member __._id with get(): float option = jsNative and set(v: float option): unit = jsNative
      member __._virtualBoundId with get(): float = jsNative and set(v: float): unit = jsNative
      member __._destroyed with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.textureCacheIds with get(): ResizeArray<string> = jsNative and set(v: ResizeArray<string>): unit = jsNative
      static member from(source: U3<string, HTMLImageElement, HTMLCanvasElement>, ?scaleMode: float, ?sourceScale: float): BaseTexture = jsNative
      member __.update(): unit = jsNative
      member __._updateDimensions(): unit = jsNative
      member __._updateImageType(): unit = jsNative
      member __._loadSvgSource(): unit = jsNative
      member __._loadSvgSourceUsingDataUri(dataUri: string): unit = jsNative
      member __._loadSvgSourceUsingXhr(): unit = jsNative
      member __._loadSvgSourceUsingString(svgString: string): unit = jsNative
      member __.loadSource(source: U3<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement>): unit = jsNative
      member __._sourceLoaded(): unit = jsNative
      member __.destroy(): unit = jsNative
      member __.dispose(): unit = jsNative
      member __.updateSourceImage(newSrc: string): unit = jsNative
      static member fromImage(imageUrl: string, ?crossorigin: bool, ?scaleMode: float, ?sourceScale: float): BaseTexture = jsNative
      static member fromCanvas(canvas: HTMLCanvasElement, ?scaleMode: float, ?origin: string): BaseTexture = jsNative
      static member addToCache(baseTexture: BaseTexture, id: string): unit = jsNative
      static member removeFromCache(baseTexture: U2<string, BaseTexture>): BaseTexture = jsNative
      member __.on(``event``: (* TODO StringEnum update | loaded | error | dispose *) string, fn: BaseTexture->unit, ?context: obj): obj = jsNative
      member __.once(``event``: (* TODO StringEnum update | loaded | error | dispose *) string, fn: BaseTexture->unit, ?context: obj): obj = jsNative
      member __.removeListener(``event``: (* TODO StringEnum update | loaded | error | dispose *) string, ?fn: BaseTexture->unit, ?context: obj): obj = jsNative
      member __.removeAllListeners(``event``: (* TODO StringEnum update | loaded | error | dispose *) string): obj = jsNative
      member __.off(``event``: (* TODO StringEnum update | loaded | error | dispose *) string, ?fn: BaseTexture->unit, ?context: obj): obj = jsNative
      member __.addListener(``event``: (* TODO StringEnum update | loaded | error | dispose *) string, fn: BaseTexture->unit, ?context: obj): obj = jsNative

  and [<AllowNullLiteral>] [<Import("RenderTexture","PIXI")>] RenderTexture(baseRenderTexture: BaseRenderTexture, ?frame: Rectangle) =
      inherit Texture(baseRenderTexture)
      member __.legacyRenderer with get(): obj = jsNative and set(v: obj): unit = jsNative
      member __.valid with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.resize(width: float, height: float, ?doNotResizeBaseTexture: bool): unit = jsNative
      static member create(?width: float, ?height: float, ?scaleMode: float, ?resolution: float): RenderTexture = jsNative

  and [<AllowNullLiteral>] [<Import("TextureUvs","PIXI")>] TextureUvs() =
      member __.x0 with get(): float = jsNative and set(v: float): unit = jsNative
      member __.y0 with get(): float = jsNative and set(v: float): unit = jsNative
      member __.x1 with get(): float = jsNative and set(v: float): unit = jsNative
      member __.y1 with get(): float = jsNative and set(v: float): unit = jsNative
      member __.x2 with get(): float = jsNative and set(v: float): unit = jsNative
      member __.y2 with get(): float = jsNative and set(v: float): unit = jsNative
      member __.x3 with get(): float = jsNative and set(v: float): unit = jsNative
      member __.y3 with get(): float = jsNative and set(v: float): unit = jsNative
      member __.uvsUint32 with get(): Uint32Array = jsNative and set(v: Uint32Array): unit = jsNative
      member __.set(frame: Rectangle, baseFrame: Rectangle, rotate: float): unit = jsNative

  and [<AllowNullLiteral>] [<Import("Texture","PIXI")>] Texture(baseTexture: BaseTexture, ?frame: Rectangle, ?orig: Rectangle, ?trim: Rectangle, ?rotate: float) =
      inherit utils.EventEmitter()
      member __.noFrame with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.baseTexture with get(): BaseTexture = jsNative and set(v: BaseTexture): unit = jsNative
      member __._frame with get(): Rectangle = jsNative and set(v: Rectangle): unit = jsNative
      member __.trim with get(): Rectangle option = jsNative and set(v: Rectangle option): unit = jsNative
      member __.valid with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.requiresUpdate with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __._uvs with get(): TextureUvs = jsNative and set(v: TextureUvs): unit = jsNative
      member __.orig with get(): Rectangle = jsNative and set(v: Rectangle): unit = jsNative
      member __._updateID with get(): float = jsNative and set(v: float): unit = jsNative
      member __.transform with get(): obj = jsNative and set(v: obj): unit = jsNative
      member __.textureCacheIds with get(): ResizeArray<string> = jsNative and set(v: ResizeArray<string>): unit = jsNative
      member __.frame with get(): Rectangle = jsNative and set(v: Rectangle): unit = jsNative
      member __._rotate with get(): U2<bool, obj> = jsNative and set(v: U2<bool, obj>): unit = jsNative
      member __.rotate with get(): float = jsNative and set(v: float): unit = jsNative
      member __.width with get(): float = jsNative and set(v: float): unit = jsNative
      member __.height with get(): float = jsNative and set(v: float): unit = jsNative
      member __.EMPTY with get(): Texture = jsNative and set(v: Texture): unit = jsNative
      member __.WHITE with get(): Texture = jsNative and set(v: Texture): unit = jsNative
      member __.update(): unit = jsNative
      member __.onBaseTextureLoaded(baseTexture: BaseTexture): unit = jsNative
      member __.onBaseTextureUpdated(baseTexture: BaseTexture): unit = jsNative
      member __.destroy(?destroyBase: bool): unit = jsNative
      member __.clone(): Texture = jsNative
      member __._updateUvs(): unit = jsNative
      static member fromImage(imageUrl: string, ?crossOrigin: bool, ?scaleMode: float, ?sourceScale: float): Texture = jsNative
      static member fromFrame(frameId: string): Texture = jsNative
      static member fromCanvas(canvas: HTMLCanvasElement, ?scaleMode: float, ?origin: string): Texture = jsNative
      static member fromVideo(video: U2<HTMLVideoElement, string>, ?scaleMode: float): Texture = jsNative
      static member fromVideoUrl(videoUrl: string, ?scaleMode: float): Texture = jsNative
      static member from(source: obj): Texture = jsNative
      static member fromLoader(source: U2<HTMLImageElement, HTMLCanvasElement>, imageUrl: string, ?name: string): Texture = jsNative
      static member addToCache(texture: Texture, id: string): unit = jsNative
      static member removeFromCache(texture: U2<string, Texture>): Texture = jsNative
      static member addTextureToCache(texture: Texture, id: string): unit = jsNative
      static member removeTextureFromCache(id: string): Texture = jsNative
      [<Emit("$0.on('update',$1...)")>] member __.on_update(fn: Texture->unit, ?context: obj): obj = jsNative
      [<Emit("$0.once('update',$1...)")>] member __.once_update(fn: Texture->unit, ?context: obj): obj = jsNative
      [<Emit("$0.removeListener('update',$1...)")>] member __.removeListener_update(?fn: Texture->unit, ?context: obj): obj = jsNative
      [<Emit("$0.removeAllListeners('update')")>] member __.removeAllListeners_update(): obj = jsNative
      [<Emit("$0.off('update',$1...)")>] member __.off_update(?fn: Texture->unit, ?context: obj): obj = jsNative
      [<Emit("$0.addListener('update',$1...)")>] member __.addListener_update(fn: Texture->unit, ?context: obj): obj = jsNative

  and [<AllowNullLiteral>] [<Import("SystemRenderer","PIXI")>] SystemRenderer(system: string, ?screenWidth: float, ?screenHeight: float, ?options: RendererOptions) =
      inherit utils.EventEmitter()
      member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
      member __.options with get(): RendererOptions = jsNative and set(v: RendererOptions): unit = jsNative
      member __.screen with get(): Rectangle = jsNative and set(v: Rectangle): unit = jsNative
      member __.width with get(): float = jsNative and set(v: float): unit = jsNative
      member __.height with get(): float = jsNative and set(v: float): unit = jsNative
      member __.view with get(): HTMLCanvasElement = jsNative and set(v: HTMLCanvasElement): unit = jsNative
      member __.resolution with get(): float = jsNative and set(v: float): unit = jsNative
      member __.transparent with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.autoResize with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.blendModes with get(): obj = jsNative and set(v: obj): unit = jsNative
      member __.preserveDrawingBuffer with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.clearBeforeRender with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.roundPixels with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __._backgroundColor with get(): float = jsNative and set(v: float): unit = jsNative
      member __._backgroundColorRgba with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
      member __._backgroundColorString with get(): string = jsNative and set(v: string): unit = jsNative
      member __._tempDisplayObjectParent with get(): Container = jsNative and set(v: Container): unit = jsNative
      member __._lastObjectRendered with get(): DisplayObject = jsNative and set(v: DisplayObject): unit = jsNative
      member __.backgroundColor with get(): float = jsNative and set(v: float): unit = jsNative
      member __.resize(screenWidth: float, screenHeight: float): unit = jsNative
      member __.generateTexture(displayObject: DisplayObject, ?scaleMode: float, ?resolution: float): RenderTexture = jsNative
      member __.render([<ParamArray>] args: obj[]): unit = jsNative
      member __.destroy(?removeView: bool): unit = jsNative

  module accessibility =
      type [<AllowNullLiteral>] [<Import("AccessibilityManager","PIXI.accessibility")>] AccessibilityManager(renderer: U2<CanvasRenderer, WebGLRenderer>) =
          member __.div with get(): HTMLElement = jsNative and set(v: HTMLElement): unit = jsNative
          member __.pool with get(): ResizeArray<HTMLElement> = jsNative and set(v: ResizeArray<HTMLElement>): unit = jsNative
          member __.renderId with get(): float = jsNative and set(v: float): unit = jsNative
          member __.debug with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.renderer with get(): SystemRenderer = jsNative and set(v: SystemRenderer): unit = jsNative
          member __.children with get(): ResizeArray<AccessibleTarget> = jsNative and set(v: ResizeArray<AccessibleTarget>): unit = jsNative
          member __.isActive with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.activate(): unit = jsNative
          member __.deactivate(): unit = jsNative
          member __.updateAccessibleObjects(displayObject: DisplayObject): unit = jsNative
          member __.update(): unit = jsNative
          member __.capHitArea(hitArea: HitArea): unit = jsNative
          member __.addChild(displayObject: DisplayObject): unit = jsNative
          member __._onClick(e: interaction.InteractionEvent): unit = jsNative
          member __._onFocus(e: interaction.InteractionEvent): unit = jsNative
          member __._onFocusOut(e: interaction.InteractionEvent): unit = jsNative
          member __._onKeyDown(e: interaction.InteractionEvent): unit = jsNative
          member __._onMouseMove(): unit = jsNative
          member __.destroy(): unit = jsNative

      and [<AllowNullLiteral>] AccessibleTarget =
          abstract accessible: bool with get, set
          abstract accessibleTitle: U2<string, obj> with get, set
          abstract accessibleHint: U2<string, obj> with get, set
          abstract tabIndex: float with get, set

  type [<AllowNullLiteral>] DefaultRendererPlugins =
      abstract accessibility: accessibility.AccessibilityManager with get, set
      abstract interaction: interaction.InteractionManager with get, set

  and [<AllowNullLiteral>] RendererPlugins =
      inherit DefaultRendererPlugins

  and [<AllowNullLiteral>] DefaultCanvasRendererPlugins =
      abstract extract: extract.CanvasExtract with get, set
      abstract prepare: prepare.CanvasPrepare with get, set

  and [<AllowNullLiteral>] CanvasRendererPlugins =
      inherit DefaultCanvasRendererPlugins
      inherit RendererPlugins

  and [<AllowNullLiteral>] DefaultWebGLRendererPlugins =
      abstract extract: extract.WebGLExtract with get, set
      abstract prepare: prepare.WebGLPrepare with get, set

  and [<AllowNullLiteral>] WebGLRendererPlugins =
      inherit DefaultWebGLRendererPlugins
      inherit RendererPlugins

  and [<AllowNullLiteral>] [<Import("WebGLRenderer","PIXI")>] WebGLRenderer(?screenWidth: float, ?screenHeight: float, ?options: WebGLRendererOptions) =
      inherit SystemRenderer("")
      member __.___plugins with get(): obj = jsNative and set(v: obj): unit = jsNative
      member __.plugins with get(): WebGLRendererPlugins = jsNative and set(v: WebGLRendererPlugins): unit = jsNative
      member __._contextOptions with get(): obj = jsNative and set(v: obj): unit = jsNative
      member __._backgroundColorRgba with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
  //      member __.maskManager with get(): MaskManager = jsNative and set(v: MaskManager): unit = jsNative
      member __.stencilManager with get(): StencilManager option = jsNative and set(v: StencilManager option): unit = jsNative
      member __.emptyRenderer with get(): ObjectRenderer = jsNative and set(v: ObjectRenderer): unit = jsNative
      member __.currentRenderer with get(): ObjectRenderer = jsNative and set(v: ObjectRenderer): unit = jsNative
      member __.gl with get(): WebGLRenderingContext = jsNative and set(v: WebGLRenderingContext): unit = jsNative
      member __.CONTEXT_UID with get(): float = jsNative and set(v: float): unit = jsNative
      member __.state with get(): WebGLState option = jsNative and set(v: WebGLState option): unit = jsNative
      member __.renderingToScreen with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.boundTextures with get(): ResizeArray<BaseTexture> = jsNative and set(v: ResizeArray<BaseTexture>): unit = jsNative
      member __.filterManager with get(): FilterManager = jsNative and set(v: FilterManager): unit = jsNative
      member __.textureManager with get(): TextureManager option = jsNative and set(v: TextureManager option): unit = jsNative
      member __.textureGC with get(): TextureGarbageCollector option = jsNative and set(v: TextureGarbageCollector option): unit = jsNative
      member __.extract with get(): extract.WebGLExtract = jsNative and set(v: extract.WebGLExtract): unit = jsNative
      member __.drawModes with get(): obj = jsNative and set(v: obj): unit = jsNative
      member __._activeShader with get(): Shader = jsNative and set(v: Shader): unit = jsNative
      member __._activeRenderTarget with get(): RenderTarget = jsNative and set(v: RenderTarget): unit = jsNative
      member __.handleContextLost with get(): WebGLContextEvent->unit = jsNative and set(v: WebGLContextEvent->unit): unit = jsNative
      member __.handleContextRestored with get(): unit->unit = jsNative and set(v: unit->unit): unit = jsNative
      static member registerPlugin(pluginName: string, ctor: obj): unit = jsNative
      member __.initPlugins(): unit = jsNative
      member __.destroyPlugins(): unit = jsNative
      member __._initContext(): unit = jsNative
      member __.render(displayObject: DisplayObject, ?renderTexture: RenderTexture, ?clear: bool, ?transform: Transform, ?skipUpdateTransform: bool): unit = jsNative
      member __.setObjectRenderer(objectRenderer: ObjectRenderer): unit = jsNative
      member __.flush(): unit = jsNative
      member __.setBlendMode(blendMode: float): unit = jsNative
      member __.clear(?clearColor: float): unit = jsNative
      member __.setTransform(matrix: Matrix): unit = jsNative
      member __.clearRenderTexture(renderTexture: RenderTexture, ?clearColor: float): WebGLRenderer = jsNative
      member __.bindRenderTexture(renderTexture: RenderTexture, transform: Transform): WebGLRenderer = jsNative
      member __.bindRenderTarget(renderTarget: RenderTarget): WebGLRenderer = jsNative
      member __.bindShader(shader: Shader, ?autoProject: bool): WebGLRenderer = jsNative
      member __.bindTexture(texture: U2<Texture, BaseTexture>, ?location: float, ?forceLocation: bool): float = jsNative
      member __.unbindTexture(texture: U2<Texture, BaseTexture>): U2<WebGLRenderer, CanvasRenderer> = jsNative
  //      member __.unbindTexture(texture: U2<Texture, BaseTexture>): U2<WebGLRenderer, undefined> = jsNative
      member __.createVao(): glCore.VertexArrayObject = jsNative
      member __.bindVao(vao: glCore.VertexArrayObject): WebGLRenderer = jsNative
      member __.reset(): WebGLRenderer = jsNative
      member __.destroy(?removeView: bool): unit = jsNative
      member __.on(``event``: (* TODO StringEnum prerender | postrender *) string, fn: unit->unit, ?context: obj): obj = jsNative
      [<Emit("$0.on('context',$1...)")>] member __.on_context(fn: WebGLRenderingContext->unit, ?context: obj): obj = jsNative
      member __.once(``event``: (* TODO StringEnum prerender | postrender *) string, fn: unit->unit, ?context: obj): obj = jsNative
      [<Emit("$0.once('context',$1...)")>] member __.once_context(fn: WebGLRenderingContext->unit, ?context: obj): obj = jsNative
      member __.removeListener(``event``: (* TODO StringEnum prerender | postrender *) string, ?fn: unit->unit, ?context: obj): obj = jsNative
      [<Emit("$0.removeListener('context',$1...)")>] member __.removeListener_context(?fn: WebGLRenderingContext->unit, ?context: obj): obj = jsNative
      member __.removeAllListeners(``event``: (* TODO StringEnum prerender | postrender | context *) string): obj = jsNative
      member __.off(``event``: (* TODO StringEnum prerender | postrender *) string, ?fn: unit->unit, ?context: obj): obj = jsNative
      [<Emit("$0.off('context',$1...)")>] member __.off_context(?fn: WebGLRenderingContext->unit, ?context: obj): obj = jsNative
      member __.addListener(``event``: (* TODO StringEnum prerender | postrender *) string, fn: unit->unit, ?context: obj): obj = jsNative
      [<Emit("$0.addListener('context',$1...)")>] member __.addListener_context(fn: WebGLRenderingContext->unit, ?context: obj): obj = jsNative

  and [<AllowNullLiteral>] [<Import("Container","PIXI")>] Container() =
      inherit DisplayObject()
      member __.children with get(): ResizeArray<DisplayObject> = jsNative and set(v: ResizeArray<DisplayObject>): unit = jsNative
      member __.width with get(): float = jsNative and set(v: float): unit = jsNative
      member __.height with get(): float = jsNative and set(v: float): unit = jsNative
      member __.onChildrenChange with get(): obj->unit = jsNative and set(v: obj->unit): unit = jsNative
      member __.getChildByName(name: string): DisplayObject = jsNative
      member __.addChild(child: 'T, [<ParamArray>] additionalChildren: DisplayObject[]): 'T = jsNative
      member __.addChildAt(child: 'T, index: float): 'T = jsNative
      member __.swapChildren(child: DisplayObject, child2: DisplayObject): unit = jsNative
      member __.getChildIndex(child: DisplayObject): float = jsNative
      member __.setChildIndex(child: DisplayObject, index: float): unit = jsNative
      member __.getChildAt(index: float): DisplayObject = jsNative
      member __.removeChild(child: DisplayObject): DisplayObject = jsNative
      member __.removeChildAt(index: float): DisplayObject = jsNative
      member __.removeChildren(?beginIndex: float, ?endIndex: float): ResizeArray<DisplayObject> = jsNative
      member __.updateTransform(): unit = jsNative
      member __.calculateBounds(): unit = jsNative
      member __._calculateBounds(): unit = jsNative
      member __.containerUpdateTransform(): unit = jsNative
      member __.renderWebGL(renderer: WebGLRenderer): unit = jsNative
      member __.renderAdvancedWebGL(renderer: WebGLRenderer): unit = jsNative
      member __._renderWebGL(renderer: WebGLRenderer): unit = jsNative
      member __._renderCanvas(renderer: CanvasRenderer): unit = jsNative
      member __.renderCanvas(renderer: CanvasRenderer): unit = jsNative
      member __.destroy(?options: U2<DestroyOptions, bool>): unit = jsNative
      member __.once(``event``: (* TODO StringEnum added | removed *) string, fn: DisplayObject->unit, ?context: obj): obj = jsNative
      member __.once(``event``: string, fn: Function, ?context: obj): obj = jsNative
      member __.on(``event``: (* TODO StringEnum added | removed *) string, fn: DisplayObject->unit, ?context: obj): obj = jsNative
      member __.on(``event``: string, fn: Function, ?context: obj): obj = jsNative
      member __.off(``event``: (* TODO StringEnum added | removed |  *) string, ?fn: Function, ?context: obj): obj = jsNative

  and [<AllowNullLiteral>] [<Import("DisplayObject","PIXI")>] DisplayObject() =
      inherit utils.EventEmitter()
      (*
      interface InteractiveTarget with
          member __.interactive with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.interactiveChildren with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.hitArea with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.buttonMode with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.cursor with get(): string = jsNative and set(v: string): unit = jsNative
          member __.defaultCursor with get(): string = jsNative and set(v: string): unit = jsNative
          member __.trackedPointers(): obj = jsNative
      interface AccessibleTarget with
          member __.accessible with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.accessibleTitle with get(): U2<string, obj> = jsNative and set(v: U2<string, obj>): unit = jsNative
          member __.``null`` with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.accessibleHint with get(): U2<string, obj> = jsNative and set(v: U2<string, obj>): unit = jsNative
          member __.``null`` with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.tabIndex with get(): float = jsNative and set(v: float): unit = jsNative
      *)
      member __._cacheAsBitmap with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __._cacheData with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.cacheAsBitmap with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.name with get(): U2<string, obj> = jsNative and set(v: U2<string, obj>): unit = jsNative
      member __.transform with get(): TransformBase = jsNative and set(v: TransformBase): unit = jsNative
      member __.alpha with get(): float = jsNative and set(v: float): unit = jsNative
      member __.visible with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.renderable with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.parent with get(): Container = jsNative and set(v: Container): unit = jsNative
      member __.worldAlpha with get(): float = jsNative and set(v: float): unit = jsNative
      member __.filterArea with get(): Rectangle = jsNative and set(v: Rectangle): unit = jsNative
      member __._filters with get(): U2<ResizeArray<Filter<obj>>, obj> = jsNative and set(v: U2<ResizeArray<Filter<obj>>, obj>): unit = jsNative
      member __._enabledFilters with get(): U2<ResizeArray<Filter<obj>>, obj> = jsNative and set(v: U2<ResizeArray<Filter<obj>>, obj>): unit = jsNative
      member __._bounds with get(): Bounds = jsNative and set(v: Bounds): unit = jsNative
      member __._boundsID with get(): float = jsNative and set(v: float): unit = jsNative
      member __._lastBoundsID with get(): float = jsNative and set(v: float): unit = jsNative
      member __._boundsRect with get(): Rectangle = jsNative and set(v: Rectangle): unit = jsNative
      member __._localBoundsRect with get(): Rectangle = jsNative and set(v: Rectangle): unit = jsNative
      member __._mask with get(): U2<Graphics, Sprite> = jsNative and set(v: U2<Graphics, Sprite>): unit = jsNative
      member __._destroyed with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.x with get(): float = jsNative and set(v: float): unit = jsNative
      member __.y with get(): float = jsNative and set(v: float): unit = jsNative
      member __.worldTransform with get(): Matrix = jsNative and set(v: Matrix): unit = jsNative
      member __.localTransform with get(): Matrix = jsNative and set(v: Matrix): unit = jsNative
      member __.position with get(): U2<Point, ObservablePoint> = jsNative and set(v: U2<Point, ObservablePoint>): unit = jsNative
      member __.scale with get(): U2<Point, ObservablePoint> = jsNative and set(v: U2<Point, ObservablePoint>): unit = jsNative
      member __.pivot with get(): U2<Point, ObservablePoint> = jsNative and set(v: U2<Point, ObservablePoint>): unit = jsNative
      member __.skew with get(): ObservablePoint = jsNative and set(v: ObservablePoint): unit = jsNative
      member __.rotation with get(): float = jsNative and set(v: float): unit = jsNative
      member __.worldVisible with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.mask with get(): U2<Graphics, Sprite> = jsNative and set(v: U2<Graphics, Sprite>): unit = jsNative
      member __.filters with get(): U2<ResizeArray<Filter<obj>>, obj> = jsNative and set(v: U2<ResizeArray<Filter<obj>>, obj>): unit = jsNative
      member __._renderCachedWebGL(renderer: WebGLRenderer): unit = jsNative
      member __._initCachedDisplayObject(renderer: WebGLRenderer): unit = jsNative
      member __._renderCachedCanvas(renderer: CanvasRenderer): unit = jsNative
      member __._initCachedDisplayObjectCanvas(renderer: CanvasRenderer): unit = jsNative
      member __._calculateCachedBounds(): Rectangle = jsNative
      member __._getCachedLocalBounds(): Rectangle = jsNative
      member __._destroyCachedDisplayObject(): unit = jsNative
      member __._cacheAsBitmapDestroy(options: U2<bool, obj>): unit = jsNative
      member __.getGlobalPosition(?point: Point, ?skipUpdate: bool): Point = jsNative
      member __.updateTransform(): unit = jsNative
      member __.displayObjectUpdateTransform(): unit = jsNative
      member __._recursivePostUpdateTransform(): unit = jsNative
      member __.getBounds(?skipUpdate: bool, ?rect: Rectangle): Rectangle = jsNative
      member __.getLocalBounds(?rect: Rectangle): Rectangle = jsNative
      member __.toGlobal(position: PointLike): Point = jsNative
      member __.toGlobal(position: PointLike, ?point: 'T, ?skipUpdate: bool): 'T = jsNative
      member __.toLocal(position: PointLike, ?from: DisplayObject): Point = jsNative
      member __.toLocal(position: PointLike, ?from: DisplayObject, ?point: 'T, ?skipUpdate: bool): 'T = jsNative
      member __.renderWebGL(renderer: WebGLRenderer): unit = jsNative
      member __.renderCanvas(renderer: CanvasRenderer): unit = jsNative
      member __.setParent(container: Container): Container = jsNative
      member __.setTransform(?x: float, ?y: float, ?scaleX: float, ?scaleY: float, ?rotation: float, ?skewX: float, ?skewY: float, ?pivotX: float, ?pivotY: float): DisplayObject = jsNative
      member __.destroy(): unit = jsNative
      member __.on(``event``: interaction.InteractionEventTypes, fn: interaction.InteractionEvent->unit, ?context: obj): obj = jsNative
      member __.once(``event``: interaction.InteractionEventTypes, fn: interaction.InteractionEvent->unit, ?context: obj): obj = jsNative
      member __.removeListener(``event``: interaction.InteractionEventTypes, ?fn: interaction.InteractionEvent->unit, ?context: obj): obj = jsNative
      member __.removeAllListeners(``event``: interaction.InteractionEventTypes): obj = jsNative
      member __.off(``event``: interaction.InteractionEventTypes, ?fn: interaction.InteractionEvent->unit, ?context: obj): obj = jsNative
      member __.addListener(``event``: interaction.InteractionEventTypes, fn: interaction.InteractionEvent->unit, ?context: obj): obj = jsNative


  module interaction =
      type [<AllowNullLiteral>] InteractiveTarget =
          abstract interactive: bool with get, set
          abstract interactiveChildren: bool with get, set
          abstract hitArea: obj with get, set
          abstract buttonMode: bool with get, set
          abstract cursor: string with get, set
          abstract defaultCursor: string with get, set
          abstract trackedPointers: unit -> obj

      and [<AllowNullLiteral>] InteractionTrackingData =
          abstract pointerId: float with get, set
          abstract flags: float with get, set
          abstract none: float with get, set
          abstract over: bool with get, set
          abstract rightDown: bool with get, set
          abstract leftDown: bool with get, set

      and [<AllowNullLiteral>] InteractionEvent =
          abstract stopped: bool with get, set
          abstract target: DisplayObject with get, set
          abstract currentTarget: DisplayObject with get, set
          abstract ``type``: string with get, set
          abstract data: InteractionData with get, set
          abstract stopPropagation: unit -> unit

      and [<AllowNullLiteral>] [<Import("InteractionData","PIXI.interaction")>] InteractionData() =
          member __.``global`` with get(): Point = jsNative and set(v: Point): unit = jsNative
          member __.target with get(): DisplayObject = jsNative and set(v: DisplayObject): unit = jsNative
          member __.originalEvent with get(): U3<MouseEvent, TouchEvent, PointerEvent> = jsNative and set(v: U3<MouseEvent, TouchEvent, PointerEvent>): unit = jsNative
          member __.identifier with get(): float = jsNative and set(v: float): unit = jsNative
          member __.isPrimary with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.button with get(): float = jsNative and set(v: float): unit = jsNative
          member __.buttons with get(): float = jsNative and set(v: float): unit = jsNative
          member __.width with get(): float = jsNative and set(v: float): unit = jsNative
          member __.height with get(): float = jsNative and set(v: float): unit = jsNative
          member __.tiltX with get(): float = jsNative and set(v: float): unit = jsNative
          member __.tiltY with get(): float = jsNative and set(v: float): unit = jsNative
          member __.pointerType with get(): string = jsNative and set(v: string): unit = jsNative
          member __.pressure with get(): float = jsNative and set(v: float): unit = jsNative
          member __.rotationAngle with get(): float = jsNative and set(v: float): unit = jsNative
          member __.twist with get(): float = jsNative and set(v: float): unit = jsNative
          member __.tangentialPressure with get(): float = jsNative and set(v: float): unit = jsNative
          member __.pointerID with get(): float = jsNative and set(v: float): unit = jsNative
          member __._copyEvent(``event``: U3<Touch, MouseEvent, PointerEvent>): unit = jsNative
          member __._reset(): unit = jsNative
          member __.getLocalPosition(displayObject: DisplayObject, ?point: Point, ?globalPos: Point): Point = jsNative

      and [<StringEnum>] InteractionPointerEvents =
          | Pointerdown | Pointercancel | Pointerup | Pointertap | Pointerupoutside | Pointermove | Pointerover | Pointerout

      and [<StringEnum>] InteractionTouchEvents =
          | Touchstart | Touchcancel | Touchend | Touchendoutside | Touchmove | Tap

      and [<StringEnum>] InteractionMouseEvents =
          | Rightdown | Mousedown | Rightup | Mouseup | Rightclick | Click | Rightupoutside | Mouseupoutside | Mousemove | Mouseout | Mouseover

      and [<StringEnum>] InteractionPixiEvents =
          | Added | Removed

      and InteractionEventTypes =
          U4<InteractionPointerEvents, InteractionTouchEvents, InteractionMouseEvents, InteractionPixiEvents>

      and [<AllowNullLiteral>] InteractionManagerOptions =
          abstract autoPreventDefault: bool option with get, set
          abstract interactionFrequency: float option with get, set

      and [<AllowNullLiteral>] [<Import("InteractionManager","PIXI.interaction")>] InteractionManager(renderer: U3<CanvasRenderer, WebGLRenderer, SystemRenderer>, ?options: InteractionManagerOptions) =
          inherit utils.EventEmitter()
          member __.renderer with get(): SystemRenderer = jsNative and set(v: SystemRenderer): unit = jsNative
          member __.autoPreventDefault with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.interactionFrequency with get(): float = jsNative and set(v: float): unit = jsNative
          member __.mouse with get(): InteractionData = jsNative and set(v: InteractionData): unit = jsNative
          member __.activeInteractionData with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.interactionDataPool with get(): ResizeArray<InteractionData> = jsNative and set(v: ResizeArray<InteractionData>): unit = jsNative
          member __.eventData with get(): InteractionEvent = jsNative and set(v: InteractionEvent): unit = jsNative
          member __.interactionDOMElement with get(): HTMLElement = jsNative and set(v: HTMLElement): unit = jsNative
          member __.moveWhenInside with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.eventsAdded with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.mouseOverRenderer with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.supportsTouchEvents with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.supportsPointerEvents with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.onPointerUp with get(): PointerEvent->unit = jsNative and set(v: PointerEvent->unit): unit = jsNative
  //          member __.processPointerUp with get(): InteractionEvent->U3<Container, Sprite, undefined.TilingSprite>->bool->unit = jsNative and set(v: InteractionEvent->U3<Container, Sprite, undefined.TilingSprite>->bool->unit): unit = jsNative
          member __.onPointerCancel with get(): PointerEvent->unit = jsNative and set(v: PointerEvent->unit): unit = jsNative
  //          member __.processPointerCancel with get(): Func<InteractionEvent, U3<Container, Sprite, undefined.TilingSprite>, unit> = jsNative and set(v: Func<InteractionEvent, U3<Container, Sprite, undefined.TilingSprite>, unit>): unit = jsNative
          member __.onPointerDown with get(): PointerEvent->unit = jsNative and set(v: PointerEvent->unit): unit = jsNative
  //          member __.processPointerDown with get(): InteractionEvent->U3<Container, Sprite, undefined.TilingSprite>->bool->unit = jsNative and set(v: InteractionEvent->U3<Container, Sprite, undefined.TilingSprite>->bool->unit): unit = jsNative
          member __.onPointerMove with get(): PointerEvent->unit = jsNative and set(v: PointerEvent->unit): unit = jsNative
  //          member __.processPointerMove with get(): InteractionEvent->U3<Container, Sprite, undefined.TilingSprite>->bool->unit = jsNative and set(v: InteractionEvent->U3<Container, Sprite, undefined.TilingSprite>->bool->unit): unit = jsNative
          member __.onPointerOut with get(): PointerEvent->unit = jsNative and set(v: PointerEvent->unit): unit = jsNative
  //          member __.processPointerOverOut with get(): InteractionEvent->U3<Container, Sprite, undefined.TilingSprite>->bool->unit = jsNative and set(v: InteractionEvent->U3<Container, Sprite, undefined.TilingSprite>->bool->unit): unit = jsNative
          member __.onPointerOver with get(): PointerEvent->unit = jsNative and set(v: PointerEvent->unit): unit = jsNative
          member __.cursorStyles with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.currentCursorMode with get(): string = jsNative and set(v: string): unit = jsNative
          member __.cursor with get(): string = jsNative and set(v: string): unit = jsNative
          member __._tempPoint with get(): Point = jsNative and set(v: Point): unit = jsNative
          member __.resolution with get(): float = jsNative and set(v: float): unit = jsNative
          member __.defaultCursorStyle with get(): string = jsNative and set(v: string): unit = jsNative
          member __.currentCursorStyle with get(): string = jsNative and set(v: string): unit = jsNative
          member __.hitTest(globalPoint: Point, ?root: Container): DisplayObject = jsNative
          member __.setTargetElement(element: HTMLCanvasElement, ?resolution: float): unit = jsNative
          member __.addEvents(): unit = jsNative
          member __.removeEvents(): unit = jsNative
          member __.update(?deltaTime: float): unit = jsNative
          member __.setCursorMode(mode: string): unit = jsNative
          member __.dispatchEvent(displayObject: U3<Container, Sprite, extras.TilingSprite>, eventString: string, eventData: obj): unit = jsNative
          member __.mapPositionToPoint(point: Point, x: float, y: float): unit = jsNative
  //          member __.processInteractive(interactionEvent: InteractionEvent, displayObject: U3<Container, Sprite, undefined.TilingSprite>, ?func: Function, ?hitTest: bool, ?interactive: bool): bool = jsNative
          member __.onPointerComplete(originalEvent: PointerEvent, cancelled: bool, func: Function): unit = jsNative
          member __.getInteractionDataForPointerId(pointerId: float): InteractionData = jsNative
          member __.releaseInteractionDataForPointerId(``event``: PointerEvent): unit = jsNative
          member __.configureInteractionEventForDOMEvent(interactionEvent: InteractionEvent, pointerEvent: PointerEvent, interactionData: InteractionData): InteractionEvent = jsNative
          member __.normalizeToPointerData(``event``: U3<TouchEvent, MouseEvent, PointerEvent>): ResizeArray<PointerEvent> = jsNative
          member __.destroy(): unit = jsNative




  type [<AllowNullLiteral>] [<Import("Application","PIXI")>] Application(?width: float, ?height: float, ?options: ApplicationOptions, ?noWebGL: bool, ?sharedTicker: bool, ?sharedLoader: bool) =
      member __._ticker with get(): ticker.Ticker = jsNative and set(v: ticker.Ticker): unit = jsNative
      member __.renderer with get(): U2<WebGLRenderer, CanvasRenderer> = jsNative and set(v: U2<WebGLRenderer, CanvasRenderer>): unit = jsNative
      member __.stage with get(): Container = jsNative and set(v: Container): unit = jsNative
      member __.ticker with get(): ticker.Ticker = jsNative and set(v: ticker.Ticker): unit = jsNative
      member __.screen with get(): Rectangle = jsNative and set(v: Rectangle): unit = jsNative
      member __.view with get(): HTMLCanvasElement = jsNative and set(v: HTMLCanvasElement): unit = jsNative
      member __.stop(): unit = jsNative
      member __.start(): unit = jsNative
      member __.render(): unit = jsNative
      member __.destroy(?removeView: bool): unit = jsNative

  and [<AllowNullLiteral>] DestroyOptions =
      abstract children: bool option with get, set
      abstract texture: bool option with get, set
      abstract baseTexture: bool option with get, set

  and [<AllowNullLiteral>] [<Import("Bounds","PIXI")>] Bounds() =
      member __.minX with get(): float = jsNative and set(v: float): unit = jsNative
      member __.minY with get(): float = jsNative and set(v: float): unit = jsNative
      member __.maxX with get(): float = jsNative and set(v: float): unit = jsNative
      member __.maxY with get(): float = jsNative and set(v: float): unit = jsNative
      member __.rect with get(): Rectangle = jsNative and set(v: Rectangle): unit = jsNative
      member __.isEmpty(): bool = jsNative
      member __.clear(): unit = jsNative
      member __.getRectangle(?rect: Rectangle): Rectangle = jsNative
      member __.addPoint(point: Point): unit = jsNative
  //      member __.addQuad(vertices: ResizeArray<float>): U2<Bounds, undefined> = jsNative
      member __.addFrame(transform: Transform, x0: float, y0: float, x1: float, y1: float): unit = jsNative
      member __.addVertices(transform: Transform, vertices: ResizeArray<float>, beginOffset: float, endOffset: float): unit = jsNative
      member __.addBounds(bounds: Bounds): unit = jsNative
      member __.addBoundsMask(bounds: Bounds, mask: Bounds): unit = jsNative
      member __.addBoundsArea(bounds: Bounds, area: Rectangle): unit = jsNative

  and [<AllowNullLiteral>] [<Import("GraphicsData","PIXI")>] GraphicsData(lineWidth: float, lineColor: float, lineAlpha: float, fillColor: float, fillAlpha: float, fill: bool, nativeLines: bool, shape: obj) =
      member __.lineWidth with get(): float = jsNative and set(v: float): unit = jsNative
      member __.nativeLines with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.lineColor with get(): float = jsNative and set(v: float): unit = jsNative
      member __.lineAlpha with get(): float = jsNative and set(v: float): unit = jsNative
      member __._lineTint with get(): float = jsNative and set(v: float): unit = jsNative
      member __.fillColor with get(): float = jsNative and set(v: float): unit = jsNative
      member __.fillAlpha with get(): float = jsNative and set(v: float): unit = jsNative
      member __._fillTint with get(): float = jsNative and set(v: float): unit = jsNative
      member __.fill with get(): bool = jsNative and set(v: bool): unit = jsNative
      //member __.shape with get(): obj = jsNative and set(v: obj): unit = jsNative
      member __.``type`` with get(): float option = jsNative and set(v: float option): unit = jsNative
      member __.clone(): GraphicsData = jsNative
      member __.addHole(shape: obj): unit = jsNative
      member __.destroy(?options: U2<DestroyOptions, bool>): unit = jsNative

  and [<AllowNullLiteral>] [<Import("Graphics","PIXI")>] Graphics(?nativeLines: bool) =
      inherit Container()
      member __.fillAlpha with get(): float = jsNative and set(v: float): unit = jsNative
      member __.lineWidth with get(): float = jsNative and set(v: float): unit = jsNative
      member __.nativeLines with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.lineColor with get(): float = jsNative and set(v: float): unit = jsNative
      member __.graphicsData with get(): ResizeArray<GraphicsData> = jsNative and set(v: ResizeArray<GraphicsData>): unit = jsNative
      member __.tint with get(): float = jsNative and set(v: float): unit = jsNative
      member __._prevTint with get(): float = jsNative and set(v: float): unit = jsNative
      member __.blendMode with get(): float = jsNative and set(v: float): unit = jsNative
      member __.currentPath with get(): GraphicsData = jsNative and set(v: GraphicsData): unit = jsNative
      member __._webGL with get(): obj = jsNative and set(v: obj): unit = jsNative
      member __.isMask with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.boundsPadding with get(): float = jsNative and set(v: float): unit = jsNative
      member __._localBounds with get(): Bounds = jsNative and set(v: Bounds): unit = jsNative
      member __.dirty with get(): float = jsNative and set(v: float): unit = jsNative
      member __.fastRectDirty with get(): float = jsNative and set(v: float): unit = jsNative
      member __.clearDirty with get(): float = jsNative and set(v: float): unit = jsNative
      member __.boundsDirty with get(): float = jsNative and set(v: float): unit = jsNative
      member __.cachedSpriteDirty with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __._spriteRect with get(): Rectangle = jsNative and set(v: Rectangle): unit = jsNative
      member __._fastRect with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __._SPRITE_TEXTURE with get(): Texture = jsNative and set(v: Texture): unit = jsNative
      member __.clone(): Graphics = jsNative
      member __.lineStyle(?lineWidth: float, ?color: float, ?alpha: float): Graphics = jsNative
      member __.moveTo(x: float, y: float): Graphics = jsNative
      member __.lineTo(x: float, y: float): Graphics = jsNative
      member __.quadraticCurveTo(cpX: float, cpY: float, toX: float, toY: float): Graphics = jsNative
      member __.bezierCurveTo(cpX: float, cpY: float, cpX2: float, cpY2: float, toX: float, toY: float): Graphics = jsNative
      member __.arcTo(x1: float, y1: float, x2: float, y2: float, radius: float): Graphics = jsNative
      member __.arc(cx: float, cy: float, radius: float, startAngle: float, endAngle: float, ?anticlockwise: bool): Graphics = jsNative
      member __.beginFill(color: float, ?alpha: float): Graphics = jsNative
      member __.endFill(): Graphics = jsNative
      member __.drawRect(x: float, y: float, width: float, height: float): Graphics = jsNative
      member __.drawRoundedRect(x: float, y: float, width: float, height: float, radius: float): Graphics = jsNative
      member __.drawCircle(x: float, y: float, radius: float): Graphics = jsNative
      member __.drawEllipse(x: float, y: float, width: float, height: float): Graphics = jsNative
      member __.drawPolygon(path: U3<ResizeArray<float>, ResizeArray<Point>, Polygon>): Graphics = jsNative
      member __.clear(): Graphics = jsNative
      member __.isFastRect(): bool = jsNative
      member __._renderCanvas(renderer: CanvasRenderer): unit = jsNative
      member __._calculateBounds(): Rectangle = jsNative
      member __._renderSpriteRect(renderer: SystemRenderer): unit = jsNative
      member __.containsPoint(point: Point): bool = jsNative
      member __.updateLocalBounds(): unit = jsNative
      member __.drawShape(shape: obj): GraphicsData = jsNative
      member __.generateCanvasTexture(?scaleMode: float, ?resolution: float): Texture = jsNative
      member __.closePath(): Graphics = jsNative
      member __.addHole(): Graphics = jsNative
      member __.destroy(?options: U2<DestroyOptions, bool>): unit = jsNative

  and [<AllowNullLiteral>] [<Import("CanvasGraphicsRenderer","PIXI")>] CanvasGraphicsRenderer(renderer: SystemRenderer) =
      member __.render(graphics: Graphics): unit = jsNative
      member __.updateGraphicsTint(graphics: Graphics): unit = jsNative
      member __.renderPolygon(points: ResizeArray<Point>, close: bool, context: CanvasRenderingContext2D): unit = jsNative
      member __.destroy(): unit = jsNative

  //    and [<AllowNullLiteral>] [<Import("*","GraphicsRenderer")>] GraphicsRenderer(renderer: CanvasRenderer) =
  and [<AllowNullLiteral>] [<Import("GraphicsRenderer","PIXI")>] GraphicsRenderer(renderer: WebGLRenderer) =
      inherit ObjectRenderer(renderer)
      member __.graphicsDataPool with get(): ResizeArray<GraphicsData> = jsNative and set(v: ResizeArray<GraphicsData>): unit = jsNative
      member __.primitiveShader with get(): PrimitiveShader = jsNative and set(v: PrimitiveShader): unit = jsNative
      member __.gl with get(): WebGLRenderingContext = jsNative and set(v: WebGLRenderingContext): unit = jsNative
      member __.CONTEXT_UID with get(): float = jsNative and set(v: float): unit = jsNative
      member __.destroy(): unit = jsNative
      member __.render(graphics: Graphics): unit = jsNative
      member __.updateGraphics(graphics: Graphics): unit = jsNative
      member __.getWebGLData(webGL: WebGLRenderingContext, ``type``: float, nativeLines: float): WebGLGraphicsData = jsNative

  and [<AllowNullLiteral>] [<Import("WebGLGraphicsData","PIXI")>] WebGLGraphicsData(gl: WebGLRenderingContext, shader: glCore.GLShader, attribsState: glCore.AttribState) =
      member __.gl with get(): WebGLRenderingContext = jsNative and set(v: WebGLRenderingContext): unit = jsNative
      member __.color with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
      member __.points with get(): ResizeArray<Point> = jsNative and set(v: ResizeArray<Point>): unit = jsNative
      member __.indices with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
      member __.buffer with get(): WebGLBuffer = jsNative and set(v: WebGLBuffer): unit = jsNative
      member __.indexBuffer with get(): WebGLBuffer = jsNative and set(v: WebGLBuffer): unit = jsNative
      member __.dirty with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.glPoints with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
      member __.glIndices with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
      member __.shader with get(): glCore.GLShader = jsNative and set(v: glCore.GLShader): unit = jsNative
      member __.vao with get(): glCore.VertexArrayObject = jsNative and set(v: glCore.VertexArrayObject): unit = jsNative
      member __.nativeLines with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.reset(): unit = jsNative
      member __.upload(): unit = jsNative
      member __.destroy(): unit = jsNative

  and [<AllowNullLiteral>] [<Import("PrimitiveShader","PIXI")>] PrimitiveShader(gl: WebGLRenderingContext, vertexSrc: U2<string, ResizeArray<string>>, fragmentSrc: U2<string, ResizeArray<string>>, precision: string, ?attributesLocation:obj) =
      inherit glCore.GLShader(gl,vertexSrc,fragmentSrc,precision, attributesLocation)




  and [<AllowNullLiteral>] [<Import("Circle","PIXI")>] Circle(?x: float, ?y: float, ?radius: float) =
      member __.x with get(): float = jsNative and set(v: float): unit = jsNative
      member __.y with get(): float = jsNative and set(v: float): unit = jsNative
      member __.radius with get(): float = jsNative and set(v: float): unit = jsNative
      member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
      member __.clone(): Circle = jsNative
      member __.contains(x: float, y: float): bool = jsNative
      member __.getBounds(): Rectangle = jsNative

  and [<AllowNullLiteral>] [<Import("Ellipse","PIXI")>] Ellipse(?x: float, ?y: float, ?width: float, ?height: float) =
      member __.x with get(): float = jsNative and set(v: float): unit = jsNative
      member __.y with get(): float = jsNative and set(v: float): unit = jsNative
      member __.width with get(): float = jsNative and set(v: float): unit = jsNative
      member __.height with get(): float = jsNative and set(v: float): unit = jsNative
      member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
      member __.clone(): Ellipse = jsNative
      member __.contains(x: float, y: float): bool = jsNative
      member __.getBounds(): Rectangle = jsNative

  and [<AllowNullLiteral>] [<Import("Polygon","PIXI")>] Polygon([<ParamArray>] points: float[]) =
      member __.closed with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.points with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
      member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
      member __.clone(): Polygon = jsNative
      member __.contains(x: float, y: float): bool = jsNative
      member __.close(): unit = jsNative

  and [<AllowNullLiteral>] [<Import("RoundedRectangle","PIXI")>] RoundedRectangle(?x: float, ?y: float, ?width: float, ?height: float, ?radius: float) =
      member __.x with get(): float = jsNative and set(v: float): unit = jsNative
      member __.y with get(): float = jsNative and set(v: float): unit = jsNative
      member __.width with get(): float = jsNative and set(v: float): unit = jsNative
      member __.height with get(): float = jsNative and set(v: float): unit = jsNative
      member __.radius with get(): float = jsNative and set(v: float): unit = jsNative
      member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
      member __.clone(): RoundedRectangle = jsNative
      member __.contains(x: float, y: float): bool = jsNative

  and ApplicationOptions = 
    | Width of float
    | Height of float 
    | View of HTMLCanvasElement 
    | Transparent of bool 
    | Antialias of bool 
    | PreserveDrawingBuffer of bool 
    | Resolution of float 
    | ForceCanvas of bool 
    | BackgroundColor of int // float 
    | ClearBeforeRender of bool 
    | RoundPixels of bool 
    | ForceFXAA of bool 
    | Legacy of bool 
    | Context of WebGLRenderingContext 
    | AutoResize of bool 
    | PowerPreference of string 
    | SharedTicker of bool
    | SharedLoader of bool
    | AutoStart of bool
     

  and [<AllowNullLiteral>] [<Import("CanvasRenderer","PIXI")>] CanvasRenderer(?screenWidth: float, ?screenHeight: float, ?options: RendererOptions) =
      inherit SystemRenderer("")
      member __.___plugins with get(): obj = jsNative and set(v: obj): unit = jsNative
      member __.plugins with get(): CanvasRendererPlugins = jsNative and set(v: CanvasRendererPlugins): unit = jsNative
      member __._activeBlendMode with get(): float = jsNative and set(v: float): unit = jsNative
      member __.rootContext with get(): CanvasRenderingContext2D = jsNative and set(v: CanvasRenderingContext2D): unit = jsNative
      member __.rootResolution with get(): float option = jsNative and set(v: float option): unit = jsNative
      member __.refresh with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.maskManager with get(): CanvasMaskManager = jsNative and set(v: CanvasMaskManager): unit = jsNative
      member __.smoothProperty with get(): string = jsNative and set(v: string): unit = jsNative
      member __.extract with get(): extract.CanvasExtract = jsNative and set(v: extract.CanvasExtract): unit = jsNative
      member __.context with get(): U2<CanvasRenderingContext2D, obj> = jsNative and set(v: U2<CanvasRenderingContext2D, obj>): unit = jsNative
      static member registerPlugin(pluginName: string, ctor: obj): unit = jsNative
      member __.initPlugins(): unit = jsNative
      member __.destroyPlugins(): unit = jsNative
      member __.render(displayObject: DisplayObject, ?renderTexture: RenderTexture, ?clear: bool, ?transform: Transform, ?skipUpdateTransform: bool): unit = jsNative
      member __.setBlendMode(blendMode: float): unit = jsNative
      member __.destroy(?removeView: bool): unit = jsNative
      member __.clear(?clearColor: string): unit = jsNative
      member __.invalidateBlendMode(): unit = jsNative
      member __.on(``event``: (* TODO StringEnum prerender | postrender *) string, fn: unit->unit, ?context: obj): obj = jsNative
      member __.once(``event``: (* TODO StringEnum prerender | postrender *) string, fn: unit->unit, ?context: obj): obj = jsNative
      member __.removeListener(``event``: (* TODO StringEnum prerender | postrender *) string, ?fn: unit->unit, ?context: obj): obj = jsNative
      member __.removeAllListeners(``event``: (* TODO StringEnum prerender | postrender *) string): obj = jsNative
      member __.off(``event``: (* TODO StringEnum prerender | postrender *) string, ?fn: unit->unit, ?context: obj): obj = jsNative
      member __.addListener(``event``: (* TODO StringEnum prerender | postrender *) string, fn: unit->unit, ?context: obj): obj = jsNative

  and [<AllowNullLiteral>] [<Import("CanvasMaskManager","PIXI")>] CanvasMaskManager(renderer: CanvasRenderer) =
      member __.pushMask(maskData: obj): unit = jsNative
      member __.renderGraphicsShape(graphics: Graphics): unit = jsNative
      member __.popMask(renderer: U2<WebGLRenderer, CanvasRenderer>): unit = jsNative
      member __.destroy(): unit = jsNative

  and [<AllowNullLiteral>] [<Import("CanvasRenderTarget","PIXI")>] CanvasRenderTarget(width: float, height: float, resolution: float) =
      member __.canvas with get(): HTMLCanvasElement = jsNative and set(v: HTMLCanvasElement): unit = jsNative
      member __.context with get(): CanvasRenderingContext2D = jsNative and set(v: CanvasRenderingContext2D): unit = jsNative
      member __.resolution with get(): float = jsNative and set(v: float): unit = jsNative
      member __.width with get(): float = jsNative and set(v: float): unit = jsNative
      member __.height with get(): float = jsNative and set(v: float): unit = jsNative
      member __.clear(): unit = jsNative
      member __.resize(width: float, height: float): unit = jsNative
      member __.destroy(): unit = jsNative


  and [<AllowNullLiteral>] [<Import("WebGLState","PIXI")>] WebGLState(gl: WebGLRenderingContext) =
      member __.activeState with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
      member __.defaultState with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
      member __.stackIndex with get(): float = jsNative and set(v: float): unit = jsNative
      member __.stack with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
      member __.gl with get(): WebGLRenderingContext = jsNative and set(v: WebGLRenderingContext): unit = jsNative
      member __.maxAttribs with get(): float = jsNative and set(v: float): unit = jsNative
      member __.attribState with get(): glCore.AttribState = jsNative and set(v: glCore.AttribState): unit = jsNative
      member __.nativeVaoExtension with get(): obj = jsNative and set(v: obj): unit = jsNative
      member __.push(): unit = jsNative
      member __.pop(): unit = jsNative
      member __.setState(state: ResizeArray<float>): unit = jsNative
      member __.setBlend(value: float): unit = jsNative
      member __.setBlendMode(value: float): unit = jsNative
      member __.setDepthTest(value: float): unit = jsNative
      member __.setCullFace(value: float): unit = jsNative
      member __.setFrontFace(value: float): unit = jsNative
      member __.resetAttributes(): unit = jsNative
      member __.resetToDefault(): unit = jsNative

  and [<AllowNullLiteral>] [<Import("TextureManager","PIXI")>] TextureManager(renderer: WebGLRenderer) =
      member __.renderer with get(): WebGLRenderer = jsNative and set(v: WebGLRenderer): unit = jsNative
      member __.gl with get(): WebGLRenderingContext = jsNative and set(v: WebGLRenderingContext): unit = jsNative
      member __._managedTextures with get(): ResizeArray<Texture> = jsNative and set(v: ResizeArray<Texture>): unit = jsNative
      member __.bindTexture(): unit = jsNative
      member __.getTexture(): WebGLTexture = jsNative
      member __.updateTexture(texture: U2<BaseTexture, Texture>): WebGLTexture = jsNative
      member __.destroyTexture(texture: BaseTexture, ?_skipRemove: bool): unit = jsNative
      member __.removeAll(): unit = jsNative
      member __.destroy(): unit = jsNative

  and [<AllowNullLiteral>] [<Import("TextureGarbageCollector","PIXI")>] TextureGarbageCollector(renderer: WebGLRenderer) =
      member __.renderer with get(): WebGLRenderer = jsNative and set(v: WebGLRenderer): unit = jsNative
      member __.count with get(): float = jsNative and set(v: float): unit = jsNative
      member __.checkCount with get(): float = jsNative and set(v: float): unit = jsNative
      member __.maxIdle with get(): float = jsNative and set(v: float): unit = jsNative
      member __.checkCountMax with get(): float = jsNative and set(v: float): unit = jsNative
      member __.mode with get(): float = jsNative and set(v: float): unit = jsNative
      member __.update(): unit = jsNative
      member __.run(): unit = jsNative
      member __.unload(): unit = jsNative

  and [<AllowNullLiteral>] [<Import("ObjectRenderer","PIXI")>] ObjectRenderer(renderer: WebGLRenderer) =
      inherit WebGLManager(renderer)
      member __.start(): unit = jsNative
      member __.stop(): unit = jsNative
      member __.flush(): unit = jsNative
      member __.render([<ParamArray>] args: obj[]): unit = jsNative

  and [<AllowNullLiteral>] [<Import("Quad","PIXI")>] Quad(gl: WebGLRenderingContext) =
      member __.gl with get(): WebGLRenderingContext = jsNative and set(v: WebGLRenderingContext): unit = jsNative
      member __.vertices with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
      member __.uvs with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
      member __.interleaved with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
      member __.indices with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
      member __.vertexBuffer with get(): WebGLBuffer = jsNative and set(v: WebGLBuffer): unit = jsNative
      member __.vao with get(): glCore.VertexArrayObject = jsNative and set(v: glCore.VertexArrayObject): unit = jsNative
      member __.initVao(shader: glCore.GLShader): unit = jsNative
      member __.map(targetTextureFrame: Rectangle, destinationFrame: Rectangle): Quad = jsNative
      member __.upload(): Quad = jsNative
      member __.destroy(): unit = jsNative

  and [<AllowNullLiteral>] FilterDataStackItem =
      abstract renderTarget: RenderTarget with get, set
      abstract filter: ResizeArray<obj> with get, set
      abstract bounds: Rectangle with get, set

  and [<AllowNullLiteral>] [<Import("RenderTarget","PIXI")>] RenderTarget(gl: WebGLRenderingContext, width: float, height: float, scaleMode: float, resolution: float, ?root: bool) =
      member __.gl with get(): WebGLRenderingContext = jsNative and set(v: WebGLRenderingContext): unit = jsNative
      member __.frameBuffer with get(): glCore.GLFramebuffer = jsNative and set(v: glCore.GLFramebuffer): unit = jsNative
      member __.texture with get(): Texture = jsNative and set(v: Texture): unit = jsNative
      member __.clearColor with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
      member __.size with get(): Rectangle = jsNative and set(v: Rectangle): unit = jsNative
      member __.resolution with get(): float = jsNative and set(v: float): unit = jsNative
      member __.projectionMatrix with get(): Matrix = jsNative and set(v: Matrix): unit = jsNative
      member __.transform with get(): Matrix = jsNative and set(v: Matrix): unit = jsNative
      member __.frame with get(): Rectangle = jsNative and set(v: Rectangle): unit = jsNative
      member __.defaultFrame with get(): Rectangle = jsNative and set(v: Rectangle): unit = jsNative
      member __.destinationFrame with get(): Rectangle = jsNative and set(v: Rectangle): unit = jsNative
      member __.sourceFrame with get(): Rectangle option = jsNative and set(v: Rectangle option): unit = jsNative
      member __.stencilBuffer with get(): glCore.GLFramebuffer = jsNative and set(v: glCore.GLFramebuffer): unit = jsNative
      member __.stencilMaskStack with get(): ResizeArray<Graphics> = jsNative and set(v: ResizeArray<Graphics>): unit = jsNative
      member __.filterData with get(): obj = jsNative and set(v: obj): unit = jsNative
      member __.scaleMode with get(): float = jsNative and set(v: float): unit = jsNative
      member __.root with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.clear(?clearColor: ResizeArray<float>): unit = jsNative
      member __.attachStencilBuffer(): unit = jsNative
      member __.setFrame(destinationFrame: Rectangle, sourceFrame: Rectangle): unit = jsNative
      member __.activate(): unit = jsNative
      member __.calculateProjection(destinationFrame: Rectangle, sourceFrame: Rectangle): unit = jsNative
      member __.resize(width: float, height: float): unit = jsNative
      member __.destroy(): unit = jsNative

  and [<AllowNullLiteral>] [<Import("BlendModeManager","PIXI")>] BlendModeManager(renderer: WebGLRenderer) =
      inherit WebGLManager(renderer)
      member __.currentBlendMode with get(): float = jsNative and set(v: float): unit = jsNative
      member __.setBlendMode(blendMode: float): bool = jsNative

  and [<AllowNullLiteral>] FilterManagerStackItem =
      abstract renderTarget: RenderTarget with get, set
      abstract sourceFrame: Rectangle with get, set
      abstract destinationFrame: Rectangle with get, set
      abstract filters: ResizeArray<Filter<obj>> with get, set
      abstract target: obj with get, set
      abstract resolution: float with get, set

  and [<AllowNullLiteral>] [<Import("FilterManager","PIXI")>] FilterManager(renderer: WebGLRenderer) =
      inherit WebGLManager(renderer)
      member __.gl with get(): WebGLRenderingContext = jsNative and set(v: WebGLRenderingContext): unit = jsNative
      member __.quad with get(): Quad = jsNative and set(v: Quad): unit = jsNative
      member __.stack with get(): ResizeArray<FilterManagerStackItem> = jsNative and set(v: ResizeArray<FilterManagerStackItem>): unit = jsNative
      member __.stackIndex with get(): float = jsNative and set(v: float): unit = jsNative
      member __.shaderCache with get(): obj = jsNative and set(v: obj): unit = jsNative
      member __.filterData with get(): obj = jsNative and set(v: obj): unit = jsNative
      member __.pushFilter(target: RenderTarget, filters: ResizeArray<Filter<obj>>): unit = jsNative
      member __.popFilter(): unit = jsNative
      member __.applyFilter(shader: U2<glCore.GLShader, Filter<obj>>, inputTarget: RenderTarget, outputTarget: RenderTarget, ?clear: bool): unit = jsNative
      member __.syncUniforms(shader: glCore.GLShader, filter: Filter<obj>): unit = jsNative
      member __.getRenderTarget(?clear: bool, ?resolution: float): RenderTarget = jsNative
      member __.returnRenderTarget(renderTarget: RenderTarget): RenderTarget = jsNative
      member __.calculateScreenSpaceMatrix(outputMatrix: Matrix): Matrix = jsNative
      member __.calculateNormalizedScreenSpaceMatrix(outputMatrix: Matrix): Matrix = jsNative
      member __.calculateSpriteMatrix(outputMatrix: Matrix, sprite: Sprite): Matrix = jsNative
      member __.destroy(): unit = jsNative
      member __.emptyPool(): unit = jsNative
      member __.getPotRenderTarget(gl: WebGLRenderingContext, minWidth: float, minHeight: float, resolution: float): RenderTarget = jsNative
      member __.freePotRenderTarget(renderTarget: RenderTarget): unit = jsNative

  and [<AllowNullLiteral>] [<Import("StencilMaskStack","PIXI")>] StencilMaskStack() =
      member __.stencilStack with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
      member __.reverse with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.count with get(): float = jsNative and set(v: float): unit = jsNative

  (*
  and [<AllowNullLiteral>] [<Import("*","MaskManager")>] MaskManager() =
      inherit WebGLManager()
      member __.scissor with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.scissorData with get(): obj = jsNative and set(v: obj): unit = jsNative
      member __.scissorRenderTarget with get(): RenderTarget = jsNative and set(v: RenderTarget): unit = jsNative
      member __.enableScissor with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.alphaMaskPool with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
      member __.alphaMaskIndex with get(): float = jsNative and set(v: float): unit = jsNative
      member __.pushMask(target: RenderTarget, maskData: U2<Sprite, Graphics>): unit = jsNative
      member __.popMask(target: RenderTarget, maskData: U2<Sprite, Graphics>): unit = jsNative
      member __.pushSpriteMask(target: RenderTarget, maskData: U2<Sprite, Graphics>): unit = jsNative
      member __.popSpriteMask(): unit = jsNative
      member __.pushStencilMask(maskData: U2<Sprite, Graphics>): unit = jsNative
      member __.popStencilMask(): unit = jsNative
      member __.pushScissorMask(target: RenderTarget, maskData: U2<Sprite, Graphics>): unit = jsNative
      member __.popScissorMask(): unit = jsNative
  *)

  and [<AllowNullLiteral>] [<Import("PIXI","StencilManager")>] StencilManager(renderer: WebGLRenderer) =
      inherit WebGLManager(renderer)
      member __.stencilMaskStack with get(): ResizeArray<Graphics> = jsNative and set(v: ResizeArray<Graphics>): unit = jsNative
      member __._useCurrent(): unit = jsNative
      member __._getBitwiseMask(): float = jsNative
      member __.setMaskStack(stencilMasStack: ResizeArray<Graphics>): unit = jsNative
      member __.pushStencil(graphics: Graphics): unit = jsNative
      member __.popStencil(): unit = jsNative
      member __.destroy(): unit = jsNative

  and [<AllowNullLiteral>] [<Import("WebGLManager","PIXI")>] WebGLManager(renderer: WebGLRenderer) =
      member __.renderer with get(): WebGLRenderer = jsNative and set(v: WebGLRenderer): unit = jsNative
      member __.onContextChange(): unit = jsNative
      member __.destroy(): unit = jsNative

  and [<AllowNullLiteral>] UniformData<'V> =
      abstract ``type``: string with get, set
      abstract value: 'V with get, set
      abstract name: string option with get, set

  //  and UniformDataMap<'U> = obj

  //  and [<AllowNullLiteral>] [<Import("*","Filter")>] Filter<'U>(?vertexSrc: string, ?fragmentSrc: string, ?uniforms: UniformDataMap<'U>) =
  and [<AllowNullLiteral>] [<Import("Filter","PIXI")>] Filter<'U>(?vertexSrc: string, ?fragmentSrc: string, ?uniforms: obj) =
      member __._blendMode with get(): float = jsNative and set(v: float): unit = jsNative
      member __.vertexSrc with get(): string option = jsNative and set(v: string option): unit = jsNative
      member __.fragmentSrc with get(): string = jsNative and set(v: string): unit = jsNative
      member __.blendMode with get(): float = jsNative and set(v: float): unit = jsNative
      member __.uniformData with get(): obj = jsNative and set(v: obj): unit = jsNative
  //      member __.uniformData with get(): UniformDataMap<'U> = jsNative and set(v: UniformDataMap<'U>): unit = jsNative
      member __.uniforms with get(): 'U = jsNative and set(v: 'U): unit = jsNative
      member __.glShaders with get(): obj = jsNative and set(v: obj): unit = jsNative
      member __.glShaderKey with get(): float option = jsNative and set(v: float option): unit = jsNative
      member __.padding with get(): float = jsNative and set(v: float): unit = jsNative
      member __.resolution with get(): float = jsNative and set(v: float): unit = jsNative
      member __.enabled with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.autoFit with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.defaultVertexSrc with get(): string = jsNative and set(v: string): unit = jsNative
      member __.defaultFragmentSrc with get(): string = jsNative and set(v: string): unit = jsNative
      member __.apply(filterManager: FilterManager, input: RenderTarget, output: RenderTarget, ?clear: bool, ?currentState: obj): unit = jsNative

  and SpriteMaskFilterUniforms =
      obj

  and [<AllowNullLiteral>] [<Import("SpriteMaskFilter","PIXI")>] SpriteMaskFilter(sprite: Sprite) =
      inherit Filter<SpriteMaskFilterUniforms>()
      member __.maskSprite with get(): Sprite = jsNative and set(v: Sprite): unit = jsNative
      member __.maskMatrix with get(): Matrix = jsNative and set(v: Matrix): unit = jsNative
      member __.apply(filterManager: FilterManager, input: RenderTarget, output: RenderTarget): unit = jsNative

  and [<AllowNullLiteral>] [<Import("Sprite","PIXI")>] Sprite(?texture: Texture) =
      inherit Container()
      member __._anchor with get(): ObservablePoint = jsNative and set(v: ObservablePoint): unit = jsNative
      member __.anchor with get(): ObservablePoint = jsNative and set(v: ObservablePoint): unit = jsNative
      member __._texture with get(): Texture = jsNative and set(v: Texture): unit = jsNative
      member __._transformTrimmedID with get(): float = jsNative and set(v: float): unit = jsNative
      member __._textureTrimmedID with get(): float = jsNative and set(v: float): unit = jsNative
      member __._width with get(): float = jsNative and set(v: float): unit = jsNative
      member __._height with get(): float = jsNative and set(v: float): unit = jsNative
      member __.tint with get(): float = jsNative and set(v: float): unit = jsNative
      member __._tint with get(): float = jsNative and set(v: float): unit = jsNative
      member __._tintRGB with get(): float = jsNative and set(v: float): unit = jsNative
      member __.blendMode with get(): float = jsNative and set(v: float): unit = jsNative
      member __.pluginName with get(): string = jsNative and set(v: string): unit = jsNative
      member __.cachedTint with get(): float = jsNative and set(v: float): unit = jsNative
      member __.texture with get(): Texture = jsNative and set(v: Texture): unit = jsNative
      member __.textureDirty with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __._textureID with get(): float = jsNative and set(v: float): unit = jsNative
      member __._transformID with get(): float = jsNative and set(v: float): unit = jsNative
      member __.vertexTrimmedData with get(): Float32Array = jsNative and set(v: Float32Array): unit = jsNative
      member __.vertexData with get(): Float32Array = jsNative and set(v: Float32Array): unit = jsNative
      member __.width with get(): float = jsNative and set(v: float): unit = jsNative
      member __.height with get(): float = jsNative and set(v: float): unit = jsNative
      member __._onTextureUpdate(): unit = jsNative
      member __.calculateVertices(): unit = jsNative
      member __._calculateBounds(): unit = jsNative
      member __.calculateTrimmedVertices(): unit = jsNative
      member __.onAnchorUpdate(): unit = jsNative
      member __._renderWebGL(renderer: WebGLRenderer): unit = jsNative
      member __._renderCanvas(renderer: CanvasRenderer): unit = jsNative
      member __.getLocalBounds(): Rectangle = jsNative
      member __.containsPoint(point: Point): bool = jsNative
      member __.destroy(?options: U2<DestroyOptions, bool>): unit = jsNative
      static member from(source: obj): Sprite = jsNative
      static member fromFrame(frameId: string): Sprite = jsNative
      static member fromImage(imageId: string, ?crossorigin: bool, ?scaleMode: float): Sprite = jsNative

  and [<AllowNullLiteral>] [<Import("BatchBuffer","PIXI")>] BatchBuffer() =
      member __.vertices with get(): ArrayBuffer = jsNative and set(v: ArrayBuffer): unit = jsNative
      member __.float32View with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
      member __.uint32View with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
      member __.destroy(): unit = jsNative

  and [<AllowNullLiteral>] [<Import("SpriteRenderer","PIXI")>] SpriteRenderer(renderer: WebGLRenderer) =
      inherit ObjectRenderer(renderer)
      member __.vertSize with get(): float = jsNative and set(v: float): unit = jsNative
      member __.vertByteSize with get(): float = jsNative and set(v: float): unit = jsNative
      member __.size with get(): float = jsNative and set(v: float): unit = jsNative
      member __.buffers with get(): ResizeArray<BatchBuffer> = jsNative and set(v: ResizeArray<BatchBuffer>): unit = jsNative
      member __.indices with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
      member __.shaders with get(): ResizeArray<Shader> = jsNative and set(v: ResizeArray<Shader>): unit = jsNative
      member __.currentIndex with get(): float = jsNative and set(v: float): unit = jsNative
      member __.tick with get(): float = jsNative and set(v: float): unit = jsNative
      member __.groups with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
      member __.sprites with get(): ResizeArray<Sprite> = jsNative and set(v: ResizeArray<Sprite>): unit = jsNative
      member __.vertexBuffers with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
      member __.vaos with get(): ResizeArray<glCore.VertexArrayObject> = jsNative and set(v: ResizeArray<glCore.VertexArrayObject>): unit = jsNative
      member __.vaoMax with get(): float = jsNative and set(v: float): unit = jsNative
      member __.vertexCount with get(): float = jsNative and set(v: float): unit = jsNative
      member __.onContextChanged with get(): unit->unit = jsNative and set(v: unit->unit): unit = jsNative
      member __.onPrerender with get(): unit->unit = jsNative and set(v: unit->unit): unit = jsNative
      member __.render(sprite: Sprite): unit = jsNative
      member __.flush(): unit = jsNative
      member __.start(): unit = jsNative
      member __.stop(): unit = jsNative
      member __.destroy(): unit = jsNative

  and [<AllowNullLiteral>] [<Import("CanvasSpriteRenderer","PIXI")>] CanvasSpriteRenderer(renderer: WebGLRenderer) =
      inherit ObjectRenderer(renderer)
      member __.render(sprite: Sprite): unit = jsNative
      member __.destroy(): unit = jsNative

  and [<AllowNullLiteral>] TextStyleOptions =
      abstract align: string option with get, set
      abstract breakWords: bool option with get, set
      abstract dropShadow: bool option with get, set
      abstract dropShadowAlpha: float option with get, set
      abstract dropShadowAngle: float option with get, set
      abstract dropShadowBlur: float option with get, set
      abstract dropShadowColor: U2<string, float> option with get, set
      abstract dropShadowDistance: float option with get, set
      abstract fill: obj option with get, set
      abstract fillGradientType: float option with get, set
      abstract fillGradientStops: ResizeArray<float> option with get, set
      abstract fontFamily: U2<string, ResizeArray<string>> option with get, set
      abstract fontSize: U2<float, string> option with get, set
      abstract fontStyle: string option with get, set
      abstract fontVariant: string option with get, set
      abstract fontWeight: string option with get, set
      abstract letterSpacing: float option with get, set
      abstract lineHeight: float option with get, set
      abstract lineJoin: string option with get, set
      abstract miterLimit: float option with get, set
      abstract padding: float option with get, set
      abstract stroke: U2<string, float> option with get, set
      abstract strokeThickness: float option with get, set
      abstract textBaseline: string option with get, set
      abstract trim: bool option with get, set
      abstract wordWrap: bool option with get, set
      abstract wordWrapWidth: float option with get, set
      abstract leading: float option with get, set

  and [<AllowNullLiteral>] [<Import("TextStyle","PIXI")>] TextStyle(style: TextStyleOptions) =
      interface TextStyleOptions with
          member __.align with get(): string option = jsNative and set(v: string option): unit = jsNative
          member __.breakWords with get(): bool option = jsNative and set(v: bool option): unit = jsNative
          member __.dropShadow with get(): bool option = jsNative and set(v: bool option): unit = jsNative
          member __.dropShadowAlpha with get(): float option = jsNative and set(v: float option): unit = jsNative
          member __.dropShadowAngle with get(): float option = jsNative and set(v: float option): unit = jsNative
          member __.dropShadowBlur with get(): float option = jsNative and set(v: float option): unit = jsNative
          member __.dropShadowColor with get(): U2<string, float> option = jsNative and set(v: U2<string, float> option): unit = jsNative
          member __.dropShadowDistance with get(): float option = jsNative and set(v: float option): unit = jsNative
          member __.fill with get(): obj option = jsNative and set(v: obj option): unit = jsNative
          member __.fillGradientType with get(): float option = jsNative and set(v: float option): unit = jsNative
          member __.fillGradientStops with get(): ResizeArray<float> option = jsNative and set(v: ResizeArray<float> option): unit = jsNative
          member __.fontFamily with get(): U2<string, ResizeArray<string>> option = jsNative and set(v: U2<string, ResizeArray<string>> option): unit = jsNative
          member __.fontSize with get(): U2<float, string> option = jsNative and set(v: U2<float, string> option): unit = jsNative
          member __.fontStyle with get(): string option = jsNative and set(v: string option): unit = jsNative
          member __.fontVariant with get(): string option = jsNative and set(v: string option): unit = jsNative
          member __.fontWeight with get(): string option = jsNative and set(v: string option): unit = jsNative
          member __.letterSpacing with get(): float option = jsNative and set(v: float option): unit = jsNative
          member __.lineHeight with get(): float option = jsNative and set(v: float option): unit = jsNative
          member __.lineJoin with get(): string option = jsNative and set(v: string option): unit = jsNative
          member __.miterLimit with get(): float option = jsNative and set(v: float option): unit = jsNative
          member __.padding with get(): float option = jsNative and set(v: float option): unit = jsNative
          member __.stroke with get(): U2<string, float> option = jsNative and set(v: U2<string, float> option): unit = jsNative
          member __.strokeThickness with get(): float option = jsNative and set(v: float option): unit = jsNative
          member __.textBaseline with get(): string option = jsNative and set(v: string option): unit = jsNative
          member __.trim with get(): bool option = jsNative and set(v: bool option): unit = jsNative
          member __.wordWrap with get(): bool option = jsNative and set(v: bool option): unit = jsNative
          member __.wordWrapWidth with get(): float option = jsNative and set(v: float option): unit = jsNative
          member __.leading with get(): float option = jsNative and set(v: float option): unit = jsNative
      member __.styleID with get(): float = jsNative and set(v: float): unit = jsNative
      member __._align with get(): string = jsNative and set(v: string): unit = jsNative
      member __._breakWords with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __._dropShadow with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __._dropShadowAlpha with get(): float = jsNative and set(v: float): unit = jsNative
      member __._dropShadowAngle with get(): float = jsNative and set(v: float): unit = jsNative
      member __._dropShadowBlur with get(): float = jsNative and set(v: float): unit = jsNative
      member __._dropShadowColor with get(): U2<string, float> = jsNative and set(v: U2<string, float>): unit = jsNative
      member __._dropShadowDistance with get(): float = jsNative and set(v: float): unit = jsNative
      member __._fill with get(): obj = jsNative and set(v: obj): unit = jsNative
      member __._fillGradientType with get(): float = jsNative and set(v: float): unit = jsNative
      member __._fillGradientStops with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
      member __._fontFamily with get(): U2<string, ResizeArray<string>> = jsNative and set(v: U2<string, ResizeArray<string>>): unit = jsNative
      member __._fontSize with get(): U2<float, string> = jsNative and set(v: U2<float, string>): unit = jsNative
      member __._fontStyle with get(): string = jsNative and set(v: string): unit = jsNative
      member __._fontVariant with get(): string = jsNative and set(v: string): unit = jsNative
      member __._fontWeight with get(): string = jsNative and set(v: string): unit = jsNative
      member __._leading with get(): float = jsNative and set(v: float): unit = jsNative
      member __._letterSpacing with get(): float = jsNative and set(v: float): unit = jsNative
      member __._lineHeight with get(): float = jsNative and set(v: float): unit = jsNative
      member __._lineJoin with get(): string = jsNative and set(v: string): unit = jsNative
      member __._miterLimit with get(): float = jsNative and set(v: float): unit = jsNative
      member __._padding with get(): float = jsNative and set(v: float): unit = jsNative
      member __._stroke with get(): U2<string, float> = jsNative and set(v: U2<string, float>): unit = jsNative
      member __._strokeThickness with get(): float = jsNative and set(v: float): unit = jsNative
      member __._textBaseline with get(): string = jsNative and set(v: string): unit = jsNative
      member __._trim with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __._wordWrap with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __._wordWrapWidth with get(): float = jsNative and set(v: float): unit = jsNative
      member __.clone(): TextStyle = jsNative
      member __.reset(): unit = jsNative
      member __.toFontString(): string = jsNative

  and [<AllowNullLiteral>] [<Import("TextMetrics","PIXI")>] TextMetrics(text: string, style: TextStyle, width: float, height: float, lines: ResizeArray<float>, lineWidths: ResizeArray<float>, lineHeight: float, maxLineWidth: float, fontProperties: obj) =
      member __._canvas with get(): HTMLCanvasElement = jsNative and set(v: HTMLCanvasElement): unit = jsNative
      member __._context with get(): CanvasRenderingContext2D = jsNative and set(v: CanvasRenderingContext2D): unit = jsNative
      member __._fonts with get(): FontMetrics = jsNative and set(v: FontMetrics): unit = jsNative
      member __.text with get(): string = jsNative and set(v: string): unit = jsNative
      member __.style with get(): TextStyle = jsNative and set(v: TextStyle): unit = jsNative
      member __.width with get(): float = jsNative and set(v: float): unit = jsNative
      member __.height with get(): float = jsNative and set(v: float): unit = jsNative
      member __.lines with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
      member __.lineWidgets with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
      member __.lineHeight with get(): float = jsNative and set(v: float): unit = jsNative
      member __.maxLineWidth with get(): float = jsNative and set(v: float): unit = jsNative
      member __.fontProperties with get(): obj = jsNative and set(v: obj): unit = jsNative
      static member measureText(text: string, style: TextStyle, ?wordWrap: bool, ?canvas: HTMLCanvasElement): TextMetrics = jsNative
      static member wordWrap(text: string, style: TextStyle, ?canvas: HTMLCanvasElement): string = jsNative
      static member measureFont(font: string): FontMetrics = jsNative

  and [<AllowNullLiteral>] FontMetrics =
      abstract ascent: float with get, set
      abstract descent: float with get, set
      abstract fontSize: float with get, set

  and [<AllowNullLiteral>] [<Import("Text","PIXI")>] Text(?text: string, ?style: TextStyleOptions, ?canvas: HTMLCanvasElement) =
      inherit Sprite()
      member __.canvas with get(): HTMLCanvasElement = jsNative and set(v: HTMLCanvasElement): unit = jsNative
      member __.context with get(): CanvasRenderingContext2D = jsNative and set(v: CanvasRenderingContext2D): unit = jsNative
      member __.resolution with get(): float = jsNative and set(v: float): unit = jsNative
      member __._text with get(): string = jsNative and set(v: string): unit = jsNative
      member __._style with get(): TextStyle = jsNative and set(v: TextStyle): unit = jsNative
      member __._styleListener with get(): Function = jsNative and set(v: Function): unit = jsNative
      member __._font with get(): string = jsNative and set(v: string): unit = jsNative
      member __.localStyleID with get(): float = jsNative and set(v: float): unit = jsNative
      member __.width with get(): float = jsNative and set(v: float): unit = jsNative
      member __.height with get(): float = jsNative and set(v: float): unit = jsNative
      member __.style with get(): TextStyle = jsNative and set(v: TextStyle): unit = jsNative
      member __.text with get(): string = jsNative and set(v: string): unit = jsNative
      member __._onStyleChange with get(): unit->unit = jsNative and set(v: unit->unit): unit = jsNative
      member __.dirty with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.updateText(?respectDirty: bool): unit = jsNative
      member __.drawLetterSpacing(text: string, x: float, y: float, ?isStroke: bool): unit = jsNative
      member __.updateTexture(): unit = jsNative
      member __.renderWebGL(renderer: WebGLRenderer): unit = jsNative
      member __._renderCanvas(renderer: CanvasRenderer): unit = jsNative
      member __.getLocalBounds(?rect: Rectangle): Rectangle = jsNative
      member __._calculateBounds(): unit = jsNative
      member __._generateFillStyle(style: TextStyle, lines: ResizeArray<string>): U3<string, float, CanvasGradient> = jsNative
      member __.destroy(?options: U2<DestroyOptions, bool>): unit = jsNative

  and [<AllowNullLiteral>] [<Import("Spritesheet","PIXI")>] Spritesheet(baseTexture: BaseTexture, data: obj, ?resolutionFilename: string) =
      member __.BATCH_SIZE with get(): float = jsNative and set(v: float): unit = jsNative
      member __.baseTexture with get(): BaseTexture = jsNative and set(v: BaseTexture): unit = jsNative
      member __.textures with get(): obj = jsNative and set(v: obj): unit = jsNative
      member __.data with get(): obj = jsNative and set(v: obj): unit = jsNative
      member __.resolution with get(): float = jsNative and set(v: float): unit = jsNative
      member __._frames with get(): obj = jsNative and set(v: obj): unit = jsNative
      member __._frameKeys with get(): string = jsNative and set(v: string): unit = jsNative
      member __._batchIndex with get(): float = jsNative and set(v: float): unit = jsNative
      member __._callback with get(): obj->obj->unit = jsNative and set(v: obj->obj->unit): unit = jsNative
      member __._updateResolution(resolutionFilename: string): float = jsNative
      member __.parse(callback: obj->obj->unit): unit = jsNative
      member __._processFrames(initialFrameIndex: float): unit = jsNative
      member __._parseComplete(): unit = jsNative
      member __._nextBatch(): unit = jsNative
      member __.destroy(?destroyBase: bool): unit = jsNative

  and [<AllowNullLiteral>] [<Import("VideoBaseTexture","PIXI")>] VideoBaseTexture(source: HTMLVideoElement, ?scaleMode: float) =
      inherit BaseTexture()
      member __.autoUpdate with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.autoPlay with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __._isAutoUpdating with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __.source with get(): HTMLVideoElement = jsNative and set(v: HTMLVideoElement): unit = jsNative
      member __.update(): unit = jsNative
      member __._onCanPlay(): unit = jsNative
      member __._onPlayStart(): unit = jsNative
      member __._onPlayStop(): unit = jsNative
      member __.destroy(): unit = jsNative
      member __._isSourcePlaying(): bool = jsNative
      member __._isSourceReady(): bool = jsNative
      static member fromVideo(video: HTMLVideoElement, ?scaleMode: float): VideoBaseTexture = jsNative
      static member fromUrl(videoSrc: U4<string, obj, ResizeArray<string>, ResizeArray<obj>>): VideoBaseTexture = jsNative
      static member fromUrls(videoSrc: U4<string, obj, ResizeArray<string>, ResizeArray<obj>>): VideoBaseTexture = jsNative
      member __.loadSource(source: HTMLVideoElement): unit = jsNative

  and [<AllowNullLiteral>] [<Import("Shader","PIXI")>] Shader(gl: WebGLRenderingContext, vertexSrc: U2<string, ResizeArray<string>>, fragmentSrc: U2<string, ResizeArray<string>>, precision: string, ?attributesLocation:obj) =
      inherit glCore.GLShader(gl,vertexSrc,fragmentSrc,precision, attributesLocation)

  and [<AllowNullLiteral>] [<Import("MiniSignalBinding","PIXI")>] MiniSignalBinding(fn: Function, ?once: bool, ?thisArg: obj) =
      member __._fn with get(): Function = jsNative and set(v: Function): unit = jsNative
      member __._once with get(): bool = jsNative and set(v: bool): unit = jsNative
      member __._thisArg with get(): obj = jsNative and set(v: obj): unit = jsNative
      member __._next with get(): MiniSignalBinding = jsNative and set(v: MiniSignalBinding): unit = jsNative
      member __._prev with get(): MiniSignalBinding = jsNative and set(v: MiniSignalBinding): unit = jsNative
      member __._owner with get(): MiniSignal = jsNative and set(v: MiniSignal): unit = jsNative
      member __.detach(): bool = jsNative

  and [<AllowNullLiteral>] [<Import("MiniSignal","PIXI")>] MiniSignal() =
      member __._head with get(): MiniSignalBinding = jsNative and set(v: MiniSignalBinding): unit = jsNative
      member __._tail with get(): MiniSignalBinding = jsNative and set(v: MiniSignalBinding): unit = jsNative
      member __.handlers(?exists: bool): U2<ResizeArray<MiniSignalBinding>, bool> = jsNative
      member __.handlers(?exists: obj): bool = jsNative
      member __.has(node: MiniSignalBinding): bool = jsNative
      member __.dispatch(): bool = jsNative
      member __.add(fn: Function, ?thisArg: obj): obj = jsNative
      member __.once(fn: Function, ?thisArg: obj): obj = jsNative
      member __.detach(node: MiniSignalBinding): MiniSignal = jsNative
      member __.detachAll(): MiniSignal = jsNative

  module PIXI =
      type [<Import("*","PIXI")>] Globals =
          static member VERSION with get(): obj = jsNative and set(v: obj): unit = jsNative
          static member PI_2 with get(): obj = jsNative and set(v: obj): unit = jsNative
          static member RAD_TO_DEG with get(): obj = jsNative and set(v: obj): unit = jsNative
          static member DEG_TO_RAD with get(): obj = jsNative and set(v: obj): unit = jsNative
          static member RENDERER_TYPE with get(): obj = jsNative and set(v: obj): unit = jsNative
          static member BLEND_MODES with get(): obj = jsNative and set(v: obj): unit = jsNative
          static member DRAW_MODES with get(): obj = jsNative and set(v: obj): unit = jsNative
          static member SCALE_MODES with get(): obj = jsNative and set(v: obj): unit = jsNative
          static member WRAP_MODES with get(): obj = jsNative and set(v: obj): unit = jsNative
          static member TRANSFORM_MODE_O with get(): obj = jsNative and set(v: obj): unit = jsNative
          static member PRECISION_O with get(): obj = jsNative and set(v: obj): unit = jsNative
          static member GC_MODES with get(): obj = jsNative and set(v: obj): unit = jsNative
          static member SHAPES with get(): obj = jsNative and set(v: obj): unit = jsNative
          static member TEXT_GRADIENT with get(): obj = jsNative and set(v: obj): unit = jsNative
          static member UPDATE_PRIORITY with get(): obj = jsNative and set(v: obj): unit = jsNative
  //          static member loader with get(): undefined.Loader = jsNative and set(v: undefined.Loader): unit = jsNative
          static member TRANSFORM_MODE with get(): float = jsNative and set(v: float): unit = jsNative
          static member GC_MODE with get(): float = jsNative and set(v: float): unit = jsNative
          static member GC_MAX_IDLE with get(): float = jsNative and set(v: float): unit = jsNative
          static member GC_MAX_CHECK_COUNT with get(): float = jsNative and set(v: float): unit = jsNative
          static member WRAP_MODE with get(): float = jsNative and set(v: float): unit = jsNative
          static member SCALE_MODE with get(): float = jsNative and set(v: float): unit = jsNative
          static member PRECISION_VERTEX with get(): string = jsNative and set(v: string): unit = jsNative
          static member PRECISION_FRAGMENT with get(): string = jsNative and set(v: string): unit = jsNative
          static member PRECISION_S with get(): string = jsNative and set(v: string): unit = jsNative
          static member UPLOADS_PER_FRAME with get(): float = jsNative and set(v: float): unit = jsNative
          static member CAN_UPLOAD_SAME_BUFFER with get(): bool = jsNative and set(v: bool): unit = jsNative
          static member autoDetectRenderer(width: float, height: float, ?options: RendererOptions, ?forceCanvas: bool): U2<WebGLRenderer, CanvasRenderer> = jsNative
          static member autoDetectRenderer(?options: RendererOptions): U2<WebGLRenderer, CanvasRenderer> = jsNative

      module settings =
          type [<AllowNullLiteral>] RENDER_OPTIONSType =
              abstract view: U2<HTMLCanvasElement, obj> with get, set

          type [<Import("settings","PIXI")>] Globals =
              static member TARGET_FPMS with get(): float = jsNative and set(v: float): unit = jsNative
              static member MIPMAP_TEXTURES with get(): bool = jsNative and set(v: bool): unit = jsNative
              static member RESOLUTION with get(): float = jsNative and set(v: float): unit = jsNative
              static member FILTER_RESOLUTION with get(): float = jsNative and set(v: float): unit = jsNative
              static member SPRITE_MAX_TEXTURES with get(): float = jsNative and set(v: float): unit = jsNative
              static member SPRITE_BATCH_SIZE with get(): float = jsNative and set(v: float): unit = jsNative
              static member RETINA_PREFIX with get(): Regex = jsNative and set(v: Regex): unit = jsNative
              static member RENDER_OPTIONS with get(): RENDER_OPTIONSType = jsNative and set(v: RENDER_OPTIONSType): unit = jsNative
              static member antialias with get(): bool = jsNative and set(v: bool): unit = jsNative
              static member forceFXAA with get(): bool = jsNative and set(v: bool): unit = jsNative
              static member autoResize with get(): bool = jsNative and set(v: bool): unit = jsNative
              static member transparent with get(): bool = jsNative and set(v: bool): unit = jsNative
              static member backgroundColor with get(): float = jsNative and set(v: float): unit = jsNative
              static member clearBeforeRender with get(): bool = jsNative and set(v: bool): unit = jsNative
              static member preserveDrawingBuffer with get(): bool = jsNative and set(v: bool): unit = jsNative
              static member roundPixels with get(): bool = jsNative and set(v: bool): unit = jsNative






  module CONST =
      type [<AllowNullLiteral>] RENDERER_TYPEType =
          abstract UNKNOWN: float with get, set
          abstract WEBGL: float with get, set
          abstract CANVAS: float with get, set

      and [<AllowNullLiteral>] BLEND_MODESType =
          abstract NORMAL: float with get, set
          abstract ADD: float with get, set
          abstract MULTIPLY: float with get, set
          abstract SCREEN: float with get, set
          abstract OVERLAY: float with get, set
          abstract DARKEN: float with get, set
          abstract LIGHTEN: float with get, set
          abstract COLOR_DODGE: float with get, set
          abstract COLOR_BURN: float with get, set
          abstract HARD_LIGHT: float with get, set
          abstract SOFT_LIGHT: float with get, set
          abstract DIFFERENCE: float with get, set
          abstract EXCLUSION: float with get, set
          abstract HUE: float with get, set
          abstract SATURATION: float with get, set
          abstract COLOR: float with get, set
          abstract LUMINOSITY: float with get, set
          abstract NORMAL_NPM: float with get, set
          abstract ADD_NPM: float with get, set
          abstract SCREEN_NPM: float with get, set

      and [<AllowNullLiteral>] DRAW_MODESType =
          abstract POINTS: float with get, set
          abstract LINES: float with get, set
          abstract LINE_LOOP: float with get, set
          abstract LINE_STRIP: float with get, set
          abstract TRIANGLES: float with get, set
          abstract TRIANGLE_STRIP: float with get, set
          abstract TRIANGLE_FAN: float with get, set

      and [<AllowNullLiteral>] SCALE_MODESType =
          abstract LINEAR: float with get, set
          abstract NEAREST: float with get, set

      and [<AllowNullLiteral>] GC_MODESType =
          abstract AUTO: float with get, set
          abstract MANUAL: float with get, set

      and [<AllowNullLiteral>] WRAP_MODESType =
          abstract CLAMP: float with get, set
          abstract MIRRORED_REPEAT: float with get, set
          abstract REPEAT: float with get, set

      and [<AllowNullLiteral>] TRANSFORM_MODEType =
          abstract DEFAULT: float with get, set
          abstract DYNAMIC: float with get, set
          abstract STATIC: float with get, set

      and [<AllowNullLiteral>] SHAPESType =
          abstract POLY: float with get, set
          abstract RECT: float with get, set
          abstract CIRC: float with get, set
          abstract ELIP: float with get, set
          abstract RREC: float with get, set

      and [<AllowNullLiteral>] PRECISIONType =
          abstract LOW: string with get, set
          abstract MEDIUM: string with get, set
          abstract HIGH: string with get, set

      and [<AllowNullLiteral>] TEXT_GRADIENTType =
          abstract LINEAR_VERTICAL: float with get, set
          abstract LINEAR_HORIZONTAL: float with get, set

      and [<AllowNullLiteral>] UPDATE_PRIORITYType =
          abstract INTERACTION: float with get, set
          abstract HIGH: float with get, set
          abstract NORMAL: float with get, set
          abstract LOW: float with get, set
          abstract UTILITY: float with get, set

      type [<Import("CONST","PIXI")>] Globals =
          static member VERSION with get(): string = jsNative and set(v: string): unit = jsNative
          static member PI_2 with get(): float = jsNative and set(v: float): unit = jsNative
          static member RAD_TO_DEG with get(): float = jsNative and set(v: float): unit = jsNative
          static member DEG_TO_RAD with get(): float = jsNative and set(v: float): unit = jsNative
          static member TARGET_FPMS with get(): float = jsNative and set(v: float): unit = jsNative
          static member RENDERER_TYPE with get(): RENDERER_TYPEType = jsNative and set(v: RENDERER_TYPEType): unit = jsNative
          static member BLEND_MODES with get(): BLEND_MODESType = jsNative and set(v: BLEND_MODESType): unit = jsNative
          static member DRAW_MODES with get(): DRAW_MODESType = jsNative and set(v: DRAW_MODESType): unit = jsNative
          static member SCALE_MODES with get(): SCALE_MODESType = jsNative and set(v: SCALE_MODESType): unit = jsNative
          static member GC_MODES with get(): GC_MODESType = jsNative and set(v: GC_MODESType): unit = jsNative
          static member WRAP_MODES with get(): WRAP_MODESType = jsNative and set(v: WRAP_MODESType): unit = jsNative
          static member TRANSFORM_MODE with get(): TRANSFORM_MODEType = jsNative and set(v: TRANSFORM_MODEType): unit = jsNative
          static member URL_FILE_EXTENSION with get(): U2<Regex, string> = jsNative and set(v: U2<Regex, string>): unit = jsNative
          static member DATA_URI with get(): U2<Regex, string> = jsNative and set(v: U2<Regex, string>): unit = jsNative
          static member SVG_SIZE with get(): U2<Regex, string> = jsNative and set(v: U2<Regex, string>): unit = jsNative
          static member SHAPES with get(): SHAPESType = jsNative and set(v: SHAPESType): unit = jsNative
          static member PRECISION with get(): PRECISIONType = jsNative and set(v: PRECISIONType): unit = jsNative
          static member TEXT_GRADIENT with get(): TEXT_GRADIENTType = jsNative and set(v: TEXT_GRADIENTType): unit = jsNative
          static member UPDATE_PRIORITY with get(): UPDATE_PRIORITYType = jsNative and set(v: UPDATE_PRIORITYType): unit = jsNative



  module GroupD8 =
      type [<Import("GroupD8","PIXI")>] Globals =
          static member E with get(): float = jsNative and set(v: float): unit = jsNative
          static member SE with get(): float = jsNative and set(v: float): unit = jsNative
          static member S with get(): float = jsNative and set(v: float): unit = jsNative
          static member SW with get(): float = jsNative and set(v: float): unit = jsNative
          static member W with get(): float = jsNative and set(v: float): unit = jsNative
          static member NW with get(): float = jsNative and set(v: float): unit = jsNative
          static member N with get(): float = jsNative and set(v: float): unit = jsNative
          static member NE with get(): float = jsNative and set(v: float): unit = jsNative
          static member MIRROR_HORIZONTAL with get(): float = jsNative and set(v: float): unit = jsNative
          static member MIRROR_VERTICAL with get(): float = jsNative and set(v: float): unit = jsNative
          static member uX(ind: float): float = jsNative
          static member uY(ind: float): float = jsNative
          static member vX(ind: float): float = jsNative
          static member vY(ind: float): float = jsNative
          static member inv(rotation: float): float = jsNative
          static member add(rotationSecond: float, rotationFirst: float): float = jsNative
          static member sub(rotationSecond: float, rotationFirst: float): float = jsNative
          static member rotate180(rotation: float): float = jsNative
          static member isSwapWidthHeight(rotation: float): bool = jsNative
          static member byDirection(dx: float, dy: float): float = jsNative
          static member matrixAppendRotationInv(matrix: Matrix, rotation: float, tx: float, ty: float): unit = jsNative



  module CanvasTinter =
      type [<Import("CanvasTinter","PIXI")>] Globals =
          static member cacheStepsPerColorChannel with get(): float = jsNative and set(v: float): unit = jsNative
          static member convertTintToImage with get(): bool = jsNative and set(v: bool): unit = jsNative
          static member canUseMultiply with get(): bool = jsNative and set(v: bool): unit = jsNative
          static member tintMethod with get(): float = jsNative and set(v: float): unit = jsNative
          static member getTintedTexture(sprite: Sprite, color: float): HTMLCanvasElement = jsNative
          static member tintWithMultiply(texture: Texture, color: float, canvas: HTMLCanvasElement): unit = jsNative
          static member tintWithOverlay(texture: Texture, color: float, canvas: HTMLCanvasElement): unit = jsNative
          static member tintWithPerPixel(texture: Texture, color: float, canvas: HTMLCanvasElement): unit = jsNative
          static member roundColor(color: float): float = jsNative





  module extract =
      type [<AllowNullLiteral>] [<Import("CanvasExtract","PIXI.extract")>] CanvasExtract(renderer: CanvasRenderer) =
          member __.renderer with get(): CanvasRenderer = jsNative and set(v: CanvasRenderer): unit = jsNative
          member __.image(?target: U2<DisplayObject, RenderTexture>): HTMLImageElement = jsNative
          member __.base64(?target: U2<DisplayObject, RenderTexture>): string = jsNative
          member __.canvas(?target: U2<DisplayObject, RenderTexture>): HTMLCanvasElement = jsNative
          member __.pixels(?renderTexture: U2<DisplayObject, RenderTexture>): ResizeArray<float> = jsNative
          member __.destroy(): unit = jsNative

      and [<AllowNullLiteral>] [<Import("WebGLExtract","PIXI.extract")>] WebGLExtract(renderer: WebGLRenderer) =
          member __.renderer with get(): WebGLRenderer = jsNative and set(v: WebGLRenderer): unit = jsNative
          member __.image(?target: U2<DisplayObject, RenderTexture>): HTMLImageElement = jsNative
          member __.base64(?target: U2<DisplayObject, RenderTexture>): string = jsNative
          member __.canvas(?target: U2<DisplayObject, RenderTexture>): HTMLCanvasElement = jsNative
          member __.pixels(?renderTexture: U2<DisplayObject, RenderTexture>): ResizeArray<float> = jsNative
          member __.destroy(): unit = jsNative



  module extras =
      type [<AllowNullLiteral>] BitmapTextStyle =
          abstract font: U2<string, obj> option with get, set
          abstract align: string option with get, set
          abstract tint: float option with get, set

      and [<AllowNullLiteral>] [<Import("BitmapText","PIXI.extras")>] BitmapText(text: string, ?style: BitmapTextStyle) =
          inherit Container()
          member __._textWidth with get(): float = jsNative and set(v: float): unit = jsNative
          member __._textHeight with get(): float = jsNative and set(v: float): unit = jsNative
          member __.textWidth with get(): float = jsNative and set(v: float): unit = jsNative
          member __.textHeight with get(): float = jsNative and set(v: float): unit = jsNative
          member __._glyphs with get(): ResizeArray<Sprite> = jsNative and set(v: ResizeArray<Sprite>): unit = jsNative
          member __._font with get(): U2<string, obj> = jsNative and set(v: U2<string, obj>): unit = jsNative
          member __.font with get(): U2<string, obj> = jsNative and set(v: U2<string, obj>): unit = jsNative
          member __._text with get(): string = jsNative and set(v: string): unit = jsNative
          member __._maxWidth with get(): float = jsNative and set(v: float): unit = jsNative
          member __.maxWidth with get(): float = jsNative and set(v: float): unit = jsNative
          member __._maxLineHeight with get(): float = jsNative and set(v: float): unit = jsNative
          member __.maxLineHeight with get(): float = jsNative and set(v: float): unit = jsNative
          member __._anchor with get(): ObservablePoint = jsNative and set(v: ObservablePoint): unit = jsNative
          member __.dirty with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.tint with get(): float = jsNative and set(v: float): unit = jsNative
          member __.align with get(): string = jsNative and set(v: string): unit = jsNative
          member __.text with get(): string = jsNative and set(v: string): unit = jsNative
          member __.anchor with get(): U2<Point, float> = jsNative and set(v: U2<Point, float>): unit = jsNative
          member __.fonts with get(): obj = jsNative and set(v: obj): unit = jsNative
          static member registerFont(xml: XMLDocument, texture: Texture): obj = jsNative
          member __.updateText(): unit = jsNative
          member __.updateTransform(): unit = jsNative
          member __.getLocalBounds(): Rectangle = jsNative
          member __.validate(): unit = jsNative

      and [<AllowNullLiteral>] AnimatedSpriteTextureTimeObject =
          abstract texture: Texture with get, set
          abstract time: float option with get, set

      and [<AllowNullLiteral>] [<Import("AnimatedSprite","PIXI.extras")>] AnimatedSprite(textures: U2<ResizeArray<Texture>, ResizeArray<AnimatedSpriteTextureTimeObject>>, ?autoUpdate: bool) =
          inherit Sprite()
          member __._autoUpdate with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __._textures with get(): ResizeArray<Texture> = jsNative and set(v: ResizeArray<Texture>): unit = jsNative
          member __._durations with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
          member __.textures with get(): U2<ResizeArray<Texture>, ResizeArray<AnimatedSpriteTextureTimeObject>> = jsNative and set(v: U2<ResizeArray<Texture>, ResizeArray<AnimatedSpriteTextureTimeObject>>): unit = jsNative
          member __.animationSpeed with get(): float = jsNative and set(v: float): unit = jsNative
          member __.loop with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.onComplete with get(): unit->unit = jsNative and set(v: unit->unit): unit = jsNative
          member __.onFrameChange with get(): float->unit = jsNative and set(v: float->unit): unit = jsNative
          member __.onLoop with get(): unit->unit = jsNative and set(v: unit->unit): unit = jsNative
          member __._currentTime with get(): float = jsNative and set(v: float): unit = jsNative
          member __.playing with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.totalFrames with get(): float = jsNative and set(v: float): unit = jsNative
          member __.currentFrame with get(): float = jsNative and set(v: float): unit = jsNative
          member __.stop(): unit = jsNative
          member __.play(): unit = jsNative
          member __.gotoAndStop(frameNumber: float): unit = jsNative
          member __.gotoAndPlay(frameNumber: float): unit = jsNative
          member __.update(deltaTime: float): unit = jsNative
          member __.destroy(?options: U2<DestroyOptions, bool>): unit = jsNative
          static member fromFrames(frame: ResizeArray<string>): AnimatedSprite = jsNative
          static member fromImages(images: ResizeArray<string>): AnimatedSprite = jsNative

      and [<AllowNullLiteral>] [<Import("TextureTransform","PIXI.extras")>] TextureTransform(texture: Texture, ?clampMargin: float) =
          member __._texture with get(): Texture = jsNative and set(v: Texture): unit = jsNative
          member __.mapCoord with get(): Matrix = jsNative and set(v: Matrix): unit = jsNative
          member __.uClampFrame with get(): Float32Array = jsNative and set(v: Float32Array): unit = jsNative
          member __.uClampOffset with get(): Float32Array = jsNative and set(v: Float32Array): unit = jsNative
          member __._lastTextureID with get(): float = jsNative and set(v: float): unit = jsNative
          member __.clampOffset with get(): float = jsNative and set(v: float): unit = jsNative
          member __.clampMargin with get(): float = jsNative and set(v: float): unit = jsNative
          member __.texture with get(): Texture = jsNative and set(v: Texture): unit = jsNative
          member __.update(?forceUpdate: bool): bool = jsNative

      and [<AllowNullLiteral>] [<Import("TilingSprite","PIXI.extras")>] TilingSprite(texture: Texture, ?width: float, ?height: float) =
          inherit Sprite()
          member __.tileTransform with get(): TransformStatic = jsNative and set(v: TransformStatic): unit = jsNative
          member __._width with get(): float = jsNative and set(v: float): unit = jsNative
          member __._height with get(): float = jsNative and set(v: float): unit = jsNative
          member __._canvasPattern with get(): CanvasPattern = jsNative and set(v: CanvasPattern): unit = jsNative
          member __.uvTransform with get(): TextureTransform = jsNative and set(v: TextureTransform): unit = jsNative
          member __.uvRespectAnchor with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.clampMargin with get(): float = jsNative and set(v: float): unit = jsNative
          member __.tileScale with get(): U2<Point, ObservablePoint> = jsNative and set(v: U2<Point, ObservablePoint>): unit = jsNative
          member __.tilePosition with get(): U2<Point, ObservablePoint> = jsNative and set(v: U2<Point, ObservablePoint>): unit = jsNative
          member __._textureDirtyFlag with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.width with get(): float = jsNative and set(v: float): unit = jsNative
          member __.height with get(): float = jsNative and set(v: float): unit = jsNative
          member __.multiplyUvs(uvs: Float32Array, out: Float32Array): Float32Array = jsNative
          member __._onTextureUpdate(): unit = jsNative
          member __._renderWebGL(renderer: WebGLRenderer): unit = jsNative
          member __._renderCanvas(renderer: CanvasRenderer): unit = jsNative
          member __._calculateBounds(): unit = jsNative
          member __.getLocalBounds(?rect: Rectangle): Rectangle = jsNative
          member __.containsPoint(point: Point): bool = jsNative
          member __.destroy(?options: U2<DestroyOptions, bool>): unit = jsNative
          static member from(source: obj, ?width: float, ?height: float): TilingSprite = jsNative
          static member fromFrame(frameId: string, ?width: float, ?height: float): TilingSprite = jsNative
          static member fromImage(imageId: string, ?crossorigin: bool, ?scaleMode: float): Sprite = jsNative
          static member fromImage(imageId: string, ?width: float, ?height: float, ?crossorigin: bool, ?scaleMode: float): TilingSprite = jsNative

      and [<AllowNullLiteral>] [<Import("TilingSpriteRenderer","PIXI.extras")>] TilingSpriteRenderer(renderer: WebGLRenderer) =
          inherit ObjectRenderer(renderer)
          member __.render(ts: TilingSprite): unit = jsNative


  (*
  module filters =
      type [<AllowNullLiteral>] [<Import("FXAAFilter","filters")>] FXAAFilter() =
          interface Filter<obj>


      and [<AllowNullLiteral>] [<Import("BlurFilter","filters")>] BlurFilter(?strength: float, ?quality: float, ?resolution: float, ?kernelSize: float) =
          interface Filter<obj>
          member __.blurXFilter with get(): BlurXFilter = jsNative and set(v: BlurXFilter): unit = jsNative
          member __.blurYFilter with get(): BlurYFilter = jsNative and set(v: BlurYFilter): unit = jsNative
          member __.resolution with get(): float = jsNative and set(v: float): unit = jsNative
          member __.padding with get(): float = jsNative and set(v: float): unit = jsNative
          member __.passes with get(): float = jsNative and set(v: float): unit = jsNative
          member __.blur with get(): float = jsNative and set(v: float): unit = jsNative
          member __.blurX with get(): float = jsNative and set(v: float): unit = jsNative
          member __.blurY with get(): float = jsNative and set(v: float): unit = jsNative
          member __.quality with get(): float = jsNative and set(v: float): unit = jsNative
          member __.blendMode with get(): float = jsNative and set(v: float): unit = jsNative

      and [<AllowNullLiteral>] BlurXFilterUniforms =
          obj

      and [<AllowNullLiteral>] [<Import("BlurXFilter","filters")>] BlurXFilter(?strength: float, ?quality: float, ?resolution: float, ?kernelSize: float) =
          interface Filter<BlurXFilterUniforms>
          member __._quality with get(): float = jsNative and set(v: float): unit = jsNative
          member __.quality with get(): float = jsNative and set(v: float): unit = jsNative
          member __.passes with get(): float = jsNative and set(v: float): unit = jsNative
          member __.resolution with get(): float = jsNative and set(v: float): unit = jsNative
          member __.strength with get(): float = jsNative and set(v: float): unit = jsNative
          member __.firstRun with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.blur with get(): float = jsNative and set(v: float): unit = jsNative

      and [<AllowNullLiteral>] BlurYFilterUniforms =
          obj

      and [<AllowNullLiteral>] [<Import("BlurYFilter","filters")>] BlurYFilter(?strength: float, ?quality: float, ?resolution: float, ?kernelSize: float) =
          interface Filter<BlurYFilterUniforms>
          member __._quality with get(): float = jsNative and set(v: float): unit = jsNative
          member __.quality with get(): float = jsNative and set(v: float): unit = jsNative
          member __.passes with get(): float = jsNative and set(v: float): unit = jsNative
          member __.resolution with get(): float = jsNative and set(v: float): unit = jsNative
          member __.strength with get(): float = jsNative and set(v: float): unit = jsNative
          member __.firstRun with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.blur with get(): float = jsNative and set(v: float): unit = jsNative

      and [<AllowNullLiteral>] ColorMatrixFilterUniforms =
          obj

      and [<AllowNullLiteral>] [<Import("ColorMatrixFilter","filters")>] ColorMatrixFilter() =
          interface Filter<ColorMatrixFilterUniforms>
          member __.matrix with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
          member __.alpha with get(): float = jsNative and set(v: float): unit = jsNative
          member __._loadMatrix(matrix: ResizeArray<float>, ?multiply: bool): unit = jsNative
          member __._multiply(out: ResizeArray<float>, a: ResizeArray<float>, b: ResizeArray<float>): unit = jsNative
          member __._colorMatrix(matrix: ResizeArray<float>): unit = jsNative
          member __.brightness(b: float, ?multiply: bool): unit = jsNative
          member __.greyscale(scale: float, ?multiply: bool): unit = jsNative
          member __.blackAndWhite(?multiply: bool): unit = jsNative
          member __.hue(rotation: float, ?multiply: bool): unit = jsNative
          member __.contrast(amount: float, ?multiply: bool): unit = jsNative
          member __.saturate(amount: float, ?multiply: bool): unit = jsNative
          member __.desaturate(?multiply: bool): unit = jsNative
          member __.negative(?multiply: bool): unit = jsNative
          member __.sepia(?multiply: bool): unit = jsNative
          member __.technicolor(?multiply: bool): unit = jsNative
          member __.polaroid(?multiply: bool): unit = jsNative
          member __.toBGR(?multiply: bool): unit = jsNative
          member __.kodachrome(?multiply: bool): unit = jsNative
          member __.browni(?multiply: bool): unit = jsNative
          member __.vintage(?multiply: bool): unit = jsNative
          member __.colorTone(desaturation: float, toned: float, lightColor: string, darkColor: string, ?multiply: bool): unit = jsNative
          member __.night(intensity: float, ?multiply: bool): unit = jsNative
          member __.predator(amount: float, ?multiply: bool): unit = jsNative
          member __.lsd(?multiply: bool): unit = jsNative
          member __.reset(): unit = jsNative

      and [<AllowNullLiteral>] DisplacementFilterUniforms =
          obj

      and [<AllowNullLiteral>] [<Import("DisplacementFilter","filters")>] DisplacementFilter(sprite: Sprite, ?scale: float) =
          interface Filter<DisplacementFilterUniforms>
          member __.scale with get(): Point = jsNative and set(v: Point): unit = jsNative
          member __.map with get(): Texture = jsNative and set(v: Texture): unit = jsNative

      and [<AllowNullLiteral>] [<Import("VoidFilter","filters")>] VoidFilter() =
          interface Filter<obj>
          member __.glShaderKey with get(): float = jsNative and set(v: float): unit = jsNative

      and [<AllowNullLiteral>] NoiseFilterUniforms =
          obj

      and [<AllowNullLiteral>] [<Import("NoiseFilter","filters")>] NoiseFilter(?noise: float, ?seed: float) =
          interface Filter<NoiseFilterUniforms>
          member __.noise with get(): float = jsNative and set(v: float): unit = jsNative
          member __.seed with get(): float = jsNative and set(v: float): unit = jsNative

  *)


  module loaders =
      type [<AllowNullLiteral>] LoaderOptions =
          abstract crossOrigin: U2<bool, string> option with get, set
          abstract loadType: float option with get, set
          abstract xhrType: string option with get, set
          abstract metaData: obj option with get, set

      and [<AllowNullLiteral>] ResourceDictionary =
          [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: string -> obj with get, set
  //          [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: string -> extras.Resource with get, set

      and [<AllowNullLiteral>] [<Import("Loader","PIXI.loaders")>] Loader(?baseUrl: string, ?concurrency: float) =
          inherit utils.EventEmitter()
          member __.Resource with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.async with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.base64 with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.baseUrl with get(): string = jsNative and set(v: string): unit = jsNative
          member __.progress with get(): float = jsNative and set(v: float): unit = jsNative
          member __.loading with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.defaultQueryString with get(): string = jsNative and set(v: string): unit = jsNative
          member __._beforeMiddleware with get(): ResizeArray<Function> = jsNative and set(v: ResizeArray<Function>): unit = jsNative
          member __._afterMiddleware with get(): ResizeArray<Function> = jsNative and set(v: ResizeArray<Function>): unit = jsNative
          member __._resourcesParsing with get(): ResizeArray<Resource> = jsNative and set(v: ResizeArray<Resource>): unit = jsNative
          member __._boundLoadResource with get():Resource->Function->unit = jsNative and set(v:Resource->Function->unit): unit = jsNative
          member __._queue with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.resources with get(): ResourceDictionary = jsNative and set(v: ResourceDictionary): unit = jsNative
          member __.onProgress with get(): MiniSignal = jsNative and set(v: MiniSignal): unit = jsNative
          member __.onError with get(): MiniSignal = jsNative and set(v: MiniSignal): unit = jsNative
          member __.onLoad with get(): MiniSignal = jsNative and set(v: MiniSignal): unit = jsNative
          member __.onStart with get(): MiniSignal = jsNative and set(v: MiniSignal): unit = jsNative
          member __.onComplete with get(): MiniSignal = jsNative and set(v: MiniSignal): unit = jsNative
          static member addPixiMiddleware(fn: Function): unit = jsNative
          member __.add([<ParamArray>] ``params``: obj[]): obj = jsNative
          member __.add(name: string, url: string, ?options: LoaderOptions, ?cb: Function): obj = jsNative
          member __.add(obj: U3<string, obj, ResizeArray<obj>>, ?options: LoaderOptions, ?cb: Function): obj = jsNative
          member __.pre(fn: Function): obj = jsNative
          member __.``use``(fn: Function): obj = jsNative
          member __.reset(): obj = jsNative
          member __.load(?cb: Function): obj = jsNative
          member __._prepareUrl(url: string): string = jsNative
          member __._loadResource(resource: Resource, dequeue: Function): unit = jsNative
          member __._onComplete(): unit = jsNative
          member __._onLoad(resource: Resource): unit = jsNative
          member __.destroy(): unit = jsNative
          [<Emit("$0.on('complete',$1...)")>] member __.on_complete(fn: loaders.Loader->obj->unit, ?context: obj): obj = jsNative
          [<Emit("$0.on('error',$1...)")>] member __.on_error(fn: Error->loaders.Loader->Resource->unit, ?context: obj): obj = jsNative
          member __.on(``event``: (* TODO StringEnum load | progress *) string, fn: loaders.Loader->Resource->Function->unit, ?context: obj): obj = jsNative
          [<Emit("$0.on('start',$1...)")>] member __.on_start(fn: loaders.Loader->unit, ?context: obj): obj = jsNative
          [<Emit("$0.once('complete',$1...)")>] member __.once_complete(fn: loaders.Loader->obj->unit, ?context: obj): obj = jsNative
          [<Emit("$0.once('error',$1...)")>] member __.once_error(fn: Error->loaders.Loader->Resource->unit, ?context: obj): obj = jsNative
          member __.once(``event``: (* TODO StringEnum load | progress *) string, fn: loaders.Loader->Resource->Function->unit, ?context: obj): obj = jsNative
          [<Emit("$0.once('start',$1...)")>] member __.once_start(fn: loaders.Loader->unit, ?context: obj): obj = jsNative
          member __.off(``event``: (* TODO StringEnum complete | error | load | progress | start |  *) string, ?fn: Function, ?context: obj): obj = jsNative

      and [<AllowNullLiteral>] TextureDictionary =
          [<Emit("$0[$1]{{=$2}}")>] abstract Item: index: string -> Texture with get, set

      and [<AllowNullLiteral>] [<Import("Resource","PIXI.loaders")>] Resource(name: string, url: U2<string, ResizeArray<string>>, ?options: LoaderOptions) =
          member __._flags with get(): float = jsNative and set(v: float): unit = jsNative
          member __.name with get(): string = jsNative and set(v: string): unit = jsNative
          member __.url with get(): string = jsNative and set(v: string): unit = jsNative
          member __.extension with get(): string = jsNative and set(v: string): unit = jsNative
          member __.data with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.crossOrigin with get(): U2<bool, string> = jsNative and set(v: U2<bool, string>): unit = jsNative
          member __.loadType with get(): float = jsNative and set(v: float): unit = jsNative
          member __.xhrType with get(): string = jsNative and set(v: string): unit = jsNative
          member __.metadata with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.error with get(): Error = jsNative and set(v: Error): unit = jsNative
          member __.xhr with get(): U2<XMLHttpRequest, obj> = jsNative and set(v: U2<XMLHttpRequest, obj>): unit = jsNative
          member __.children with get(): ResizeArray<Resource> = jsNative and set(v: ResizeArray<Resource>): unit = jsNative
          member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
          member __.progressChunk with get(): float = jsNative and set(v: float): unit = jsNative
          member __._dequeue with get(): Function = jsNative and set(v: Function): unit = jsNative
          member __._onLoadBinding with get(): Function = jsNative and set(v: Function): unit = jsNative
          member __._boundComplete with get(): Function = jsNative and set(v: Function): unit = jsNative
          member __._boundOnError with get(): Function = jsNative and set(v: Function): unit = jsNative
          member __._boundOnProgress with get(): Function = jsNative and set(v: Function): unit = jsNative
          member __._boundXhrOnError with get(): Function = jsNative and set(v: Function): unit = jsNative
          member __._boundXhrOnAbort with get(): Function = jsNative and set(v: Function): unit = jsNative
          member __._boundXhrOnLoad with get(): Function = jsNative and set(v: Function): unit = jsNative
          member __._boundXdrOnTimeout with get(): Function = jsNative and set(v: Function): unit = jsNative
          member __.onStart with get(): MiniSignal = jsNative and set(v: MiniSignal): unit = jsNative
          member __.onProgress with get(): MiniSignal = jsNative and set(v: MiniSignal): unit = jsNative
          member __.onComplete with get(): MiniSignal = jsNative and set(v: MiniSignal): unit = jsNative
          member __.onAfterMiddleware with get(): MiniSignal = jsNative and set(v: MiniSignal): unit = jsNative
          member __.isDataUrl with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.isComplete with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.isLoading with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.STATUS_FLAGS with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.TYPE with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.LOAD_TYPE with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.XHR_RESPONSE_TYPE with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.EMPTY_GIF with get(): string = jsNative and set(v: string): unit = jsNative
          member __.texture with get(): Texture = jsNative and set(v: Texture): unit = jsNative
          member __.spineAtlas with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.spineData with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.textures with get(): TextureDictionary option = jsNative and set(v: TextureDictionary option): unit = jsNative
          static member setExtensionLoadType(extname: string, loadType: float): unit = jsNative
          static member setExtensionXhrType(extname: string, xhrType: string): unit = jsNative
          member __.complete(): unit = jsNative
          member __.abort(?message: string): unit = jsNative
          member __.load(?cb: Function): unit = jsNative
          member __._hasFlag(flag: float): bool = jsNative
          member __._setFlag(flag: float, value: bool): unit = jsNative
          member __._loadElement(``type``: string): unit = jsNative
          member __._loadSourceElement(``type``: string): unit = jsNative
          member __._loadXhr(): unit = jsNative
          member __._loadXdr(): unit = jsNative
          member __._createSource(``type``: string, url: string, ?mime: string): HTMLSourceElement = jsNative
          member __._onError(?``event``: obj): unit = jsNative
          member __._onProgress(?``event``: obj): unit = jsNative
          member __._xhrOnError(): unit = jsNative
          member __._xhrOnAbort(): unit = jsNative
          member __._xdrOnTimeout(): unit = jsNative
          member __._xhrOnLoad(): unit = jsNative
          member __._determineCrossOrigin(url: string, loc: obj): string = jsNative
          member __._determineXhrType(): float = jsNative
          member __._determineLoadType(): float = jsNative
          member __._getExtension(): string = jsNative
          member __._getMimeXhrType(``type``: float): string = jsNative



  module mesh =
      type [<AllowNullLiteral>] [<Import("Mesh","PIXI.mesh")>] Mesh(texture: Texture, ?vertices: Float32Array, ?uvs: Float32Array, ?indices: Uint16Array, ?drawMode: float) =
          inherit Container()
          member __._texture with get(): Texture = jsNative and set(v: Texture): unit = jsNative
          member __.uvs with get(): Float32Array = jsNative and set(v: Float32Array): unit = jsNative
          member __.vertices with get(): Float32Array = jsNative and set(v: Float32Array): unit = jsNative
          member __.indices with get(): Uint16Array = jsNative and set(v: Uint16Array): unit = jsNative
          member __.dirty with get(): float = jsNative and set(v: float): unit = jsNative
          member __.indexDirty with get(): float = jsNative and set(v: float): unit = jsNative
          member __.dirtyVertex with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __._geometryVersion with get(): float = jsNative and set(v: float): unit = jsNative
          member __.blendMode with get(): float = jsNative and set(v: float): unit = jsNative
          member __.pluginName with get(): string = jsNative and set(v: string): unit = jsNative
          member __.canvasPadding with get(): float = jsNative and set(v: float): unit = jsNative
          member __.drawMode with get(): float = jsNative and set(v: float): unit = jsNative
          member __.texture with get(): Texture = jsNative and set(v: Texture): unit = jsNative
          member __.tintRgb with get(): Float32Array = jsNative and set(v: Float32Array): unit = jsNative
          member __._glDatas with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __._uvTransform with get(): extras.TextureTransform = jsNative and set(v: extras.TextureTransform): unit = jsNative
          member __.uploadUvTransform with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.tint with get(): float = jsNative and set(v: float): unit = jsNative
          member __.DRAW_MODES with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.multiplyUvs(): unit = jsNative
          member __.refresh(?forceUpdate: bool): unit = jsNative
          member __._refresh(): unit = jsNative
          member __._renderWebGL(renderer: WebGLRenderer): unit = jsNative
          member __._renderCanvas(renderer: CanvasRenderer): unit = jsNative
          member __._onTextureUpdate(): unit = jsNative
          member __._calculateBounds(): unit = jsNative
          member __.containsPoint(point: Point): bool = jsNative

      and [<AllowNullLiteral>] [<Import("CanvasMeshRenderer","PIXI.mesh")>] CanvasMeshRenderer(renderer: CanvasRenderer) =
          member __.renderer with get(): CanvasRenderer = jsNative and set(v: CanvasRenderer): unit = jsNative
          member __.render(mesh: Mesh): unit = jsNative
          member __._renderTriangleMesh(mesh: Mesh): unit = jsNative
          member __._renderTriangles(mesh: Mesh): unit = jsNative
          member __._renderDrawTriangle(mesh: Mesh, index0: float, index1: float, index2: float): unit = jsNative
          member __.renderMeshFlat(mesh: Mesh): unit = jsNative
          member __.destroy(): unit = jsNative

      and [<AllowNullLiteral>] [<Import("MeshRenderer","PIXI.mesh")>] MeshRenderer(renderer: WebGLRenderer) =
          inherit ObjectRenderer(renderer)
          member __.shader with get(): Shader = jsNative and set(v: Shader): unit = jsNative
          member __.render(mesh: Mesh): unit = jsNative

      and [<AllowNullLiteral>] [<Import("Plane","PIXI.mesh")>] Plane(texture: Texture, ?verticesX: float, ?verticesY: float) =
          inherit Mesh(texture)
          member __._ready with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.verticesX with get(): float = jsNative and set(v: float): unit = jsNative
          member __.verticesY with get(): float = jsNative and set(v: float): unit = jsNative
          member __.drawMode with get(): float = jsNative and set(v: float): unit = jsNative
          member __.refresh(): unit = jsNative
          member __._onTexureUpdate(): unit = jsNative

      and [<AllowNullLiteral>] [<Import("NineSlicePlane","PIXI.mesh")>] NineSlicePlane(texture: Texture, ?leftWidth: float, ?topHeight: float, ?rightWidth: float, ?bottomHeight: float) =
          inherit Plane(texture)
          member __.width with get(): float = jsNative and set(v: float): unit = jsNative
          member __.height with get(): float = jsNative and set(v: float): unit = jsNative
          member __.leftWidth with get(): float = jsNative and set(v: float): unit = jsNative
          member __.rightWidth with get(): float = jsNative and set(v: float): unit = jsNative
          member __.topHeight with get(): float = jsNative and set(v: float): unit = jsNative
          member __.bottomHeight with get(): float = jsNative and set(v: float): unit = jsNative
          member __._leftWidth with get(): float = jsNative and set(v: float): unit = jsNative
          member __._rightWidth with get(): float = jsNative and set(v: float): unit = jsNative
          member __._topHeight with get(): float = jsNative and set(v: float): unit = jsNative
          member __._bottomHeight with get(): float = jsNative and set(v: float): unit = jsNative
          member __._height with get(): float = jsNative and set(v: float): unit = jsNative
          member __._width with get(): float = jsNative and set(v: float): unit = jsNative
          member __._origHeight with get(): float = jsNative and set(v: float): unit = jsNative
          member __._origWidth with get(): float = jsNative and set(v: float): unit = jsNative
          member __._uvh with get(): float = jsNative and set(v: float): unit = jsNative
          member __._uvw with get(): float = jsNative and set(v: float): unit = jsNative
          member __.updateHorizontalVertices(): unit = jsNative
          member __.updateVerticalVertices(): unit = jsNative
          member __.drawSegment(context: U2<CanvasRenderingContext2D, WebGLRenderingContext>, textureSource: obj, w: float, h: float, x1: float, y1: float, x2: float, y2: float): unit = jsNative
          member __._refresh(): unit = jsNative

      and [<AllowNullLiteral>] [<Import("Rope","PIXI.mesh")>] Rope(texture: Texture, points: ResizeArray<Point>) =
          inherit Mesh(texture)
          member __.points with get(): ResizeArray<Point> = jsNative and set(v: ResizeArray<Point>): unit = jsNative
          member __.colors with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
          member __.autoUpdate with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __._refresh(): unit = jsNative
          member __.refreshVertices(): unit = jsNative



  module particles =
      type [<AllowNullLiteral>] ParticleContainerProperties =
          abstract scale: bool option with get, set
          abstract position: bool option with get, set
          abstract rotation: bool option with get, set
          abstract uvs: bool option with get, set
          abstract alpha: bool option with get, set

      and [<AllowNullLiteral>] [<Import("ParticleContainer","PIXI.particles")>] ParticleContainer(?size: float, ?properties: ParticleContainerProperties, ?batchSize: float) =
          inherit Container()
          member __._tint with get(): float = jsNative and set(v: float): unit = jsNative
          member __.tintRgb with get(): U2<float, ResizeArray<obj>> = jsNative and set(v: U2<float, ResizeArray<obj>>): unit = jsNative
          member __.tint with get(): float = jsNative and set(v: float): unit = jsNative
          member __._properties with get(): ResizeArray<bool> = jsNative and set(v: ResizeArray<bool>): unit = jsNative
          member __._maxSize with get(): float = jsNative and set(v: float): unit = jsNative
          member __._batchSize with get(): float = jsNative and set(v: float): unit = jsNative
          member __._glBuffers with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __._bufferToUpdate with get(): float = jsNative and set(v: float): unit = jsNative
          member __.interactiveChildren with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.blendMode with get(): float = jsNative and set(v: float): unit = jsNative
          member __.roundPixels with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.baseTexture with get(): BaseTexture = jsNative and set(v: BaseTexture): unit = jsNative
          member __.onChildrenChange with get(): float->unit = jsNative and set(v: float->unit): unit = jsNative
          member __.setProperties(properties: ParticleContainerProperties): unit = jsNative
          member __.destroy(?options: U2<DestroyOptions, bool>): unit = jsNative

      and [<AllowNullLiteral>] [<Import("ParticleBuffer","PIXI.particles")>] ParticleBuffer(gl: WebGLRenderingContext, properties: obj, dynamicPropertyFlags: ResizeArray<obj>, size: float) =
          member __.gl with get(): WebGLRenderingContext = jsNative and set(v: WebGLRenderingContext): unit = jsNative
          member __.vertSize with get(): float = jsNative and set(v: float): unit = jsNative
          member __.vertByteSize with get(): float = jsNative and set(v: float): unit = jsNative
          member __.size with get(): float = jsNative and set(v: float): unit = jsNative
          member __.dynamicProperties with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
          member __.staticProperties with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
          member __.staticStride with get(): float = jsNative and set(v: float): unit = jsNative
          member __.staticBuffer with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.staticData with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.dynamicStride with get(): float = jsNative and set(v: float): unit = jsNative
          member __.dynamicBuffer with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.dynamicData with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.destroy(): unit = jsNative

      and [<AllowNullLiteral>] ParticleRendererProperty =
          abstract attribute: float with get, set
          abstract size: float with get, set
          abstract uploadFunction: Func<ResizeArray<DisplayObject>, float, float, ResizeArray<float>, float, float, unit> with get, set
          abstract offset: float with get, set

      and [<AllowNullLiteral>] [<Import("ParticleRenderer","PIXI.particles")>] ParticleRenderer(renderer: WebGLRenderer) =
          inherit ObjectRenderer(renderer)
          member __.shader with get(): glCore.GLShader = jsNative and set(v: glCore.GLShader): unit = jsNative
          member __.indexBuffer with get(): WebGLBuffer = jsNative and set(v: WebGLBuffer): unit = jsNative
          member __.properties with get(): ResizeArray<ParticleRendererProperty> = jsNative and set(v: ResizeArray<ParticleRendererProperty>): unit = jsNative
          member __.tempMatrix with get(): Matrix = jsNative and set(v: Matrix): unit = jsNative
          member __.indices with get(): Uint16Array = jsNative and set(v: Uint16Array): unit = jsNative
          member __.start(): unit = jsNative
          member __.generateBuffers(container: ParticleContainer): ResizeArray<ParticleBuffer> = jsNative
          member __.uploadVertices(children: ResizeArray<DisplayObject>, startIndex: float, amount: float, array: ResizeArray<float>, stride: float, offset: float): unit = jsNative
          member __.uploadPosition(children: ResizeArray<DisplayObject>, startIndex: float, amount: float, array: ResizeArray<float>, stride: float, offset: float): unit = jsNative
          member __.uploadRotation(children: ResizeArray<DisplayObject>, startIndex: float, amount: float, array: ResizeArray<float>, stride: float, offset: float): unit = jsNative
          member __.uploadUvs(children: ResizeArray<DisplayObject>, startIndex: float, amount: float, array: ResizeArray<float>, stride: float, offset: float): unit = jsNative
          member __.uploadAlpha(children: ResizeArray<DisplayObject>, startIndex: float, amount: float, array: ResizeArray<float>, stride: float, offset: float): unit = jsNative
          member __.destroy(): unit = jsNative



  module prepare =
      type AddHook =
          Func<obj, ResizeArray<obj>, bool>

      and UploadHook<'UploadHookSource> =
          Func<'UploadHookSource, obj, bool>

      and [<AllowNullLiteral>] [<Import("BasePrepare","PIXI.prepare")>] BasePrepare<'UploadHookSource>(renderer: SystemRenderer) =
          member __.limiter with get(): U2<CountLimiter, TimeLimiter> = jsNative and set(v: U2<CountLimiter, TimeLimiter>): unit = jsNative
          member __.renderer with get(): SystemRenderer = jsNative and set(v: SystemRenderer): unit = jsNative
          member __.uploadHookHelper with get(): 'UploadHookSource = jsNative and set(v: 'UploadHookSource): unit = jsNative
          member __.queue with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
          member __.addHooks with get(): ResizeArray<AddHook> = jsNative and set(v: ResizeArray<AddHook>): unit = jsNative
          member __.uploadHooks with get(): ResizeArray<UploadHook<'UploadHookSource>> = jsNative and set(v: ResizeArray<UploadHook<'UploadHookSource>>): unit = jsNative
          member __.completes with get(): ResizeArray<Function> = jsNative and set(v: ResizeArray<Function>): unit = jsNative
          member __.ticking with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.delayedTick with get(): unit->unit = jsNative and set(v: unit->unit): unit = jsNative
          member __.upload(item: obj, ?``done``: unit->unit): unit = jsNative
          member __.tick(): unit = jsNative
          member __.prepareItems(): unit = jsNative
          member __.registerFindHook(addHook: AddHook): obj = jsNative
          member __.registerUploadHook(uploadHook: UploadHook<'UploadHookSource>): obj = jsNative
          member __.findMultipleBaseTextures(item: DisplayObject, queue: ResizeArray<obj>): bool = jsNative
          member __.findBaseTexture(item: DisplayObject, queue: ResizeArray<obj>): bool = jsNative
          member __.findTexture(item: DisplayObject, queue: ResizeArray<obj>): bool = jsNative
          member __.add(item: obj): obj = jsNative
          member __.destroy(): unit = jsNative

      and [<AllowNullLiteral>] [<Import("CanvasPrepare","PIXI.prepare")>] CanvasPrepare(renderer: CanvasRenderer) =
          inherit BasePrepare<CanvasPrepare>(renderer)
          member __.canvas with get(): HTMLCanvasElement = jsNative and set(v: HTMLCanvasElement): unit = jsNative
          member __.ctx with get(): CanvasRenderingContext2D = jsNative and set(v: CanvasRenderingContext2D): unit = jsNative

      and [<AllowNullLiteral>] [<Import("WebGLPrepare","PIXI.prepare")>] WebGLPrepare(renderer: WebGLRenderer) =
          inherit BasePrepare<WebGLRenderer>(renderer)


      and [<AllowNullLiteral>] [<Import("CountLimiter","PIXI.prepare")>] CountLimiter(maxItemsPerFrame: float) =
          member __.maxItemsPerFrame with get(): float = jsNative and set(v: float): unit = jsNative
          member __.itemsLeft with get(): float = jsNative and set(v: float): unit = jsNative
          member __.beginFrame(): unit = jsNative
          member __.allowedToUpload(): bool = jsNative

      and [<AllowNullLiteral>] [<Import("TimeLimiter","PIXI.prepare")>] TimeLimiter(maxMilliseconds: float) =
          member __.maxMilliseconds with get(): float = jsNative and set(v: float): unit = jsNative
          member __.frameStart with get(): float = jsNative and set(v: float): unit = jsNative
          member __.beginFrame(): unit = jsNative
          member __.allowedToUpload(): bool = jsNative



  module glCore =
      type [<AllowNullLiteral>] ContextOptions =
          abstract alpha: bool option with get, set
          abstract depth: bool option with get, set
          abstract stencil: bool option with get, set
          abstract antialias: bool option with get, set
          abstract premultipliedAlpha: bool option with get, set
          abstract preserveDrawingBuffer: bool option with get, set
          abstract failIfMajorPerformanceCaveat: bool option with get, set

      and [<AllowNullLiteral>] [<Import("GLBuffer","PIXI.glCore")>] GLBuffer(gl: WebGLRenderingContext, ``type``: float, data: U3<ArrayBuffer, ArrayBufferView, obj>, drawType: float) =
          member __._updateID with get(): float option = jsNative and set(v: float option): unit = jsNative
          member __.gl with get(): WebGLRenderingContext = jsNative and set(v: WebGLRenderingContext): unit = jsNative
          member __.buffer with get(): WebGLBuffer = jsNative and set(v: WebGLBuffer): unit = jsNative
          member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
          member __.drawType with get(): float = jsNative and set(v: float): unit = jsNative
          member __.data with get(): U3<ArrayBuffer, ArrayBufferView, obj> = jsNative and set(v: U3<ArrayBuffer, ArrayBufferView, obj>): unit = jsNative
          member __.upload(?data: U3<ArrayBuffer, ArrayBufferView, obj>, ?offset: float, ?dontBind: bool): unit = jsNative
          member __.bind(): unit = jsNative
          static member createVertexBuffer(gl: WebGLRenderingContext, data: U3<ArrayBuffer, ArrayBufferView, obj>, drawType: float): GLBuffer = jsNative
          static member createIndexBuffer(gl: WebGLRenderingContext, data: U3<ArrayBuffer, ArrayBufferView, obj>, drawType: float): GLBuffer = jsNative
          static member create(gl: WebGLRenderingContext, ``type``: float, data: U3<ArrayBuffer, ArrayBufferView, obj>, drawType: float): GLBuffer = jsNative
          member __.destroy(): unit = jsNative

      and [<AllowNullLiteral>] [<Import("GLFramebuffer","PIXI.glCore")>] GLFramebuffer(gl: WebGLRenderingContext, width: float, height: float) =
          member __.gl with get(): WebGLRenderingContext = jsNative and set(v: WebGLRenderingContext): unit = jsNative
          member __.frameBuffer with get(): WebGLFramebuffer = jsNative and set(v: WebGLFramebuffer): unit = jsNative
          member __.stencil with get(): WebGLRenderbuffer = jsNative and set(v: WebGLRenderbuffer): unit = jsNative
          member __.texture with get(): GLTexture = jsNative and set(v: GLTexture): unit = jsNative
          member __.width with get(): float = jsNative and set(v: float): unit = jsNative
          member __.height with get(): float = jsNative and set(v: float): unit = jsNative
          member __.enableTexture(texture: GLTexture): unit = jsNative
          member __.enableStencil(): unit = jsNative
          member __.clear(r: float, g: float, b: float, a: float): unit = jsNative
          member __.bind(): unit = jsNative
          member __.unbind(): unit = jsNative
          member __.resize(width: float, height: float): unit = jsNative
          member __.destroy(): unit = jsNative
          static member createRGBA(gl: WebGLRenderingContext, width: float, height: float, data: U3<ArrayBuffer, ArrayBufferView, obj>): GLFramebuffer = jsNative
          static member createFloat32(gl: WebGLRenderingContext, width: float, height: float, data: U3<ArrayBuffer, ArrayBufferView, obj>): GLFramebuffer = jsNative

      and [<AllowNullLiteral>] [<Import("GLShader","PIXI.glCore")>] GLShader(gl: WebGLRenderingContext, vertexSrc: U2<string, ResizeArray<string>>, fragmentSrc: U2<string, ResizeArray<string>>, ?precision: string, ?attributeLocations: obj) =
          member __.gl with get(): WebGLRenderingContext = jsNative and set(v: WebGLRenderingContext): unit = jsNative
          member __.program with get(): U2<WebGLProgram, obj> option = jsNative and set(v: U2<WebGLProgram, obj> option): unit = jsNative
          member __.uniformData with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.uniforms with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.attributes with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.bind(): unit = jsNative
          member __.destroy(): unit = jsNative

      and [<AllowNullLiteral>] [<Import("GLTexture","PIXI.glCore")>] GLTexture(gl: WebGLRenderingContext, ?width: float, ?height: float, ?format: float, ?``type``: float) =
          member __.gl with get(): WebGLRenderingContext = jsNative and set(v: WebGLRenderingContext): unit = jsNative
          member __.texture with get(): WebGLTexture = jsNative and set(v: WebGLTexture): unit = jsNative
          member __.mipmap with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.premultiplyAlpha with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.width with get(): float = jsNative and set(v: float): unit = jsNative
          member __.height with get(): float = jsNative and set(v: float): unit = jsNative
          member __.format with get(): float = jsNative and set(v: float): unit = jsNative
          member __.``type`` with get(): float = jsNative and set(v: float): unit = jsNative
          member __.upload(source: U4<HTMLImageElement, ImageData, HTMLVideoElement, HTMLCanvasElement>): unit = jsNative
          member __.uploadData(data: U2<ArrayBuffer, ArrayBufferView>, width: float, height: float): unit = jsNative
          member __.bind(?location: float): unit = jsNative
          member __.unbind(): unit = jsNative
          member __.minFilter(linear: bool): unit = jsNative
          member __.magFilter(linear: bool): unit = jsNative
          member __.enableMipmap(): unit = jsNative
          member __.enableLinearScaling(): unit = jsNative
          member __.enableNearestScaling(): unit = jsNative
          member __.enableWrapClamp(): unit = jsNative
          member __.enableWrapRepeat(): unit = jsNative
          member __.enableWrapMirrorRepeat(): unit = jsNative
          member __.destroy(): unit = jsNative
          static member fromSource(gl: WebGLRenderingContext, source: U4<HTMLImageElement, ImageData, HTMLVideoElement, HTMLCanvasElement>, ?premultipleAlpha: bool): GLTexture = jsNative
          static member fromData(gl: WebGLRenderingContext, data: ResizeArray<float>, width: float, height: float): GLTexture = jsNative

      and [<AllowNullLiteral>] Attrib =
          abstract attribute: obj with get, set
          abstract normalized: bool with get, set
          abstract stride: float with get, set
          abstract start: float with get, set
          abstract buffer: ArrayBuffer with get, set

      and [<AllowNullLiteral>] WebGLRenderingContextAttribute =
          abstract buffer: WebGLBuffer with get, set
          abstract attribute: obj with get, set
          abstract ``type``: float with get, set
          abstract normalized: bool with get, set
          abstract stride: float with get, set
          abstract start: float with get, set

      and [<AllowNullLiteral>] AttribState =
          abstract tempAttribState: ResizeArray<Attrib> with get, set
          abstract attribState: ResizeArray<Attrib> with get, set

      and [<AllowNullLiteral>] [<Import("VertexArrayObject","PIXI.glCore")>] VertexArrayObject(gl: WebGLRenderingContext, ?state: WebGLState) =
          member __.FORCE_NATIVE with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.nativeVaoExtension with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.nativeState with get(): AttribState = jsNative and set(v: AttribState): unit = jsNative
          member __.nativeVao with get(): VertexArrayObject = jsNative and set(v: VertexArrayObject): unit = jsNative
          member __.gl with get(): WebGLRenderingContext = jsNative and set(v: WebGLRenderingContext): unit = jsNative
          member __.attributes with get(): ResizeArray<Attrib> = jsNative and set(v: ResizeArray<Attrib>): unit = jsNative
          member __.indexBuffer with get(): GLBuffer = jsNative and set(v: GLBuffer): unit = jsNative
          member __.dirty with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.bind(): VertexArrayObject = jsNative
          member __.unbind(): VertexArrayObject = jsNative
          member __.activate(): VertexArrayObject = jsNative
          member __.addAttribute(buffer: GLBuffer, attribute: Attrib, ``type``: float, normalized: bool, stride: float, start: float): VertexArrayObject = jsNative
          member __.addIndex(buffer: GLBuffer, ?options: obj): VertexArrayObject = jsNative
          member __.clear(): VertexArrayObject = jsNative
          member __.draw(``type``: float, size: float, start: float): VertexArrayObject = jsNative
          member __.destroy(): unit = jsNative

      type [<Import("glCore","PIXI")>] Globals =
          static member createContext(view: HTMLCanvasElement, ?options: ContextOptions): WebGLRenderingContext = jsNative
          static member setVertexAttribArrays(gl: WebGLRenderingContext, attribs: ResizeArray<Attrib>, ?state: WebGLState): U2<WebGLRenderingContext, CanvasRenderingContext2D> = jsNative





  module core =
      type SpriteBatch =
          ParticleContainer

      and AssetLoader =
          loaders.Loader

      and Stage =
          Container

      and DisplayObjectContainer =
          Container

      and Strip =
          mesh.Mesh

      and Rope =
          mesh.Rope

      and ParticleContainer =
          particles.ParticleContainer

      and MovieClip =
          extras.AnimatedSprite

      and TilingSprite =
          extras.TilingSprite

      and BaseTextureCache =
          obj

      and BitmapText =
          extras.BitmapText

      and math =
          obj

      and AbstractFilter<'U> =
          Filter<'U>

      and TransformManual =
          TransformBase

      and TARGET_FPMS =
          float

      and FILTER_RESOLUTION =
          float

      and RESOLUTION =
          float

      and MIPMAP_TEXTURES =
          obj

      and SPRITE_BATCH_SIZE =
          float

      and SPRITE_MAX_TEXTURES =
          float

      and RETINA_PREFIX =
          U2<Regex, string>

      and DEFAULT_RENDER_OPTIONS =
          float

      and PRECISION =
          string

  module settings =
      type PRECISION =
          float

  module pixi =
      type [<Import("*","PIXI")>] Globals =
          static member gl with get(): obj = jsNative and set(v: obj): unit = jsNative


