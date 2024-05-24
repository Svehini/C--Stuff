public class Solution {
    public int DistanceTraveled(int mainTank, int additionalTank) {
        int totalDistance = 0;
        while (mainTank != 0){
            if (mainTank < 5){
                return totalDistance + (mainTank*10);
            }
            mainTank -= 5;
            totalDistance += 50;
            if (additionalTank != 0){
                mainTank += 1;
                additionalTank -= 1;
            }
            if (additionalTank == 0){
                return totalDistance + (mainTank*10);
            }
        }
        return totalDistance;
    }
}