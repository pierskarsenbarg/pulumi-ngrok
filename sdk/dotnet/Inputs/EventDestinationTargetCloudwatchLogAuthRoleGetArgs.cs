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

    public sealed class EventDestinationTargetCloudwatchLogAuthRoleGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("roleArn", required: true)]
        public Input<string> RoleArn { get; set; } = null!;

        public EventDestinationTargetCloudwatchLogAuthRoleGetArgs()
        {
        }
        public static new EventDestinationTargetCloudwatchLogAuthRoleGetArgs Empty => new EventDestinationTargetCloudwatchLogAuthRoleGetArgs();
    }
}
