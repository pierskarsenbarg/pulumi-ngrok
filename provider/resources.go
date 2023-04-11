// Copyright 2016-2018, Pulumi Corporation.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

package ngrok

import (
	"fmt"
	"path/filepath"

	"github.com/ngrok/terraform-provider-ngrok/ngrok"
	"github.com/pierskarsenbarg/pulumi-ngrok/provider/pkg/version"
	"github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfbridge"
	shim "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfshim"
	shimv2 "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfshim/sdk-v2"
	"github.com/pulumi/pulumi/sdk/v3/go/common/resource"
)

// all of the token components used below.
const (
	// This variable controls the default name of the package in the package
	// registries for nodejs and python:
	mainPkg = "ngrok"
	// modules:
	mainMod = "index" // the ngrok module
)

// preConfigureCallback is called before the providerConfigure function of the underlying provider.
// It should validate that the provider can be configured, and provide actionable errors in the case
// it cannot be. Configuration variables can be read from `vars` using the `stringValue` function -
// for example `stringValue(vars, "accessKey")`.
func preConfigureCallback(vars resource.PropertyMap, c shim.ResourceConfig) error {
	return nil
}

// Provider returns additional overlaid schema and metadata associated with the provider..
func Provider() tfbridge.ProviderInfo {
	// Instantiate the Terraform provider
	p := shimv2.NewProvider(ngrok.Provider())

	// Create a Pulumi provider mapping
	prov := tfbridge.ProviderInfo{
		P:    p,
		Name: "ngrok",
		// DisplayName is a way to be able to change the casing of the provider
		// name when being displayed on the Pulumi registry
		DisplayName: "ngrok",
		// The default publisher for all packages is Pulumi.
		// Change this to your personal name (or a company name) that you
		// would like to be shown in the Pulumi Registry if this package is published
		// there.
		Publisher: "Piers Karsenbarg",
		// LogoURL is optional but useful to help identify your package in the Pulumi Registry
		// if this package is published there.
		//
		// You may host a logo on a domain you control or add an SVG logo for your package
		// in your repository and use the raw content URL for that file as your logo URL.
		LogoURL: "",
		// PluginDownloadURL is an optional URL used to download the Provider
		// for use in Pulumi programs
		// e.g https://github.com/org/pulumi-provider-name/releases/
		PluginDownloadURL: "github://api.github.com/pierskarsenbarg/pulumi-ngrok",
		Description:       "A Pulumi package for creating and managing ngrok cloud resources.",
		// category/cloud tag helps with categorizing the package in the Pulumi Registry.
		// For all available categories, see `Keywords` in
		// https://www.pulumi.com/docs/guides/pulumi-packages/schema/#package.
		Keywords:   []string{"pulumi", "ngrok", "category/cloud"},
		License:    "Apache-2.0",
		Homepage:   "https://ngrok.com",
		Repository: "https://github.com/pierskarsenbarg/pulumi-ngrok",
		// The GitHub Org for the provider - defaults to `terraform-providers`. Note that this
		// should match the TF provider module's require directive, not any replace directives.
		GitHubOrg: "ngrok",
		Config:    map[string]*tfbridge.SchemaInfo{
			// Add any required configuration here, or remove the example below if
			// no additional points are required.
			// "region": {
			// 	Type: tfbridge.MakeType("region", "Region"),
			// 	Default: &tfbridge.DefaultInfo{
			// 		EnvVars: []string{"AWS_REGION", "AWS_DEFAULT_REGION"},
			// 	},
			// },
		},
		PreConfigureCallback: preConfigureCallback,
		Resources: map[string]*tfbridge.ResourceInfo{
			// Map each resource in the Terraform provider to a Pulumi type. Two examples
			// are below - the single line form is the common case. The multi-line form is
			// needed only if you wish to override types or other default options.
			//
			// "aws_iam_role": {Tok: tfbridge.MakeResource(mainPkg, mainMod, "IamRole")}
			//
			// "aws_acm_certificate": {
			// 	Tok: tfbridge.MakeResource(mainPkg, mainMod, "Certificate"),
			// 	Fields: map[string]*tfbridge.SchemaInfo{
			// 		"tags": {Type: tfbridge.MakeType(mainPkg, "Tags")},
			// 	},
			// },
			"ngrok_agent_ingress":             {Tok: tfbridge.MakeResource(mainPkg, mainMod, "AgentIngress")},
			"ngrok_api_key":                   {Tok: tfbridge.MakeResource(mainPkg, mainMod, "ApiKey")},
			"ngrok_certificate_authority":     {Tok: tfbridge.MakeResource(mainPkg, mainMod, "CertificateAuthority")},
			"ngrok_credential":                {Tok: tfbridge.MakeResource(mainPkg, mainMod, "Credential")},
			"ngrok_endpoint_configuration":    {Tok: tfbridge.MakeResource(mainPkg, mainMod, "EndpointConfiguration")},
			"ngrok_event_destination":         {Tok: tfbridge.MakeResource(mainPkg, mainMod, "EventDestination")},
			"ngrok_event_subscription":        {Tok: tfbridge.MakeResource(mainPkg, mainMod, "EventSubscription")},
			"ngrok_ip_policy":                 {Tok: tfbridge.MakeResource(mainPkg, mainMod, "IpPolicy")},
			"ngrok_ip_policy_rule":            {Tok: tfbridge.MakeResource(mainPkg, mainMod, "IpPolicyRule")},
			"ngrok_ip_restriction":            {Tok: tfbridge.MakeResource(mainPkg, mainMod, "IpRestriction")},
			"ngrok_reserved_addr":             {Tok: tfbridge.MakeResource(mainPkg, mainMod, "ReservedAddress")},
			"ngrok_reserved_domain":           {Tok: tfbridge.MakeResource(mainPkg, mainMod, "ReservedDomain")},
			"ngrok_ssh_certificate_authority": {Tok: tfbridge.MakeResource(mainPkg, mainMod, "SshCertificateAuthority")},
			"ngrok_ssh_credential":            {Tok: tfbridge.MakeResource(mainPkg, mainMod, "SshCredential")},
			"ngrok_ssh_host_certificate":      {Tok: tfbridge.MakeResource(mainPkg, mainMod, "SshHostCertificate")},
			"ngrok_ssh_user_certificate":      {Tok: tfbridge.MakeResource(mainPkg, mainMod, "SshUserCertificate")},
			"ngrok_tls_certificate":           {Tok: tfbridge.MakeResource(mainPkg, mainMod, "TlsCertificate")},
		},
		DataSources: map[string]*tfbridge.DataSourceInfo{
			// Map each resource in the Terraform provider to a Pulumi function. An example
			// is below.
			// "aws_ami": {Tok: tfbridge.MakeDataSource(mainPkg, mainMod, "getAmi")},
		},
		JavaScript: &tfbridge.JavaScriptInfo{
			// List any npm dependencies and their versions
			Dependencies: map[string]string{
				"@pulumi/pulumi": "^3.0.0",
			},
			DevDependencies: map[string]string{
				"@types/node": "^10.0.0", // so we can access strongly typed node definitions.
				"@types/mime": "^2.0.0",
			},
			PackageName: "@pierskarsenbarg/pulumi-ngrok",
			// See the documentation for tfbridge.OverlayInfo for how to lay out this
			// section, or refer to the AWS provider. Delete this section if there are
			// no overlay files.
			//Overlay: &tfbridge.OverlayInfo{},
		},
		Python: &tfbridge.PythonInfo{
			// List any Python dependencies and their version ranges
			Requires: map[string]string{
				"pulumi": ">=3.0.0,<4.0.0",
			},
		},
		Golang: &tfbridge.GolangInfo{
			ImportBasePath: filepath.Join(
				fmt.Sprintf("github.com/pulumi/pulumi-%[1]s/sdk/", mainPkg),
				tfbridge.GetModuleMajorVersion(version.Version),
				"go",
				mainPkg,
			),
			GenerateResourceContainerTypes: true,
		},
		CSharp: &tfbridge.CSharpInfo{
			RootNamespace: "PiersKarsenbarg",
			PackageReferences: map[string]string{
				"Pulumi": "3.*",
			},
		},
	}

	prov.SetAutonaming(255, "-")

	return prov
}
