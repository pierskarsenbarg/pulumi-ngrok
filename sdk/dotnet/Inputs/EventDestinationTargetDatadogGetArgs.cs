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

    public sealed class EventDestinationTargetDatadogGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("apiKey")]
        public Input<string>? ApiKey { get; set; }

        [Input("ddsite")]
        public Input<string>? Ddsite { get; set; }

        [Input("ddtags")]
        public Input<string>? Ddtags { get; set; }

        [Input("service")]
        public Input<string>? Service { get; set; }

        public EventDestinationTargetDatadogGetArgs()
        {
        }
        public static new EventDestinationTargetDatadogGetArgs Empty => new EventDestinationTargetDatadogGetArgs();
    }
}
