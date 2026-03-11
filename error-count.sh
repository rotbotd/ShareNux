#!/usr/bin/env bash
# Track compiler error count for ShareNux migration progress

count=$(dotnet build 2>&1 | grep -c "error CS")
echo "Compiler errors: $count"

# Save to log with timestamp
echo "$(date -Iseconds) $count" >> .error-log
