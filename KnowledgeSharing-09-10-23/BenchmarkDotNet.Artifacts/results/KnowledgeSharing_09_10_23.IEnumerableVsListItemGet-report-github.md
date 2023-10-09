```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 10 (10.0.19045.3448/22H2/2022Update)
12th Gen Intel Core i7-1255U, 1 CPU, 12 logical and 10 physical cores
.NET SDK 7.0.401
  [Host]     : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2


```
| Method         | NLoops | Mean      | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|--------------- |------- |----------:|----------:|----------:|------:|--------:|----------:|------------:|
| **Find**           | **1000**   |  **1.550 μs** | **0.0189 μs** | **0.0177 μs** |  **1.00** |    **0.00** |         **-** |          **NA** |
| FirstOrDefault | 1000   |  7.559 μs | 0.1506 μs | 0.1674 μs |  4.86 |    0.14 |      40 B |          NA |
| First          | 1000   |        NA |        NA |        NA |     ? |       ? |        NA |           ? |
|                |        |           |           |           |       |         |           |             |
| **Find**           | **10000**  | **13.457 μs** | **0.0979 μs** | **0.0818 μs** |  **1.00** |    **0.00** |         **-** |          **NA** |
| FirstOrDefault | 10000  | 66.544 μs | 0.5912 μs | 0.5530 μs |  4.95 |    0.06 |      40 B |          NA |
| First          | 10000  | 66.510 μs | 0.6499 μs | 0.9727 μs |  4.97 |    0.06 |      40 B |          NA |

Benchmarks with issues:
  IEnumerableVsListItemGet.First: DefaultJob [NLoops=1000]
