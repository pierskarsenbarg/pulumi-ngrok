// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Reserved Addresses are TCP addresses that can be used to listen for traffic.
 *  TCP address hostnames and ports are assigned by ngrok, they cannot be
 *  chosen.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as ngrok from "@pierskarsenbarg/ngrok";
 *
 * const example = new ngrok.ReservedAddress("example", {
 *     description: "SSH for device #001",
 *     region: "us",
 * });
 * ```
 */
export class ReservedAddress extends pulumi.CustomResource {
    /**
     * Get an existing ReservedAddress resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ReservedAddressState, opts?: pulumi.CustomResourceOptions): ReservedAddress {
        return new ReservedAddress(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'ngrok:index/reservedAddress:ReservedAddress';

    /**
     * Returns true if the given object is an instance of ReservedAddress.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ReservedAddress {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ReservedAddress.__pulumiType;
    }

    /**
     * hostname:port of the reserved address that was assigned at creation time
     */
    public readonly addr!: pulumi.Output<string>;
    /**
     * human-readable description of what this reserved address will be used for
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * ID of an endpoint configuration of type tcp that will be used to handle inbound traffic to this address
     */
    public readonly endpointConfigurationId!: pulumi.Output<string | undefined>;
    /**
     * arbitrary user-defined machine-readable data of this reserved address. Optional, max 4096 bytes.
     */
    public readonly metadata!: pulumi.Output<string | undefined>;
    /**
     * reserve the address in this geographic ngrok datacenter. Optional, default is us. (au, eu, ap, us, jp, in, sa)
     */
    public readonly region!: pulumi.Output<string | undefined>;

    /**
     * Create a ReservedAddress resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: ReservedAddressArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ReservedAddressArgs | ReservedAddressState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ReservedAddressState | undefined;
            resourceInputs["addr"] = state ? state.addr : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["endpointConfigurationId"] = state ? state.endpointConfigurationId : undefined;
            resourceInputs["metadata"] = state ? state.metadata : undefined;
            resourceInputs["region"] = state ? state.region : undefined;
        } else {
            const args = argsOrState as ReservedAddressArgs | undefined;
            resourceInputs["addr"] = args ? args.addr : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["endpointConfigurationId"] = args ? args.endpointConfigurationId : undefined;
            resourceInputs["metadata"] = args ? args.metadata : undefined;
            resourceInputs["region"] = args ? args.region : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ReservedAddress.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ReservedAddress resources.
 */
export interface ReservedAddressState {
    /**
     * hostname:port of the reserved address that was assigned at creation time
     */
    addr?: pulumi.Input<string>;
    /**
     * human-readable description of what this reserved address will be used for
     */
    description?: pulumi.Input<string>;
    /**
     * ID of an endpoint configuration of type tcp that will be used to handle inbound traffic to this address
     */
    endpointConfigurationId?: pulumi.Input<string>;
    /**
     * arbitrary user-defined machine-readable data of this reserved address. Optional, max 4096 bytes.
     */
    metadata?: pulumi.Input<string>;
    /**
     * reserve the address in this geographic ngrok datacenter. Optional, default is us. (au, eu, ap, us, jp, in, sa)
     */
    region?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ReservedAddress resource.
 */
export interface ReservedAddressArgs {
    /**
     * hostname:port of the reserved address that was assigned at creation time
     */
    addr?: pulumi.Input<string>;
    /**
     * human-readable description of what this reserved address will be used for
     */
    description?: pulumi.Input<string>;
    /**
     * ID of an endpoint configuration of type tcp that will be used to handle inbound traffic to this address
     */
    endpointConfigurationId?: pulumi.Input<string>;
    /**
     * arbitrary user-defined machine-readable data of this reserved address. Optional, max 4096 bytes.
     */
    metadata?: pulumi.Input<string>;
    /**
     * reserve the address in this geographic ngrok datacenter. Optional, default is us. (au, eu, ap, us, jp, in, sa)
     */
    region?: pulumi.Input<string>;
}
