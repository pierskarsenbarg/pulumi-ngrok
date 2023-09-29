// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * A Failover backend defines failover behavior within a list of referenced
 *  backends. Traffic is sent to the first backend in the list. If that backend
 *  is offline or no connection can be established, ngrok attempts to connect to
 *  the next backend in the list until one is successful.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as ngrok from "@pierskarsenbarg/ngrok";
 *
 * const example = new ngrok.FailoverBackend("example", {
 *     backends: ["bkdhr_26rOyncxuCZ0JdIjYiEDGlsh1lO"],
 *     description: "acme failover",
 *     metadata: "{\"environment\": \"staging\"}",
 * });
 * ```
 */
export class FailoverBackend extends pulumi.CustomResource {
    /**
     * Get an existing FailoverBackend resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: FailoverBackendState, opts?: pulumi.CustomResourceOptions): FailoverBackend {
        return new FailoverBackend(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'ngrok:index/failoverBackend:FailoverBackend';

    /**
     * Returns true if the given object is an instance of FailoverBackend.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is FailoverBackend {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === FailoverBackend.__pulumiType;
    }

    /**
     * the ids of the child backends in order
     */
    public readonly backends!: pulumi.Output<string[] | undefined>;
    /**
     * timestamp when the backend was created, RFC 3339 format
     */
    public readonly createdAt!: pulumi.Output<string>;
    /**
     * human-readable description of this backend. Optional
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * arbitrary user-defined machine-readable data of this backend. Optional
     */
    public readonly metadata!: pulumi.Output<string | undefined>;
    /**
     * URI of the FailoverBackend API resource
     */
    public readonly uri!: pulumi.Output<string>;

    /**
     * Create a FailoverBackend resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: FailoverBackendArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: FailoverBackendArgs | FailoverBackendState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as FailoverBackendState | undefined;
            resourceInputs["backends"] = state ? state.backends : undefined;
            resourceInputs["createdAt"] = state ? state.createdAt : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["metadata"] = state ? state.metadata : undefined;
            resourceInputs["uri"] = state ? state.uri : undefined;
        } else {
            const args = argsOrState as FailoverBackendArgs | undefined;
            resourceInputs["backends"] = args ? args.backends : undefined;
            resourceInputs["createdAt"] = args ? args.createdAt : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["metadata"] = args ? args.metadata : undefined;
            resourceInputs["uri"] = args ? args.uri : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(FailoverBackend.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering FailoverBackend resources.
 */
export interface FailoverBackendState {
    /**
     * the ids of the child backends in order
     */
    backends?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * timestamp when the backend was created, RFC 3339 format
     */
    createdAt?: pulumi.Input<string>;
    /**
     * human-readable description of this backend. Optional
     */
    description?: pulumi.Input<string>;
    /**
     * arbitrary user-defined machine-readable data of this backend. Optional
     */
    metadata?: pulumi.Input<string>;
    /**
     * URI of the FailoverBackend API resource
     */
    uri?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a FailoverBackend resource.
 */
export interface FailoverBackendArgs {
    /**
     * the ids of the child backends in order
     */
    backends?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * timestamp when the backend was created, RFC 3339 format
     */
    createdAt?: pulumi.Input<string>;
    /**
     * human-readable description of this backend. Optional
     */
    description?: pulumi.Input<string>;
    /**
     * arbitrary user-defined machine-readable data of this backend. Optional
     */
    metadata?: pulumi.Input<string>;
    /**
     * URI of the FailoverBackend API resource
     */
    uri?: pulumi.Input<string>;
}
