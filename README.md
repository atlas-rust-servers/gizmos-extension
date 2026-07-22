# Gizmos Framework
Gizmos framework for [Rust](https://store.steampowered.com/app/252490/Rust/) using the [Oxide/uMod](https://umod.org) or [Carbon](https://carbonmod.gg) extension platforms, exposing debug methods for developers.

## Getting Started
Download the artifact for your extension platform from the latest release:

### Oxide/uMod
1. Download `Oxide.Ext.GizmosExt.dll`.
2. Put the DLL into the `RustDedicated_Data\Managed` folder.
3. Restart the server.

### Carbon
1. Download `Carbon.Ext.GizmosExt.dll`.
2. Put the DLL into the `carbon\extensions` folder.
3. Restart the server.

## Usage
```csharp
using Oxide.Ext.GizmosExt;

// some code
OxideGizmos.Sphere(player, pos, radius, Color.green, DURATION);
OxideGizmos.Box(player, pos, rot, size, Color.green, DURATION);
```
![image](https://github.com/ilovepatatos-rust/gizmos-extension/assets/49655463/6736893e-b3f2-4115-8b81-f7b3aea31bd3)
