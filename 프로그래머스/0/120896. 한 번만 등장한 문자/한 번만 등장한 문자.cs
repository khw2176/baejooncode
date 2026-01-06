using System;

public class Solution 
{
    public string solution(string s) 
    {
        int[] count = new int[26];
        
        for(int i = 0; i < s.Length; i++)
        {
            count[s[i] - 'a']++;
        }
        
        char[] unique = new char[s.Length];
        int idx = 0;
        for(int i = 0; i < 26; i++)
        {
            if(count[i] == 1)
            {
                unique[idx] = (char)(i + 'a');
                idx++;
            }
        }
        
        if(idx == 0) return "";
        
        Array.Sort(unique, 0, idx);
        
        return new string(unique, 0, idx);
    }
}