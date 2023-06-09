// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Ngrok.Outputs
{

    [OutputType]
    public sealed class EndpointConfigurationBackend
    {
        /// <summary>
        /// backend to be used to back this endpoint
        /// </summary>
        public readonly ImmutableArray<Outputs.EndpointConfigurationBackendBackend> Backends;
        /// <summary>
        /// `true` if the module will be applied to traffic, `false` to disable. default `true` if unspecified
        /// </summary>
        public readonly bool? Enabled;

        [OutputConstructor]
        private EndpointConfigurationBackend(
            ImmutableArray<Outputs.EndpointConfigurationBackendBackend> backends,

            bool? enabled)
        {
            Backends = backends;
            Enabled = enabled;
        }
    }
}
