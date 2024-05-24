public class Solution {
    public int SmallestEqual(int[] nums) {
        int lowest = -1;
        int numsLength = nums.Length;
        for (int numIndex = 0; numIndex < numsLength; numIndex++ ){
            if (nums[numIndex] == numIndex % 10){
                if ((lowest == -1) || (numIndex < lowest)){
                    lowest = numIndex;
                }
            }
        }
        return lowest;
    }
}