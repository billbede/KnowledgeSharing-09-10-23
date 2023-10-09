using BenchmarkDotNet.Running;

namespace KnowledgeSharing_09_10_23
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BenchmarkRunner.Run<IEnumerableVsListIteration>();
            BenchmarkRunner.Run<IEnumerableVsListItemGet>();
            BenchmarkRunner.Run<IEnumerableVsListRef>();
            BenchmarkRunner.Run<SOLID_HotPath>();
        }
    }
}