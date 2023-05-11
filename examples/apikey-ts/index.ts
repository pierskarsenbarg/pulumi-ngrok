import * as pulumi from "@pulumi/pulumi";
import * as ngrok from "@pierskarsenbarg/ngrok";

const apikey = new ngrok.ApiKey("apikey");