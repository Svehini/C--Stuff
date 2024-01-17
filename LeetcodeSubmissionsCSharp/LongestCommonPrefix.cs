public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string longestCommonPrefix = new string("");
        string firstWord = strs[0];
        for (int x = 0; x < strs[0].Length; x++){
            try{
                foreach (string str in strs){
                    if (firstWord[x] != str[x])
                    return longestCommonPrefix;
                }
                longestCommonPrefix += firstWord[x];
            }
            catch {
                return longestCommonPrefix;
            }
        }
        return longestCommonPrefix;
    }
}