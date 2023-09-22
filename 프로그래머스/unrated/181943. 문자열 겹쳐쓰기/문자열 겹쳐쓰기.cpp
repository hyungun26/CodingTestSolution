#include <string>
#include <vector>

using namespace std;

string solution(string my_string, string overwrite_string, int s) {
    string answer = "";
    answer.append(my_string.substr(0, s));
    answer.append(overwrite_string);
    answer.append(my_string.substr(answer.size(), my_string.size() - answer.size()));
    return answer;
}