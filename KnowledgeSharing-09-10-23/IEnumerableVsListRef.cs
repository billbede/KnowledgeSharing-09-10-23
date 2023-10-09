using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace KnowledgeSharing_09_10_23
{
    [RPlotExporter]
    [JsonExporterAttribute.Full()]
    [MemoryDiagnoser(true)]
    public class IEnumerableVsListRef
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
        public void GetInts_Bench()
        {
            var v = GetInts();
            var num = 0;
            for (int i = 0; i < v.Length; i++)
            {
                num += i;
            }
        }

        [Benchmark]
        public void GetInts_IE_Bench()
        {
            var v = GetInts();
            var num = 0;
            foreach (int i in v)
            {
                num += i;
            }
        }

        [Benchmark]
        public void GetInts_IEnumerable_Yield_Bench()
        {
            var v = GetInts_IEnumerable_Yield();
            var num = 0;
            foreach (int i in v)
            {
                num += i;
            }
        }

        [Benchmark]
        public void GetInts_IEnumerable_Bench()
        {
            var v = GetInts_IEnumerable();
            var num = 0;
            foreach (int i in v)
            {
                num += i;
            }
        }

        [Benchmark]
        public void GetInts_IEnumerable_ToList_Bench()
        {
            var v = GetInts_IEnumerable_ToList();
            var num = 0;
            foreach (int i in v)
            {
                num += i;
            }
        }

        [Benchmark]
        public void GetInts_List_ToList_Bench()
        {
            var v = GetInts_List_ToList();
            var num = 0;
            foreach (int i in v)
            {
                num += i;
            }
        }

        [Benchmark]
        public void GetInts_List_ToListToListToList_Bench()
        {
            var v = GetInts_List_ToListToListToList();
            var num = 0;
            foreach (int i in v)
            {
                num += i;
            }
        }

        [Benchmark]
        public void GetInts_IE_ToList_Bench()
        {
            var v = GetInts_IE_ToList();
            var num = 0;
            foreach (int i in v)
            {
                num += i;
            }
        }

        [Benchmark]
        public void GetInts_IEnumerable_AlmostSmart_Yield()
        {
            var v = GetInts_IEnumerable_Yield();
            var num = 0;
            foreach (int i in v)
            {
                if (i > NLoops / 2) break;
                num += i;
            }
        }

        [Benchmark]
        public void GetInts_IEnumerable_Smart_Yield()
        {
            var num = 0;
            foreach (int i in GetInts_IEnumerable_Yield())
            {
                if (i > NLoops / 2) break;
                num += i;
            }
        }

        [Benchmark]
        public void GetInts_List_List_Yield()
        {
            var v = GetInts_List_ToList();
            var num = 0;
            foreach (int i in v)
            {
                if (i > NLoops / 2) break;
                num += i;
            }
        }

        [Benchmark]
        public void GetInts_IE_List_Yield()
        {
            var v = GetInts_IE_ToList();
            var num = 0;
            foreach (int i in v)
            {
                if (i > NLoops / 2) break;
                num += i;
            }
        }

        private int[] GetInts()
        {
            return DataTable;
        }

        private IEnumerable<int> GetInts_IEnumerable_Yield()
        {
            foreach (int i in DataIEnumerable)
                yield return i;
        }

        private IEnumerable<int> GetInts_IEnumerable()
        {
            return DataIEnumerable;
        }

        private IEnumerable<int> GetInts_IEnumerable_ToList()
        {
            var a = DataIEnumerable.Where(x => x > 1);

            return DataIEnumerable.ToList();
        }

        /// ___COMPILER ERROR___
        ///  private List<int> GetInts_List_ListYield()
        ///  {
        ///      foreach (int i in DataList)
        ///          yield return i;
        ///  }

        private List<int> GetInts_List_ToList()
        {
            return DataList.ToList();
        }

        private List<int> GetInts_IE_ToList()
        {
            return DataIEnumerable.ToList();
        }

        private List<int> GetInts_List_ToListToListToList()
        {
            return DataList.ToList().ToList().ToList();
        }
    }
}