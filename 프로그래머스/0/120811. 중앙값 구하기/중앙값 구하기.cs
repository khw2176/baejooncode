using System;

public class Solution 
{
    public int solution(int[] array) 
    {
        Array.Sort(array);
        int mid = array.Length / 2;
        return array[mid];
    }
}