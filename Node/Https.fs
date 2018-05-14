module rec Fable.Import.Node.Https

open Fable.Core
open Fable.Import.JS
open Fable.Import.Node

type [<AllowNullLiteral>] ServerOptions =
    abstract pfx: obj option with get, set
    abstract key: obj option with get, set
    abstract passphrase: string option with get, set
    abstract cert: obj option with get, set
    abstract ca: obj option with get, set
    abstract crl: obj option with get, set
    abstract ciphers: string option with get, set
    abstract honorCipherOrder: bool option with get, set
    abstract requestCert: bool option with get, set
    abstract rejectUnauthorized: bool option with get, set
    abstract NPNProtocols: obj option with get, set
    abstract SNICallback: (string -> (Error -> Tls.SecureContext -> obj) -> obj) option with get, set

type [<AllowNullLiteral>] RequestOptions =
    inherit Http.RequestOptions
    /// Optional PFX or PKCS12 encoded private key and certificate chain.
    /// pfx is an alternative to providing key and cert individually.
    /// PFX is usually encrypted, if it is, passphrase will be used to decrypt it.
    /// Multiple PFX can be provided either as an array of unencrypted PFX buffers, or an array of objects in the form {buf: <string|buffer>[, passphrase: <string>]}.
    /// The object form can only occur in an array. 
    /// object.passphrase is optional.
    /// Encrypted PFX will be decrypted with object.passphrase if provided, or options.passphrase if it is not.
    abstract pfx: obj option with get, set
    /// Optional private keys in PEM format. PEM allows the option of private keys being encrypted.
    /// Encrypted keys will be decrypted with options.passphrase.
    /// Multiple keys using different algorithms can be provided either as an array of unencrypted key strings or buffers, or an array of objects in the form {pem: <string|buffer>[, passphrase: <string>]}.
    /// The object form can only occur in an array. object.passphrase is optional.
    /// Encrypted keys will be decrypted with object.passphrase if provided, or options.passphrase if it is not.
    abstract key: obj option with get, set
    /// Optional shared passphrase used for a single private key and/or a PFX.
    abstract passphrase: string option with get, set
    /// Optional cert chains in PEM format.
    /// One cert chain should be provided per private key.
    /// Each cert chain should consist of the PEM formatted certificate for a provided private key,
    /// followed by the PEM formatted intermediate certificates (if any), in order, and not including the root CA
    /// (the root CA must be pre-known to the peer, see ca).
    /// When providing multiple cert chains, they do not have to be in the same order as their private keys in key.
    /// If the intermediate certificates are not provided, the peer will not be able to validate the certificate, and the handshake will fail.
    abstract cert: obj option with get, set
    /// Optionally override the trusted CA certificates.
    /// Default is to trust the well-known CAs curated by Mozilla.
    /// Mozilla's CAs are completely replaced when CAs are explicitly specified using this option.
    /// The value can be a string or Buffer, or an Array of strings and/or Buffers.
    /// Any string or Buffer can contain multiple PEM CAs concatenated together.
    /// The peer's certificate must be chainable to a CA trusted by the server for the connection to be authenticated.
    /// When using certificates that are not chainable to a well-known CA,
    /// the certificate's CA must be explicitly specified as a trusted or the connection will fail to authenticate.
    /// If the peer uses a certificate that doesn't match or chain to one of the default CAs,
    /// use the ca option to provide a CA certificate that the peer's certificate can match or chain to.
    /// For self-signed certificates, the certificate is its own CA, and must be provided.
    abstract ca: obj option with get, set
    /// Optional cipher suite specification, replacing the default
    abstract ciphers: string option with get, set
    /// If not false, the server certificate is verified against the list of supplied CAs. 
    /// An 'error' event is emitted if verification fails; err.code contains the OpenSSL error code. Default: true.
    abstract rejectUnauthorized: bool option with get, set
    /// Optional SSL method to use. The possible values are listed as SSL_METHODS, use the function names as strings. 
    /// For example, 'TLSv1_2_method' to force TLS version 1.2. Default: 'TLS_method'.
    abstract secureProtocol: string option with get, set

type [<AllowNullLiteral>] Agent =
    abstract maxSockets: float with get, set
    abstract sockets: obj with get, set
    abstract requests: obj with get, set
    abstract destroy: unit -> unit

type [<AllowNullLiteral>] AgentOptions =
    inherit Http.AgentOptions
    abstract pfx: obj option with get, set
    abstract key: obj option with get, set
    abstract passphrase: string option with get, set
    abstract cert: obj option with get, set
    abstract ca: obj option with get, set
    abstract ciphers: string option with get, set
    abstract rejectUnauthorized: bool option with get, set
    abstract secureProtocol: string option with get, set
    abstract maxCachedSessions: float option with get, set

type [<AllowNullLiteral>] AgentStatic =
  [<Emit("new $0($1...)")>] abstract Create: ?options: AgentOptions -> Agent
    
type [<AllowNullLiteral>] Server =
    inherit Tls.Server

type IExports =
    abstract Agent: AgentStatic with get, set
    abstract globalAgent: Agent with get, set
    abstract createServer: options: ServerOptions * ?requestListener: (Http.IncomingMessage -> Http.ServerResponse -> unit) -> Server
    abstract request: options: RequestOptions * ?callback: (Http.IncomingMessage -> unit) -> Http.ClientRequest<_>
    abstract get: options: RequestOptions * ?callback: (Http.IncomingMessage -> unit) -> Http.ClientRequest<_>