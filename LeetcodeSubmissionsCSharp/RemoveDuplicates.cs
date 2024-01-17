public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int n = 0;
        for (int m = 1; m < nums.Length; m++) {
            if (nums[n] != nums[m])
            nums[++n] = nums[m];
        }
        return n + 1;
    }
}