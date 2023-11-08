using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        List<int> list = new List<int>();
        List<int> list2 = new List<int>();
        bool check = false;
        for(int i = 0 ; i < arr.Length; i++)
        {
            if(arr[i] == 2)
                check = true;
            if(check)
                list.Add(arr[i]);
        }
        list.Reverse();
        check = false;
        for(int i = 0 ; i < list.Count; i++)
        {
            if(list[i] == 2)
                check = true;
            if(check)
                list2.Add(list[i]);
        }
        list2.Reverse();
        if(list2.Count == 0)
        {
            list2.Add(-1);
        }
        return list2.ToArray();
    }
}