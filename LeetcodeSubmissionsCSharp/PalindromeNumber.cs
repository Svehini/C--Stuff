public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0)
        return false;
        string num = Convert.ToString(x);
        char[] arr = num.ToCharArray();
        Array.Reverse(arr);
        string str = new string(arr);
        BigInteger y = BigInteger.Parse(str);
        if (x == y)
        return true;
        else
        return false;
    }
}