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
    public sealed class EndpointConfigurationOauthProviderMicrosoft
    {
        public readonly string? ClientId;
        public readonly string? ClientSecret;
        public readonly ImmutableArray<string> EmailAddresses;
        public readonly ImmutableArray<string> EmailDomains;
        public readonly ImmutableArray<string> Scopes;

        [OutputConstructor]
        private EndpointConfigurationOauthProviderMicrosoft(
            string? clientId,

            string? clientSecret,

            ImmutableArray<string> emailAddresses,

            ImmutableArray<string> emailDomains,

            ImmutableArray<string> scopes)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            EmailAddresses = emailAddresses;
            EmailDomains = emailDomains;
            Scopes = scopes;
        }
    }
}
