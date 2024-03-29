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

type EventSubscription struct {
	pulumi.CustomResourceState

	// Arbitrary customer supplied information intended to be human readable. Optional, max 255 chars.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// A list of Event Destination IDs which should be used for this Event Subscription.
	DestinationIds pulumi.StringArrayOutput `pulumi:"destinationIds"`
	// Arbitrary customer supplied information intended to be machine readable. Optional, max 4096 chars.
	Metadata pulumi.StringPtrOutput `pulumi:"metadata"`
	// Sources containing the types for which this event subscription will trigger
	Sources EventSubscriptionSourceArrayOutput `pulumi:"sources"`
}

// NewEventSubscription registers a new resource with the given unique name, arguments, and options.
func NewEventSubscription(ctx *pulumi.Context,
	name string, args *EventSubscriptionArgs, opts ...pulumi.ResourceOption) (*EventSubscription, error) {
	if args == nil {
		args = &EventSubscriptionArgs{}
	}

	opts = internal.PkgResourceDefaultOpts(opts)
	var resource EventSubscription
	err := ctx.RegisterResource("ngrok:index/eventSubscription:EventSubscription", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetEventSubscription gets an existing EventSubscription resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEventSubscription(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *EventSubscriptionState, opts ...pulumi.ResourceOption) (*EventSubscription, error) {
	var resource EventSubscription
	err := ctx.ReadResource("ngrok:index/eventSubscription:EventSubscription", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering EventSubscription resources.
type eventSubscriptionState struct {
	// Arbitrary customer supplied information intended to be human readable. Optional, max 255 chars.
	Description *string `pulumi:"description"`
	// A list of Event Destination IDs which should be used for this Event Subscription.
	DestinationIds []string `pulumi:"destinationIds"`
	// Arbitrary customer supplied information intended to be machine readable. Optional, max 4096 chars.
	Metadata *string `pulumi:"metadata"`
	// Sources containing the types for which this event subscription will trigger
	Sources []EventSubscriptionSource `pulumi:"sources"`
}

type EventSubscriptionState struct {
	// Arbitrary customer supplied information intended to be human readable. Optional, max 255 chars.
	Description pulumi.StringPtrInput
	// A list of Event Destination IDs which should be used for this Event Subscription.
	DestinationIds pulumi.StringArrayInput
	// Arbitrary customer supplied information intended to be machine readable. Optional, max 4096 chars.
	Metadata pulumi.StringPtrInput
	// Sources containing the types for which this event subscription will trigger
	Sources EventSubscriptionSourceArrayInput
}

func (EventSubscriptionState) ElementType() reflect.Type {
	return reflect.TypeOf((*eventSubscriptionState)(nil)).Elem()
}

type eventSubscriptionArgs struct {
	// Arbitrary customer supplied information intended to be human readable. Optional, max 255 chars.
	Description *string `pulumi:"description"`
	// A list of Event Destination IDs which should be used for this Event Subscription.
	DestinationIds []string `pulumi:"destinationIds"`
	// Arbitrary customer supplied information intended to be machine readable. Optional, max 4096 chars.
	Metadata *string `pulumi:"metadata"`
	// Sources containing the types for which this event subscription will trigger
	Sources []EventSubscriptionSource `pulumi:"sources"`
}

// The set of arguments for constructing a EventSubscription resource.
type EventSubscriptionArgs struct {
	// Arbitrary customer supplied information intended to be human readable. Optional, max 255 chars.
	Description pulumi.StringPtrInput
	// A list of Event Destination IDs which should be used for this Event Subscription.
	DestinationIds pulumi.StringArrayInput
	// Arbitrary customer supplied information intended to be machine readable. Optional, max 4096 chars.
	Metadata pulumi.StringPtrInput
	// Sources containing the types for which this event subscription will trigger
	Sources EventSubscriptionSourceArrayInput
}

func (EventSubscriptionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*eventSubscriptionArgs)(nil)).Elem()
}

type EventSubscriptionInput interface {
	pulumi.Input

	ToEventSubscriptionOutput() EventSubscriptionOutput
	ToEventSubscriptionOutputWithContext(ctx context.Context) EventSubscriptionOutput
}

func (*EventSubscription) ElementType() reflect.Type {
	return reflect.TypeOf((**EventSubscription)(nil)).Elem()
}

func (i *EventSubscription) ToEventSubscriptionOutput() EventSubscriptionOutput {
	return i.ToEventSubscriptionOutputWithContext(context.Background())
}

func (i *EventSubscription) ToEventSubscriptionOutputWithContext(ctx context.Context) EventSubscriptionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EventSubscriptionOutput)
}

