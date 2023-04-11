// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package ngrok

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Reserved Domains are hostnames that you can listen for traffic on. Domains
//
//	can be used to listen for http, https or tls traffic. You may use a domain
//	that you own by creating a CNAME record specified in the returned resource.
//	This CNAME record points traffic for that domain to ngrok's edge servers.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi-ngrok/sdk/go/ngrok"
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := ngrok.NewReservedDomain(ctx, "example", &ngrok.ReservedDomainArgs{
//				CertificateId: pulumi.String("cert_25auGELSEngiae3wzmLLesiZn8h"),
//				Region:        pulumi.String("us"),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
type ReservedDomain struct {
	pulumi.CustomResourceState

	// DNS CNAME target for the host _acme-challenge.example.com, where example.com is your reserved domain name. This is required to issue certificates for wildcard, non-ngrok reserved domains. Must be null for non-wildcard domains and ngrok subdomains.
	AcmeChallengeCnameTarget pulumi.StringOutput `pulumi:"acmeChallengeCnameTarget"`
	// ID of a user-uploaded TLS certificate to use for connections to targeting this domain. Optional, mutually exclusive with `certificateManagementPolicy`.
	CertificateId pulumi.StringPtrOutput `pulumi:"certificateId"`
	// configuration for automatic management of TLS certificates for this domain, or null if automatic management is disabled
	CertificateManagementPolicies ReservedDomainCertificateManagementPolicyArrayOutput `pulumi:"certificateManagementPolicies"`
	// DNS CNAME target for a custom hostname, or null if the reserved domain is a subdomain of *.ngrok.io
	CnameTarget pulumi.StringOutput `pulumi:"cnameTarget"`
	// human-readable description of what this reserved domain will be used for
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// hostname of the reserved domain
	Domain pulumi.StringOutput `pulumi:"domain"`
	// ID of an endpoint configuration of type http that will be used to handle inbound http traffic to this domain
	HttpEndpointConfigurationId pulumi.StringPtrOutput `pulumi:"httpEndpointConfigurationId"`
	// ID of an endpoint configuration of type https that will be used to handle inbound https traffic to this domain
	HttpsEndpointConfigurationId pulumi.StringPtrOutput `pulumi:"httpsEndpointConfigurationId"`
	// arbitrary user-defined machine-readable data of this reserved domain. Optional, max 4096 bytes.
	Metadata pulumi.StringPtrOutput `pulumi:"metadata"`
	// the domain name to reserve. It may be a full domain name like app.example.com. If the name does not contain a '.' it will reserve that subdomain on ngrok.io.
	Name pulumi.StringOutput `pulumi:"name"`
	// reserve the domain in this geographic ngrok datacenter. Optional, default is us. (au, eu, ap, us, jp, in, sa)
	Region pulumi.StringPtrOutput `pulumi:"region"`
}

// NewReservedDomain registers a new resource with the given unique name, arguments, and options.
func NewReservedDomain(ctx *pulumi.Context,
	name string, args *ReservedDomainArgs, opts ...pulumi.ResourceOption) (*ReservedDomain, error) {
	if args == nil {
		args = &ReservedDomainArgs{}
	}

	opts = pkgResourceDefaultOpts(opts)
	var resource ReservedDomain
	err := ctx.RegisterResource("ngrok:index/reservedDomain:ReservedDomain", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetReservedDomain gets an existing ReservedDomain resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetReservedDomain(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ReservedDomainState, opts ...pulumi.ResourceOption) (*ReservedDomain, error) {
	var resource ReservedDomain
	err := ctx.ReadResource("ngrok:index/reservedDomain:ReservedDomain", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ReservedDomain resources.
type reservedDomainState struct {
	// DNS CNAME target for the host _acme-challenge.example.com, where example.com is your reserved domain name. This is required to issue certificates for wildcard, non-ngrok reserved domains. Must be null for non-wildcard domains and ngrok subdomains.
	AcmeChallengeCnameTarget *string `pulumi:"acmeChallengeCnameTarget"`
	// ID of a user-uploaded TLS certificate to use for connections to targeting this domain. Optional, mutually exclusive with `certificateManagementPolicy`.
	CertificateId *string `pulumi:"certificateId"`
	// configuration for automatic management of TLS certificates for this domain, or null if automatic management is disabled
	CertificateManagementPolicies []ReservedDomainCertificateManagementPolicy `pulumi:"certificateManagementPolicies"`
	// DNS CNAME target for a custom hostname, or null if the reserved domain is a subdomain of *.ngrok.io
	CnameTarget *string `pulumi:"cnameTarget"`
	// human-readable description of what this reserved domain will be used for
	Description *string `pulumi:"description"`
	// hostname of the reserved domain
	Domain *string `pulumi:"domain"`
	// ID of an endpoint configuration of type http that will be used to handle inbound http traffic to this domain
	HttpEndpointConfigurationId *string `pulumi:"httpEndpointConfigurationId"`
	// ID of an endpoint configuration of type https that will be used to handle inbound https traffic to this domain
	HttpsEndpointConfigurationId *string `pulumi:"httpsEndpointConfigurationId"`
	// arbitrary user-defined machine-readable data of this reserved domain. Optional, max 4096 bytes.
	Metadata *string `pulumi:"metadata"`
	// the domain name to reserve. It may be a full domain name like app.example.com. If the name does not contain a '.' it will reserve that subdomain on ngrok.io.
	Name *string `pulumi:"name"`
	// reserve the domain in this geographic ngrok datacenter. Optional, default is us. (au, eu, ap, us, jp, in, sa)
	Region *string `pulumi:"region"`
}

type ReservedDomainState struct {
	// DNS CNAME target for the host _acme-challenge.example.com, where example.com is your reserved domain name. This is required to issue certificates for wildcard, non-ngrok reserved domains. Must be null for non-wildcard domains and ngrok subdomains.
	AcmeChallengeCnameTarget pulumi.StringPtrInput
	// ID of a user-uploaded TLS certificate to use for connections to targeting this domain. Optional, mutually exclusive with `certificateManagementPolicy`.
	CertificateId pulumi.StringPtrInput
	// configuration for automatic management of TLS certificates for this domain, or null if automatic management is disabled
	CertificateManagementPolicies ReservedDomainCertificateManagementPolicyArrayInput
	// DNS CNAME target for a custom hostname, or null if the reserved domain is a subdomain of *.ngrok.io
	CnameTarget pulumi.StringPtrInput
	// human-readable description of what this reserved domain will be used for
	Description pulumi.StringPtrInput
	// hostname of the reserved domain
	Domain pulumi.StringPtrInput
	// ID of an endpoint configuration of type http that will be used to handle inbound http traffic to this domain
	HttpEndpointConfigurationId pulumi.StringPtrInput
	// ID of an endpoint configuration of type https that will be used to handle inbound https traffic to this domain
	HttpsEndpointConfigurationId pulumi.StringPtrInput
	// arbitrary user-defined machine-readable data of this reserved domain. Optional, max 4096 bytes.
	Metadata pulumi.StringPtrInput
	// the domain name to reserve. It may be a full domain name like app.example.com. If the name does not contain a '.' it will reserve that subdomain on ngrok.io.
	Name pulumi.StringPtrInput
	// reserve the domain in this geographic ngrok datacenter. Optional, default is us. (au, eu, ap, us, jp, in, sa)
	Region pulumi.StringPtrInput
}

func (ReservedDomainState) ElementType() reflect.Type {
	return reflect.TypeOf((*reservedDomainState)(nil)).Elem()
}

type reservedDomainArgs struct {
	// DNS CNAME target for the host _acme-challenge.example.com, where example.com is your reserved domain name. This is required to issue certificates for wildcard, non-ngrok reserved domains. Must be null for non-wildcard domains and ngrok subdomains.
	AcmeChallengeCnameTarget *string `pulumi:"acmeChallengeCnameTarget"`
	// ID of a user-uploaded TLS certificate to use for connections to targeting this domain. Optional, mutually exclusive with `certificateManagementPolicy`.
	CertificateId *string `pulumi:"certificateId"`
	// configuration for automatic management of TLS certificates for this domain, or null if automatic management is disabled
	CertificateManagementPolicies []ReservedDomainCertificateManagementPolicy `pulumi:"certificateManagementPolicies"`
	// DNS CNAME target for a custom hostname, or null if the reserved domain is a subdomain of *.ngrok.io
	CnameTarget *string `pulumi:"cnameTarget"`
	// human-readable description of what this reserved domain will be used for
	Description *string `pulumi:"description"`
	// ID of an endpoint configuration of type http that will be used to handle inbound http traffic to this domain
	HttpEndpointConfigurationId *string `pulumi:"httpEndpointConfigurationId"`
	// ID of an endpoint configuration of type https that will be used to handle inbound https traffic to this domain
	HttpsEndpointConfigurationId *string `pulumi:"httpsEndpointConfigurationId"`
	// arbitrary user-defined machine-readable data of this reserved domain. Optional, max 4096 bytes.
	Metadata *string `pulumi:"metadata"`
	// the domain name to reserve. It may be a full domain name like app.example.com. If the name does not contain a '.' it will reserve that subdomain on ngrok.io.
	Name *string `pulumi:"name"`
	// reserve the domain in this geographic ngrok datacenter. Optional, default is us. (au, eu, ap, us, jp, in, sa)
	Region *string `pulumi:"region"`
}

// The set of arguments for constructing a ReservedDomain resource.
type ReservedDomainArgs struct {
	// DNS CNAME target for the host _acme-challenge.example.com, where example.com is your reserved domain name. This is required to issue certificates for wildcard, non-ngrok reserved domains. Must be null for non-wildcard domains and ngrok subdomains.
	AcmeChallengeCnameTarget pulumi.StringPtrInput
	// ID of a user-uploaded TLS certificate to use for connections to targeting this domain. Optional, mutually exclusive with `certificateManagementPolicy`.
	CertificateId pulumi.StringPtrInput
	// configuration for automatic management of TLS certificates for this domain, or null if automatic management is disabled
	CertificateManagementPolicies ReservedDomainCertificateManagementPolicyArrayInput
	// DNS CNAME target for a custom hostname, or null if the reserved domain is a subdomain of *.ngrok.io
	CnameTarget pulumi.StringPtrInput
	// human-readable description of what this reserved domain will be used for
	Description pulumi.StringPtrInput
	// ID of an endpoint configuration of type http that will be used to handle inbound http traffic to this domain
	HttpEndpointConfigurationId pulumi.StringPtrInput
	// ID of an endpoint configuration of type https that will be used to handle inbound https traffic to this domain
	HttpsEndpointConfigurationId pulumi.StringPtrInput
	// arbitrary user-defined machine-readable data of this reserved domain. Optional, max 4096 bytes.
	Metadata pulumi.StringPtrInput
	// the domain name to reserve. It may be a full domain name like app.example.com. If the name does not contain a '.' it will reserve that subdomain on ngrok.io.
	Name pulumi.StringPtrInput
	// reserve the domain in this geographic ngrok datacenter. Optional, default is us. (au, eu, ap, us, jp, in, sa)
	Region pulumi.StringPtrInput
}

func (ReservedDomainArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*reservedDomainArgs)(nil)).Elem()
}

type ReservedDomainInput interface {
	pulumi.Input

	ToReservedDomainOutput() ReservedDomainOutput
	ToReservedDomainOutputWithContext(ctx context.Context) ReservedDomainOutput
}

func (*ReservedDomain) ElementType() reflect.Type {
	return reflect.TypeOf((**ReservedDomain)(nil)).Elem()
}

func (i *ReservedDomain) ToReservedDomainOutput() ReservedDomainOutput {
	return i.ToReservedDomainOutputWithContext(context.Background())
}

func (i *ReservedDomain) ToReservedDomainOutputWithContext(ctx context.Context) ReservedDomainOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ReservedDomainOutput)
}

// ReservedDomainArrayInput is an input type that accepts ReservedDomainArray and ReservedDomainArrayOutput values.
// You can construct a concrete instance of `ReservedDomainArrayInput` via:
//
//	ReservedDomainArray{ ReservedDomainArgs{...} }
type ReservedDomainArrayInput interface {
	pulumi.Input

	ToReservedDomainArrayOutput() ReservedDomainArrayOutput
	ToReservedDomainArrayOutputWithContext(context.Context) ReservedDomainArrayOutput
}

type ReservedDomainArray []ReservedDomainInput

func (ReservedDomainArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ReservedDomain)(nil)).Elem()
}

