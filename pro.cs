using System;
class Program
{
    static void Main()
    {
        // int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(arr);
        int[] arr2 = new int[arr[n - 1] + 1];
        for (int i = 0; i < n; i++)
        {
            int c = arr[i];
            arr2[c] += 1;
        }
        int count = 0;
        for (int i = 0; i < arr2.Length; i++)
        {
            if (arr2[i] % 2 == 0)
            {
                int ans = arr2[i] / 2;
                count += ans;
            }
            else
            {

                arr2[i] = arr2[i] - 1;
                if (arr2[i] > 1)
                {
                    int ans1 = arr2[i] / 2;
                    count += ans1;
                }

            }
        }
        Console.WriteLine(count);
    }
}