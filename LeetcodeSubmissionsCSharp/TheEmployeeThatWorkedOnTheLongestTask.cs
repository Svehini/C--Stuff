public class Solution {
    public int HardestWorker(int n, int[][] logs) {
        int longestHours = 0;
        int longestWorkingEmployee = 0;
        int startTime = 0;
        for (int employee = 0; employee < logs.Length; employee++){
            if (logs[employee][1]-startTime > longestHours){
                longestHours = logs[employee][1]-startTime;
                longestWorkingEmployee = logs[employee][0];
            }
            else if ((logs[employee][1]-startTime == longestHours) && (logs[employee][0] < longestWorkingEmployee)){
                longestHours = logs[employee][1]-startTime;
                longestWorkingEmployee = logs[employee][0];
            }
            startTime = logs[employee][1];
        }
        return longestWorkingEmployee;
    }
}