using System;
using System.Collections.Generic;

public class Solution 
{
    public int solution(int n, Func<int, string> submit)
    {
        List<string> candidates = GenerateCandidates();
        
        int submitCount = 0;
        
        while(candidates.Count > 1 && submitCount < n)
        {
            string guess = candidates[0];
            string result = submit(int.Parse(guess));
            submitCount++;
            
            string[] parts = result.Split(' ');
            int strike = int.Parse(parts[0].Replace("S", ""));
            int ball = int.Parse(parts[1].Replace("B", ""));
            
            List<string> next = new List<string>();
            
            foreach(string cand in candidates)
            {
                int s, b;
                check(cand, guess, out s, out b);
                
                if(s == strike && b == ball)
                    next.Add(cand);
            }
            
            candidates = next;
        }
        
        return int.Parse(candidates[0]);
    }
    
    private List<string> GenerateCandidates()
    {
        List<string> list = new List<string>();
        
        for(int a = 1; a <= 9; a++)
        for(int b = 1; b <= 9; b++)
        for(int c = 1; c <= 9; c++)
        for(int d = 1; d <= 9; d++)
        {
            if(a == b || a == c || a == d||
               b == c || b == d ||
               c == d) continue;
            
            list.Add($"{a}{b}{c}{d}");
        }
        
        return list;
    }
    
    private void check(string secret, string guess, out int strike, out int ball)
    {
        strike = 0;
        ball = 0;
        
        for(int i = 0; i < 4; i++)
        {
            if(secret[i] == guess[i])
            {
                strike++;
            }
            else if(secret.Contains(guess[i]))
            {
                ball++;
            }
        }
    }
}