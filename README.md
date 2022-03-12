# Results of benchmarks
## FindItem
|          Method |                  Job |              Runtime |          Mean |         Error |         StdDev |        Median |    Ratio |  RatioSD |  Gen 0 | Allocated |
|---------------- |--------------------- |--------------------- |--------------:|--------------:|---------------:|--------------:|---------:|---------:|-------:|----------:|
|      FindInList |             .NET 5.0 |             .NET 5.0 | 389,115.77 ns | 96,162.155 ns | 283,536.285 ns | 219,627.64 ns | 4,705.60 | 3,474.31 |      - |     104 B |
|     FindInArray |             .NET 5.0 |             .NET 5.0 | 129,763.28 ns |  5,141.768 ns |  14,247.815 ns | 130,132.53 ns | 1,576.18 |   237.70 |      - |      96 B |
| FindInDicString |             .NET 5.0 |             .NET 5.0 |      83.56 ns |      2.413 ns |       7.116 ns |      84.43 ns |     1.00 |     0.00 | 0.0254 |     120 B |
|  FindInDicTuple |             .NET 5.0 |             .NET 5.0 |     161.82 ns |      5.764 ns |      16.723 ns |     155.96 ns |     1.95 |     0.25 | 0.0083 |      40 B |
|                 |                      |                      |               |               |                |               |          |          |        |           |
|      FindInList | .NET Framework 4.6.1 | .NET Framework 4.6.1 | 154,159.72 ns |  3,339.943 ns |   9,365.558 ns | 151,742.80 ns | 1,430.18 |   113.68 |      - |     106 B |
|     FindInArray | .NET Framework 4.6.1 | .NET Framework 4.6.1 | 118,007.93 ns |  2,348.269 ns |   6,661.647 ns | 117,554.01 ns | 1,098.48 |    56.35 |      - |      97 B |
| FindInDicString | .NET Framework 4.6.1 | .NET Framework 4.6.1 |     106.60 ns |      2.046 ns |       1.913 ns |     106.56 ns |     1.00 |     0.00 | 0.0391 |     185 B |
|  FindInDicTuple | .NET Framework 4.6.1 | .NET Framework 4.6.1 |     235.48 ns |      5.603 ns |      16.077 ns |     232.43 ns |     2.24 |     0.10 | 0.0083 |      40 B |

## StringVsStringBuilder
|               Method |                  Job |              Runtime |      Mean |    Error |   StdDev | Ratio | RatioSD |    Gen 0 |  Gen 1 | Allocated |
|--------------------- |--------------------- |--------------------- |----------:|---------:|---------:|------:|--------:|---------:|-------:|----------:|
| ConcatenationStrings |             .NET 5.0 |             .NET 5.0 | 187.87 us | 2.080 us | 1.736 us | 14.17 |    0.41 | 605.2246 | 8.5449 |  2,783 KB |
|       StringBuilders |             .NET 5.0 |             .NET 5.0 |  12.86 us | 0.256 us | 0.567 us |  1.00 |    0.00 |   1.9226 | 0.0610 |      9 KB |
|                      |                      |                      |           |          |          |       |         |          |        |           |
| ConcatenationStrings | .NET Framework 4.6.1 | .NET Framework 4.6.1 | 233.82 us | 4.621 us | 9.230 us |  3.90 |    0.23 | 606.2012 |      - |  2,796 KB |
|       StringBuilders | .NET Framework 4.6.1 | .NET Framework 4.6.1 |  60.12 us | 1.193 us | 2.669 us |  1.00 |    0.00 |   8.6670 |      - |     40 KB |

## ListArray
|                      Method |                  Job |              Runtime |           Mean |         Error |        StdDev |         Median |     Ratio | RatioSD |       Gen 0 |   Gen 1 |  Allocated |
|---------------------------- |--------------------- |--------------------- |---------------:|--------------:|--------------:|---------------:|----------:|--------:|------------:|--------:|-----------:|
|                   AddToList |             .NET 5.0 |             .NET 5.0 |      22.557 us |     0.4465 us |     1.2373 us |      22.123 us |      0.92 |    0.06 |     27.7710 |  5.5237 |     128 KB |
|                   FillArray |             .NET 5.0 |             .NET 5.0 |       5.792 us |     0.1159 us |     0.1507 us |       5.744 us |      0.23 |    0.01 |      8.4686 |       - |      39 KB |
|           AddToResizedArray |             .NET 5.0 |             .NET 5.0 |  13,129.825 us |   260.0115 us |   612.8778 us |  13,030.829 us |    528.98 |   35.28 |  42359.3750 | 15.6250 | 195,586 KB |
|                 ConcatArray |             .NET 5.0 |             .NET 5.0 |  14,740.156 us |   291.6953 us |   582.5471 us |  14,478.967 us |    592.44 |   34.25 |  42703.1250 | 15.6250 | 196,992 KB |
|          ConvertArrayToList |             .NET 5.0 |             .NET 5.0 |      24.889 us |     0.4940 us |     1.1351 us |      24.494 us |      1.00 |    0.00 |     36.1328 |  0.0610 |     167 KB |
| ConvertArrayToListEveryTime |             .NET 5.0 |             .NET 5.0 |  47,021.701 us |   908.0193 us | 1,115.1293 us |  46,691.945 us |  1,871.08 |   88.52 | 169363.6364 | 90.9091 | 782,266 KB |
|                             |                      |                      |                |               |               |                |           |         |             |         |            |
|                   AddToList | .NET Framework 4.6.1 | .NET Framework 4.6.1 |      30.726 us |     0.5462 us |     0.9566 us |      30.370 us |      0.93 |    0.05 |     27.7710 |  4.6082 |     128 KB |
|                   FillArray | .NET Framework 4.6.1 | .NET Framework 4.6.1 |       6.642 us |     0.1323 us |     0.2791 us |       6.552 us |      0.20 |    0.01 |      8.4686 |       - |      39 KB |
|           AddToResizedArray | .NET Framework 4.6.1 | .NET Framework 4.6.1 |  12,793.768 us |   252.8271 us |   415.4022 us |  12,777.388 us |    388.34 |   20.40 |  42359.3750 | 15.6250 | 195,804 KB |
|                 ConcatArray | .NET Framework 4.6.1 | .NET Framework 4.6.1 | 622,587.750 us | 9,021.6964 us | 7,997.4989 us | 621,604.750 us | 18,683.04 |  810.43 | 169000.0000 |       - | 782,187 KB |
|          ConvertArrayToList | .NET Framework 4.6.1 | .NET Framework 4.6.1 |      32.944 us |     0.6051 us |     1.3283 us |      32.439 us |      1.00 |    0.00 |     36.1328 |  0.1221 |     168 KB |
| ConvertArrayToListEveryTime | .NET Framework 4.6.1 | .NET Framework 4.6.1 |  46,730.520 us |   840.7485 us |   968.2072 us |  46,547.927 us |  1,403.06 |   76.34 | 169363.6364 |       - | 783,993 KB |

