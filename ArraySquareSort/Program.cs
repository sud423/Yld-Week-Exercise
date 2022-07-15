// 对应 leetcode 题 977
int[] nums = { -4, -1, 0, 3, 10 };
for (int i = 0; i < nums.Length; i++)
{
    Console.Write(nums[i]+" ");
}
Console.WriteLine();
int[] results=SortedSquares(nums);

for (int i = 0; i < results.Length; i++)
{
    Console.Write(results[i] + " ");
}

static int[] SortedSquares(int[] nums)
{
    int [] result = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = nums[i] * nums[i];

        result[i] = nums[i];
        for (int j = nums.Length-1; j >= 0; j--)
        {
            nums[j] = nums[j] * nums[j];
            if (nums[i] > nums[j]) 
                result[j]=nums[i];
        }
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (Math.Abs(nums[i]) > Math.Abs(nums[j]))
            {
                int temp = Math.Abs(nums[i]);
                nums[i] = nums[j];
                nums[j] = temp;
            }
        }

    }

    return result;
}
