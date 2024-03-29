// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package ngrok

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi-ngrok/sdk/go/ngrok/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumix"
)

// IP Policies are reusable groups of CIDR ranges with an `allow` or `deny`
//
//	action. They can be attached to endpoints via the Endpoint Configuration IP
//	Policy module. They can also be used with IP Restrictions to control source
//	IP ranges that can start tunnel sessions and connect to the API and dashboard.
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
//			_, err := ngrok.NewIpPolicy(ctx, "example", &ngrok.IpPolicyArgs{
//				Action:      pulumi.String("allow"),
//				Description: pulumi.String("API Outbound Gateway"),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
type IpPolicy struct {
	pulumi.CustomResourceState

	// this field is deprecated. Please leave it empty and use the ip policy rule object's "action" field instead. It is temporarily retained for backwards compatibility reasons.
	Action pulumi.StringPtrOutput `pulumi:"action"`
	// human-readable description of the source IPs of this IP policy. optional, max 255 bytes.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// arbitrary user-defined machine-readable data of this IP policy. optional, max 4096 bytes.
	Metadata pulumi.StringPtrOutput `pulumi:"metadata"`
}

// NewIpPolicy registers a new resource with the given unique name, arguments, and options.
func NewIpPolicy(ctx *pulumi.Context,
	name string, args *IpPolicyArgs, opts ...pulumi.ResourceOption) (*IpPolicy, error) {
	if args == nil {
		args = &IpPolicyArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource IpPolicy
	err := ctx.RegisterResource("ngrok:index/ipPolicy:IpPolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIpPolicy gets an existing IpPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIpPolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IpPolicyState, opts ...pulumi.ResourceOption) (*IpPolicy, error) {
	var resource IpPolicy
	err := ctx.ReadResource("ngrok:index/ipPolicy:IpPolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering IpPolicy resources.
type ipPolicyState struct {
	// this field is deprecated. Please leave it empty and use the ip policy rule object's "action" field instead. It is temporarily retained for backwards compatibility reasons.
	Action *string `pulumi:"action"`
	// human-readable description of the source IPs of this IP policy. optional, max 255 bytes.
	Description *string `pulumi:"description"`
	// arbitrary user-defined machine-readable data of this IP policy. optional, max 4096 bytes.
	Metadata *string `pulumi:"metadata"`
}

type IpPolicyState struct {
	// this field is deprecated. Please leave it empty and use the ip policy rule object's "action" field instead. It is temporarily retained for backwards compatibility reasons.
	Action pulumi.StringPtrInput
	// human-readable description of the source IPs of this IP policy. optional, max 255 bytes.
	Description pulumi.StringPtrInput
	// arbitrary user-defined machine-readable data of this IP policy. optional, max 4096 bytes.
	Metadata pulumi.StringPtrInput
}

func (IpPolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*ipPolicyState)(nil)).Elem()
}

type ipPolicyArgs struct {
	// this field is deprecated. Please leave it empty and use the ip policy rule object's "action" field instead. It is temporarily retained for backwards compatibility reasons.
	Action *string `pulumi:"action"`
	// human-readable description of the source IPs of this IP policy. optional, max 255 bytes.
	Description *string `pulumi:"description"`
	// arbitrary user-defined machine-readable data of this IP policy. optional, max 4096 bytes.
	Metadata *string `pulumi:"metadata"`
}

// The set of arguments for constructing a IpPolicy resource.
type IpPolicyArgs struct {
	// this field is deprecated. Please leave it empty and use the ip policy rule object's "action" field instead. It is temporarily retained for backwards compatibility reasons.
	Action pulumi.StringPtrInput
	// human-readable description of the source IPs of this IP policy. optional, max 255 bytes.
	Description pulumi.StringPtrInput
	// arbitrary user-defined machine-readable data of this IP policy. optional, max 4096 bytes.
	Metadata pulumi.StringPtrInput
}

func (IpPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ipPolicyArgs)(nil)).Elem()
}

type IpPolicyInput interface {
	pulumi.Input

	ToIpPolicyOutput() IpPolicyOutput
	ToIpPolicyOutputWithContext(ctx context.Context) IpPolicyOutput
}

func (*IpPolicy) ElementType() reflect.Type {
	return reflect.TypeOf((**IpPolicy)(nil)).Elem()
}

func (i *IpPolicy) ToIpPolicyOutput() IpPolicyOutput {
	return i.ToIpPolicyOutputWithContext(context.Background())
}

func (i *IpPolicy) ToIpPolicyOutputWithContext(ctx context.Context) IpPolicyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IpPolicyOutput)
}

func (i *IpPolicy) ToOutput(ctx context.Context) pulumix.Output[*IpPolicy] {
	return pulumix.Output[*IpPolicy]{
		OutputState: i.ToIpPolicyOutputWithContext(ctx).OutputState,
	}
}

// IpPolicyArrayInput is an input type that accepts IpPolicyArray and IpPolicyArrayOutput values.
// You can construct a concrete instance of `IpPolicyArrayInput` via:
//
//	IpPolicyArray{ IpPolicyArgs{...} }
type IpPolicyArrayInput interface {
	pulumi.Input

	ToIpPolicyArrayOutput() IpPolicyArrayOutput
	ToIpPolicyArrayOutputWithContext(context.Context) IpPolicyArrayOutput
}

type IpPolicyArray []IpPolicyInput

func (IpPolicyArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*IpPolicy)(nil)).Elem()
}