func (i ReservedDomainArray) ToReservedDomainArrayOutput() ReservedDomainArrayOutput {
	return i.ToReservedDomainArrayOutputWithContext(context.Background())
}

func (i ReservedDomainArray) ToReservedDomainArrayOutputWithContext(ctx context.Context) ReservedDomainArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ReservedDomainArrayOutput)
}

// ReservedDomainMapInput is an input type that accepts ReservedDomainMap and ReservedDomainMapOutput values.
// You can construct a concrete instance of `ReservedDomainMapInput` via:
//
//	ReservedDomainMap{ "key": ReservedDomainArgs{...} }
type ReservedDomainMapInput interface {
	pulumi.Input

	ToReservedDomainMapOutput() ReservedDomainMapOutput
	ToReservedDomainMapOutputWithContext(context.Context) ReservedDomainMapOutput
}

type ReservedDomainMap map[string]ReservedDomainInput

func (ReservedDomainMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ReservedDomain)(nil)).Elem()
}

func (i ReservedDomainMap) ToReservedDomainMapOutput() ReservedDomainMapOutput {
	return i.ToReservedDomainMapOutputWithContext(context.Background())
}

func (i ReservedDomainMap) ToReservedDomainMapOutputWithContext(ctx context.Context) ReservedDomainMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ReservedDomainMapOutput)
}

