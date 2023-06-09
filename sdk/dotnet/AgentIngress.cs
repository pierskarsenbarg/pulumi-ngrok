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
    ///     var example = new Ngrok.AgentIngress("example", new()
    ///     {
    ///         Description = "acme devices",
    ///         Domain = "connect.acme.com",
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [NgrokResourceType("ngrok:index/agentIngress:AgentIngress")]
    public partial class AgentIngress : global::Pulumi.CustomResource
    {
        /// <summary>
        /// timestamp when the Agent Ingress was created, RFC 3339 format
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// human-readable description of the use of this Agent Ingress. optional, max 255 bytes.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// the domain that you own to be used as the base domain name to generate regional agent ingress domains.
        /// </summary>
        [Output("domain")]
        public Output<string> Domain { get; private set; } = null!;

        /// <summary>
        /// arbitrary user-defined machine-readable data of this Agent Ingress. optional, max 4096 bytes
        /// </summary>
        [Output("metadata")]
        public Output<string?> Metadata { get; private set; } = null!;

        /// <summary>
        /// a list of target values to use as the values of NS records for the domain property these values will delegate control over the domain to ngrok
        /// </summary>
        [Output("nsTargets")]
        public Output<ImmutableArray<string>> NsTargets { get; private set; } = null!;

        /// <summary>
        /// a list of regional agent ingress domains that are subdomains of the value of domain this value may increase over time as ngrok adds more regions
        /// </summary>
        [Output("regionDomains")]
        public Output<ImmutableArray<string>> RegionDomains { get; private set; } = null!;

        /// <summary>
        /// URI to the API resource of this Agent ingress
        /// </summary>
        [Output("uri")]
        public Output<string> Uri { get; private set; } = null!;


        /// <summary>
        /// Create a AgentIngress resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AgentIngress(string name, AgentIngressArgs args, CustomResourceOptions? options = null)
            : base("ngrok:index/agentIngress:AgentIngress", name, args ?? new AgentIngressArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AgentIngress(string name, Input<string> id, AgentIngressState? state = null, CustomResourceOptions? options = null)
            : base("ngrok:index/agentIngress:AgentIngress", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing AgentIngress resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AgentIngress Get(string name, Input<string> id, AgentIngressState? state = null, CustomResourceOptions? options = null)
        {
            return new AgentIngress(name, id, state, options);
        }
    }

    public sealed class AgentIngressArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// human-readable description of the use of this Agent Ingress. optional, max 255 bytes.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// the domain that you own to be used as the base domain name to generate regional agent ingress domains.
        /// </summary>
        [Input("domain", required: true)]
        public Input<string> Domain { get; set; } = null!;

        /// <summary>
        /// arbitrary user-defined machine-readable data of this Agent Ingress. optional, max 4096 bytes
        /// </summary>
        [Input("metadata")]
        public Input<string>? Metadata { get; set; }

        /// <summary>
        /// URI to the API resource of this Agent ingress
        /// </summary>
        [Input("uri")]
        public Input<string>? Uri { get; set; }

        public AgentIngressArgs()
        {
        }
        public static new AgentIngressArgs Empty => new AgentIngressArgs();
    }

    public sealed class AgentIngressState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// timestamp when the Agent Ingress was created, RFC 3339 format
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        /// <summary>
        /// human-readable description of the use of this Agent Ingress. optional, max 255 bytes.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// the domain that you own to be used as the base domain name to generate regional agent ingress domains.
        /// </summary>
        [Input("domain")]
        public Input<string>? Domain { get; set; }

        /// <summary>
        /// arbitrary user-defined machine-readable data of this Agent Ingress. optional, max 4096 bytes
        /// </summary>
        [Input("metadata")]
        public Input<string>? Metadata { get; set; }

        [Input("nsTargets")]
        private InputList<string>? _nsTargets;

        /// <summary>
        /// a list of target values to use as the values of NS records for the domain property these values will delegate control over the domain to ngrok
        /// </summary>
        public InputList<string> NsTargets
        {
            get => _nsTargets ?? (_nsTargets = new InputList<string>());
            set => _nsTargets = value;
        }

        [Input("regionDomains")]
        private InputList<string>? _regionDomains;

        /// <summary>
        /// a list of regional agent ingress domains that are subdomains of the value of domain this value may increase over time as ngrok adds more regions
        /// </summary>
        public InputList<string> RegionDomains
        {
            get => _regionDomains ?? (_regionDomains = new InputList<string>());
            set => _regionDomains = value;
        }

        /// <summary>
        /// URI to the API resource of this Agent ingress
        /// </summary>
        [Input("uri")]
        public Input<string>? Uri { get; set; }

        public AgentIngressState()
        {
        }
        public static new AgentIngressState Empty => new AgentIngressState();
    }
}
