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
    /// IP Policies are reusable groups of CIDR ranges with an `allow` or `deny`
    ///  action. They can be attached to endpoints via the Endpoint Configuration IP
    ///  Policy module. They can also be used with IP Restrictions to control source
    ///  IP ranges that can start tunnel sessions and connect to the API and dashboard.
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
    ///     var example = new Ngrok.IpPolicy("example", new()
    ///     {
    ///         Action = "allow",
    ///         Description = "API Outbound Gateway",
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [NgrokResourceType("ngrok:index/ipPolicy:IpPolicy")]
    public partial class IpPolicy : global::Pulumi.CustomResource
    {
        /// <summary>
        /// this field is deprecated. Please leave it empty and use the ip policy rule object's "action" field instead. It is temporarily retained for backwards compatibility reasons.
        /// </summary>
        [Output("action")]
        public Output<string?> Action { get; private set; } = null!;

        /// <summary>
        /// human-readable description of the source IPs of this IP policy. optional, max 255 bytes.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// arbitrary user-defined machine-readable data of this IP policy. optional, max 4096 bytes.
        /// </summary>
        [Output("metadata")]
        public Output<string?> Metadata { get; private set; } = null!;


        /// <summary>
        /// Create a IpPolicy resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IpPolicy(string name, IpPolicyArgs? args = null, CustomResourceOptions? options = null)
            : base("ngrok:index/ipPolicy:IpPolicy", name, args ?? new IpPolicyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private IpPolicy(string name, Input<string> id, IpPolicyState? state = null, CustomResourceOptions? options = null)
            : base("ngrok:index/ipPolicy:IpPolicy", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing IpPolicy resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IpPolicy Get(string name, Input<string> id, IpPolicyState? state = null, CustomResourceOptions? options = null)
        {
            return new IpPolicy(name, id, state, options);
        }
    }

    public sealed class IpPolicyArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// this field is deprecated. Please leave it empty and use the ip policy rule object's "action" field instead. It is temporarily retained for backwards compatibility reasons.
        /// </summary>
        [Input("action")]
        public Input<string>? Action { get; set; }

        /// <summary>
        /// human-readable description of the source IPs of this IP policy. optional, max 255 bytes.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// arbitrary user-defined machine-readable data of this IP policy. optional, max 4096 bytes.
        /// </summary>
        [Input("metadata")]
        public Input<string>? Metadata { get; set; }

        public IpPolicyArgs()
        {
        }
        public static new IpPolicyArgs Empty => new IpPolicyArgs();
    }

    public sealed class IpPolicyState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// this field is deprecated. Please leave it empty and use the ip policy rule object's "action" field instead. It is temporarily retained for backwards compatibility reasons.
        /// </summary>
        [Input("action")]
        public Input<string>? Action { get; set; }

        /// <summary>
        /// human-readable description of the source IPs of this IP policy. optional, max 255 bytes.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// arbitrary user-defined machine-readable data of this IP policy. optional, max 4096 bytes.
        /// </summary>
        [Input("metadata")]
        public Input<string>? Metadata { get; set; }

        public IpPolicyState()
        {
        }
        public static new IpPolicyState Empty => new IpPolicyState();
    }
}
