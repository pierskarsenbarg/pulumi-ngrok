// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace PiersKarsenbarg.Ngrok.Inputs
{

    public sealed class EndpointConfigurationBackendGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("backends")]
        private InputList<Inputs.EndpointConfigurationBackendBackendGetArgs>? _backends;

        /// <summary>
        /// backend to be used to back this endpoint
        /// </summary>
        public InputList<Inputs.EndpointConfigurationBackendBackendGetArgs> Backends
        {
            get => _backends ?? (_backends = new InputList<Inputs.EndpointConfigurationBackendBackendGetArgs>());
            set => _backends = value;
        }

        /// <summary>
        /// `true` if the module will be applied to traffic, `false` to disable. default `true` if unspecified
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        public EndpointConfigurationBackendGetArgs()
        {
        }
        public static new EndpointConfigurationBackendGetArgs Empty => new EndpointConfigurationBackendGetArgs();
    }
}
