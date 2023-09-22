#include <string>
#include <vector>

using namespace std;

int solution(int num, int n) {
    int answer = num % n;
    answer = (answer != 0) ? 0 : 1;
    return answer;
}