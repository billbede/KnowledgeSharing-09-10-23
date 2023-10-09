using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace KnowledgeSharing_09_10_23
{
    [RPlotExporter]
    [JsonExporterAttribute.Full()]
    [MemoryDiagnoser(true)]
    public class IEnumerableVsListItemGet
    {
        [Params(1000, 10000)]
        public int NLoops { get; set; }

        private int[] DataTable;
        private List<int> DataList;
        private IEnumerable<int> DataIEnumerable;

        [GlobalSetup]
        public void GlobalSetup()
        {
            DataTable = new int[NLoops];

            for (int i = 0; i < NLoops; i++)
            {
                DataTable[i] = i;
            }

            DataList = DataTable.ToList();
            DataIEnumerable = DataList;
        }

        [Benchmark(Baseline = true)]
        public void Find()
        {
            var v = DataList.Find(x => x == 8888);
        }

        [Benchmark]
        public void FirstOrDefault()
        {
            var v = DataList.FirstOrDefault(x => x == 8888);
        }

        [Benchmark]
        public void First()
        {
            var v = DataList.First(x => x == 8888);
        }
    }
}