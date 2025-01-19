class Program
{
    static void Main(string[] args)
    {

        int[] nums = [9, 6, 4, 2, 3, 5, 7, 0, 1];
        int[] numsExpect = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

        int result = Solution(nums, numsExpect);
        Console.WriteLine(result); 

    }

    static int Solution(int[] nums, int[] numsExpect) 
    {
        // có 2 cái mảng nè
        // tìm xem số nào ko có trong mảng cần tìm
        for(int i = 0; i < numsExpect.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (numsExpect[i] == nums[j])
                {
                    count++;   
                }
            }
            if (count == 0)
            {
                return numsExpect[i];
            }
        }
        return -1;
    }
}