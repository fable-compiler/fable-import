module rec Fable.Import.Node.Os

open Fable.Core
open Fable.Import.Node.Base

type [<AllowNullLiteral>] CpuTimes =
    abstract user: float with get, set
    abstract nice: float with get, set
    abstract sys: float with get, set
    abstract idle: float with get, set
    abstract irq: float with get, set

type [<AllowNullLiteral>] CpuInfo =
    abstract model: string with get, set
    abstract speed: float with get, set
    abstract times: CpuTimes with get, set

type [<AllowNullLiteral>] NetworkInterfaceInfo =
    abstract address: string with get, set
    abstract netmask: string with get, set
    abstract family: string with get, set
    abstract mac: string with get, set
    abstract ``internal``: bool with get, set

type [<AllowNullLiteral>] Constants =
    abstract UV_UDP_REUSEADDR: float with get, set
    abstract signals: obj with get, set
    abstract errno: obj with get, set

type [<StringEnum>] Endianness =
    | [<CompiledName("BE")>] Be | [<CompiledName("LE")>] Le

type [<AllowNullLiteral>] UserInfoOptions =
    abstract encoding: string option with get, set

type [<AllowNullLiteral>] UserInfo =
    abstract username: string with get, set
    abstract uid: float with get, set
    abstract gid: float with get, set
    abstract shell: string with get, set
    abstract homedir: string with get, set

type IExports =
    /// A string constant defining the operating system-specific end-of-line marker:
    /// - \n on POSIX
    /// - \r\n on Windows
    abstract EOL: string with get, set
    /// The os.arch() method returns a string identifying the operating system CPU architecture for which the Node.js binary was compiled.
    abstract arch: unit -> NodeJS.Arch
    /// Returns an object containing commonly used operating system specific constants for error codes, process signals, and so on. 
    abstract constants: Constants with get, set
    /// The os.cpus() method returns an array of objects containing information about each CPU/core installed.
    abstract cpus: unit -> ResizeArray<CpuInfo>
    /// The os.endianness() method returns a string identifying the endianness of the CPU for which the Node.js binary was compiled.
    /// Possible values are:
    ///     - 'BE' for big endian
    ///     - 'LE' for little endian.
    abstract endianness: unit -> Endianness
    /// The os.freemem() method returns the amount of free system memory in bytes as an integer.
    abstract freemem: unit -> float
    /// The os.homedir() method returns the home directory of the current user as a string.
    abstract homedir: unit -> string
    /// The os.hostname() method returns the hostname of the operating system as a string.
    abstract hostname: unit -> string
    /// The os.loadavg() method returns an array containing the 1, 5, and 15 minute load averages.
    /// The load average is a measure of system activity, calculated by the operating system and expressed as a fractional number. As a rule of thumb, the load average should ideally be less than the number of logical CPUs in the system.
    /// The load average is a UNIX-specific concept with no real equivalent on Windows platforms. On Windows, the return value is always [0, 0, 0].
    abstract loadavg: unit -> (float * float * float)
    /// The os.networkInterfaces() method returns an object containing only network interfaces that have been assigned a network address.
    /// Each key on the returned object identifies a network interface. The associated value is an array of objects that each describe an assigned network address.
    abstract networkInterfaces: unit -> obj
    /// The os.platform() method returns a string identifying the operating system platform as set during compile time of Node.js.
    abstract platform: unit -> NodeJS.Platform
    /// The os.release() method returns a string identifying the operating system release.
    /// Note: On POSIX systems, the operating system release is determined by calling uname(3). On Windows, GetVersionExW() is used. Please see https://en.wikipedia.org/wiki/Uname#Examples for more information.
    abstract release: unit -> string
    /// The os.tmpdir() method returns a string specifying the operating system's default directory for temporary files.
    abstract tmpdir: unit -> string
    /// The os.totalmem() method returns the total amount of system memory in bytes as an integer.
    abstract totalmem: unit -> float
    /// The os.type() method returns a string identifying the operating system name as returned by uname(3). For example 'Linux' on Linux, 'Darwin' on macOS and 'Windows_NT' on Windows.
    /// Please see https://en.wikipedia.org/wiki/Uname#Examples for additional information about the output of running uname(3) on various operating systems.
    abstract ``type``: unit -> string
    /// The os.uptime() method returns the system uptime in number of seconds.
    /// Note: On Windows the returned value includes fractions of a second.
    abstract uptime: unit -> float
    /// The os.userInfo() method returns information about the currently effective user -- on POSIX platforms, this is typically a subset of the password file. The returned object includes the username, uid, gid, shell, and homedir. On Windows, the uid and gid fields are -1, and shell is null.
    abstract userInfo: ?options: UserInfoOptions -> UserInfo