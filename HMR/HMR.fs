namespace Fable.Import

module HMR =

    open Fable.Core
    open Fable.Import

    [<StringEnum>]
    type Status =
        /// The process is waiting for a call to check (see below)
        | [<CompiledName("idle")>] Idle
        /// The process is checking for updates
        | [<CompiledName("check")>] Check
        /// The process is getting ready for the update (e.g. downloading the updated module)
        | [<CompiledName("prepare")>] Prepare
        /// The update is prepared and available
        | [<CompiledName("ready")>] Ready
        /// The process is calling the dispose handlers on the modules that will be replaced
        | [<CompiledName("dispose")>] Dispose
        /// The process is calling the accept handlers and re-executing self-accepted modules
        | [<CompiledName("apply")>] Apply
        /// An update was aborted, but the system is still in it's previous state
        | [<CompiledName("abort")>] Abort
        /// An update has thrown an exception and the system's state has been compromised
        | [<CompiledName("fail")>] Fail

    type ApplyOptions =
        /// Ignore changes made to unaccepted modules.
        abstract ignoreUnaccepted : bool option with get, set
        /// Ignore changes made to declined modules.
        abstract ignoreDeclined : bool option with get, set
        /// Ignore errors throw in accept handlers, error handlers and while reevaluating module.
        abstract ignoreErrored : bool option with get, set
        /// Notifier for declined modules
        abstract onDeclined : (obj -> unit) option with get, set
        /// Notifier for unaccepted modules
        abstract onUnaccepted : (obj -> unit) option with get, set
        /// Notifier for accepted modules
        abstract onAccepted : (obj -> unit) option with get, set
        /// Notifier for disposed modules
        abstract onDisposed : (obj -> unit) option with get, set
        /// Notifier for errors
        abstract onErrored : (obj -> unit) option with get, set


    [<AllowNullLiteral>]
    type IHot =

        /// **Description**
        /// Retrieve the current status of the hot module replacement process.
        /// **Parameters**
        ///
        ///
        /// **Output Type**
        ///   * `Status`
        ///
        /// **Exceptions**
        ///
        abstract status: unit -> Status

        /// **Description**
        /// Accept updates for the given dependencies and fire a callback to react to those updates.
        /// **Parameters**
        ///   * `dependencies` - parameter of type `U2<string list,string>` - Either a string or an array of strings
        ///   * `errorHandler` - parameter of type `(obj -> unit) option` - Function to fire when the dependencies are updated
        /// **Output Type**
        ///   * `unit`
        ///
        /// **Exceptions**
        ///
        abstract accept: dependencies:  U2<string list, string> * ?errorHandler: (obj -> unit) -> unit

        /// **Description**
        /// Accept updates for itself.
        /// **Parameters**
        ///   * `errorHandler` - parameter of type `(obj -> unit) option` - Function to fire when the dependencies are updated
        ///
        /// **Output Type**
        ///   * `unit`
        ///
        /// **Exceptions**
        ///
        abstract accept: ?errorHandler: (obj -> unit) -> unit

        /// **Description**
        /// Reject updates for the given dependencies forcing the update to fail with a 'decline' code.
        /// **Parameters**
        ///   * `dependencies` - parameter of type `U2<string list,string>` - Either a string or an array of strings
        ///
        /// **Output Type**
        ///   * `unit`
        ///
        /// **Exceptions**
        ///
        abstract decline: dependencies:  U2<string list, string> -> unit

        /// **Description**
        /// Reject updates for itself.
        /// **Parameters**
        ///
        ///
        /// **Output Type**
        ///   * `unit`
        ///
        /// **Exceptions**
        ///
        abstract decline: unit -> unit

        /// **Description**
        /// Add a handler which is executed when the current module code is replaced.
        /// This should be used to remove any persistent resource you have claimed or created.
        /// If you want to transfer state to the updated module, add it to given `data` parameter.
        /// This object will be available at `module.hot.data` after the update.
        /// **Parameters**
        ///   * `data` - parameter of type `obj`
        ///
        /// **Output Type**
        ///   * `unit`
        ///
        /// **Exceptions**
        ///
        abstract dispose: data: obj -> unit

        /// **Description**
        /// Add a handler which is executed when the current module code is replaced.
        /// This should be used to remove any persistent resource you have claimed or created.
        /// If you want to transfer state to the updated module, add it to given `data` parameter.
        /// This object will be available at `module.hot.data` after the update.
        /// **Parameters**
        ///   * `handler` - parameter of type `obj -> unit`
        ///
        /// **Output Type**
        ///   * `unit`
        ///
        /// **Exceptions**
        ///
        abstract addDisposeHandler: handler: (obj -> unit) -> unit

        /// **Description**
        /// Remove the callback added via `dispose` or `addDisposeHandler`.
        /// **Parameters**
        ///   * `callback` - parameter of type `obj -> unit`
        ///
        /// **Output Type**
        ///   * `unit`
        ///
        /// **Exceptions**
        ///
        abstract removeDisposeHandler: callback: (obj -> unit) -> unit

        /// **Description**
        /// Test all loaded modules for updates and, if updates exist, `apply` them.
        /// **Parameters**
        ///   * `autoApply` - parameter of type `U2<bool,ApplyOptions>`
        ///
        /// **Output Type**
        ///   * `JS.Promise<obj>`
        ///
        /// **Exceptions**
        ///
        abstract check: autoApply: U2<bool, ApplyOptions> -> JS.Promise<obj>

        /// **Description**
        /// Continue the update process (as long as `module.hot.status() === 'ready'`).
        /// **Parameters**
        ///   * `options` - parameter of type `U2<bool,ApplyOptions>`
        ///
        /// **Output Type**
        ///   * `JS.Promise<obj>`
        ///
        /// **Exceptions**
        ///
        abstract apply: options : ApplyOptions -> JS.Promise<obj>

        /// **Description**
        /// Register a function to listen for changes in `status`.
        /// **Parameters**
        ///
        ///
        /// **Output Type**
        ///   * `unit`
        ///
        /// **Exceptions**
        ///
        abstract addStatusHandler: (obj -> unit) -> unit

        /// **Description**
        /// Remove a registered status handler.
        /// **Parameters**
        ///   * `callback` - parameter of type `obj -> unit`
        ///
        /// **Output Type**
        ///   * `unit`
        ///
        /// **Exceptions**
        ///
        abstract removeStatusHandler: callback: (obj -> unit) -> unit

    type IModule =
        abstract hot: IHot with get, set

    let [<Global>] [<Emit("module")>] ``module`` : IModule = jsNative
