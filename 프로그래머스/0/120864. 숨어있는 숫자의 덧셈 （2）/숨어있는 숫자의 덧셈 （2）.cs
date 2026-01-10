using System;

public class Solution 
{
    public int solution(string my_string) 
    {
        int sum = 0;
        int currentNumber = 0;
        
        foreach(char c in my_string)
        {
            if(c >= '0' && c <= '9')
            {
                currentNumber = currentNumber * 10 + (c - '0');
            }
            else
            {
                sum += currentNumber;
                currentNumber = 0;
            }
        }
        
        sum += currentNumber;
        
        return sum;
    }
}