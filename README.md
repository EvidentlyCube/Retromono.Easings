# Retromono.Easings
A collection of 31 easing functions in two variants: one that takes a single param (`time`) and another that takes four params (`from`, `to`, `time`, `duration`).

## Usage
Just call any static function from [Easings](api/Retromono.Easings.Easings.yml) or [EasingsMultiParam](api/Retromono.Easings.EasingsMultiParam.yml) with proper arguments.

> [!NOTE]
> All of the easings you can find in this library are unit tested and guaranteed to:
>
>  1. Return `0`/`<from>` when the time passed is `0`
>  2. Return `1`/`<to>` whe the time passed is `1`/`<duration>`
>  3. Never return a crazy number in the valid range

> [!WARNING]
> Do not pass `time` outside the accepted range (`0` to `1`/`<duration>`) because you're going to get crazy results.

## Installation

This package is available in NuGet as `retromono.easings`.

### NuGet CLI

 1. Make sure you have [installed NuGet](https://docs.microsoft.com/en-us/nuget/tools/nuget-exe-cli-reference#installing-nugetexe).
 2. Navigate to your project in CLI.
 3. Execute `nuget install retromono.easings`
 
### VisualStudio (any version)

 1. In the top menu go to `Tools` -> `NuGet Package Manager` -> `Manage NuGet Packages for Solution`. The naming can be slightly different in different Visual Studio versions.
 2. Change the tab to *Browse*.
 3. Type `retromono.easings` in the Search field.
 4. Select the package and in the project list on the right click the checkbox next to the projects you want to have this package, select version underneath and press *Install*.
 
### JetBRains Rider

 1. In the top menu go to `Tools` -> `NuGet` -> `Manage NuGet Packages for Solution`.
 2. Type `retromono.easings` in the Search field.
 3. Select the package and in the project list on the right select version and press the plus button next to the projects which you want to have the package installed.
 
## License

This project is licensed under MIT license and the body of the license can be found [here](https://github.com/RetrocadeNet/Retromono.Easings/blob/master/LICENSE.txt).