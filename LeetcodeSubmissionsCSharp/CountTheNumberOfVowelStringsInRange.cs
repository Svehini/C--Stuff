public class Solution {
    public int VowelStrings(string[] words, int left, int right) {
        int numberOfVowelStrings = 0;
        char[] vowels = {'a', 'e', 'i', 'o', 'u'};
        for (int word = left; word <= right; word++){
            int wordLength = words[word].Length;
            if ((vowels.Contains(words[word][0])) && (vowels.Contains(words[word][wordLength-1]))){
                numberOfVowelStrings++;
            }
        }
        return numberOfVowelStrings;
    }
}