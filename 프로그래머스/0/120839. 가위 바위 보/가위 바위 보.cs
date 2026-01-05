using System;
using System.Text;

public class Solution 
{
    public string solution(string rsp) 
    {
        StringBuilder sb = new StringBuilder();
        
        foreach(char c in rsp)
        {
            if(c == '2') sb.Append('0');
            else if(c == '0') sb.Append('5');
            else if(c == '5') sb.Append('2');
        }
        
        return sb.ToString();
    }
}