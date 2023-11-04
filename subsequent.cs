using System.Text.RegularExpressions;
using System;
public class Solution {
    public bool IsSubsequence(string s, string t) {
        t = t.ToLower();
        string t1 = Regex.Replace(t, "[^A-Za-z0-9]", "");
        Console.WriteLine(t1);
        int p1 = 0;
        int p2 = 0;
        string found = "";
        if(s == "") return true;
        else{
            while(p1 < t1.Length  && p2 < s.Length) {
                if(s[p2] != t1[p1]) {
                    p1++;
                } else if(s[p2] == t1[p1]) {
                    found += t1[p1];
                    p1++;
                    p2++;        
                }
            }
        }
        
        return found.Equals(s);
    }
}