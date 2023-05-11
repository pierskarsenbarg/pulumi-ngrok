# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['IpPolicyArgs', 'IpPolicy']

@pulumi.input_type
class IpPolicyArgs:
    def __init__(__self__, *,
                 action: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 metadata: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a IpPolicy resource.
        :param pulumi.Input[str] action: this field is deprecated. Please leave it empty and use the ip policy rule object's "action" field instead. It is temporarily retained for backwards compatibility reasons.
        :param pulumi.Input[str] description: human-readable description of the source IPs of this IP policy. optional, max 255 bytes.
        :param pulumi.Input[str] metadata: arbitrary user-defined machine-readable data of this IP policy. optional, max 4096 bytes.
        """
        if action is not None:
            pulumi.set(__self__, "action", action)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if metadata is not None:
            pulumi.set(__self__, "metadata", metadata)

    @property
    @pulumi.getter
    def action(self) -> Optional[pulumi.Input[str]]:
        """
        this field is deprecated. Please leave it empty and use the ip policy rule object's "action" field instead. It is temporarily retained for backwards compatibility reasons.
        """
        return pulumi.get(self, "action")

    @action.setter
    def action(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "action", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        human-readable description of the source IPs of this IP policy. optional, max 255 bytes.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def metadata(self) -> Optional[pulumi.Input[str]]:
        """
        arbitrary user-defined machine-readable data of this IP policy. optional, max 4096 bytes.
        """
        return pulumi.get(self, "metadata")

    @metadata.setter
    def metadata(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "metadata", value)


@pulumi.input_type
class _IpPolicyState:
    def __init__(__self__, *,
                 action: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 metadata: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering IpPolicy resources.
        :param pulumi.Input[str] action: this field is deprecated. Please leave it empty and use the ip policy rule object's "action" field instead. It is temporarily retained for backwards compatibility reasons.
        :param pulumi.Input[str] description: human-readable description of the source IPs of this IP policy. optional, max 255 bytes.
        :param pulumi.Input[str] metadata: arbitrary user-defined machine-readable data of this IP policy. optional, max 4096 bytes.
        """
        if action is not None:
            pulumi.set(__self__, "action", action)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if metadata is not None:
            pulumi.set(__self__, "metadata", metadata)

    @property
    @pulumi.getter
    def action(self) -> Optional[pulumi.Input[str]]:
        """
        this field is deprecated. Please leave it empty and use the ip policy rule object's "action" field instead. It is temporarily retained for backwards compatibility reasons.
        """
        return pulumi.get(self, "action")

    @action.setter
    def action(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "action", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        human-readable description of the source IPs of this IP policy. optional, max 255 bytes.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def metadata(self) -> Optional[pulumi.Input[str]]:
        """
        arbitrary user-defined machine-readable data of this IP policy. optional, max 4096 bytes.
        """
        return pulumi.get(self, "metadata")

    @metadata.setter
    def metadata(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "metadata", value)


class IpPolicy(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 action: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 metadata: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        IP Policies are reusable groups of CIDR ranges with an `allow` or `deny`
         action. They can be attached to endpoints via the Endpoint Configuration IP
         Policy module. They can also be used with IP Restrictions to control source
         IP ranges that can start tunnel sessions and connect to the API and dashboard.

        ## Example Usage

        ```python
        import pulumi
        import pierskarsenbarg_pulumi_ngrok as ngrok

        example = ngrok.IpPolicy("example",
            action="allow",
            description="API Outbound Gateway")
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] action: this field is deprecated. Please leave it empty and use the ip policy rule object's "action" field instead. It is temporarily retained for backwards compatibility reasons.
        :param pulumi.Input[str] description: human-readable description of the source IPs of this IP policy. optional, max 255 bytes.
        :param pulumi.Input[str] metadata: arbitrary user-defined machine-readable data of this IP policy. optional, max 4096 bytes.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[IpPolicyArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        IP Policies are reusable groups of CIDR ranges with an `allow` or `deny`
         action. They can be attached to endpoints via the Endpoint Configuration IP
         Policy module. They can also be used with IP Restrictions to control source
         IP ranges that can start tunnel sessions and connect to the API and dashboard.

        ## Example Usage

        ```python
        import pulumi
        import pierskarsenbarg_pulumi_ngrok as ngrok

        example = ngrok.IpPolicy("example",
            action="allow",
            description="API Outbound Gateway")
        ```

        :param str resource_name: The name of the resource.
        :param IpPolicyArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(IpPolicyArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 action: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 metadata: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = IpPolicyArgs.__new__(IpPolicyArgs)

            __props__.__dict__["action"] = action
            __props__.__dict__["description"] = description
            __props__.__dict__["metadata"] = metadata
        super(IpPolicy, __self__).__init__(
            'ngrok:index/ipPolicy:IpPolicy',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            action: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            metadata: Optional[pulumi.Input[str]] = None) -> 'IpPolicy':
        """
        Get an existing IpPolicy resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] action: this field is deprecated. Please leave it empty and use the ip policy rule object's "action" field instead. It is temporarily retained for backwards compatibility reasons.
        :param pulumi.Input[str] description: human-readable description of the source IPs of this IP policy. optional, max 255 bytes.
        :param pulumi.Input[str] metadata: arbitrary user-defined machine-readable data of this IP policy. optional, max 4096 bytes.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _IpPolicyState.__new__(_IpPolicyState)

        __props__.__dict__["action"] = action
        __props__.__dict__["description"] = description
        __props__.__dict__["metadata"] = metadata
        return IpPolicy(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def action(self) -> pulumi.Output[Optional[str]]:
        """
        this field is deprecated. Please leave it empty and use the ip policy rule object's "action" field instead. It is temporarily retained for backwards compatibility reasons.
        """
        return pulumi.get(self, "action")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        human-readable description of the source IPs of this IP policy. optional, max 255 bytes.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def metadata(self) -> pulumi.Output[Optional[str]]:
        """
        arbitrary user-defined machine-readable data of this IP policy. optional, max 4096 bytes.
        """
        return pulumi.get(self, "metadata")
