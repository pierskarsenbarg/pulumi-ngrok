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

    public sealed class EventDestinationTargetKineseArgs : global::Pulumi.ResourceArgs
    {
        [Input("auths")]
        private InputList<Inputs.EventDestinationTargetKineseAuthArgs>? _auths;
        public InputList<Inputs.EventDestinationTargetKineseAuthArgs> Auths
        {
            get => _auths ?? (_auths = new InputList<Inputs.EventDestinationTargetKineseAuthArgs>());
            set => _auths = value;
        }

        [Input("streamArn")]
        public Input<string>? StreamArn { get; set; }

        public EventDestinationTargetKineseArgs()
        {
        }
        public static new EventDestinationTargetKineseArgs Empty => new EventDestinationTargetKineseArgs();
    }
}
