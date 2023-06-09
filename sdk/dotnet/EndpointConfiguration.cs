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
    /// Endpoint Configurations are a reusable group of modules that encapsulate how
    ///  traffic to a domain or address is handled. Endpoint configurations are only
    ///  applied to Domains and TCP Addresses they have been attached to.
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
    ///     var example = new Ngrok.EndpointConfiguration("example", new()
    ///     {
    ///         Description = "app servers",
    ///         RequestHeaders = new[]
    ///         {
    ///             new Ngrok.Inputs.EndpointConfigurationRequestHeaderArgs
    ///             {
    ///                 Add = 
    ///                 {
    ///                     { "x-frontend", "ngrok" },
    ///                 },
    ///                 Removes = new[]
    ///                 {
    ///                     "cache-control",
    ///                 },
    ///             },
    ///         },
    ///         Type = "https",
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [NgrokResourceType("ngrok:index/endpointConfiguration:EndpointConfiguration")]
    public partial class EndpointConfiguration : global::Pulumi.CustomResource
    {
        /// <summary>
        /// backend module configuration or `null`
        /// </summary>
        [Output("backends")]
        public Output<ImmutableArray<Outputs.EndpointConfigurationBackend>> Backends { get; private set; } = null!;

        /// <summary>
        /// basic auth module configuration or `null`
        /// </summary>
        [Output("basicAuths")]
        public Output<ImmutableArray<Outputs.EndpointConfigurationBasicAuth>> BasicAuths { get; private set; } = null!;

        /// <summary>
        /// circuit breaker module configuration or `null`
        /// </summary>
        [Output("circuitBreakers")]
        public Output<ImmutableArray<Outputs.EndpointConfigurationCircuitBreaker>> CircuitBreakers { get; private set; } = null!;

        /// <summary>
        /// compression module configuration or `null`
        /// </summary>
        [Output("compressions")]
        public Output<ImmutableArray<Outputs.EndpointConfigurationCompression>> Compressions { get; private set; } = null!;

        /// <summary>
        /// human-readable description of what this endpoint configuration will be do when applied or what traffic it will be applied to. Optional, max 255 bytes
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// ip policy module configuration or `null`
        /// </summary>
        [Output("ipPolicies")]
        public Output<ImmutableArray<Outputs.EndpointConfigurationIpPolicy>> IpPolicies { get; private set; } = null!;

        /// <summary>
        /// logging module configuration or `null`
        /// </summary>
        [Output("loggings")]
        public Output<ImmutableArray<Outputs.EndpointConfigurationLogging>> Loggings { get; private set; } = null!;

        /// <summary>
        /// arbitrary user-defined machine-readable data of this endpoint configuration. Optional, max 4096 bytes.
        /// </summary>
        [Output("metadata")]
        public Output<string?> Metadata { get; private set; } = null!;

        /// <summary>
        /// mutual TLS module configuration or `null`
        /// </summary>
        [Output("mutualTls")]
        public Output<ImmutableArray<Outputs.EndpointConfigurationMutualTl>> MutualTls { get; private set; } = null!;

        /// <summary>
        /// oauth module configuration or `null`
        /// </summary>
        [Output("oauths")]
        public Output<ImmutableArray<Outputs.EndpointConfigurationOauth>> Oauths { get; private set; } = null!;

        /// <summary>
        /// oidc module configuration or `null`
        /// </summary>
        [Output("oidcs")]
        public Output<ImmutableArray<Outputs.EndpointConfigurationOidc>> Oidcs { get; private set; } = null!;

        /// <summary>
        /// request headers module configuration or `null`
        /// </summary>
        [Output("requestHeaders")]
        public Output<ImmutableArray<Outputs.EndpointConfigurationRequestHeader>> RequestHeaders { get; private set; } = null!;

        /// <summary>
        /// response headers module configuration or `null`
        /// </summary>
        [Output("responseHeaders")]
        public Output<ImmutableArray<Outputs.EndpointConfigurationResponseHeader>> ResponseHeaders { get; private set; } = null!;

        /// <summary>
        /// saml module configuration or `null`
        /// </summary>
        [Output("samls")]
        public Output<ImmutableArray<Outputs.EndpointConfigurationSaml>> Samls { get; private set; } = null!;

        /// <summary>
        /// TLS termination module configuration or `null`
        /// </summary>
        [Output("tlsTerminations")]
        public Output<ImmutableArray<Outputs.EndpointConfigurationTlsTermination>> TlsTerminations { get; private set; } = null!;

        /// <summary>
        /// they type of traffic this endpoint configuration can be applied to. one of: `http`, `https`, `tcp`
        /// </summary>
        [Output("type")]
        public Output<string?> Type { get; private set; } = null!;

        /// <summary>
        /// webhook validation module configuration or `null`
        /// </summary>
        [Output("webhookValidations")]
        public Output<ImmutableArray<Outputs.EndpointConfigurationWebhookValidation>> WebhookValidations { get; private set; } = null!;


        /// <summary>
        /// Create a EndpointConfiguration resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public EndpointConfiguration(string name, EndpointConfigurationArgs? args = null, CustomResourceOptions? options = null)
            : base("ngrok:index/endpointConfiguration:EndpointConfiguration", name, args ?? new EndpointConfigurationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private EndpointConfiguration(string name, Input<string> id, EndpointConfigurationState? state = null, CustomResourceOptions? options = null)
            : base("ngrok:index/endpointConfiguration:EndpointConfiguration", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing EndpointConfiguration resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static EndpointConfiguration Get(string name, Input<string> id, EndpointConfigurationState? state = null, CustomResourceOptions? options = null)
        {
            return new EndpointConfiguration(name, id, state, options);
        }
    }

    public sealed class EndpointConfigurationArgs : global::Pulumi.ResourceArgs
    {
        [Input("backends")]
        private InputList<Inputs.EndpointConfigurationBackendArgs>? _backends;

        /// <summary>
        /// backend module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationBackendArgs> Backends
        {
            get => _backends ?? (_backends = new InputList<Inputs.EndpointConfigurationBackendArgs>());
            set => _backends = value;
        }

        [Input("basicAuths")]
        private InputList<Inputs.EndpointConfigurationBasicAuthArgs>? _basicAuths;

        /// <summary>
        /// basic auth module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationBasicAuthArgs> BasicAuths
        {
            get => _basicAuths ?? (_basicAuths = new InputList<Inputs.EndpointConfigurationBasicAuthArgs>());
            set => _basicAuths = value;
        }

        [Input("circuitBreakers")]
        private InputList<Inputs.EndpointConfigurationCircuitBreakerArgs>? _circuitBreakers;

        /// <summary>
        /// circuit breaker module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationCircuitBreakerArgs> CircuitBreakers
        {
            get => _circuitBreakers ?? (_circuitBreakers = new InputList<Inputs.EndpointConfigurationCircuitBreakerArgs>());
            set => _circuitBreakers = value;
        }

        [Input("compressions")]
        private InputList<Inputs.EndpointConfigurationCompressionArgs>? _compressions;

        /// <summary>
        /// compression module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationCompressionArgs> Compressions
        {
            get => _compressions ?? (_compressions = new InputList<Inputs.EndpointConfigurationCompressionArgs>());
            set => _compressions = value;
        }

        /// <summary>
        /// human-readable description of what this endpoint configuration will be do when applied or what traffic it will be applied to. Optional, max 255 bytes
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("ipPolicies")]
        private InputList<Inputs.EndpointConfigurationIpPolicyArgs>? _ipPolicies;

        /// <summary>
        /// ip policy module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationIpPolicyArgs> IpPolicies
        {
            get => _ipPolicies ?? (_ipPolicies = new InputList<Inputs.EndpointConfigurationIpPolicyArgs>());
            set => _ipPolicies = value;
        }

        [Input("loggings")]
        private InputList<Inputs.EndpointConfigurationLoggingArgs>? _loggings;

        /// <summary>
        /// logging module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationLoggingArgs> Loggings
        {
            get => _loggings ?? (_loggings = new InputList<Inputs.EndpointConfigurationLoggingArgs>());
            set => _loggings = value;
        }

        /// <summary>
        /// arbitrary user-defined machine-readable data of this endpoint configuration. Optional, max 4096 bytes.
        /// </summary>
        [Input("metadata")]
        public Input<string>? Metadata { get; set; }

        [Input("mutualTls")]
        private InputList<Inputs.EndpointConfigurationMutualTlArgs>? _mutualTls;

        /// <summary>
        /// mutual TLS module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationMutualTlArgs> MutualTls
        {
            get => _mutualTls ?? (_mutualTls = new InputList<Inputs.EndpointConfigurationMutualTlArgs>());
            set => _mutualTls = value;
        }

        [Input("oauths")]
        private InputList<Inputs.EndpointConfigurationOauthArgs>? _oauths;

        /// <summary>
        /// oauth module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationOauthArgs> Oauths
        {
            get => _oauths ?? (_oauths = new InputList<Inputs.EndpointConfigurationOauthArgs>());
            set => _oauths = value;
        }

        [Input("oidcs")]
        private InputList<Inputs.EndpointConfigurationOidcArgs>? _oidcs;

        /// <summary>
        /// oidc module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationOidcArgs> Oidcs
        {
            get => _oidcs ?? (_oidcs = new InputList<Inputs.EndpointConfigurationOidcArgs>());
            set => _oidcs = value;
        }

        [Input("requestHeaders")]
        private InputList<Inputs.EndpointConfigurationRequestHeaderArgs>? _requestHeaders;

        /// <summary>
        /// request headers module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationRequestHeaderArgs> RequestHeaders
        {
            get => _requestHeaders ?? (_requestHeaders = new InputList<Inputs.EndpointConfigurationRequestHeaderArgs>());
            set => _requestHeaders = value;
        }

        [Input("responseHeaders")]
        private InputList<Inputs.EndpointConfigurationResponseHeaderArgs>? _responseHeaders;

        /// <summary>
        /// response headers module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationResponseHeaderArgs> ResponseHeaders
        {
            get => _responseHeaders ?? (_responseHeaders = new InputList<Inputs.EndpointConfigurationResponseHeaderArgs>());
            set => _responseHeaders = value;
        }

        [Input("samls")]
        private InputList<Inputs.EndpointConfigurationSamlArgs>? _samls;

        /// <summary>
        /// saml module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationSamlArgs> Samls
        {
            get => _samls ?? (_samls = new InputList<Inputs.EndpointConfigurationSamlArgs>());
            set => _samls = value;
        }

        [Input("tlsTerminations")]
        private InputList<Inputs.EndpointConfigurationTlsTerminationArgs>? _tlsTerminations;

        /// <summary>
        /// TLS termination module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationTlsTerminationArgs> TlsTerminations
        {
            get => _tlsTerminations ?? (_tlsTerminations = new InputList<Inputs.EndpointConfigurationTlsTerminationArgs>());
            set => _tlsTerminations = value;
        }

        /// <summary>
        /// they type of traffic this endpoint configuration can be applied to. one of: `http`, `https`, `tcp`
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("webhookValidations")]
        private InputList<Inputs.EndpointConfigurationWebhookValidationArgs>? _webhookValidations;

        /// <summary>
        /// webhook validation module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationWebhookValidationArgs> WebhookValidations
        {
            get => _webhookValidations ?? (_webhookValidations = new InputList<Inputs.EndpointConfigurationWebhookValidationArgs>());
            set => _webhookValidations = value;
        }

        public EndpointConfigurationArgs()
        {
        }
        public static new EndpointConfigurationArgs Empty => new EndpointConfigurationArgs();
    }

    public sealed class EndpointConfigurationState : global::Pulumi.ResourceArgs
    {
        [Input("backends")]
        private InputList<Inputs.EndpointConfigurationBackendGetArgs>? _backends;

        /// <summary>
        /// backend module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationBackendGetArgs> Backends
        {
            get => _backends ?? (_backends = new InputList<Inputs.EndpointConfigurationBackendGetArgs>());
            set => _backends = value;
        }

        [Input("basicAuths")]
        private InputList<Inputs.EndpointConfigurationBasicAuthGetArgs>? _basicAuths;

        /// <summary>
        /// basic auth module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationBasicAuthGetArgs> BasicAuths
        {
            get => _basicAuths ?? (_basicAuths = new InputList<Inputs.EndpointConfigurationBasicAuthGetArgs>());
            set => _basicAuths = value;
        }

        [Input("circuitBreakers")]
        private InputList<Inputs.EndpointConfigurationCircuitBreakerGetArgs>? _circuitBreakers;

        /// <summary>
        /// circuit breaker module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationCircuitBreakerGetArgs> CircuitBreakers
        {
            get => _circuitBreakers ?? (_circuitBreakers = new InputList<Inputs.EndpointConfigurationCircuitBreakerGetArgs>());
            set => _circuitBreakers = value;
        }

        [Input("compressions")]
        private InputList<Inputs.EndpointConfigurationCompressionGetArgs>? _compressions;

        /// <summary>
        /// compression module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationCompressionGetArgs> Compressions
        {
            get => _compressions ?? (_compressions = new InputList<Inputs.EndpointConfigurationCompressionGetArgs>());
            set => _compressions = value;
        }

        /// <summary>
        /// human-readable description of what this endpoint configuration will be do when applied or what traffic it will be applied to. Optional, max 255 bytes
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("ipPolicies")]
        private InputList<Inputs.EndpointConfigurationIpPolicyGetArgs>? _ipPolicies;

        /// <summary>
        /// ip policy module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationIpPolicyGetArgs> IpPolicies
        {
            get => _ipPolicies ?? (_ipPolicies = new InputList<Inputs.EndpointConfigurationIpPolicyGetArgs>());
            set => _ipPolicies = value;
        }

        [Input("loggings")]
        private InputList<Inputs.EndpointConfigurationLoggingGetArgs>? _loggings;

        /// <summary>
        /// logging module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationLoggingGetArgs> Loggings
        {
            get => _loggings ?? (_loggings = new InputList<Inputs.EndpointConfigurationLoggingGetArgs>());
            set => _loggings = value;
        }

        /// <summary>
        /// arbitrary user-defined machine-readable data of this endpoint configuration. Optional, max 4096 bytes.
        /// </summary>
        [Input("metadata")]
        public Input<string>? Metadata { get; set; }

        [Input("mutualTls")]
        private InputList<Inputs.EndpointConfigurationMutualTlGetArgs>? _mutualTls;

        /// <summary>
        /// mutual TLS module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationMutualTlGetArgs> MutualTls
        {
            get => _mutualTls ?? (_mutualTls = new InputList<Inputs.EndpointConfigurationMutualTlGetArgs>());
            set => _mutualTls = value;
        }

        [Input("oauths")]
        private InputList<Inputs.EndpointConfigurationOauthGetArgs>? _oauths;

        /// <summary>
        /// oauth module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationOauthGetArgs> Oauths
        {
            get => _oauths ?? (_oauths = new InputList<Inputs.EndpointConfigurationOauthGetArgs>());
            set => _oauths = value;
        }

        [Input("oidcs")]
        private InputList<Inputs.EndpointConfigurationOidcGetArgs>? _oidcs;

        /// <summary>
        /// oidc module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationOidcGetArgs> Oidcs
        {
            get => _oidcs ?? (_oidcs = new InputList<Inputs.EndpointConfigurationOidcGetArgs>());
            set => _oidcs = value;
        }

        [Input("requestHeaders")]
        private InputList<Inputs.EndpointConfigurationRequestHeaderGetArgs>? _requestHeaders;

        /// <summary>
        /// request headers module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationRequestHeaderGetArgs> RequestHeaders
        {
            get => _requestHeaders ?? (_requestHeaders = new InputList<Inputs.EndpointConfigurationRequestHeaderGetArgs>());
            set => _requestHeaders = value;
        }

        [Input("responseHeaders")]
        private InputList<Inputs.EndpointConfigurationResponseHeaderGetArgs>? _responseHeaders;

        /// <summary>
        /// response headers module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationResponseHeaderGetArgs> ResponseHeaders
        {
            get => _responseHeaders ?? (_responseHeaders = new InputList<Inputs.EndpointConfigurationResponseHeaderGetArgs>());
            set => _responseHeaders = value;
        }

        [Input("samls")]
        private InputList<Inputs.EndpointConfigurationSamlGetArgs>? _samls;

        /// <summary>
        /// saml module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationSamlGetArgs> Samls
        {
            get => _samls ?? (_samls = new InputList<Inputs.EndpointConfigurationSamlGetArgs>());
            set => _samls = value;
        }

        [Input("tlsTerminations")]
        private InputList<Inputs.EndpointConfigurationTlsTerminationGetArgs>? _tlsTerminations;

        /// <summary>
        /// TLS termination module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationTlsTerminationGetArgs> TlsTerminations
        {
            get => _tlsTerminations ?? (_tlsTerminations = new InputList<Inputs.EndpointConfigurationTlsTerminationGetArgs>());
            set => _tlsTerminations = value;
        }

        /// <summary>
        /// they type of traffic this endpoint configuration can be applied to. one of: `http`, `https`, `tcp`
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("webhookValidations")]
        private InputList<Inputs.EndpointConfigurationWebhookValidationGetArgs>? _webhookValidations;

        /// <summary>
        /// webhook validation module configuration or `null`
        /// </summary>
        public InputList<Inputs.EndpointConfigurationWebhookValidationGetArgs> WebhookValidations
        {
            get => _webhookValidations ?? (_webhookValidations = new InputList<Inputs.EndpointConfigurationWebhookValidationGetArgs>());
            set => _webhookValidations = value;
        }

        public EndpointConfigurationState()
        {
        }
        public static new EndpointConfigurationState Empty => new EndpointConfigurationState();
    }
}
