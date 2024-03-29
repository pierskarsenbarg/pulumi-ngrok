// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package ngrok

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi-ngrok/sdk/go/ngrok/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumix"
)

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
//			_, err := ngrok.NewAgentIngress(ctx, "example", &ngrok.AgentIngressArgs{
//				Description: pulumi.String("acme devices"),
//				Domain:      pulumi.String("connect.acme.com"),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
type AgentIngress struct {
	pulumi.CustomResourceState

	// timestamp when the Agent Ingress was created, RFC 3339 format
	CreatedAt pulumi.StringOutput `pulumi:"createdAt"`
	// human-readable description of the use of this Agent Ingress. optional, max 255 bytes.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// the domain that you own to be used as the base domain name to generate regional agent ingress domains.
	Domain pulumi.StringOutput `pulumi:"domain"`
	// arbitrary user-defined machine-readable data of this Agent Ingress. optional, max 4096 bytes
	Metadata pulumi.StringPtrOutput `pulumi:"metadata"`
	// a list of target values to use as the values of NS records for the domain property these values will delegate control over the domain to ngrok
	NsTargets pulumi.StringArrayOutput `pulumi:"nsTargets"`
	// a list of regional agent ingress domains that are subdomains of the value of domain this value may increase over time as ngrok adds more regions
	RegionDomains pulumi.StringArrayOutput `pulumi:"regionDomains"`
	// URI to the API resource of this Agent ingress
	Uri pulumi.StringOutput `pulumi:"uri"`
}

// NewAgentIngress registers a new resource with the given unique name, arguments, and options.
func NewAgentIngress(ctx *pulumi.Context,
	name string, args *AgentIngressArgs, opts ...pulumi.ResourceOption) (*AgentIngress, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Domain == nil {
		return nil, errors.New("invalid value for required argument 'Domain'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource AgentIngress
	err := ctx.RegisterResource("ngrok:index/agentIngress:AgentIngress", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAgentIngress gets an existing AgentIngress resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAgentIngress(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AgentIngressState, opts ...pulumi.ResourceOption) (*AgentIngress, error) {
	var resource AgentIngress
	err := ctx.ReadResource("ngrok:index/agentIngress:AgentIngress", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AgentIngress resources.
type agentIngressState struct {
	// timestamp when the Agent Ingress was created, RFC 3339 format
	CreatedAt *string `pulumi:"createdAt"`
	// human-readable description of the use of this Agent Ingress. optional, max 255 bytes.
	Description *string `pulumi:"description"`
	// the domain that you own to be used as the base domain name to generate regional agent ingress domains.
	Domain *string `pulumi:"domain"`
	// arbitrary user-defined machine-readable data of this Agent Ingress. optional, max 4096 bytes
	Metadata *string `pulumi:"metadata"`
	// a list of target values to use as the values of NS records for the domain property these values will delegate control over the domain to ngrok
	NsTargets []string `pulumi:"nsTargets"`
	// a list of regional agent ingress domains that are subdomains of the value of domain this value may increase over time as ngrok adds more regions
	RegionDomains []string `pulumi:"regionDomains"`
	// URI to the API resource of this Agent ingress
	Uri *string `pulumi:"uri"`
}

type AgentIngressState struct {
	// timestamp when the Agent Ingress was created, RFC 3339 format
	CreatedAt pulumi.StringPtrInput
	// human-readable description of the use of this Agent Ingress. optional, max 255 bytes.
	Description pulumi.StringPtrInput
	// the domain that you own to be used as the base domain name to generate regional agent ingress domains.
	Domain pulumi.StringPtrInput
	// arbitrary user-defined machine-readable data of this Agent Ingress. optional, max 4096 bytes
	Metadata pulumi.StringPtrInput
	// a list of target values to use as the values of NS records for the domain property these values will delegate control over the domain to ngrok
	NsTargets pulumi.StringArrayInput
	// a list of regional agent ingress domains that are subdomains of the value of domain this value may increase over time as ngrok adds more regions
	RegionDomains pulumi.StringArrayInput
	// URI to the API resource of this Agent ingress
	Uri pulumi.StringPtrInput
}

func (AgentIngressState) ElementType() reflect.Type {
	return reflect.TypeOf((*agentIngressState)(nil)).Elem()
}

type agentIngressArgs struct {
	// human-readable description of the use of this Agent Ingress. optional, max 255 bytes.
	Description *string `pulumi:"description"`
	// the domain that you own to be used as the base domain name to generate regional agent ingress domains.
	Domain string `pulumi:"domain"`
	// arbitrary user-defined machine-readable data of this Agent Ingress. optional, max 4096 bytes
	Metadata *string `pulumi:"metadata"`
	// URI to the API resource of this Agent ingress
	Uri *string `pulumi:"uri"`
}

// The set of arguments for constructing a AgentIngress resource.
type AgentIngressArgs struct {
	// human-readable description of the use of this Agent Ingress. optional, max 255 bytes.
	Description pulumi.StringPtrInput
	// the domain that you own to be used as the base domain name to generate regional agent ingress domains.
	Domain pulumi.StringInput
	// arbitrary user-defined machine-readable data of this Agent Ingress. optional, max 4096 bytes
	Metadata pulumi.StringPtrInput
	// URI to the API resource of this Agent ingress
	Uri pulumi.StringPtrInput
}

func (AgentIngressArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*agentIngressArgs)(nil)).Elem()
}

type AgentIngressInput interface {
	pulumi.Input

	ToAgentIngressOutput() AgentIngressOutput
	ToAgentIngressOutputWithContext(ctx context.Context) AgentIngressOutput
}

func (*AgentIngress) ElementType() reflect.Type {
	return reflect.TypeOf((**AgentIngress)(nil)).Elem()
}

func (i *AgentIngress) ToAgentIngressOutput() AgentIngressOutput {
	return i.ToAgentIngressOutputWithContext(context.Background())
}

func (i *AgentIngress) ToAgentIngressOutputWithContext(ctx context.Context) AgentIngressOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AgentIngressOutput)
}

func (i *AgentIngress) ToOutput(ctx context.Context) pulumix.Output[*AgentIngress] {
	return pulumix.Output[*AgentIngress]{
		OutputState: i.ToAgentIngressOutputWithContext(ctx).OutputState,
	}
}

// AgentIngressArrayInput is an input type that accepts AgentIngressArray and AgentIngressArrayOutput values.
// You can construct a concrete instance of `AgentIngressArrayInput` via:
//
//	AgentIngressArray{ AgentIngressArgs{...} }
type AgentIngressArrayInput interface {
	pulumi.Input

	ToAgentIngressArrayOutput() AgentIngressArrayOutput
	ToAgentIngressArrayOutputWithContext(context.Context) AgentIngressArrayOutput
}

type AgentIngressArray []AgentIngressInput

func (AgentIngressArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AgentIngress)(nil)).Elem()
}

