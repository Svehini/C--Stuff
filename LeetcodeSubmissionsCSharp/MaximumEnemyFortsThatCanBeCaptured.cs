public class Solution {
    public int CaptureForts(int[] forts) {
        int longestStreak = 0;
        int currentStreak = 0;
        bool start = false;
        bool ourFort = false;
        for (int land = 0; land < forts.Length; land++){
            if (forts[land] == 0 && start){
                currentStreak += 1;
            }
            else if(forts[land] == 1){
                start = true;
                if (currentStreak > longestStreak){
                    if (!ourFort){
                        longestStreak = currentStreak;
                    }
                }
                currentStreak = 0;
                ourFort = true;
            }
            else if(forts[land] == -1){
                start = true;
                if (currentStreak > longestStreak){
                    if (ourFort){
                        longestStreak = currentStreak;
                    }
                }
                ourFort = false;
                currentStreak = 0;
            }
        }
        return longestStreak;
    }
}