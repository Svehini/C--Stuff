public class Solution {
    public int DominantIndex(int[] nums) {
        int biggestInteger = 0;
        int biggestIntegerIndex = 0;
        int seccondBiggestInteger = 0;
        for (int number = 0; number < nums.Length; number++){
            if (nums[number] > biggestInteger){
                seccondBiggestInteger = biggestInteger;
                biggestInteger = nums[number];
                biggestIntegerIndex = number;
            }
            else if (nums[number] > seccondBiggestInteger){
                seccondBiggestInteger = nums[number];
            }
        }
        if (biggestInteger >=  seccondBiggestInteger * 2){
            return biggestIntegerIndex;
        }
        return -1;
    }
}