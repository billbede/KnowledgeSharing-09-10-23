```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 10 (10.0.19045.3448/22H2/2022Update)
12th Gen Intel Core i7-1255U, 1 CPU, 12 logical and 10 physical cores
.NET SDK 7.0.401
  [Host]     : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2


```
| Method                                      | NLoops | Mean         | Error       | StdDev      | Median       | Ratio | RatioSD | Allocated | Alloc Ratio |
|-------------------------------------------- |------- |-------------:|------------:|------------:|-------------:|------:|--------:|----------:|------------:|
| **DataTable_Iteration**                         | **1000**   |     **330.9 ns** |     **6.34 ns** |     **6.23 ns** |     **332.3 ns** |  **1.00** |    **0.00** |         **-** |          **NA** |
| DataList_Iteration_ForLoop                  | 1000   |     360.9 ns |     3.98 ns |     3.72 ns |     361.7 ns |  1.09 |    0.03 |         - |          NA |
| DataList_Iteration_ForEach                  | 1000   |     380.5 ns |     3.88 ns |     3.24 ns |     380.3 ns |  1.16 |    0.03 |         - |          NA |
| DataIEnumerable_Iteration_ForEach           | 1000   |   5,555.3 ns |    55.00 ns |    51.45 ns |   5,553.6 ns | 16.81 |    0.35 |      40 B |          NA |
| DataIEnumerable_Iteration_ForLoop_WithCount | 1000   |  10,385.1 ns |    94.16 ns |    83.47 ns |  10,371.1 ns | 31.45 |    0.73 |         - |          NA |
|                                             |        |              |             |             |              |       |         |           |             |
| **DataTable_Iteration**                         | **10000**  |   **3,046.6 ns** |    **29.91 ns** |    **27.98 ns** |   **3,039.0 ns** |  **1.00** |    **0.00** |         **-** |          **NA** |
| DataList_Iteration_ForLoop                  | 10000  |   3,576.9 ns |    68.96 ns |   140.86 ns |   3,507.1 ns |  1.19 |    0.06 |         - |          NA |
| DataList_Iteration_ForEach                  | 10000  |   3,673.8 ns |    25.32 ns |    23.69 ns |   3,675.2 ns |  1.21 |    0.01 |         - |          NA |
| DataIEnumerable_Iteration_ForEach           | 10000  |  56,675.0 ns |   986.95 ns |   923.19 ns |  56,452.2 ns | 18.60 |    0.37 |      40 B |          NA |
| DataIEnumerable_Iteration_ForLoop_WithCount | 10000  | 115,641.5 ns | 2,048.79 ns | 5,177.56 ns | 116,361.3 ns | 35.80 |    2.01 |         - |          NA |
