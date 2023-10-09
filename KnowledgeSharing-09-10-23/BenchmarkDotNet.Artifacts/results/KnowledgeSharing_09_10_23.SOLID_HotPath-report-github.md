```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 10 (10.0.19045.3448/22H2/2022Update)
12th Gen Intel Core i7-1255U, 1 CPU, 12 logical and 10 physical cores
.NET SDK 7.0.401
  [Host]     : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2


```
| Method     | Mean     | Error    | StdDev   | Median   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------- |---------:|---------:|---------:|---------:|------:|--------:|----------:|------------:|
| Benchmark  | 503.3 ns | 24.77 ns | 66.55 ns | 475.0 ns |  1.07 |    0.04 |         - |          NA |
| Benchmark2 | 436.6 ns |  2.22 ns |  1.73 ns | 436.9 ns |  1.00 |    0.00 |         - |          NA |
