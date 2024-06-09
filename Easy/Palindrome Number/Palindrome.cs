public class Solution {
    public bool IsPalindrome(int x) {
        //if the number is negative then no palindrome
        if (x < 0){
            return false;
        }

        int original = x;
        int reversed = 0;

        while (x != 0){
            int digit = x % 10; // gives output of 1 as 121 divide by 10 gives 120, remainder 1. for 1st iteration
            reversed = reversed * 10 + digit; //output is 1 for first iteration
            x /= 10; //output is 12 for first iteration
        }

        return original == reversed;
    }
}