func (i AgentIngressArray) ToAgentIngressArrayOutput() AgentIngressArrayOutput {
	return i.ToAgentIngressArrayOutputWithContext(context.Background())
}

func (i AgentIngressArray) ToAgentIngressArrayOutputWithContext(ctx context.Context) AgentIngressArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AgentIngressArrayOutput)
}

func (i AgentIngressArray) ToOutput(ctx context.Context) pulumix.Output[[]*AgentIngress] {
	return pulumix.Output[[]*AgentIngress]{
		OutputState: i.ToAgentIngressArrayOutputWithContext(ctx).OutputState,
	}
}

// AgentIngressMapInput is an input type that accepts AgentIngressMap and AgentIngressMapOutput values.
// You can construct a concrete instance of `AgentIngressMapInput` via:
//
//	AgentIngressMap{ "key": AgentIngressArgs{...} }
type AgentIngressMapInput interface {
	pulumi.Input

	ToAgentIngressMapOutput() AgentIngressMapOutput
	ToAgentIngressMapOutputWithContext(context.Context) AgentIngressMapOutput
}

type AgentIngressMap map[string]AgentIngressInput

func (AgentIngressMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AgentIngress)(nil)).Elem()
}

func (i AgentIngressMap) ToAgentIngressMapOutput() AgentIngressMapOutput {
	return i.ToAgentIngressMapOutputWithContext(context.Background())
}

func (i AgentIngressMap) ToAgentIngressMapOutputWithContext(ctx context.Context) AgentIngressMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AgentIngressMapOutput)
}

func (i AgentIngressMap) ToOutput(ctx context.Context) pulumix.Output[map[string]*AgentIngress] {
	return pulumix.Output[map[string]*AgentIngress]{
		OutputState: i.ToAgentIngressMapOutputWithContext(ctx).OutputState,
	}
}

type AgentIngressOutput struct{ *pulumi.OutputState }

func (AgentIngressOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AgentIngress)(nil)).Elem()
}

