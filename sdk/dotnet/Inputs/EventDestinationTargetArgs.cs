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

    public sealed class EventDestinationTargetArgs : global::Pulumi.ResourceArgs
    {
        [Input("cloudwatchLogs")]
        private InputList<Inputs.EventDestinationTargetCloudwatchLogArgs>? _cloudwatchLogs;

        /// <summary>
        /// Configuration used to send events to Amazon CloudWatch Logs.
        /// </summary>
        public InputList<Inputs.EventDestinationTargetCloudwatchLogArgs> CloudwatchLogs
        {
            get => _cloudwatchLogs ?? (_cloudwatchLogs = new InputList<Inputs.EventDestinationTargetCloudwatchLogArgs>());
            set => _cloudwatchLogs = value;
        }

        [Input("debugs")]
        private InputList<Inputs.EventDestinationTargetDebugArgs>? _debugs;

        /// <summary>
        /// Configuration used for internal debugging.
        /// </summary>
        public InputList<Inputs.EventDestinationTargetDebugArgs> Debugs
        {
            get => _debugs ?? (_debugs = new InputList<Inputs.EventDestinationTargetDebugArgs>());
            set => _debugs = value;
        }

        [Input("firehoses")]
        private InputList<Inputs.EventDestinationTargetFirehoseArgs>? _firehoses;

        /// <summary>
        /// Configuration used to send events to Amazon Kinesis Data Firehose.
        /// </summary>
        public InputList<Inputs.EventDestinationTargetFirehoseArgs> Firehoses
        {
            get => _firehoses ?? (_firehoses = new InputList<Inputs.EventDestinationTargetFirehoseArgs>());
            set => _firehoses = value;
        }

        [Input("kineses")]
        private InputList<Inputs.EventDestinationTargetKineseArgs>? _kineses;

        /// <summary>
        /// Configuration used to send events to Amazon Kinesis.
        /// </summary>
        public InputList<Inputs.EventDestinationTargetKineseArgs> Kineses
        {
            get => _kineses ?? (_kineses = new InputList<Inputs.EventDestinationTargetKineseArgs>());
            set => _kineses = value;
        }

        public EventDestinationTargetArgs()
        {
        }
        public static new EventDestinationTargetArgs Empty => new EventDestinationTargetArgs();
    }
}