func (i *EventSubscription) ToOutput(ctx context.Context) pulumix.Output[*EventSubscription] {
	return pulumix.Output[*EventSubscription]{
		OutputState: i.ToEventSubscriptionOutputWithContext(ctx).OutputState,
	}
}

// EventSubscriptionArrayInput is an input type that accepts EventSubscriptionArray and EventSubscriptionArrayOutput values.
// You can construct a concrete instance of `EventSubscriptionArrayInput` via:
//
//	EventSubscriptionArray{ EventSubscriptionArgs{...} }
type EventSubscriptionArrayInput interface {
	pulumi.Input

	ToEventSubscriptionArrayOutput() EventSubscriptionArrayOutput
	ToEventSubscriptionArrayOutputWithContext(context.Context) EventSubscriptionArrayOutput
}

type EventSubscriptionArray []EventSubscriptionInput

func (EventSubscriptionArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*EventSubscription)(nil)).Elem()
}

func (i EventSubscriptionArray) ToEventSubscriptionArrayOutput() EventSubscriptionArrayOutput {
	return i.ToEventSubscriptionArrayOutputWithContext(context.Background())
}

func (i EventSubscriptionArray) ToEventSubscriptionArrayOutputWithContext(ctx context.Context) EventSubscriptionArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EventSubscriptionArrayOutput)
}

func (i EventSubscriptionArray) ToOutput(ctx context.Context) pulumix.Output[[]*EventSubscription] {
	return pulumix.Output[[]*EventSubscription]{
		OutputState: i.ToEventSubscriptionArrayOutputWithContext(ctx).OutputState,
	}
}

// EventSubscriptionMapInput is an input type that accepts EventSubscriptionMap and EventSubscriptionMapOutput values.
// You can construct a concrete instance of `EventSubscriptionMapInput` via:
//
//	EventSubscriptionMap{ "key": EventSubscriptionArgs{...} }
type EventSubscriptionMapInput interface {
	pulumi.Input

	ToEventSubscriptionMapOutput() EventSubscriptionMapOutput
	ToEventSubscriptionMapOutputWithContext(context.Context) EventSubscriptionMapOutput
}

type EventSubscriptionMap map[string]EventSubscriptionInput

func (EventSubscriptionMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*EventSubscription)(nil)).Elem()
}

func (i EventSubscriptionMap) ToEventSubscriptionMapOutput() EventSubscriptionMapOutput {
	return i.ToEventSubscriptionMapOutputWithContext(context.Background())
}

func (i EventSubscriptionMap) ToEventSubscriptionMapOutputWithContext(ctx context.Context) EventSubscriptionMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EventSubscriptionMapOutput)
}

func (i EventSubscriptionMap) ToOutput(ctx context.Context) pulumix.Output[map[string]*EventSubscription] {
	return pulumix.Output[map[string]*EventSubscription]{
		OutputState: i.ToEventSubscriptionMapOutputWithContext(ctx).OutputState,
	}
}

type EventSubscriptionOutput struct{ *pulumi.OutputState }

func (EventSubscriptionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**EventSubscription)(nil)).Elem()
}

