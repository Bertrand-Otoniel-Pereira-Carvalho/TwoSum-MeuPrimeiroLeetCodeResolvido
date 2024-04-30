public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for ( int i = 0; i < nums.Length;i++)
        {
             int a = 0;
            while( a < nums.Length)
            {
                if ( nums[a] + nums[i] == target && a != i)
                {
                    int[] array = new int[2] {a,i};
                    return array;
                } 
                a++;
            }
        }
        return null;
    }
}