namespace _0._0
{
    internal class arrLearn
    {
        public static void Call()
        {
            int[] arr1 = { 100, 80, 72, 180, 850, 50, 1 };
            int[] sort = BoubleSort(arr1);
            foreach (var item in sort)
            {
                System.Console.WriteLine(item);
            }
        }

        private static  int[] BoubleSort(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {

                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }

            }
            return arr;
        }
    }
}