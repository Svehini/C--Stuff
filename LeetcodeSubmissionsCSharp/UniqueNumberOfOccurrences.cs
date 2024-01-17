public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> uniqueOccDict = new Dictionary<int, int>();
        foreach (int num in arr){
            int[] keyList = uniqueOccDict.Keys.ToArray();
            if (!keyList.Contains(num))
            uniqueOccDict.Add(num, 1);
            else
            uniqueOccDict[num] = uniqueOccDict[num]+1;
        }
        int[] allOccs = uniqueOccDict.Values.ToArray();
        List<object> noDups = new List<object>();
        foreach (int num in allOccs){
            if (!noDups.Contains(num))
            noDups.Add(num);
            else
            return false;
        }
        return true;
    }
}