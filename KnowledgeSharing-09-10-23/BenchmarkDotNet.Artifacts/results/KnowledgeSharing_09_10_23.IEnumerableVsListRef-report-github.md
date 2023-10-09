```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 10 (10.0.19045.3448/22H2/2022Update)
12th Gen Intel Core i7-1255U, 1 CPU, 12 logical and 10 physical cores
.NET SDK 7.0.401
  [Host]     : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2


```
| Method                                | NLoops | Mean         | Error       | StdDev      | Median       | Ratio | RatioSD | Gen0    | Gen1   | Allocated | Alloc Ratio |
|-------------------------------------- |------- |-------------:|------------:|------------:|-------------:|------:|--------:|--------:|-------:|----------:|------------:|
| **GetInts_Bench**                         | **1000**   |     **295.2 ns** |     **1.52 ns** |     **1.27 ns** |     **295.7 ns** |  **1.00** |    **0.00** |       **-** |      **-** |         **-** |          **NA** |
| GetInts_IE_Bench                      | 1000   |     310.6 ns |     2.91 ns |     2.72 ns |     311.2 ns |  1.05 |    0.01 |       - |      - |         - |          NA |
| GetInts_IEnumerable_Yield_Bench       | 1000   |   9,724.4 ns |   193.20 ns |   283.19 ns |   9,688.5 ns | 33.08 |    0.85 |       - |      - |      88 B |          NA |
| GetInts_IEnumerable_Bench             | 1000   |   6,044.6 ns |    51.12 ns |    45.32 ns |   6,054.8 ns | 20.49 |    0.20 |       - |      - |      40 B |          NA |
| GetInts_IEnumerable_ToList_Bench      | 1000   |   6,865.3 ns |   136.92 ns |   363.08 ns |   6,755.3 ns | 24.00 |    0.95 |  0.6485 | 0.0076 |    4096 B |          NA |
| GetInts_List_ToList_Bench             | 1000   |     674.5 ns |    12.84 ns |    10.02 ns |     672.3 ns |  2.29 |    0.03 |  0.6456 | 0.0095 |    4056 B |          NA |
| GetInts_List_ToListToListToList_Bench | 1000   |   1,094.1 ns |    21.04 ns |    20.66 ns |   1,089.6 ns |  3.72 |    0.08 |  1.9379 | 0.0458 |   12168 B |          NA |
| GetInts_IE_ToList_Bench               | 1000   |     682.6 ns |    14.28 ns |    41.44 ns |     663.9 ns |  2.38 |    0.07 |  0.6456 | 0.0095 |    4056 B |          NA |
| GetInts_IEnumerable_AlmostSmart_Yield | 1000   |   5,434.7 ns |   170.99 ns |   498.78 ns |   5,166.4 ns | 20.27 |    1.73 |       - |      - |      88 B |          NA |
| GetInts_IEnumerable_Smart_Yield       | 1000   |   5,149.8 ns |   101.64 ns |   121.00 ns |   5,109.7 ns | 17.55 |    0.44 |  0.0076 |      - |      88 B |          NA |
| GetInts_List_List_Yield               | 1000   |     749.7 ns |    22.04 ns |    63.94 ns |     737.1 ns |  2.44 |    0.16 |  0.6456 | 0.0095 |    4056 B |          NA |
| GetInts_IE_List_Yield                 | 1000   |     705.4 ns |    27.28 ns |    80.45 ns |     706.9 ns |  2.65 |    0.22 |  0.6456 | 0.0095 |    4056 B |          NA |
|                                       |        |              |             |             |              |       |         |         |        |           |             |
| **GetInts_Bench**                         | **10000**  |   **2,918.1 ns** |    **36.81 ns** |    **34.43 ns** |   **2,918.0 ns** |  **1.00** |    **0.00** |       **-** |      **-** |         **-** |          **NA** |
| GetInts_IE_Bench                      | 10000  |   3,103.2 ns |    61.33 ns |    91.80 ns |   3,076.4 ns |  1.05 |    0.03 |       - |      - |         - |          NA |
| GetInts_IEnumerable_Yield_Bench       | 10000  | 104,659.6 ns | 2,039.44 ns | 5,582.93 ns | 103,750.9 ns | 36.74 |    2.80 |       - |      - |      88 B |          NA |
| GetInts_IEnumerable_Bench             | 10000  |  60,140.3 ns | 1,177.06 ns | 1,355.50 ns |  60,079.4 ns | 20.62 |    0.42 |       - |      - |      40 B |          NA |
| GetInts_IEnumerable_ToList_Bench      | 10000  |  65,099.5 ns |   936.58 ns | 1,401.82 ns |  64,580.5 ns | 22.45 |    0.60 |  6.3477 | 0.6104 |   40096 B |          NA |
| GetInts_List_ToList_Bench             | 10000  |   6,879.6 ns |   189.99 ns |   545.11 ns |   6,711.2 ns |  2.32 |    0.18 |  6.3629 | 0.7019 |   40056 B |          NA |
| GetInts_List_ToListToListToList_Bench | 10000  |  12,620.8 ns |   411.72 ns | 1,207.51 ns |  12,442.8 ns |  4.85 |    0.43 | 19.1040 | 3.1738 |  120168 B |          NA |
| GetInts_IE_ToList_Bench               | 10000  |   6,784.9 ns |   149.10 ns |   415.63 ns |   6,766.7 ns |  2.41 |    0.08 |  6.3629 | 0.7019 |   40056 B |          NA |
| GetInts_IEnumerable_AlmostSmart_Yield | 10000  |  49,013.4 ns |   891.76 ns | 1,608.03 ns |  48,316.6 ns | 17.32 |    0.58 |       - |      - |      88 B |          NA |
| GetInts_IEnumerable_Smart_Yield       | 10000  |  51,247.0 ns | 1,021.73 ns | 2,428.24 ns |  50,985.8 ns | 17.05 |    0.57 |       - |      - |      88 B |          NA |
| GetInts_List_List_Yield               | 10000  |   6,449.9 ns |   124.18 ns |   318.31 ns |   6,337.8 ns |  2.21 |    0.11 |  6.3629 | 0.7019 |   40056 B |          NA |
| GetInts_IE_List_Yield                 | 10000  |   6,789.4 ns |   168.75 ns |   494.91 ns |   6,718.8 ns |  2.33 |    0.19 |  6.3629 | 0.7019 |   40056 B |          NA |
