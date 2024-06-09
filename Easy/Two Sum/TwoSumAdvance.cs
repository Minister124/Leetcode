public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Dictionary to store the complement and its index
        Dictionary<int, int> numDict = new Dictionary<int, int>();

        // Iterate through the array
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];

            // Check if the complement is already in the dictionary
            if (numDict.ContainsKey(complement)) {
                // If found, return the indices
                return new int[] { numDict[complement], i };
            }

            // If not found, add the current number and its index to the dictionary
            if (!numDict.ContainsKey(nums[i])) {
                numDict.Add(nums[i], i);
            }
        }

        // Return an empty array if no solution is found
        // (According to the problem constraints, this line should never be reached)
        return new int[0];
    }