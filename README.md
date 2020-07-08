# JSIL Compilation Example

This is an example of compilation of a C# class library using [JSIL](https://github.com/sq/JSIL), and using it in a front-end page.

## Setup

Run `git submodule update --init --recursive` to install the submodules (JSIL)

## Compilation

First, ensure you have [JSIL](https://github.com/sq/JSIL) installed, and the path to the folder containing JSILc.exe is in your PATH environment variable (`JSILc` should give an output displaying options when run in the command line)

Build the C# class library solution using `dotnet build ExampleJsilCompilation.sln`.

Then transpile the dll to JavaScript with `JSILc .\ExampleJsilCompilation\bin\Debug\netcoreapp3.1\ExampleJsilCompilation.dll -o js`.

This will output the compiled JavaScript into the `js` folder, so it can be used by the front-end.