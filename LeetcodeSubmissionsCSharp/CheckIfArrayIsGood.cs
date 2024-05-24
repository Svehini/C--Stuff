public class Solution {
    public bool IsGood(int[] nums) {
        Array.Sort(nums);
        for (int num = 0; num < nums.Length; num++){
            if (num == nums.Length-1){
                if (nums[num] == num){
                    return true;
                }
                else{
                    return false;
                }
                
            }
            else if (nums[num] != num+1){
                return false;
            }
        }
        return true;
    }
}