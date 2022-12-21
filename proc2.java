using System;

 class Program
    {
        static void Main()
        {
        int k=int.Parse(Console.ReadLine());
        int n=int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for(int i=0;i<n;i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] arr2 = new int[n];
        //int c = 0;
        for(int i=0;i<n;i++)
        {
            int ans = arr[i] - k;
            if(ans<0 || ans==0)
            {
                arr2[i] = arr[i] + k;
            }
            else
            {
                arr2[i] = arr[i]-k;
            }
        }

        for(int i=0;i<n;i++)
        {
            Console.WriteLine(arr2[i]); 
        }
        Array.Sort(arr2);
        int ans1 = arr2[n-1] - arr2[0];
        Console.WriteLine(ans1);
        }
    }
