using BenchmarkDotNet.Attributes;
using System.Runtime.CompilerServices;

namespace KnowledgeSharing_09_10_23
{
    [RPlotExporter]
    [JsonExporterAttribute.Full()]
    [MemoryDiagnoser(true)]
    public class SOLID_HotPath
    {
        [Benchmark]
        public void Benchmark()
        {
            SharedMethod();
        }

        [Benchmark(Baseline = true)]
        public void Benchmark2()
        {
            SharedMethodAgressive();
        }

        private int SharedMethod()
        {
            var a = 1; var b = 2; var c = 3; var d = 4; var e = 5; var f = 6; var g = 7; var h = 8; var i = 9; var j = 10; var k = 11; var l = 12; var m = 13; var n = 14; var o = 15; var p = 16; var q = 17; var r = 18; var s = 19; var t = 20; var u = 21; var v = 22; var w = 23; var x = 24; var y = 25; var z = 26;

            for (int num = 0; num < 100; num++)
            {
                a = a + 1; b = b + 1; c = c + 1; d = d + 1; e = e + 1; f = f + 1; g = g + 1; h = h + 1; i = i + 1; j = j + 1; k = k + 1; l = l + 1; m = m + 1; n = n + 1; o = o + 1; p = p + 1; q = q + 1; r = r + 1; s = s + 1; t = t + 1; u = u + 1; v = v + 1; w = w + 1; x = x + 1; y = y + 1; z = z + 1;
                b = a + b; c = c + b; d = d + b; e = e + b; f = f + b; g = g + b; h = h + b; i = i + b; j = j + b; k = k + b; l = l + b; m = m + b; n = n + b; o = o + b; p = p + b; q = q + b; r = r + b; s = s + b; t = t + b; u = u + b; v = v + b; w = w + b; x = x + b; y = y + b; z = z + b;
            }
            return a + b + c + d + e + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w + x + y + z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private int SharedMethodAgressive()
        {
            var a = 1; var b = 2; var c = 3; var d = 4; var e = 5; var f = 6; var g = 7; var h = 8; var i = 9; var j = 10; var k = 11; var l = 12; var m = 13; var n = 14; var o = 15; var p = 16; var q = 17; var r = 18; var s = 19; var t = 20; var u = 21; var v = 22; var w = 23; var x = 24; var y = 25; var z = 26;

            for (int num = 0; num < 100; num++)
            {
                a = a + 1; b = b + 1; c = c + 1; d = d + 1; e = e + 1; f = f + 1; g = g + 1; h = h + 1; i = i + 1; j = j + 1; k = k + 1; l = l + 1; m = m + 1; n = n + 1; o = o + 1; p = p + 1; q = q + 1; r = r + 1; s = s + 1; t = t + 1; u = u + 1; v = v + 1; w = w + 1; x = x + 1; y = y + 1; z = z + 1;
                b = a + b; c = c + b; d = d + b; e = e + b; f = f + b; g = g + b; h = h + b; i = i + b; j = j + b; k = k + b; l = l + b; m = m + b; n = n + b; o = o + b; p = p + b; q = q + b; r = r + b; s = s + b; t = t + b; u = u + b; v = v + b; w = w + b; x = x + b; y = y + b; z = z + b;
            }
            return a + b + c + d + e + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w + x + y + z;
        }
    }
}