func (i IpPolicyArray) ToIpPolicyArrayOutput() IpPolicyArrayOutput {
	return i.ToIpPolicyArrayOutputWithContext(context.Background())
}

func (i IpPolicyArray) ToIpPolicyArrayOutputWithContext(ctx context.Context) IpPolicyArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IpPolicyArrayOutput)
}

func (i IpPolicyArray) ToOutput(ctx context.Context) pulumix.Output[[]*IpPolicy] {
	return pulumix.Output[[]*IpPolicy]{
		OutputState: i.ToIpPolicyArrayOutputWithContext(ctx).OutputState,
	}
}

// IpPolicyMapInput is an input type that accepts IpPolicyMap and IpPolicyMapOutput values.
// You can construct a concrete instance of `IpPolicyMapInput` via:
//
//	IpPolicyMap{ "key": IpPolicyArgs{...} }
type IpPolicyMapInput interface {
	pulumi.Input

	ToIpPolicyMapOutput() IpPolicyMapOutput
	ToIpPolicyMapOutputWithContext(context.Context) IpPolicyMapOutput
}

type IpPolicyMap map[string]IpPolicyInput

func (IpPolicyMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*IpPolicy)(nil)).Elem()
}

func (i IpPolicyMap) ToIpPolicyMapOutput() IpPolicyMapOutput {
	return i.ToIpPolicyMapOutputWithContext(context.Background())
}

func (i IpPolicyMap) ToIpPolicyMapOutputWithContext(ctx context.Context) IpPolicyMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IpPolicyMapOutput)
}

func (i IpPolicyMap) ToOutput(ctx context.Context) pulumix.Output[map[string]*IpPolicy] {
	return pulumix.Output[map[string]*IpPolicy]{
		OutputState: i.ToIpPolicyMapOutputWithContext(ctx).OutputState,
	}
}

type IpPolicyOutput struct{ *pulumi.OutputState }

func (IpPolicyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**IpPolicy)(nil)).Elem()
}

func (o IpPolicyOutput) ToIpPolicyOutput() IpPolicyOutput {
	return o
}

func (o IpPolicyOutput) ToIpPolicyOutputWithContext(ctx context.Context) IpPolicyOutput {
	return o
}

func (o IpPolicyOutput) ToOutput(ctx context.Context) pulumix.Output[*IpPolicy] {
	return pulumix.Output[*IpPolicy]{
		OutputState: o.OutputState,
	}
}

// this field is deprecated. Please leave it empty and use the ip policy rule object's "action" field instead. It is temporarily retained for backwards compatibility reasons.
func (o IpPolicyOutput) Action() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *IpPolicy) pulumi.StringPtrOutput { return v.Action }).(pulumi.StringPtrOutput)
}

// human-readable description of the source IPs of this IP policy. optional, max 255 bytes.
func (o IpPolicyOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *IpPolicy) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// arbitrary user-defined machine-readable data of this IP policy. optional, max 4096 bytes.
func (o IpPolicyOutput) Metadata() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *IpPolicy) pulumi.StringPtrOutput { return v.Metadata }).(pulumi.StringPtrOutput)
}

type IpPolicyArrayOutput struct{ *pulumi.OutputState }

func (IpPolicyArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*IpPolicy)(nil)).Elem()
}

func (o IpPolicyArrayOutput) ToIpPolicyArrayOutput() IpPolicyArrayOutput {
	return o
}

func (o IpPolicyArrayOutput) ToIpPolicyArrayOutputWithContext(ctx context.Context) IpPolicyArrayOutput {
	return o
}

func (o IpPolicyArrayOutput) ToOutput(ctx context.Context) pulumix.Output[[]*IpPolicy] {
	return pulumix.Output[[]*IpPolicy]{
		OutputState: o.OutputState,
	}
}

func (o IpPolicyArrayOutput) Index(i pulumi.IntInput) IpPolicyOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *IpPolicy {
		return vs[0].([]*IpPolicy)[vs[1].(int)]
	}).(IpPolicyOutput)
}

type IpPolicyMapOutput struct{ *pulumi.OutputState }

func (IpPolicyMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*IpPolicy)(nil)).Elem()
}

func (o IpPolicyMapOutput) ToIpPolicyMapOutput() IpPolicyMapOutput {
	return o
}

func (o IpPolicyMapOutput) ToIpPolicyMapOutputWithContext(ctx context.Context) IpPolicyMapOutput {
	return o
}

func (o IpPolicyMapOutput) ToOutput(ctx context.Context) pulumix.Output[map[string]*IpPolicy] {
	return pulumix.Output[map[string]*IpPolicy]{
		OutputState: o.OutputState,
	}
}

func (o IpPolicyMapOutput) MapIndex(k pulumi.StringInput) IpPolicyOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *IpPolicy {
		return vs[0].(map[string]*IpPolicy)[vs[1].(string)]
	}).(IpPolicyOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*IpPolicyInput)(nil)).Elem(), &IpPolicy{})
	pulumi.RegisterInputType(reflect.TypeOf((*IpPolicyArrayInput)(nil)).Elem(), IpPolicyArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*IpPolicyMapInput)(nil)).Elem(), IpPolicyMap{})
	pulumi.RegisterOutputType(IpPolicyOutput{})
	pulumi.RegisterOutputType(IpPolicyArrayOutput{})
	pulumi.RegisterOutputType(IpPolicyMapOutput{})
}
