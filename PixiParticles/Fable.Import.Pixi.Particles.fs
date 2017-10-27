namespace rec Fable.Import.Pixi.Particles 

open System
open Fable.Core
open Fable.Import.Pixi

module PIXI =
  module particles =
      type TexSrc =
          U2<string, PIXI.Texture>

      and [<AllowNullLiteral>] ParticleConstructor =
          [<Emit("new $0($1...)")>] abstract Create: emitter: Emitter -> Particle

      and [<AllowNullLiteral>] AnimatedParticleArt =
          abstract textures: ResizeArray<U2<TexSrc, obj>> with get, set
          abstract framerate: U2<float, obj> with get, set
          abstract loop: bool option with get, set

      and [<AllowNullLiteral>] ParsedAnimatedParticleArt =
          abstract textures: ResizeArray<PIXI.Texture> with get, set
          abstract framerate: float with get, set
          abstract elapsed: float with get, set
          abstract loop: bool with get, set

      and [<AllowNullLiteral>] [<Import("AnimatedParticle","PIXI/particles")>] AnimatedParticle(emitter: Emitter) =
          inherit Particle(emitter)
          member __.textures with get(): ResizeArray<PIXI.Texture> = jsNative and set(v: ResizeArray<PIXI.Texture>): unit = jsNative
          member __.duration with get(): float = jsNative and set(v: float): unit = jsNative
          member __.framerate with get(): float = jsNative and set(v: float): unit = jsNative
          member __.elapsed with get(): float = jsNative and set(v: float): unit = jsNative
          member __.loop with get(): bool = jsNative and set(v: bool): unit = jsNative
          static member parseArt(art: ResizeArray<AnimatedParticleArt>): ResizeArray<ParsedAnimatedParticleArt> = jsNative
          member __.applyArt(art: ParsedAnimatedParticleArt): unit = jsNative

      and [<AllowNullLiteral>] [<Import("Emitter","PIXI/particles")>] Emitter(particleParent: PIXI.Container, particleImages: obj, config: obj) =
          member __._particleConstructor with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __._frequency with get(): float = jsNative and set(v: float): unit = jsNative
          member __._spawnFunc with get(): Func<Particle, float, float, float, unit> = jsNative and set(v: Func<Particle, float, float, float, unit>): unit = jsNative
          member __._prevEmitterPos with get(): PIXI.Point = jsNative and set(v: PIXI.Point): unit = jsNative
          member __._prevPosIsValid with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __._posChanged with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __._parentIsPC with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __._parent with get(): PIXI.Container = jsNative and set(v: PIXI.Container): unit = jsNative
          member __._emit with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __._spawnTimer with get(): float = jsNative and set(v: float): unit = jsNative
          member __._emitterLife with get(): float = jsNative and set(v: float): unit = jsNative
          member __._activeParticlesFirst with get(): Particle = jsNative and set(v: Particle): unit = jsNative
          member __._activeParticlesLast with get(): Particle = jsNative and set(v: Particle): unit = jsNative
          member __._poolFirst with get(): Particle = jsNative and set(v: Particle): unit = jsNative
          member __._origConfig with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __._origArt with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __._autoUpdate with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.particleImages with get(): ResizeArray<obj> = jsNative and set(v: ResizeArray<obj>): unit = jsNative
          member __.startAlpha with get(): float = jsNative and set(v: float): unit = jsNative
          member __.endAlpha with get(): float = jsNative and set(v: float): unit = jsNative
          member __.startSpeed with get(): float = jsNative and set(v: float): unit = jsNative
          member __.endSpeed with get(): float = jsNative and set(v: float): unit = jsNative
          member __.minimumSpeedMultiplier with get(): float = jsNative and set(v: float): unit = jsNative
          member __.acceleration with get(): PIXI.Point = jsNative and set(v: PIXI.Point): unit = jsNative
          member __.maxSpeed with get(): float = jsNative and set(v: float): unit = jsNative
          member __.startScale with get(): float = jsNative and set(v: float): unit = jsNative
          member __.endScale with get(): float = jsNative and set(v: float): unit = jsNative
          member __.minimumScaleMultiplier with get(): float = jsNative and set(v: float): unit = jsNative
          member __.startColor with get(): float * float * float = jsNative and set(v: float * float * float): unit = jsNative
          member __.endColor with get(): float * float * float = jsNative and set(v: float * float * float): unit = jsNative
          member __.minLifetime with get(): float = jsNative and set(v: float): unit = jsNative
          member __.maxLifetime with get(): float = jsNative and set(v: float): unit = jsNative
          member __.minStartRotation with get(): float = jsNative and set(v: float): unit = jsNative
          member __.maxStartRotation with get(): float = jsNative and set(v: float): unit = jsNative
          member __.noRotation with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.minRotationSpeed with get(): float = jsNative and set(v: float): unit = jsNative
          member __.maxRotationSpeed with get(): float = jsNative and set(v: float): unit = jsNative
          member __.particleBlendMode with get(): float = jsNative and set(v: float): unit = jsNative
          member __.customEase with get(): Func<float, float> = jsNative and set(v: Func<float, float>): unit = jsNative
          member __.extraData with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.maxParticles with get(): float = jsNative and set(v: float): unit = jsNative
          member __.emitterLifetime with get(): float = jsNative and set(v: float): unit = jsNative
          member __.spawnPos with get(): PIXI.Point = jsNative and set(v: PIXI.Point): unit = jsNative
          member __.spawnType with get(): (* TODO StringEnum point | rectangle | circle | burst | ring *) string = jsNative and set(v: (* TODO StringEnum point | rectangle | circle | burst | ring *) string): unit = jsNative
          member __.spawnRect with get(): PIXI.Rectangle = jsNative and set(v: PIXI.Rectangle): unit = jsNative
          member __.spawnCircle with get(): PIXI.Circle = jsNative and set(v: PIXI.Circle): unit = jsNative
          member __.particlesPerWave with get(): float = jsNative and set(v: float): unit = jsNative
          member __.particleSpacing with get(): float = jsNative and set(v: float): unit = jsNative
          member __.angleStart with get(): float = jsNative and set(v: float): unit = jsNative
          member __.rotation with get(): float = jsNative and set(v: float): unit = jsNative
          member __.ownerPos with get(): PIXI.Point = jsNative and set(v: PIXI.Point): unit = jsNative
          member __.addAtBack with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.particleCount with get(): float = jsNative and set(v: float): unit = jsNative
          member __.frequency with get(): float = jsNative and set(v: float): unit = jsNative
          member __.particleConstructor with get(): ParticleConstructor = jsNative and set(v: ParticleConstructor): unit = jsNative
          member __.parent with get(): PIXI.Container = jsNative and set(v: PIXI.Container): unit = jsNative
          member __.emit with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.autoUpdate with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __.recycle(p: Particle): unit = jsNative
          member __._spawnPoint(p: Particle, emitPosX: float, emitPosY: float, i: float): unit = jsNative
          member __._spawnRect(p: Particle, emitPosX: float, emitPosY: float, i: float): unit = jsNative
          member __._spawnCircle(p: Particle, emitPosX: float, emitPosY: float, i: float): unit = jsNative
          member __._spawnRing(p: Particle, emitPosX: float, emitPosY: float, i: float): unit = jsNative
          member __._spawnBurst(p: Particle, emitPosX: float, emitPosY: float, i: float): unit = jsNative
          member __.init(art: obj, config: obj): unit = jsNative
          member __.rotate(newRot: float): unit = jsNative
          member __.updateSpawnPos(x: float, y: float): unit = jsNative
          member __.updateOwnerPos(x: float, y: float): unit = jsNative
          member __.resetPositionTracking(): unit = jsNative
          member __.update(delta: float): unit = jsNative
          member __.cleanup(): unit = jsNative
          member __.destroy(): unit = jsNative

      and [<AllowNullLiteral>] [<Import("Particle","PIXI/particles")>] Particle(emitter: Emitter) =
          inherit PIXI.Sprite()
          member __._sR with get(): float = jsNative and set(v: float): unit = jsNative
          member __._sG with get(): float = jsNative and set(v: float): unit = jsNative
          member __._sB with get(): float = jsNative and set(v: float): unit = jsNative
          member __._eR with get(): float = jsNative and set(v: float): unit = jsNative
          member __._eG with get(): float = jsNative and set(v: float): unit = jsNative
          member __._eB with get(): float = jsNative and set(v: float): unit = jsNative
          member __._doAlpha with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __._doScale with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __._doSpeed with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __._doAcceleration with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __._doColor with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __._doNormalMovement with get(): bool = jsNative and set(v: bool): unit = jsNative
          member __._oneOverLife with get(): float = jsNative and set(v: float): unit = jsNative
          member __.next with get(): Particle = jsNative and set(v: Particle): unit = jsNative
          member __.prev with get(): Particle = jsNative and set(v: Particle): unit = jsNative
          member __.emitter with get(): Emitter = jsNative and set(v: Emitter): unit = jsNative
          member __.velocity with get(): PIXI.Point = jsNative and set(v: PIXI.Point): unit = jsNative
          member __.maxLife with get(): float = jsNative and set(v: float): unit = jsNative
          member __.age with get(): float = jsNative and set(v: float): unit = jsNative
          member __.ease with get(): Func<float, float> = jsNative and set(v: Func<float, float>): unit = jsNative
          member __.extraData with get(): obj = jsNative and set(v: obj): unit = jsNative
          member __.startAlpha with get(): float = jsNative and set(v: float): unit = jsNative
          member __.endAlpha with get(): float = jsNative and set(v: float): unit = jsNative
          member __.startSpeed with get(): float = jsNative and set(v: float): unit = jsNative
          member __.endSpeed with get(): float = jsNative and set(v: float): unit = jsNative
          member __.acceleration with get(): PIXI.Point = jsNative and set(v: PIXI.Point): unit = jsNative
          member __.maxSpeed with get(): float = jsNative and set(v: float): unit = jsNative
          member __.startScale with get(): float = jsNative and set(v: float): unit = jsNative
          member __.endScale with get(): float = jsNative and set(v: float): unit = jsNative
          member __.startColor with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
          member __.endColor with get(): ResizeArray<float> = jsNative and set(v: ResizeArray<float>): unit = jsNative
          static member parseArt(art: obj): obj = jsNative
          static member parseData(data: obj): obj = jsNative
          member __.Particle_init(): unit = jsNative
          member __.Particle_update(delta: float): float = jsNative
          member __.init(): unit = jsNative
          member __.applyArt(art: obj): unit = jsNative
          member __.update(delta: float): float = jsNative
          member __.kill(): unit = jsNative
          member __.destroy(): unit = jsNative

      and [<AllowNullLiteral>] EaseSegment =
          abstract cp: float with get, set
          abstract s: float with get, set
          abstract e: float with get, set

      and [<AllowNullLiteral>] [<Import("ParticleUtils","PIXI/particles")>] ParticleUtils() =
          member __.verbose with get(): bool = jsNative and set(v: bool): unit = jsNative
          static member rotatePoint(angle: float, p: PIXI.Point): unit = jsNative
          static member combineRGBComponents(r: float, g: float, b: float): float = jsNative
          static member normalize(p: PIXI.Point): unit = jsNative
          static member scaleBy(p: PIXI.Point, value: float): unit = jsNative
          static member length(p: PIXI.Point): float = jsNative
          static member hexToRGB(color: string, ?output: float * float * float): float * float * float = jsNative
          static member generateEase(segments: ResizeArray<EaseSegment>): Func<float, float> = jsNative
          static member getBlendMode(name: string): float = jsNative

      and [<AllowNullLiteral>] [<Import("PathParticle","PIXI/particles")>] PathParticle(emitter:Emitter) =
          inherit Particle(emitter)
          member __.path with get(): Func<float, float> = jsNative and set(v: Func<float, float>): unit = jsNative
          member __.initialRotation with get(): float = jsNative and set(v: float): unit = jsNative
          member __.initialPosition with get(): PIXI.Point = jsNative and set(v: PIXI.Point): unit = jsNative
          member __.movement with get(): float = jsNative and set(v: float): unit = jsNative
          static member parseArt(art: ResizeArray<TexSrc>): ResizeArray<PIXI.Texture> = jsNative
          static member parseData(data: obj): obj = jsNative


