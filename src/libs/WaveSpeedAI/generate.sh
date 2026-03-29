#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained (no public spec available)

dotnet tool install --global autosdk.cli --prerelease

rm -rf Generated

# WaveSpeed AI has no public OpenAPI spec — openapi.yaml is manually maintained from docs.
autosdk generate openapi.yaml \
  --namespace WaveSpeedAI \
  --clientClassName WaveSpeedAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
