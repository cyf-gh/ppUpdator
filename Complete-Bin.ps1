$x = Split-Path -Parent $MyInvocation.MyCommand.Definition

Copy-Item $x\\.bin_asset\\* $x\\\ppUpdator\\ppUpdator.App\\bin\\Debug -Recurse -Force
Copy-Item $x\\.bin_asset\\* $x\\\ppUpdator\\ppUpdator.App\\bin\\Release -Recurse -Force

Write-Host("Done")