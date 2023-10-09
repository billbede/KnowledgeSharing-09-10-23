```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 10 (10.0.19045.3448/22H2/2022Update)
12th Gen Intel Core i7-1255U, 1 CPU, 12 logical and 10 physical cores
.NET SDK 7.0.401
  [Host]     : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.11 (7.0.1123.42427), X64 RyuJIT AVX2


```
| Method   | Mean      | Error    | StdDev   | Ratio | Allocated | Alloc Ratio |
|--------- |----------:|---------:|---------:|------:|----------:|------------:|
| Sleep50  |  62.03 ms | 0.335 ms | 0.313 ms |  0.57 |      56 B |        0.55 |
| Sleep97  | 107.92 ms | 0.650 ms | 0.608 ms |  1.00 |     101 B |        1.00 |
| Sleep99  | 108.06 ms | 0.688 ms | 0.643 ms |  1.00 |     101 B |        1.00 |
| Sleep100 | 108.24 ms | 0.698 ms | 0.653 ms |  1.00 |     101 B |        1.00 |
| Sleep101 | 108.15 ms | 0.576 ms | 0.538 ms |  1.00 |     101 B |        1.00 |
| Sleep103 | 108.50 ms | 0.681 ms | 0.604 ms |  1.00 |     101 B |        1.00 |
| Sleep150 | 154.73 ms | 0.814 ms | 0.761 ms |  1.43 |     126 B |        1.25 |
