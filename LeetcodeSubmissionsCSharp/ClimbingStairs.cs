public class Solution {
    public int ClimbStairs(int n) {
        int thisStep = 0;
        int lastStep = 1;
        int newLast = 0;
        for (int x = 0; x <= n+1; x++) {
            newLast = lastStep;
            lastStep = thisStep;
            thisStep = thisStep + newLast;
        }
        return lastStep;
    }
}