func (o AgentIngressOutput) ToAgentIngressOutput() AgentIngressOutput {
	return o
}

func (o AgentIngressOutput) ToAgentIngressOutputWithContext(ctx context.Context) AgentIngressOutput {
	return o
}

func (o AgentIngressOutput) ToOutput(ctx context.Context) pulumix.Output[*AgentIngress] {
	return pulumix.Output[*AgentIngress]{
		OutputState: o.OutputState,
	}
}

// timestamp when the Agent Ingress was created, RFC 3339 format
func (o AgentIngressOutput) CreatedAt() pulumi.StringOutput {
	return o.ApplyT(func(v *AgentIngress) pulumi.StringOutput { return v.CreatedAt }).(pulumi.StringOutput)
}

// human-readable description of the use of this Agent Ingress. optional, max 255 bytes.
func (o AgentIngressOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AgentIngress) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// the domain that you own to be used as the base domain name to generate regional agent ingress domains.
func (o AgentIngressOutput) Domain() pulumi.StringOutput {
	return o.ApplyT(func(v *AgentIngress) pulumi.StringOutput { return v.Domain }).(pulumi.StringOutput)
}

// arbitrary user-defined machine-readable data of this Agent Ingress. optional, max 4096 bytes
func (o AgentIngressOutput) Metadata() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AgentIngress) pulumi.StringPtrOutput { return v.Metadata }).(pulumi.StringPtrOutput)
}

// a list of target values to use as the values of NS records for the domain property these values will delegate control over the domain to ngrok
func (o AgentIngressOutput) NsTargets() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *AgentIngress) pulumi.StringArrayOutput { return v.NsTargets }).(pulumi.StringArrayOutput)
}

// a list of regional agent ingress domains that are subdomains of the value of domain this value may increase over time as ngrok adds more regions
func (o AgentIngressOutput) RegionDomains() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *AgentIngress) pulumi.StringArrayOutput { return v.RegionDomains }).(pulumi.StringArrayOutput)
}

// URI to the API resource of this Agent ingress
func (o AgentIngressOutput) Uri() pulumi.StringOutput {
	return o.ApplyT(func(v *AgentIngress) pulumi.StringOutput { return v.Uri }).(pulumi.StringOutput)
}

type AgentIngressArrayOutput struct{ *pulumi.OutputState }

func (AgentIngressArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AgentIngress)(nil)).Elem()
}

func (o AgentIngressArrayOutput) ToAgentIngressArrayOutput() AgentIngressArrayOutput {
	return o
}

func (o AgentIngressArrayOutput) ToAgentIngressArrayOutputWithContext(ctx context.Context) AgentIngressArrayOutput {
	return o
}

func (o AgentIngressArrayOutput) ToOutput(ctx context.Context) pulumix.Output[[]*AgentIngress] {
	return pulumix.Output[[]*AgentIngress]{
		OutputState: o.OutputState,
	}
}

func (o AgentIngressArrayOutput) Index(i pulumi.IntInput) AgentIngressOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *AgentIngress {
		return vs[0].([]*AgentIngress)[vs[1].(int)]
	}).(AgentIngressOutput)
}

type AgentIngressMapOutput struct{ *pulumi.OutputState }

func (AgentIngressMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AgentIngress)(nil)).Elem()
}

func (o AgentIngressMapOutput) ToAgentIngressMapOutput() AgentIngressMapOutput {
	return o
}

func (o AgentIngressMapOutput) ToAgentIngressMapOutputWithContext(ctx context.Context) AgentIngressMapOutput {
	return o
}

func (o AgentIngressMapOutput) ToOutput(ctx context.Context) pulumix.Output[map[string]*AgentIngress] {
	return pulumix.Output[map[string]*AgentIngress]{
		OutputState: o.OutputState,
	}
}

func (o AgentIngressMapOutput) MapIndex(k pulumi.StringInput) AgentIngressOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *AgentIngress {
		return vs[0].(map[string]*AgentIngress)[vs[1].(string)]
	}).(AgentIngressOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AgentIngressInput)(nil)).Elem(), &AgentIngress{})
	pulumi.RegisterInputType(reflect.TypeOf((*AgentIngressArrayInput)(nil)).Elem(), AgentIngressArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AgentIngressMapInput)(nil)).Elem(), AgentIngressMap{})
	pulumi.RegisterOutputType(AgentIngressOutput{})
	pulumi.RegisterOutputType(AgentIngressArrayOutput{})
	pulumi.RegisterOutputType(AgentIngressMapOutput{})
}
