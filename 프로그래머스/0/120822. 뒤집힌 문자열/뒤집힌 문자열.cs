using System;

public class Solution 
{
    public string solution(string my_string) 
    {
        string result = "";
        
        for(int i = my_string.Length-1; i >= 0 ; i--)
        {
            result += my_string[i];
        }
        
        return result;
    }
}