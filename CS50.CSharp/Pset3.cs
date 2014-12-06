namespace CS50.CSharp
{
    public static class PSet3
    {
    }

    public static class PSet3Custom
    {
        public static void Sort(int[] values, int n)
        {
            bool unSorted = true;
            var insertionIndex = 0;
            while (unSorted)
            {
                // Get the lowest value after the most recently inserted low value.
                var results = LowestValue(values, insertionIndex, values.Length);
                var lowest = results[0];
                var lowestValueIndex = results[1];

                // Shift all the values after the insertion index down by one.
                Shift(values, insertionIndex, lowestValueIndex);

                // Bubble lowest value according to insertionIndex;
                values[insertionIndex] = lowest;

                // Move to next position to order from.
                insertionIndex++;

                if (insertionIndex == values.Length - 1)
                {
                    unSorted = false;
                }
            }
        }

        public static int[] LowestValue(int[] values, int start, int end)
        {
            var lowest = values[start];
            var lowestValueIndex = 0;
            for (int i = start + 1; i < end; i++)
            {
                if (i == 0) lowest = values[i];
                if (values[i] < lowest)
                {
                    lowest = values[i];
                    lowestValueIndex = i;
                }
            }
            return new[] { lowest, lowestValueIndex };
        }

        public static void Shift(int[] values, int insertionIndex, int lowestValueIndex)
        {
            // Move all values after the insertion index and before the index of the lowest value down by one.
            for (int i = lowestValueIndex - 1; i >= insertionIndex && i <= values.Length - 1; i--)
            {
                values[i + 1] = values[i];
            }
        }
    }
}