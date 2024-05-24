public class Solution {
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target) {
        int EmployeesMetTarget = 0;
        for (int emp = 0; emp < hours.Length; emp++){
            if (hours[emp] >= target){
                EmployeesMetTarget++;
            }
        }
        return EmployeesMetTarget;
    }
}