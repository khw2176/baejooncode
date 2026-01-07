using System;

public class Solution 
{
    public int solution(int[] num_list) 
    {
        int answer = 0;
        
        for(int i = 0; i < num_list.Length; i++)
        {
            int n = num_list[i];
            
            for(; n > 1; answer++)
            {
                if(n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n = (n - 1) / 2;
                }
            }
        }
        
        return answer;
    }
}