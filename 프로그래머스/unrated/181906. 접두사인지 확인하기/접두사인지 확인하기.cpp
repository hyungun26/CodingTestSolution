#include <string>
#include <vector>

using namespace std;

int solution(string my_string, string is_prefix) {
    int answer = 0;
    string s = "";
    if(my_string.length() > is_prefix.length())
    {
        s = my_string.substr(0, is_prefix.length());
    }
    if(s == is_prefix)
        return 1;
    return answer;
}