type ReservedDomainOutput struct{ *pulumi.OutputState }

func (ReservedDomainOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ReservedDomain)(nil)).Elem()
}

func (o ReservedDomainOutput) ToReservedDomainOutput() ReservedDomainOutput {
	return o
}

func (o ReservedDomainOutput) ToReservedDomainOutputWithContext(ctx context.Context) ReservedDomainOutput {
	return o
}

// DNS CNAME target for the host _acme-challenge.example.com, where example.com is your reserved domain name. This is required to issue certificates for wildcard, non-ngrok reserved domains. Must be null for non-wildcard domains and ngrok subdomains.
func (o ReservedDomainOutput) AcmeChallengeCnameTarget() pulumi.StringOutput {
	return o.ApplyT(func(v *ReservedDomain) pulumi.StringOutput { return v.AcmeChallengeCnameTarget }).(pulumi.StringOutput)
}

// ID of a user-uploaded TLS certificate to use for connections to targeting this domain. Optional, mutually exclusive with `certificateManagementPolicy`.
func (o ReservedDomainOutput) CertificateId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ReservedDomain) pulumi.StringPtrOutput { return v.CertificateId }).(pulumi.StringPtrOutput)
}

// configuration for automatic management of TLS certificates for this domain, or null if automatic management is disabled
func (o ReservedDomainOutput) CertificateManagementPolicies() ReservedDomainCertificateManagementPolicyArrayOutput {
	return o.ApplyT(func(v *ReservedDomain) ReservedDomainCertificateManagementPolicyArrayOutput {
		return v.CertificateManagementPolicies
	}).(ReservedDomainCertificateManagementPolicyArrayOutput)
}

