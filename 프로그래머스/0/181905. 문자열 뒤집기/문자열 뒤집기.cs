using System;
using System.Text;

public class Solution 
{
    public string solution(string my_string, int s, int e) 
    {
        char[] chars = my_string.ToCharArray();
        
        while(s < e)
        {
            char temp = chars[s];
            chars[s] = chars[e];
            chars[e] = temp;
            s++;
            e--;
        }
        
        return new string(chars);
    }
}