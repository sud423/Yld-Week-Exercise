// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

public class Program
{

    static int[] source = new int[1000 * 100];
    static void Main(string[] args)
    {


        /**
         * 基准测试，取消注释就可
         */
        //for (int i = 0; i < source.Length; i++)
        //    source[i] = new Random().Next(0, int.MaxValue);

        //BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, new DebugInProcessConfig());


        int[] arr = { 3, 5, 27, 45, 34, 9, 18 };

        Console.WriteLine("待查找的数组如下：");
        foreach (int i in arr)
            Console.Write(i + "  ");

        Console.WriteLine();
        Console.WriteLine();

        int index = Max(arr);

        Console.WriteLine("使用 for 查找 最大值=" + arr[index] + ",下标=" + index);

        int max = arr.Max();

        Console.WriteLine();
        Console.WriteLine("使用 Enumerable.Max 查找最大值=" + max + ",下标=" + Array.IndexOf(arr, max));

        int max1 = arr.MaxBy(a => a);

        Console.WriteLine();
        Console.WriteLine("使用 Enumerable.MaxBy 查找最大值=" + max1 + ",下标=" + Array.IndexOf(arr, max1));

        //找最小值
        Console.WriteLine();

        int minIndex = Min(arr);

        Console.WriteLine("使用 for 查找 最小值=" + arr[minIndex] + ",下标=" + minIndex);

        int min = arr.Min();

        Console.WriteLine();
        Console.WriteLine("使用 Enumerable.Min 查找最小值=" + min + ",下标=" + Array.IndexOf(arr, min));

        int min1 = arr.MinBy(a => a);

        Console.WriteLine();
        Console.WriteLine("使用 Enumerable.MinBy 查找最大值=" + min1 + ",下标=" + Array.IndexOf(arr, min1));


        Console.ReadLine();
    }


    [Benchmark]
    public void UseMax()
    {
        source.Max();
    }


    [Benchmark]
    public void UseMaxBy()
    {
        source.MaxBy(x => x);
    }

    [Benchmark]
    public void UseFor()
    {
        Max(source);
    }

    /// <summary>
    /// 找出数组中最大值的下标
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    static int Max(int[] arr)
    {
        //假设第1个为最大值
        int max = arr[0];
        int maxIndex = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            //将 max 与数组中的元素去对比，如果 max 小于当前值，就将值赋给 max，并将下标赋值给 maxIndex
            if (arr[i] > max)
            {
                max = arr[i];
                maxIndex = i;
            }
        }

        return maxIndex;
    }



    /// <summary>
    /// 找出数组中最小值的下标
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    static int Min(int[] arr)
    {
        //假设第1个为最小值
        int min = arr[0];
        int minIndex = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            //将 min 与数组中的元素去对比，如果 min 大于当前值，就将值赋给 min，并将下标赋值给 minIndex
            if (arr[i] < min)
            {
                min = arr[i];
                minIndex = i;
            }
        }

        return minIndex;
    }
}