// DNS CNAME target for a custom hostname, or null if the reserved domain is a subdomain of *.ngrok.io
func (o ReservedDomainOutput) CnameTarget() pulumi.StringOutput {
	return o.ApplyT(func(v *ReservedDomain) pulumi.StringOutput { return v.CnameTarget }).(pulumi.StringOutput)
}

// human-readable description of what this reserved domain will be used for
func (o ReservedDomainOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ReservedDomain) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// hostname of the reserved domain
func (o ReservedDomainOutput) Domain() pulumi.StringOutput {
	return o.ApplyT(func(v *ReservedDomain) pulumi.StringOutput { return v.Domain }).(pulumi.StringOutput)
}

// ID of an endpoint configuration of type http that will be used to handle inbound http traffic to this domain
func (o ReservedDomainOutput) HttpEndpointConfigurationId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ReservedDomain) pulumi.StringPtrOutput { return v.HttpEndpointConfigurationId }).(pulumi.StringPtrOutput)
}

// ID of an endpoint configuration of type https that will be used to handle inbound https traffic to this domain
func (o ReservedDomainOutput) HttpsEndpointConfigurationId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ReservedDomain) pulumi.StringPtrOutput { return v.HttpsEndpointConfigurationId }).(pulumi.StringPtrOutput)
}

