using System;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        return my_string.StartsWith(is_prefix)? 1 : 0;
    }
}