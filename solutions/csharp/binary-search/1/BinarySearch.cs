public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        int low = 0;
        int high = input.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (input[mid] == value)
                return mid;

            if (input[mid] < value)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return -1;
    }
}