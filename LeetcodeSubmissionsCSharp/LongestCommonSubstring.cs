public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string firstWord = strs[0];
        var checker = new Checker();
        return checker.WordToCheck(firstWord, strs.Skip(1).ToArray());
    }
}

public class Checker {
    public string WordToCheck(string firstWord, string[] strs) {
        while (firstWord != ""){
            foreach (string word in strs){
                if (!word.Contains(firstWord)) {
                    string firstRemoved = WordToCheck(firstWord.Substring(1), strs);
                    string lastRemoved = WordToCheck(firstWord.Remove(firstWord.Length - 1), strs);
                    if (firstRemoved.Length == 0 && lastRemoved.Length == 0)
                    return "";
                    else if (firstRemoved.Length > lastRemoved.Length)
                    return firstRemoved;
                    else
                    return lastRemoved;
                }
            }
            return firstWord;
        }
        return "";
    }
}