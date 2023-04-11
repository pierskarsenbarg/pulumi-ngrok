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
    /// IP Policy Rules are the IPv4 or IPv6 CIDRs entries that
    ///  make up an IP Policy.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using Pulumi;
    /// using Ngrok = PiersKarsenbarg.Ngrok;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var example = new Ngrok.IpPolicyRule("example", new()
    ///     {
    ///         Cidr = "212.3.14.0/24",
    ///         Description = "nyc office",
    ///         IpPolicyId = "ipp_25auGv9R7vPmi6NKs5Cxcyzc2Cm",
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [NgrokResourceType("ngrok:index/ipPolicyRule:IpPolicyRule")]
    public partial class IpPolicyRule : global::Pulumi.CustomResource
    {
        /// <summary>
        /// the action to apply to the policy rule, either `allow` or `deny`
        /// </summary>
        [Output("action")]
        public Output<string?> Action { get; private set; } = null!;

        /// <summary>
        /// an IP or IP range specified in CIDR notation. IPv4 and IPv6 are both supported.
        /// </summary>
        [Output("cidr")]
        public Output<string> Cidr { get; private set; } = null!;

        /// <summary>
        /// human-readable description of the source IPs of this IP rule. optional, max 255 bytes.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// ID of the IP policy this IP policy rule will be attached to
        /// </summary>
        [Output("ipPolicyId")]
        public Output<string> IpPolicyId { get; private set; } = null!;

        /// <summary>
        /// arbitrary user-defined machine-readable data of this IP policy rule. optional, max 4096 bytes.
        /// </summary>
        [Output("metadata")]
        public Output<string?> Metadata { get; private set; } = null!;


        /// <summary>
        /// Create a IpPolicyRule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IpPolicyRule(string name, IpPolicyRuleArgs args, CustomResourceOptions? options = null)
            : base("ngrok:index/ipPolicyRule:IpPolicyRule", name, args ?? new IpPolicyRuleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private IpPolicyRule(string name, Input<string> id, IpPolicyRuleState? state = null, CustomResourceOptions? options = null)
            : base("ngrok:index/ipPolicyRule:IpPolicyRule", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing IpPolicyRule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IpPolicyRule Get(string name, Input<string> id, IpPolicyRuleState? state = null, CustomResourceOptions? options = null)
        {
            return new IpPolicyRule(name, id, state, options);
        }
    }

    public sealed class IpPolicyRuleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// the action to apply to the policy rule, either `allow` or `deny`
        /// </summary>
        [Input("action")]
        public Input<string>? Action { get; set; }

        /// <summary>
        /// an IP or IP range specified in CIDR notation. IPv4 and IPv6 are both supported.
        /// </summary>
        [Input("cidr", required: true)]
        public Input<string> Cidr { get; set; } = null!;

        /// <summary>
        /// human-readable description of the source IPs of this IP rule. optional, max 255 bytes.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// ID of the IP policy this IP policy rule will be attached to
        /// </summary>
        [Input("ipPolicyId", required: true)]
        public Input<string> IpPolicyId { get; set; } = null!;

        /// <summary>
        /// arbitrary user-defined machine-readable data of this IP policy rule. optional, max 4096 bytes.
        /// </summary>
        [Input("metadata")]
        public Input<string>? Metadata { get; set; }

        public IpPolicyRuleArgs()
        {
        }
        public static new IpPolicyRuleArgs Empty => new IpPolicyRuleArgs();
    }

    public sealed class IpPolicyRuleState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// the action to apply to the policy rule, either `allow` or `deny`
        /// </summary>
        [Input("action")]
        public Input<string>? Action { get; set; }

        /// <summary>
        /// an IP or IP range specified in CIDR notation. IPv4 and IPv6 are both supported.
        /// </summary>
        [Input("cidr")]
        public Input<string>? Cidr { get; set; }

        /// <summary>
        /// human-readable description of the source IPs of this IP rule. optional, max 255 bytes.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// ID of the IP policy this IP policy rule will be attached to
        /// </summary>
        [Input("ipPolicyId")]
        public Input<string>? IpPolicyId { get; set; }

        /// <summary>
        /// arbitrary user-defined machine-readable data of this IP policy rule. optional, max 4096 bytes.
        /// </summary>
        [Input("metadata")]
        public Input<string>? Metadata { get; set; }

        public IpPolicyRuleState()
        {
        }
        public static new IpPolicyRuleState Empty => new IpPolicyRuleState();
    }
}
