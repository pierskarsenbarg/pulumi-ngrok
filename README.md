# ngrok Resource Provider

The ngrok Resource Provider lets you manage [ngrok](http://ngrok.com) resources.

## Installing

This package is available for several languages/platforms:

### Node.js (JavaScript/TypeScript)

To use from JavaScript or TypeScript in Node.js, install using either `npm`:

```bash
npm install @pierskarsenbarg/ngrok
```

or `yarn`:

```bash
yarn add @pierskarsenbarg/ngrok
```

### Python

To use from Python, install using `pip`:

```bash
pip install pierskarsenbarg-pulumi-ngrok
```

### Go

To use from Go, use `go get` to grab the latest version of the library:

```bash
go get github.com/pierskarsenbarg/pulumi-ngrok/sdk/go/...
```

### .NET

To use from .NET, install using `dotnet add package`:

```bash
dotnet add package PiersKarsenbarg.Ngrok
```

## Configuration

The following configuration points are available for the `ngrok` provider:

- `ngrok:apiKey` (environment: `NGROK_API_KEY`) - the API key for `ngrok`
- `ngrok:apiBaseUrl` (environment: `NGROK_API_BASE_URL`) - The API URL used to talk with ngrok. The default is `https://api.ngrok.com.` - optional

## Todo

* Add Java language support
* Add YAML language support
