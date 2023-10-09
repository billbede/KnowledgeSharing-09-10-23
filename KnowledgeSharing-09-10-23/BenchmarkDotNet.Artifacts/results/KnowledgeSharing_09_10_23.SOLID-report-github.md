```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 10 (10.0.19045.3448/22H2/2022Update)
12th Gen Intel Core i7-1255U, 1 CPU, 12 logical and 10 physical cores
.NET SDK 7.0.401
  [Host]     : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2


```
| Method     | Mean     | Error    | StdDev   | Median   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------- |---------:|---------:|---------:|---------:|------:|--------:|----------:|------------:|
| Benchmark  | 434.1 ns |  6.98 ns |  6.53 ns | 433.1 ns |  0.89 |    0.09 |         - |          NA |
| Benchmark2 | 469.0 ns | 18.78 ns | 55.08 ns | 444.8 ns |  1.00 |    0.00 |         - |          NA |
