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

    public sealed class EventDestinationTargetFirehoseAuthArgs : global::Pulumi.ResourceArgs
    {
        [Input("creds")]
        private InputList<Inputs.EventDestinationTargetFirehoseAuthCredArgs>? _creds;

        /// <summary>
        /// Credentials to your AWS account if you prefer ngrok to sign in with long-term access keys.
        /// </summary>
        public InputList<Inputs.EventDestinationTargetFirehoseAuthCredArgs> Creds
        {
            get => _creds ?? (_creds = new InputList<Inputs.EventDestinationTargetFirehoseAuthCredArgs>());
            set => _creds = value;
        }

        [Input("roles")]
        private InputList<Inputs.EventDestinationTargetFirehoseAuthRoleArgs>? _roles;

        /// <summary>
        /// A role for ngrok to assume on your behalf to deposit events into your AWS account.
        /// </summary>
        public InputList<Inputs.EventDestinationTargetFirehoseAuthRoleArgs> Roles
        {
            get => _roles ?? (_roles = new InputList<Inputs.EventDestinationTargetFirehoseAuthRoleArgs>());
            set => _roles = value;
        }

        public EventDestinationTargetFirehoseAuthArgs()
        {
        }
        public static new EventDestinationTargetFirehoseAuthArgs Empty => new EventDestinationTargetFirehoseAuthArgs();
    }
}
