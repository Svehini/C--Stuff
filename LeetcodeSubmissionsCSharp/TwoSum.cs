public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
       for (int n = 0; n < nums.Length-1; n++){
           for (int m = n+1; m < nums.Length; m++){
               if (nums[m] + nums[n] == target)
               return new int[] {n, m};
           }
       }
       return new int[] { };
    }
}