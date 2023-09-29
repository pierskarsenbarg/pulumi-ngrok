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
    /// An IP restriction is a restriction placed on the CIDRs that are allowed to
    ///  initiate traffic to a specific aspect of your ngrok account. An IP
    ///  restriction has a type which defines the ingress it applies to. IP
    ///  restrictions can be used to enforce the source IPs that can make API
    ///  requests, log in to the dashboard, start ngrok agents, and connect to your
    ///  public-facing endpoints.
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
    ///     var example = new Ngrok.IpRestriction("example", new()
    ///     {
    ///         IpPolicyIds = new[]
    ///         {
    ///             "ipp_26rOyhglKmVz5ABMOwZwPFBFXBZ",
    ///         },
    ///         Type = "dashboard",
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [NgrokResourceType("ngrok:index/ipRestriction:IpRestriction")]
    public partial class IpRestriction : global::Pulumi.CustomResource
    {
        /// <summary>
        /// human-readable description of this IP restriction. optional, max 255 bytes.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// true if the IP restriction will be enforced. if false, only warnings will be issued
        /// </summary>
        [Output("enforced")]
        public Output<bool?> Enforced { get; private set; } = null!;

        /// <summary>
        /// the set of IP policy identifiers that are used to enforce the restriction
        /// </summary>
        [Output("ipPolicyIds")]
        public Output<ImmutableArray<string>> IpPolicyIds { get; private set; } = null!;

        /// <summary>
        /// arbitrary user-defined machine-readable data of this IP restriction. optional, max 4096 bytes.
        /// </summary>
        [Output("metadata")]
        public Output<string?> Metadata { get; private set; } = null!;

        /// <summary>
        /// the type of IP restriction. this defines what traffic will be restricted with the attached policies. four values are currently supported: `dashboard`, `api`, `agent`, and `endpoints`
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a IpRestriction resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IpRestriction(string name, IpRestrictionArgs args, CustomResourceOptions? options = null)
            : base("ngrok:index/ipRestriction:IpRestriction", name, args ?? new IpRestrictionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private IpRestriction(string name, Input<string> id, IpRestrictionState? state = null, CustomResourceOptions? options = null)
            : base("ngrok:index/ipRestriction:IpRestriction", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing IpRestriction resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IpRestriction Get(string name, Input<string> id, IpRestrictionState? state = null, CustomResourceOptions? options = null)
        {
            return new IpRestriction(name, id, state, options);
        }
    }

    public sealed class IpRestrictionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// human-readable description of this IP restriction. optional, max 255 bytes.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// true if the IP restriction will be enforced. if false, only warnings will be issued
        /// </summary>
        [Input("enforced")]
        public Input<bool>? Enforced { get; set; }

        [Input("ipPolicyIds", required: true)]
        private InputList<string>? _ipPolicyIds;

        /// <summary>
        /// the set of IP policy identifiers that are used to enforce the restriction
        /// </summary>
        public InputList<string> IpPolicyIds
        {
            get => _ipPolicyIds ?? (_ipPolicyIds = new InputList<string>());
            set => _ipPolicyIds = value;
        }

        /// <summary>
        /// arbitrary user-defined machine-readable data of this IP restriction. optional, max 4096 bytes.
        /// </summary>
        [Input("metadata")]
        public Input<string>? Metadata { get; set; }

        /// <summary>
        /// the type of IP restriction. this defines what traffic will be restricted with the attached policies. four values are currently supported: `dashboard`, `api`, `agent`, and `endpoints`
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public IpRestrictionArgs()
        {
        }
        public static new IpRestrictionArgs Empty => new IpRestrictionArgs();
    }

    public sealed class IpRestrictionState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// human-readable description of this IP restriction. optional, max 255 bytes.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// true if the IP restriction will be enforced. if false, only warnings will be issued
        /// </summary>
        [Input("enforced")]
        public Input<bool>? Enforced { get; set; }

        [Input("ipPolicyIds")]
        private InputList<string>? _ipPolicyIds;

        /// <summary>
        /// the set of IP policy identifiers that are used to enforce the restriction
        /// </summary>
        public InputList<string> IpPolicyIds
        {
            get => _ipPolicyIds ?? (_ipPolicyIds = new InputList<string>());
            set => _ipPolicyIds = value;
        }

        /// <summary>
        /// arbitrary user-defined machine-readable data of this IP restriction. optional, max 4096 bytes.
        /// </summary>
        [Input("metadata")]
        public Input<string>? Metadata { get; set; }

        /// <summary>
        /// the type of IP restriction. this defines what traffic will be restricted with the attached policies. four values are currently supported: `dashboard`, `api`, `agent`, and `endpoints`
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public IpRestrictionState()
        {
        }
        public static new IpRestrictionState Empty => new IpRestrictionState();
    }
}
