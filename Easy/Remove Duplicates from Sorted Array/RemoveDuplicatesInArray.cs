public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int[] uniqueNumbers = nums.Distinct().ToArray();

        for (int i = 0; i < uniqueNumbers.Length; i++){
            nums[i] = uniqueNumbers[i];
        }
        //or
        Array.Copy(uniqueNumbers, nums, uniqueNumbers.Length);
        
        return uniqueNumbers.Length;
    }
}