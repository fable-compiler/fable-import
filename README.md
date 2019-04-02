# fable-import

**EDIT**: This repository has been deprecated in favour of having separate repositories per binding for easier maintenance. To track the new repositories, please check [this issue](https://github.com/fable-compiler/fable-import/issues/80).

Fable bindings for JavaScript libraries. This repository contains only _pure_ bindings maintained by fable-compiler.org. Pure bindings only contain metadata and no helper code. The distinction is important because Fable packages must include the F# source code in a folder named `fable` ([example](https://github.com/fable-compiler/fable-powerpack/blob/b035313b7376922446d51e503ef2913ef41d2172/Fable.PowerPack.fsproj#L20-L23)) in order to compile it to JS. Packages in this repo don't do that.

You can find more bindings by other contributors. The convention is prefixing the packages with `Fable.Import` so please use that to make a search in [Nuget](https://www.nuget.org/).

> You can also check [awesome-fable](https://github.com/kunjee17/awesome-fable) for more bindings and useful Fable libraries and tools.

See README.md on each directory for instructions on how to install each binding.
