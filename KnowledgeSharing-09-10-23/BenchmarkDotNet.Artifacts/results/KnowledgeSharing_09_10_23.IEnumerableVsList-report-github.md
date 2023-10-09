```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 10 (10.0.19045.3448/22H2/2022Update)
12th Gen Intel Core i7-1255U, 1 CPU, 12 logical and 10 physical cores
.NET SDK 7.0.401
  [Host]     : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2


```
| Method | NLoops | Mean      | Error     | StdDev    | Median    | Allocated |
|------- |------- |----------:|----------:|----------:|----------:|----------:|
| **Test**   | **10**     | **0.0012 ns** | **0.0035 ns** | **0.0031 ns** | **0.0000 ns** |         **-** |
| **Test**   | **100**    | **0.0049 ns** | **0.0101 ns** | **0.0131 ns** | **0.0000 ns** |         **-** |
| **Test**   | **1000**   | **0.0302 ns** | **0.0190 ns** | **0.0323 ns** | **0.0327 ns** |         **-** |
