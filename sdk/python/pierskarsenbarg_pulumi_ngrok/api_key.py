# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['ApiKeyArgs', 'ApiKey']

@pulumi.input_type
class ApiKeyArgs:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 metadata: Optional[pulumi.Input[str]] = None,
                 token: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a ApiKey resource.
        :param pulumi.Input[str] description: human-readable description of what uses the API key to authenticate. optional, max 255 bytes.
        :param pulumi.Input[str] metadata: arbitrary user-defined data of this API key. optional, max 4096 bytes
        :param pulumi.Input[str] token: the bearer token that can be placed into the Authorization header to authenticate request to the ngrok API. **This value is only available one time, on the API response from key creation. Otherwise it is null.**
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if metadata is not None:
            pulumi.set(__self__, "metadata", metadata)
        if token is not None:
            pulumi.set(__self__, "token", token)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        human-readable description of what uses the API key to authenticate. optional, max 255 bytes.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def metadata(self) -> Optional[pulumi.Input[str]]:
        """
        arbitrary user-defined data of this API key. optional, max 4096 bytes
        """
        return pulumi.get(self, "metadata")

    @metadata.setter
    def metadata(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "metadata", value)

    @property
    @pulumi.getter
    def token(self) -> Optional[pulumi.Input[str]]:
        """
        the bearer token that can be placed into the Authorization header to authenticate request to the ngrok API. **This value is only available one time, on the API response from key creation. Otherwise it is null.**
        """
        return pulumi.get(self, "token")

    @token.setter
    def token(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "token", value)


@pulumi.input_type
class _ApiKeyState:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 metadata: Optional[pulumi.Input[str]] = None,
                 token: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering ApiKey resources.
        :param pulumi.Input[str] description: human-readable description of what uses the API key to authenticate. optional, max 255 bytes.
        :param pulumi.Input[str] metadata: arbitrary user-defined data of this API key. optional, max 4096 bytes
        :param pulumi.Input[str] token: the bearer token that can be placed into the Authorization header to authenticate request to the ngrok API. **This value is only available one time, on the API response from key creation. Otherwise it is null.**
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if metadata is not None:
            pulumi.set(__self__, "metadata", metadata)
        if token is not None:
            pulumi.set(__self__, "token", token)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        human-readable description of what uses the API key to authenticate. optional, max 255 bytes.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def metadata(self) -> Optional[pulumi.Input[str]]:
        """
        arbitrary user-defined data of this API key. optional, max 4096 bytes
        """
        return pulumi.get(self, "metadata")

    @metadata.setter
    def metadata(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "metadata", value)

    @property
    @pulumi.getter
    def token(self) -> Optional[pulumi.Input[str]]:
        """
        the bearer token that can be placed into the Authorization header to authenticate request to the ngrok API. **This value is only available one time, on the API response from key creation. Otherwise it is null.**
        """
        return pulumi.get(self, "token")

    @token.setter
    def token(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "token", value)


class ApiKey(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 metadata: Optional[pulumi.Input[str]] = None,
                 token: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        API Keys are used to authenticate to the [ngrok
         API](https://ngrok.com/docs/api#authentication). You may use the API itself
         to provision and manage API Keys but you'll need to provision your first API
         key from the [API Keys page](https://dashboard.ngrok.com/api/keys) on your
         ngrok.com dashboard.

        ## Example Usage

        ```python
        import pulumi
        import pierskarsenbarg_pulumi_ngrok as ngrok

        example = ngrok.ApiKey("example",
            description="ad-hoc dev testing",
            metadata="{\\"environment\\":\\"dev\\"}")
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: human-readable description of what uses the API key to authenticate. optional, max 255 bytes.
        :param pulumi.Input[str] metadata: arbitrary user-defined data of this API key. optional, max 4096 bytes
        :param pulumi.Input[str] token: the bearer token that can be placed into the Authorization header to authenticate request to the ngrok API. **This value is only available one time, on the API response from key creation. Otherwise it is null.**
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[ApiKeyArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        API Keys are used to authenticate to the [ngrok
         API](https://ngrok.com/docs/api#authentication). You may use the API itself
         to provision and manage API Keys but you'll need to provision your first API
         key from the [API Keys page](https://dashboard.ngrok.com/api/keys) on your
         ngrok.com dashboard.

        ## Example Usage

        ```python
        import pulumi
        import pierskarsenbarg_pulumi_ngrok as ngrok

        example = ngrok.ApiKey("example",
            description="ad-hoc dev testing",
            metadata="{\\"environment\\":\\"dev\\"}")
        ```

        :param str resource_name: The name of the resource.
        :param ApiKeyArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ApiKeyArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 metadata: Optional[pulumi.Input[str]] = None,
                 token: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ApiKeyArgs.__new__(ApiKeyArgs)

            __props__.__dict__["description"] = description
            __props__.__dict__["metadata"] = metadata
            __props__.__dict__["token"] = None if token is None else pulumi.Output.secret(token)
        secret_opts = pulumi.ResourceOptions(additional_secret_outputs=["token"])
        opts = pulumi.ResourceOptions.merge(opts, secret_opts)
        super(ApiKey, __self__).__init__(
            'ngrok:index/apiKey:ApiKey',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[str]] = None,
            metadata: Optional[pulumi.Input[str]] = None,
            token: Optional[pulumi.Input[str]] = None) -> 'ApiKey':
        """
        Get an existing ApiKey resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: human-readable description of what uses the API key to authenticate. optional, max 255 bytes.
        :param pulumi.Input[str] metadata: arbitrary user-defined data of this API key. optional, max 4096 bytes
        :param pulumi.Input[str] token: the bearer token that can be placed into the Authorization header to authenticate request to the ngrok API. **This value is only available one time, on the API response from key creation. Otherwise it is null.**
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ApiKeyState.__new__(_ApiKeyState)

        __props__.__dict__["description"] = description
        __props__.__dict__["metadata"] = metadata
        __props__.__dict__["token"] = token
        return ApiKey(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        human-readable description of what uses the API key to authenticate. optional, max 255 bytes.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def metadata(self) -> pulumi.Output[Optional[str]]:
        """
        arbitrary user-defined data of this API key. optional, max 4096 bytes
        """
        return pulumi.get(self, "metadata")

    @property
    @pulumi.getter
    def token(self) -> pulumi.Output[str]:
        """
        the bearer token that can be placed into the Authorization header to authenticate request to the ngrok API. **This value is only available one time, on the API response from key creation. Otherwise it is null.**
        """
        return pulumi.get(self, "token")

