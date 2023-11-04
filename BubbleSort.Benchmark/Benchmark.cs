using BenchmarkDotNet.Attributes;
using BubbleSort.TempVariable;
using BubbleSort.TupleSwap;

namespace BubbleSort.Benchmark
{
    public class Benchmark
    {
        [Params(10, 100, 1_000, 10_000, 100_000)]
        public int N;

        #pragma warning disable CS8618
        
        private int[] _tempVariableArray;
        private int[] _tupleSwapArray;
        
        #pragma warning restore CS8618

        [GlobalSetup]
        public void Setup()
        {
            _tempVariableArray = new int[N];
            _tupleSwapArray = new int[N];
            var rand = new Random();
            for (int i = 0; i < N; i++)
            {
                int valueSUT = rand.Next(N + 1);

                _tempVariableArray[i] = valueSUT;
                _tupleSwapArray[i] = valueSUT;
            }
        }

        [Benchmark]
        public void TempVariable_BubbleSortArray() => TempVariableBubbleSort.BubbleSortArray(_tempVariableArray);

        [Benchmark]
        public void TupleSwap_BubbleSortArray() => TupleSwapBubbleSort.BubbleSortArray(_tupleSwapArray);

    }
}
