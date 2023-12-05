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

    public sealed class EventDestinationTargetKineseGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("auths")]
        private InputList<Inputs.EventDestinationTargetKineseAuthGetArgs>? _auths;

        /// <summary>
        /// Configuration for how to authenticate into your AWS account. Exactly one of `role` or `creds` should be configured.
        /// </summary>
        public InputList<Inputs.EventDestinationTargetKineseAuthGetArgs> Auths
        {
            get => _auths ?? (_auths = new InputList<Inputs.EventDestinationTargetKineseAuthGetArgs>());
            set => _auths = value;
        }

        /// <summary>
        /// An Amazon Resource Name specifying the Kinesis stream to deposit events into.
        /// </summary>
        [Input("streamArn")]
        public Input<string>? StreamArn { get; set; }

        public EventDestinationTargetKineseGetArgs()
        {
        }
        public static new EventDestinationTargetKineseGetArgs Empty => new EventDestinationTargetKineseGetArgs();
    }
}
