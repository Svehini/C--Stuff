public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        int numOfPeople = people.Length;
        int indexTwo = numOfPeople-1;
        int numberOfBoats = 0;

        Array.Sort(people);
        Array.Reverse(people);

        for (int person = 0; person < numOfPeople; person++){
            if (person == indexTwo){
                return numberOfBoats+1;
            }
            if (people[person] + people[indexTwo] > limit){
                numberOfBoats++;
            }
            else{
                numberOfBoats++;
                indexTwo--;
            }
            if (person == indexTwo){
                return numberOfBoats;
            }
        }
        return numberOfBoats;
    }
}