# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['IpPolicyRuleArgs', 'IpPolicyRule']

@pulumi.input_type
class IpPolicyRuleArgs:
    def __init__(__self__, *,
                 action: pulumi.Input[str],
                 cidr: pulumi.Input[str],
                 ip_policy_id: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None,
                 metadata: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a IpPolicyRule resource.
        :param pulumi.Input[str] action: the action to apply to the policy rule, either `allow` or `deny`
        :param pulumi.Input[str] cidr: an IP or IP range specified in CIDR notation. IPv4 and IPv6 are both supported.
        :param pulumi.Input[str] ip_policy_id: ID of the IP policy this IP policy rule will be attached to
        :param pulumi.Input[str] description: human-readable description of the source IPs of this IP rule. optional, max 255 bytes.
        :param pulumi.Input[str] metadata: arbitrary user-defined machine-readable data of this IP policy rule. optional, max 4096 bytes.
        """
        pulumi.set(__self__, "action", action)
        pulumi.set(__self__, "cidr", cidr)
        pulumi.set(__self__, "ip_policy_id", ip_policy_id)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if metadata is not None:
            pulumi.set(__self__, "metadata", metadata)

    @property
    @pulumi.getter
    def action(self) -> pulumi.Input[str]:
        """
        the action to apply to the policy rule, either `allow` or `deny`
        """
        return pulumi.get(self, "action")

    @action.setter
    def action(self, value: pulumi.Input[str]):
        pulumi.set(self, "action", value)

    @property
    @pulumi.getter
    def cidr(self) -> pulumi.Input[str]:
        """
        an IP or IP range specified in CIDR notation. IPv4 and IPv6 are both supported.
        """
        return pulumi.get(self, "cidr")

    @cidr.setter
    def cidr(self, value: pulumi.Input[str]):
        pulumi.set(self, "cidr", value)

    @property
    @pulumi.getter(name="ipPolicyId")
    def ip_policy_id(self) -> pulumi.Input[str]:
        """
        ID of the IP policy this IP policy rule will be attached to
        """
        return pulumi.get(self, "ip_policy_id")

    @ip_policy_id.setter
    def ip_policy_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "ip_policy_id", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        human-readable description of the source IPs of this IP rule. optional, max 255 bytes.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def metadata(self) -> Optional[pulumi.Input[str]]:
        """
        arbitrary user-defined machine-readable data of this IP policy rule. optional, max 4096 bytes.
        """
        return pulumi.get(self, "metadata")

    @metadata.setter
    def metadata(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "metadata", value)


@pulumi.input_type
class _IpPolicyRuleState:
    def __init__(__self__, *,
                 action: Optional[pulumi.Input[str]] = None,
                 cidr: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 ip_policy_id: Optional[pulumi.Input[str]] = None,
                 metadata: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering IpPolicyRule resources.
        :param pulumi.Input[str] action: the action to apply to the policy rule, either `allow` or `deny`
        :param pulumi.Input[str] cidr: an IP or IP range specified in CIDR notation. IPv4 and IPv6 are both supported.
        :param pulumi.Input[str] description: human-readable description of the source IPs of this IP rule. optional, max 255 bytes.
        :param pulumi.Input[str] ip_policy_id: ID of the IP policy this IP policy rule will be attached to
        :param pulumi.Input[str] metadata: arbitrary user-defined machine-readable data of this IP policy rule. optional, max 4096 bytes.
        """
        if action is not None:
            pulumi.set(__self__, "action", action)
        if cidr is not None:
            pulumi.set(__self__, "cidr", cidr)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if ip_policy_id is not None:
            pulumi.set(__self__, "ip_policy_id", ip_policy_id)
        if metadata is not None:
            pulumi.set(__self__, "metadata", metadata)

    @property
    @pulumi.getter
    def action(self) -> Optional[pulumi.Input[str]]:
        """
        the action to apply to the policy rule, either `allow` or `deny`
        """
        return pulumi.get(self, "action")

    @action.setter
    def action(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "action", value)

    @property
    @pulumi.getter
    def cidr(self) -> Optional[pulumi.Input[str]]:
        """
        an IP or IP range specified in CIDR notation. IPv4 and IPv6 are both supported.
        """
        return pulumi.get(self, "cidr")

    @cidr.setter
    def cidr(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cidr", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        human-readable description of the source IPs of this IP rule. optional, max 255 bytes.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="ipPolicyId")
    def ip_policy_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID of the IP policy this IP policy rule will be attached to
        """
        return pulumi.get(self, "ip_policy_id")

    @ip_policy_id.setter
    def ip_policy_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ip_policy_id", value)

    @property
    @pulumi.getter
    def metadata(self) -> Optional[pulumi.Input[str]]:
        """
        arbitrary user-defined machine-readable data of this IP policy rule. optional, max 4096 bytes.
        """
        return pulumi.get(self, "metadata")

    @metadata.setter
    def metadata(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "metadata", value)


class IpPolicyRule(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 action: Optional[pulumi.Input[str]] = None,
                 cidr: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 ip_policy_id: Optional[pulumi.Input[str]] = None,
                 metadata: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        IP Policy Rules are the IPv4 or IPv6 CIDRs entries that
         make up an IP Policy.

        ## Example Usage

        ```python
        import pulumi
        import pierskarsenbarg_pulumi_ngrok as ngrok

        example = ngrok.IpPolicyRule("example",
            action="allow",
            cidr="212.3.14.0/24",
            description="nyc office",
            ip_policy_id="ipp_26rOydjEUNZSLTi8bYXBg278qUT")
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] action: the action to apply to the policy rule, either `allow` or `deny`
        :param pulumi.Input[str] cidr: an IP or IP range specified in CIDR notation. IPv4 and IPv6 are both supported.
        :param pulumi.Input[str] description: human-readable description of the source IPs of this IP rule. optional, max 255 bytes.
        :param pulumi.Input[str] ip_policy_id: ID of the IP policy this IP policy rule will be attached to
        :param pulumi.Input[str] metadata: arbitrary user-defined machine-readable data of this IP policy rule. optional, max 4096 bytes.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: IpPolicyRuleArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        IP Policy Rules are the IPv4 or IPv6 CIDRs entries that
         make up an IP Policy.

        ## Example Usage

        ```python
        import pulumi
        import pierskarsenbarg_pulumi_ngrok as ngrok

        example = ngrok.IpPolicyRule("example",
            action="allow",
            cidr="212.3.14.0/24",
            description="nyc office",
            ip_policy_id="ipp_26rOydjEUNZSLTi8bYXBg278qUT")
        ```

        :param str resource_name: The name of the resource.
        :param IpPolicyRuleArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(IpPolicyRuleArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 action: Optional[pulumi.Input[str]] = None,
                 cidr: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 ip_policy_id: Optional[pulumi.Input[str]] = None,
                 metadata: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = IpPolicyRuleArgs.__new__(IpPolicyRuleArgs)

            if action is None and not opts.urn:
                raise TypeError("Missing required property 'action'")
            __props__.__dict__["action"] = action
            if cidr is None and not opts.urn:
                raise TypeError("Missing required property 'cidr'")
            __props__.__dict__["cidr"] = cidr
            __props__.__dict__["description"] = description
            if ip_policy_id is None and not opts.urn:
                raise TypeError("Missing required property 'ip_policy_id'")
            __props__.__dict__["ip_policy_id"] = ip_policy_id
            __props__.__dict__["metadata"] = metadata
        super(IpPolicyRule, __self__).__init__(
            'ngrok:index/ipPolicyRule:IpPolicyRule',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            action: Optional[pulumi.Input[str]] = None,
            cidr: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            ip_policy_id: Optional[pulumi.Input[str]] = None,
            metadata: Optional[pulumi.Input[str]] = None) -> 'IpPolicyRule':
        """
        Get an existing IpPolicyRule resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] action: the action to apply to the policy rule, either `allow` or `deny`
        :param pulumi.Input[str] cidr: an IP or IP range specified in CIDR notation. IPv4 and IPv6 are both supported.
        :param pulumi.Input[str] description: human-readable description of the source IPs of this IP rule. optional, max 255 bytes.
        :param pulumi.Input[str] ip_policy_id: ID of the IP policy this IP policy rule will be attached to
        :param pulumi.Input[str] metadata: arbitrary user-defined machine-readable data of this IP policy rule. optional, max 4096 bytes.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _IpPolicyRuleState.__new__(_IpPolicyRuleState)

        __props__.__dict__["action"] = action
        __props__.__dict__["cidr"] = cidr
        __props__.__dict__["description"] = description
        __props__.__dict__["ip_policy_id"] = ip_policy_id
        __props__.__dict__["metadata"] = metadata
        return IpPolicyRule(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def action(self) -> pulumi.Output[str]:
        """
        the action to apply to the policy rule, either `allow` or `deny`
        """
        return pulumi.get(self, "action")

    @property
    @pulumi.getter
    def cidr(self) -> pulumi.Output[str]:
        """
        an IP or IP range specified in CIDR notation. IPv4 and IPv6 are both supported.
        """
        return pulumi.get(self, "cidr")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        human-readable description of the source IPs of this IP rule. optional, max 255 bytes.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="ipPolicyId")
    def ip_policy_id(self) -> pulumi.Output[str]:
        """
        ID of the IP policy this IP policy rule will be attached to
        """
        return pulumi.get(self, "ip_policy_id")

    @property
    @pulumi.getter
    def metadata(self) -> pulumi.Output[Optional[str]]:
        """
        arbitrary user-defined machine-readable data of this IP policy rule. optional, max 4096 bytes.
        """
        return pulumi.get(self, "metadata")

