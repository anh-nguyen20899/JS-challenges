using System.Text.RegularExpressions;
using System;
public class Solution {
    public bool IsPalindrome(string s) {
        if(s == " ") return true;
        else{
            s = s.ToLower();
            string s1 = Regex.Replace(s, "[^A-Za-z0-9]", "");
            Console.WriteLine(s1);
            int i = 0;
            int j = s1.Length - 1;
            while(i < s1.Length / 2 && j >= s1.Length / 2) {
                if(s1[i] != s1[j]) return false;
                    else {                      
                        i++;
                        j--;
                    }     
            }      
        }
        return true;
    }
}