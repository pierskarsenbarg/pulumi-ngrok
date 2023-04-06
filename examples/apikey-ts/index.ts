import * as pulumi from "@pulumi/pulumi";
import * as ngrok from "@pierskarsenbarg/pulumi-ngrok";

const apikey = new ngrok.ApiKey("apikey");