func (o EventSubscriptionOutput) ToEventSubscriptionOutput() EventSubscriptionOutput {
	return o
}

func (o EventSubscriptionOutput) ToEventSubscriptionOutputWithContext(ctx context.Context) EventSubscriptionOutput {
	return o
}

func (o EventSubscriptionOutput) ToOutput(ctx context.Context) pulumix.Output[*EventSubscription] {
	return pulumix.Output[*EventSubscription]{
		OutputState: o.OutputState,
	}
}

// Arbitrary customer supplied information intended to be human readable. Optional, max 255 chars.
func (o EventSubscriptionOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *EventSubscription) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// A list of Event Destination IDs which should be used for this Event Subscription.
func (o EventSubscriptionOutput) DestinationIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *EventSubscription) pulumi.StringArrayOutput { return v.DestinationIds }).(pulumi.StringArrayOutput)
}

// Arbitrary customer supplied information intended to be machine readable. Optional, max 4096 chars.
func (o EventSubscriptionOutput) Metadata() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *EventSubscription) pulumi.StringPtrOutput { return v.Metadata }).(pulumi.StringPtrOutput)
}

// Sources containing the types for which this event subscription will trigger
func (o EventSubscriptionOutput) Sources() EventSubscriptionSourceArrayOutput {
	return o.ApplyT(func(v *EventSubscription) EventSubscriptionSourceArrayOutput { return v.Sources }).(EventSubscriptionSourceArrayOutput)
}

type EventSubscriptionArrayOutput struct{ *pulumi.OutputState }

func (EventSubscriptionArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*EventSubscription)(nil)).Elem()
}

func (o EventSubscriptionArrayOutput) ToEventSubscriptionArrayOutput() EventSubscriptionArrayOutput {
	return o
}

func (o EventSubscriptionArrayOutput) ToEventSubscriptionArrayOutputWithContext(ctx context.Context) EventSubscriptionArrayOutput {
	return o
}

func (o EventSubscriptionArrayOutput) ToOutput(ctx context.Context) pulumix.Output[[]*EventSubscription] {
	return pulumix.Output[[]*EventSubscription]{
		OutputState: o.OutputState,
	}
}

func (o EventSubscriptionArrayOutput) Index(i pulumi.IntInput) EventSubscriptionOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *EventSubscription {
		return vs[0].([]*EventSubscription)[vs[1].(int)]
	}).(EventSubscriptionOutput)
}

type EventSubscriptionMapOutput struct{ *pulumi.OutputState }

func (EventSubscriptionMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*EventSubscription)(nil)).Elem()
}

func (o EventSubscriptionMapOutput) ToEventSubscriptionMapOutput() EventSubscriptionMapOutput {
	return o
}

func (o EventSubscriptionMapOutput) ToEventSubscriptionMapOutputWithContext(ctx context.Context) EventSubscriptionMapOutput {
	return o
}

func (o EventSubscriptionMapOutput) ToOutput(ctx context.Context) pulumix.Output[map[string]*EventSubscription] {
	return pulumix.Output[map[string]*EventSubscription]{
		OutputState: o.OutputState,
	}
}

func (o EventSubscriptionMapOutput) MapIndex(k pulumi.StringInput) EventSubscriptionOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *EventSubscription {
		return vs[0].(map[string]*EventSubscription)[vs[1].(string)]
	}).(EventSubscriptionOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*EventSubscriptionInput)(nil)).Elem(), &EventSubscription{})
	pulumi.RegisterInputType(reflect.TypeOf((*EventSubscriptionArrayInput)(nil)).Elem(), EventSubscriptionArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*EventSubscriptionMapInput)(nil)).Elem(), EventSubscriptionMap{})
	pulumi.RegisterOutputType(EventSubscriptionOutput{})
	pulumi.RegisterOutputType(EventSubscriptionArrayOutput{})
	pulumi.RegisterOutputType(EventSubscriptionMapOutput{})
}