// arbitrary user-defined machine-readable data of this reserved domain. Optional, max 4096 bytes.
func (o ReservedDomainOutput) Metadata() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ReservedDomain) pulumi.StringPtrOutput { return v.Metadata }).(pulumi.StringPtrOutput)
}

// the domain name to reserve. It may be a full domain name like app.example.com. If the name does not contain a '.' it will reserve that subdomain on ngrok.io.
func (o ReservedDomainOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *ReservedDomain) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// reserve the domain in this geographic ngrok datacenter. Optional, default is us. (au, eu, ap, us, jp, in, sa)
func (o ReservedDomainOutput) Region() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ReservedDomain) pulumi.StringPtrOutput { return v.Region }).(pulumi.StringPtrOutput)
}

type ReservedDomainArrayOutput struct{ *pulumi.OutputState }

func (ReservedDomainArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ReservedDomain)(nil)).Elem()
}

func (o ReservedDomainArrayOutput) ToReservedDomainArrayOutput() ReservedDomainArrayOutput {
	return o
}

func (o ReservedDomainArrayOutput) ToReservedDomainArrayOutputWithContext(ctx context.Context) ReservedDomainArrayOutput {
	return o
}

func (o ReservedDomainArrayOutput) Index(i pulumi.IntInput) ReservedDomainOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ReservedDomain {
		return vs[0].([]*ReservedDomain)[vs[1].(int)]
	}).(ReservedDomainOutput)
}

type ReservedDomainMapOutput struct{ *pulumi.OutputState }

func (ReservedDomainMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ReservedDomain)(nil)).Elem()
}

func (o ReservedDomainMapOutput) ToReservedDomainMapOutput() ReservedDomainMapOutput {
	return o
}

func (o ReservedDomainMapOutput) ToReservedDomainMapOutputWithContext(ctx context.Context) ReservedDomainMapOutput {
	return o
}

func (o ReservedDomainMapOutput) MapIndex(k pulumi.StringInput) ReservedDomainOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ReservedDomain {
		return vs[0].(map[string]*ReservedDomain)[vs[1].(string)]
	}).(ReservedDomainOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ReservedDomainInput)(nil)).Elem(), &ReservedDomain{})
	pulumi.RegisterInputType(reflect.TypeOf((*ReservedDomainArrayInput)(nil)).Elem(), ReservedDomainArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ReservedDomainMapInput)(nil)).Elem(), ReservedDomainMap{})
	pulumi.RegisterOutputType(ReservedDomainOutput{})
	pulumi.RegisterOutputType(ReservedDomainArrayOutput{})
	pulumi.RegisterOutputType(ReservedDomainMapOutput{})
}
