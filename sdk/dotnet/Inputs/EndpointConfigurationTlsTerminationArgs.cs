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

    public sealed class EndpointConfigurationTlsTerminationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// `true` if the module will be applied to traffic, `false` to disable. default `true` if unspecified
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The minimum TLS version used for termination and advertised to the client during the TLS handshake. if unspecified, ngrok will choose an industry-safe default. This value must be null if `terminate_at` is set to `upstream`.
        /// </summary>
        [Input("minVersion")]
        public Input<string>? MinVersion { get; set; }

        /// <summary>
        /// `edge` if the ngrok edge should terminate TLS traffic, `upstream` if TLS traffic should be passed through to the upstream ngrok agent / application server for termination. if `upstream` is chosen, most other modules will be disallowed because they rely on the ngrok edge being able to access the underlying traffic.
        /// </summary>
        [Input("terminateAt")]
        public Input<string>? TerminateAt { get; set; }

        public EndpointConfigurationTlsTerminationArgs()
        {
        }
        public static new EndpointConfigurationTlsTerminationArgs Empty => new EndpointConfigurationTlsTerminationArgs();
    }
}
