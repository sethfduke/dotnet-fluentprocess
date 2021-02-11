# FluentProcess

The FluentProcess library is sub-class of the Systems.Diagnostics.Process class and provides fluent style methods for building and executing a process without the need to separately define the StartInfo property. The construction and execution of a Process can be completed in a single line of code.

## Installation

The library is available via Nuget at https://www.nuget.org/packages/FluentProcess

## Usage

```
var p = new FluentProcess()
    .FileName("dotnet")
    .Arguments("--help")
    .UseShellExecute(false)
    .CreateNoWindow()
    .RedirectStandardError()
    .RedirectStandardOutput()
    .ErrorDataReceived((_, e) => Console.WriteLine(e.Data))
    .OutputDataReceived((_, e) => Console.WriteLine(e.Data))
    .Start()
    .BeginOutputReadLine()
    .WaitForExit();
```

## Issues

Please submit any issues or feature requests to https://github.com/sethfduke/dotnet-fluentprocess/issues

## Contributing

1. Fork this repository.
2. Create your feature branch: `git checkout -b my-new-feature`
3. Commit your changes: `git commit -am 'Add some feature'`
4. Push to the branch: `git push origin my-new-feature`
5. Submit a pull request

## History

Version 1.0.0 (2021-02-11) - Initial release

## Credits

Seth Duke (@sethfduke)

## License

The MIT License (MIT)

Copyright (c) 2021 Seth Duke

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.