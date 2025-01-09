public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        int list1index = 0;
        int list2index = 0;
        var intResult = new int[select.Length];
        for (int i = 0; i < select.Length; i++)
        {
            if (select[i] == 1)
            {
                intResult[i] = list1[list1index];
                list1index++;
            }
            else
            {
                intResult[i] = list2[list2index];
                list2index++;
            }
        }
        return intResult;
    }
}