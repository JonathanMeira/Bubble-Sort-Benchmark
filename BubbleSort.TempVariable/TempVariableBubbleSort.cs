namespace BubbleSort.TempVariable
{
    public class TempVariableBubbleSort
    {
        public static void BubbleSortArray(int[] unsortedArray)
        {
            var arrayLength = unsortedArray.Length;

            bool swapRequired;

            for (int i = 0; i < arrayLength - 1; i++)
            {
                swapRequired = false;

                for (int j = 0; j < arrayLength - i - 1; j++)
                {
                    if (unsortedArray[j] > unsortedArray[j + 1])
                    {
                        int tempVar = unsortedArray[j];
                        unsortedArray[j] = unsortedArray[j + 1];
                        unsortedArray[j + 1] = tempVar;
                        swapRequired = true;
                    }
                }

                if (!swapRequired)
                {
                    break;
                }
            }
        }
    }
}