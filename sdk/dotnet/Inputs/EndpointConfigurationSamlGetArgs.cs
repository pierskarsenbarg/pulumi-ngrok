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

    public sealed class EndpointConfigurationSamlGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// If true, the IdP may initiate a login directly (e.g. the user does not need to visit the endpoint first and then be redirected). The IdP should set the `RelayState` parameter to the target URL of the resource they want the user to be redirected to after the SAML login assertion has been processed.
        /// </summary>
        [Input("allowIdpInitiated")]
        public Input<bool>? AllowIdpInitiated { get; set; }

        /// <summary>
        /// The public URL of the SP's Assertion Consumer Service. This is where the IdP will redirect to during an authentication flow. This will need to be specified to the IdP as configuration.
        /// </summary>
        [Input("assertionConsumerServiceUrl")]
        public Input<string>? AssertionConsumerServiceUrl { get; set; }

        [Input("authorizedGroups")]
        private InputList<string>? _authorizedGroups;

        /// <summary>
        /// If present, only users who are a member of one of the listed groups may access the target endpoint.
        /// </summary>
        public InputList<string> AuthorizedGroups
        {
            get => _authorizedGroups ?? (_authorizedGroups = new InputList<string>());
            set => _authorizedGroups = value;
        }

        /// <summary>
        /// the prefix of the session cookie that ngrok sets on the http client to cache authentication. default is 'ngrok.'
        /// </summary>
        [Input("cookiePrefix")]
        public Input<string>? CookiePrefix { get; set; }

        /// <summary>
        /// `true` if the module will be applied to traffic, `false` to disable. default `true` if unspecified
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The SP Entity's unique ID. This always takes the form of a URL. In ngrok's implementation, this URL is the same as the metadata URL. This will need to be specified to the IdP as configuration.
        /// </summary>
        [Input("entityId")]
        public Input<string>? EntityId { get; set; }

        /// <summary>
        /// If true, indicates that whenever we redirect a user to the IdP for authentication that the IdP must prompt the user for authentication credentials even if the user already has a valid session with the IdP.
        /// </summary>
        [Input("forceAuthn")]
        public Input<bool>? ForceAuthn { get; set; }

        /// <summary>
        /// The full XML IdP EntityDescriptor. Your IdP may provide this to you as a a file to download or as a URL.
        /// </summary>
        [Input("idpMetadata")]
        public Input<string>? IdpMetadata { get; set; }

        /// <summary>
        /// The IdP's metadata URL which returns the XML IdP EntityDescriptor. The IdP's metadata URL specifies how to connect to the IdP as well as its public key which is then used to validate the signature on incoming SAML assertions to the ACS endpoint.
        /// </summary>
        [Input("idpMetadataUrl")]
        public Input<string>? IdpMetadataUrl { get; set; }

        /// <summary>
        /// Integer number of seconds of inactivity after which if the user has not accessed the endpoint, their session will time out and they will be forced to reauthenticate.
        /// </summary>
        [Input("inactivityTimeout")]
        public Input<int>? InactivityTimeout { get; set; }

        /// <summary>
        /// Integer number of seconds of the maximum duration of an authenticated session. After this period is exceeded, a user must reauthenticate.
        /// </summary>
        [Input("maximumDuration")]
        public Input<int>? MaximumDuration { get; set; }

        /// <summary>
        /// A public URL where the SP's metadata is hosted. If an IdP supports dynamic configuration, this is the URL it can use to retrieve the SP metadata.
        /// </summary>
        [Input("metadataUrl")]
        public Input<string>? MetadataUrl { get; set; }

        /// <summary>
        /// Defines the name identifier format the SP expects the IdP to use in its assertions to identify subjects. If unspecified, a default value of `urn:oasis:names:tc:SAML:2.0:nameid-format:persistent` will be used. A subset of the allowed values enumerated by the SAML specification are supported.
        /// </summary>
        [Input("nameidFormat")]
        public Input<string>? NameidFormat { get; set; }

        /// <summary>
        /// Do not enforce authentication on HTTP OPTIONS requests. necessary if you are supporting CORS.
        /// </summary>
        [Input("optionsPassthrough")]
        public Input<bool>? OptionsPassthrough { get; set; }

        /// <summary>
        /// PEM-encoded x.509 certificate of the key pair that is used to sign all SAML requests that the ngrok SP makes to the IdP. Many IdPs do not support request signing verification, but we highly recommend specifying this in the IdP's configuration if it is supported.
        /// </summary>
        [Input("requestSigningCertificatePem")]
        public Input<string>? RequestSigningCertificatePem { get; set; }

        /// <summary>
        /// The public URL of the SP's Single Logout Service. This is where the IdP will redirect to during a single logout flow. This will optionally need to be specified to the IdP as configuration.
        /// </summary>
        [Input("singleLogoutUrl")]
        public Input<string>? SingleLogoutUrl { get; set; }

        public EndpointConfigurationSamlGetArgs()
        {
        }
        public static new EndpointConfigurationSamlGetArgs Empty => new EndpointConfigurationSamlGetArgs();
    }
}
