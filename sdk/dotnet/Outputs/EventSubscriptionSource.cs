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
    public sealed class EventSubscriptionSource
    {
        /// <summary>
        /// TODO
        /// </summary>
        public readonly ImmutableArray<string> Fields;
        /// <summary>
        /// TODO
        /// </summary>
        public readonly string? Filter;
        /// <summary>
        /// Type of event for which an event subscription will trigger
        /// </summary>
        public readonly string? Type;
        /// <summary>
        /// URI of the Event Source API resource.
        /// </summary>
        public readonly string? Uri;

        [OutputConstructor]
        private EventSubscriptionSource(
            ImmutableArray<string> fields,

            string? filter,

            string? type,

            string? uri)
        {
            Fields = fields;
            Filter = filter;
            Type = type;
            Uri = uri;
        }
    }
}
