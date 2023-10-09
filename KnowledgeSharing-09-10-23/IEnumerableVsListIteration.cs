using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace KnowledgeSharing_09_10_23
{
    [RPlotExporter]
    [JsonExporterAttribute.Full()]
    [MemoryDiagnoser(true)]
    public class IEnumerableVsListIteration
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
        public void DataTable_Iteration()
        {
            var num = 0;
            for (int i = 0; i < DataTable.Length; i++)
            {
                num += DataTable[i];
            }
        }

        [Benchmark]
        public void DataList_Iteration_ForLoop()
        {
            var num = 0;
            for (int i = 0; i < DataList.Count; i++)
            {
                num += DataList[i];
            }
        }

        [Benchmark]
        public void DataList_Iteration_ForEach()
        {
            var num = 0;
            foreach (var element in DataList)
            {
                num += element;
            }
        }

        [Benchmark]
        public void DataIEnumerable_Iteration_ForEach()
        {
            var num = 0;
            foreach (var element in DataIEnumerable)
            {
                num += element;
            }
        }

        [Benchmark]
        public void DataIEnumerable_Iteration_ForLoop_WithCount()
        {
            var num = 0;
            for (int i = 0; i < DataIEnumerable.Count(); i++)
            {
                num += DataIEnumerable.ElementAt(i);
            }
        }
    }
}