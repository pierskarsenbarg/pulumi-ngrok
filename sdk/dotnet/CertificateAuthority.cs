// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Ngrok
{
    /// <summary>
    /// Certificate Authorities are x509 certificates that are used to sign other
    ///  x509 certificates. Attach a Certificate Authority to the Mutual TLS module
    ///  to verify that the TLS certificate presented by a client has been signed by
    ///  this CA. Certificate Authorities  are used only for mTLS validation only and
    ///  thus a private key is not included in the resource.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Ngrok = PiersKarsenbarg.Ngrok;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var example = new Ngrok.CertificateAuthority("example", new()
    ///     {
    ///         CaPem = @"-----BEGIN CERTIFICATE-----
    /// MIIEETCCAvmgAwIBAgIUU3N6lNzPqar4400cLQMcVHFl+mEwDQYJKoZIhvcNAQEL
    /// BQAwgZcxCzAJBgNVBAYTAkFVMQwwCgYDVQQIDANOU1cxDzANBgNVBAcMBlN5ZG5l
    /// eTEZMBcGA1UECgwQRHJvcGJlYXIgUHR5IEx0ZDEkMCIGA1UEAwwbSW50cmFuZXQg
    /// U2VydmljZXMgQXV0aG9yaXR5MSgwJgYJKoZIhvcNAQkBFhlzZWN1cml0eUBkcm9w
    /// YmVhci5leGFtcGxlMB4XDTIwMDUwMTE2Mjc1OVoXDTIxMDUwMTE2Mjc1OVowgZcx
    /// CzAJBgNVBAYTAkFVMQwwCgYDVQQIDANOU1cxDzANBgNVBAcMBlN5ZG5leTEZMBcG
    /// A1UECgwQRHJvcGJlYXIgUHR5IEx0ZDEkMCIGA1UEAwwbSW50cmFuZXQgU2Vydmlj
    /// ZXMgQXV0aG9yaXR5MSgwJgYJKoZIhvcNAQkBFhlzZWN1cml0eUBkcm9wYmVhci5l
    /// eGFtcGxlMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA7y/EAN0yZkA0
    /// nRpMBfomnnS8KMWHb90kvGfhkCDR8WCQz5mX7eDEYDthRQrEgp63qtJ7IoCM5f0A
    /// UD6J2m/mZecP7SfA8OuTAZ7UyRixpZh0zJQSgj24Sh1LQuYci0DNXrei+R1qBvd+
    /// pmpZwkKygNrbZYe3oY1PZ3jEYPSAQzIObDF7LhdhLLrcfWa9BHOGMLnALNMY558b
    /// voijTCEmRrSavdvrAS9LDRipEXT8EQOWZZT9VbPtgSBalvStdoupAptmPIWjXftf
    /// Wi1kry+P0xVFZG9iZwUeAT6fSJ+gJD8M1UXWaQbocYrctESP0sZEFM3rzdWqrZb7
    /// 3cH3K5OCvwIDAQABo1MwUTAdBgNVHQ4EFgQUsZdchgUimRHLiPRWw51+DGBmlfMw
    /// HwYDVR0jBBgwFoAUsZdchgUimRHLiPRWw51+DGBmlfMwDwYDVR0TAQH/BAUwAwEB
    /// /zANBgkqhkiG9w0BAQsFAAOCAQEANk25tt8sSfn6Qu1bbhWRbjKgS5z+j9LqyCna
    /// v3fbSchMthaQR7w0vL69ayroeYdqDZkRMmHjuYKY4NyqyXkkaqVO63wEicCo55d9
    /// pIKuPzc/7xwdRephosjGTQ4QaQ4OnrdpJZieI92m9ODexgsab84AYmwNpbGOI/tK
    /// nPsQr8x1RfLs2gbBwQ4MYVM3tQQbX0o+yve5nz/NCOq4vdG+eKON5u6VYMkOOg9F
    /// VyNY1iISQkpNk/AF6Vi9BGuDb5Hg0phEl1Q0ntCO7ZHAUHjy0ucqXZiXoXdXZcs3
    /// 3zKKLUKva59EDBZ5TUucvXh8VemBtNc6hd1mX4Tq7lAreG9pjQ==
    /// -----END CERTIFICATE-----
    /// ",
    ///         Description = "Internal Coprorates Services Authority",
    ///         Metadata = "{\"internal_id\": \"7d2caeee-cdc3-4b26-b2c2-b280b8287552\"}",
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [NgrokResourceType("ngrok:index/certificateAuthority:CertificateAuthority")]
    public partial class CertificateAuthority : global::Pulumi.CustomResource
    {
        /// <summary>
        /// raw PEM of the Certificate Authority
        /// </summary>
        [Output("caPem")]
        public Output<string> CaPem { get; private set; } = null!;

        /// <summary>
        /// human-readable description of this Certificate Authority. optional, max 255 bytes.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// arbitrary user-defined machine-readable data of this Certificate Authority. optional, max 4096 bytes.
        /// </summary>
        [Output("metadata")]
        public Output<string?> Metadata { get; private set; } = null!;


        /// <summary>
        /// Create a CertificateAuthority resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CertificateAuthority(string name, CertificateAuthorityArgs args, CustomResourceOptions? options = null)
            : base("ngrok:index/certificateAuthority:CertificateAuthority", name, args ?? new CertificateAuthorityArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CertificateAuthority(string name, Input<string> id, CertificateAuthorityState? state = null, CustomResourceOptions? options = null)
            : base("ngrok:index/certificateAuthority:CertificateAuthority", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pierskarsenbarg/pulumi-ngrok",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing CertificateAuthority resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CertificateAuthority Get(string name, Input<string> id, CertificateAuthorityState? state = null, CustomResourceOptions? options = null)
        {
            return new CertificateAuthority(name, id, state, options);
        }
    }

    public sealed class CertificateAuthorityArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// raw PEM of the Certificate Authority
        /// </summary>
        [Input("caPem", required: true)]
        public Input<string> CaPem { get; set; } = null!;

        /// <summary>
        /// human-readable description of this Certificate Authority. optional, max 255 bytes.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// arbitrary user-defined machine-readable data of this Certificate Authority. optional, max 4096 bytes.
        /// </summary>
        [Input("metadata")]
        public Input<string>? Metadata { get; set; }

        public CertificateAuthorityArgs()
        {
        }
        public static new CertificateAuthorityArgs Empty => new CertificateAuthorityArgs();
    }

    public sealed class CertificateAuthorityState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// raw PEM of the Certificate Authority
        /// </summary>
        [Input("caPem")]
        public Input<string>? CaPem { get; set; }

        /// <summary>
        /// human-readable description of this Certificate Authority. optional, max 255 bytes.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// arbitrary user-defined machine-readable data of this Certificate Authority. optional, max 4096 bytes.
        /// </summary>
        [Input("metadata")]
        public Input<string>? Metadata { get; set; }

        public CertificateAuthorityState()
        {
        }
        public static new CertificateAuthorityState Empty => new CertificateAuthorityState();
    }
}
