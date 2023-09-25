#include <string>
#include <vector>

using namespace std;

int solution(string ineq, string eq, int n, int m) {
    int answer = 0;
    string s = ineq + eq;
    if(s == ">=") answer = n >= m ? 1 : 0;
    if(s == "<=") answer = n <= m ? 1 : 0;
    if(s == ">!") answer = n > m ? 1 : 0;
    if(s == "<!") answer = n < m ? 1 : 0;
    return answer;
}