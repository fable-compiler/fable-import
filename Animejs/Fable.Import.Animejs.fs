namespace Fable.Import.Animejs

(*
  bindings based on typescript definitions located here: https://github.com/kohashi/types-npm-animejs/blob/master/index.d.ts
*)
open System
open Fable.Core
open Fable.Import.Browser
open Fable.Import.JS

type target =
    obj

and [<AllowNullLiteral>] AnimeStatic =
    abstract version: string with get, set
    abstract speed: float with get, set
    abstract running: ResizeArray<AnimInstance> with get, set
    abstract easings: Easings with get, set
    [<Emit("$0($1...)")>] abstract Invoke: ?``params``: AnimInput -> AnimInstance
    abstract remove: targets: target -> unit
    abstract getValue: targets: target * propName: string -> U2<string, float>
    abstract path: path: obj * ?percent: float-> (string -> FunctionBasedValues)
    abstract setDashoffset: el: SVGPathElement -> float
    abstract bezier: x1: float * x2: float * y1: float * y2: float -> Func<obj, float>
    abstract timeline: ?``params``: AnimInput -> TimelineInstance
    abstract random: min: float * max: float -> float

and [<AllowNullLiteral>] AnimInput =
    inherit Targets
    inherit AnimatableProperties
    inherit PropertyParameters
    inherit AnimationParameters
    inherit animationCallbacks

and [<AllowNullLiteral>] Targets =
    abstract targets: target option with get, set

and [<AllowNullLiteral>] AnimatableProperties =
    abstract translateX: animatableProperty option with get, set
    abstract translateY: animatableProperty option with get, set
    abstract rotate: animatableProperty option with get, set
    abstract scale: animatableProperty option with get, set
    abstract opacity: animatableProperty option with get, set
    abstract color: animatableProperty option with get, set
    abstract backgroundColor: animatableProperty option with get, set
    abstract left: animatableProperty option with get, set
    abstract top: animatableProperty option with get, set
    abstract border: animatableProperty option with get, set
    abstract points: animatableProperty option with get, set
    abstract strokeDashoffset: animatableProperty option with get, set
    abstract value: animatableProperty option with get, set
    abstract round: float option with get, set
    [<Emit("$0[$1]{{=$2}}")>] abstract Item: prop: string -> obj with get, set

and propertyValue =
    U2<float, string>

and FunctionBasedValues =
    Element -> float -> float -> propertyValue

and FromToValues =
    U2<propertyValue, FunctionBasedValues> * U2<propertyValue, FunctionBasedValues>

and propertyValues =
    U3<propertyValue, FromToValues, FunctionBasedValues>

and [<AllowNullLiteral>] PropertyParameters =
    abstract value: propertyValues with get, set
    abstract duration: U2<FunctionBasedValues, float> with get, set
    abstract delay: U2<FunctionBasedValues, float> option with get, set
    abstract elasticity: U2<FunctionBasedValues, float> option with get, set
    abstract easing: U2<Easing, Function> option with get, set
    abstract round: U3<float, bool, Function> option with get, set

and Keyframes =
    ResizeArray<PropertyParameters>

and animatableProperty =
    U3<propertyValues, PropertyParameters, Keyframes>

and [<AllowNullLiteral>] AnimationParameters =
    abstract loop: U2<bool, float> option with get, set
    abstract direction: Direction option with get, set
    abstract autoplay: bool option with get, set

and [<AllowNullLiteral>] AnimInstance =
    inherit animationCallbacks
    inherit AnimationParameters
    inherit instanceParams
    abstract children: ResizeArray<AnimInstance> with get, set
    abstract animatables: ResizeArray<FunctionBasedValues> with get, set
    abstract animations: ResizeArray<obj> with get, set
    abstract currentTime: float with get, set
    abstract progress: float with get, set
    abstract paused: bool with get, set
    abstract began: bool with get, set
    abstract completed: bool with get, set
    abstract reversed: bool with get, set
    abstract remaining: bool with get, set
    abstract reset: unit -> obj
    abstract tick: t: float -> obj
    abstract seek: t: float -> obj
    abstract pause: unit -> obj
    abstract play: unit -> obj
    abstract reverse: unit -> obj
    abstract restart: unit -> obj

and [<AllowNullLiteral>] instanceParams =
    abstract offset: FunctionBasedValues with get, set
    abstract duration: FunctionBasedValues with get, set
    abstract delay: FunctionBasedValues with get, set

and animCallback =
    AnimInstance -> unit

and [<AllowNullLiteral>] animationCallbacks =
    abstract update: animCallback with get, set
    abstract ``begin``: animCallback with get, set
    abstract complete: animCallback with get, set
    abstract run: animCallback with get, set

and [<AllowNullLiteral>] TimelineInstance =
    inherit animationCallbacks
    inherit AnimInstance
    abstract add: ``params``: AnimInput -> obj

and [<AllowNullLiteral>] Easings =
    abstract easeInElastic: a: obj * b: obj -> obj
    abstract easeInOutElastic: b: obj * c: obj -> obj
    abstract easeOutElastic: b: obj * c: obj -> obj
    abstract easeInBack: h: obj -> obj
    abstract easeInCirc: h: obj -> obj
    abstract easeInCubic: h: obj -> obj
    abstract easeInExpo: h: obj -> obj
    abstract easeInOutBack: h: obj -> obj
    abstract easeInOutCirc: h: obj -> obj
    abstract easeInOutCubic: h: obj -> obj
    abstract easeInOutExpo: h: obj -> obj
    abstract easeInOutQuad: h: obj -> obj
    abstract easeInOutQuart: h: obj -> obj
    abstract easeInOutQuint: h: obj -> obj
    abstract easeInOutSine: h: obj -> obj
    abstract easeInQuad: h: obj -> obj
    abstract easeInQuart: h: obj -> obj
    abstract easeInQuint: h: obj -> obj
    abstract easeInSine: h: obj -> obj
    abstract easeOutBack: h: obj -> obj
    abstract easeOutCirc: h: obj -> obj
    abstract easeOutCubic: h: obj -> obj
    abstract easeOutExpo: h: obj -> obj
    abstract easeOutQuad: h: obj -> obj
    abstract easeOutQuart: h: obj -> obj
    abstract easeOutQuint: h: obj -> obj
    abstract easeOutSine: h: obj -> obj

and [<StringEnum>]Easing =
    | EaseInSine
    | EaseOutSine
    | EaseInOutSine
    | EaseInCirc
    | EaseOutCirc
    | EaseInOutCirc
    | EaseInElastic
    | EaseOutElastic
    | EaseInOutElastic
    | EaseInBack
    | EaseOutBack
    | EaseInOutBack
    | EaseInBounce
    | EaseOutBounce
    | EaseInOutBounce
    | EaseInQuad
    | EaseOutQuad
    | EaseInOutQuad
    | EaseInCubic
    | EaseOutCubic
    | EaseInOutCubic
    | EaseInQuart
    | EaseOutQuart
    | EaseInOutQuart
    | EaseInQuint
    | EaseOutQuint
    | EaseInOutQuint
    | EaseInExpo
    | EaseOutExpo
    | EaseInOutExpo
    | Linear

and [<StringEnum>] Direction =
    | Normal
    | Reverse
    | Alternate

type [<Erase>]Globals =
    [<Global>] static member anime with get(): AnimeStatic = jsNative and set(v: AnimeStatic): unit = jsNative
