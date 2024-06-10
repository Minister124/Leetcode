public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0){
            return "";
        }
        string firstPrefix = strs[0];
        for(int i = 0; i < strs.Length; i++){
            while (strs[i].IndexOf(firstPrefix) != 0){
                if(firstPrefix.Length == 0){
                    return "";
                }
                firstPrefix = firstPrefix.Substring(0, firstPrefix.Length - 1);
            }
        }
        return firstPrefix;
    }
}