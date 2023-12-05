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

    public sealed class EndpointConfigurationOauthProviderGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("facebooks")]
        private InputList<Inputs.EndpointConfigurationOauthProviderFacebookGetArgs>? _facebooks;

        /// <summary>
        /// configuration for using facebook as the identity provider
        /// </summary>
        public InputList<Inputs.EndpointConfigurationOauthProviderFacebookGetArgs> Facebooks
        {
            get => _facebooks ?? (_facebooks = new InputList<Inputs.EndpointConfigurationOauthProviderFacebookGetArgs>());
            set => _facebooks = value;
        }

        [Input("githubs")]
        private InputList<Inputs.EndpointConfigurationOauthProviderGithubGetArgs>? _githubs;

        /// <summary>
        /// configuration for using github as the identity provider
        /// </summary>
        public InputList<Inputs.EndpointConfigurationOauthProviderGithubGetArgs> Githubs
        {
            get => _githubs ?? (_githubs = new InputList<Inputs.EndpointConfigurationOauthProviderGithubGetArgs>());
            set => _githubs = value;
        }

        [Input("googles")]
        private InputList<Inputs.EndpointConfigurationOauthProviderGoogleGetArgs>? _googles;

        /// <summary>
        /// configuration for using google as the identity provider
        /// </summary>
        public InputList<Inputs.EndpointConfigurationOauthProviderGoogleGetArgs> Googles
        {
            get => _googles ?? (_googles = new InputList<Inputs.EndpointConfigurationOauthProviderGoogleGetArgs>());
            set => _googles = value;
        }

        [Input("microsofts")]
        private InputList<Inputs.EndpointConfigurationOauthProviderMicrosoftGetArgs>? _microsofts;

        /// <summary>
        /// configuration for using microsoft as the identity provider
        /// </summary>
        public InputList<Inputs.EndpointConfigurationOauthProviderMicrosoftGetArgs> Microsofts
        {
            get => _microsofts ?? (_microsofts = new InputList<Inputs.EndpointConfigurationOauthProviderMicrosoftGetArgs>());
            set => _microsofts = value;
        }

        public EndpointConfigurationOauthProviderGetArgs()
        {
        }
        public static new EndpointConfigurationOauthProviderGetArgs Empty => new EndpointConfigurationOauthProviderGetArgs();
    }
}
