//go:build nodejs || all
// +build nodejs all

package examples

import (
	"os"
	"path/filepath"
	"testing"

	"github.com/pulumi/pulumi/pkg/v3/testing/integration"
)

// func TestApiKey(t *testing.T) {
// 	cwd, _ := os.Getwd()
// 	integration.ProgramTest(t, &integration.ProgramTestOptions{
// 		Quick: true,
// 		SkipRefresh: true,
// 		Dir: path.Join(cwd, ".", "ngrok-apikey"),
// 		Dependencies: []string{
// 			"@pierskarsenbarg/pulumi-ngrok"
// 		}
// 	})
// }

func TestApiKey(t *testing.T) {
	cwd, _ := os.Getwd()
	test := getJSBaseOptions(t).
		With(integration.ProgramTestOptions{
			Dir: filepath.Join(cwd, ".", "apikey-ts"),
		})
	integration.ProgramTest(t, &test)
}

func getJSBaseOptions(t *testing.T) integration.ProgramTestOptions {
	base := getBaseOptions()
	baseJS := base.With(integration.ProgramTestOptions{
		Dependencies: []string{
			"@pierskarsenbarg/ngrok",
		},
	})

	return baseJS
}
