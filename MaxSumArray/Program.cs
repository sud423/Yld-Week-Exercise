// See https://aka.ms/new-console-template for more information


int[] arr1 = { 3 };
int max1 = MaxSumArrary(arr1);

Console.WriteLine("[3]\n连续子数组最大和=" + max1);

int[] arr2 = { 9, 2, -3, 6, 5 };
int max2 = MaxSumArrary(arr2);

Console.WriteLine("\n[9,2,-3,6,5]\n连续子数组最大和=" + max2);

int[] arr3 = { -2, 5 };
int max3 = MaxSumArrary(arr3);

Console.WriteLine("\n[-2,5]\n连续子数组最大和=" + max3);

int[] arr4 = { -4, 2, -5, 1, 2, 3, 6, -5, 1 };
int max4 = MaxSumArrary(arr4);

Console.WriteLine("\n[-4, 2, -5, 1, 2, 3, 6, -5, 1]\n连续子数组最大和=" + max4);

Console.ReadKey();


//static int MaxSumArrary(int[] arr)
//{
//    if (arr == null || arr.Length == 0)
//        return 0;

//    //存储组成子数组和最大值
//    int globalMax = 0;

//    //循环每个元素与后面连续元素组成子数组的第一个元素
//    for (int i = 0; i < arr.Length; i++)
//    {
//        //存储计算子数组的和
//        int currMax = 0;
//        //循环子数组求和
//        for (int j = i; j < arr.Length; j++)
//        {
//            currMax = currMax + arr[j];
//            //判断从第 i 个到第 j 个的子数组和大于之前子数组的和则要替换
//            if (globalMax < currMax)
//                globalMax = currMax;
//        }
//    }
//    return globalMax;
//}

//static int MaxSumArrary(int[] arr)
//{
//    if (arr == null || arr.Length == 0)
//    {
//        return 0;
//    }

//    //存储子数组和最大值
//    int globalMax = arr[0];
//    //存储计算子数组的和
//    int currMax = arr[0];
//    for (int i = 1; i < arr.Length; i++)
//    {
//        currMax += arr[i];

//        /**
//         * 判断当前累计子数组和是否大于当前元素
//         * 如果小于当前元素则把当前元素为子数组的第一个元素
//         * 然后重新求和
//         */
//        if (currMax < arr[i])
//            currMax = arr[i];

//        //判断从第 i 个到第 j 个的子数组和大于之前子数组的和则要替换
//        if (globalMax < currMax)
//            globalMax = currMax;
//    }
//    return globalMax;
//}

static int MaxSumArrary(int[] arr)
{
    if (arr == null || arr.Length == 0)
    {
        return 0;
    }

    //存储子数组和最大值
    int globalMax = arr[0];
    //存储计算子数组的和
    int currMax = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        currMax = Math.Max(currMax + arr[i], arr[i]);

        globalMax = Math.Max(globalMax, currMax);
    }
    return globalMax;
}