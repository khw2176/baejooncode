using System;

public class Solution
{
    public bool solution(string s) 
    {
        int a = 0;
        
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(')
            {
                a++;
            }
            else
            {
                a--;
            }
            
            if( a < 0) return false;
        }
        
        return a == 0;
    }
}