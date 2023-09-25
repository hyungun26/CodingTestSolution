#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> arr) {
    vector<int> answer(arr.size());
    for(int i = 0; i < arr.size(); i++)
        {
            if(arr[i] >= 50 && arr[i] % 2 == 0)
            {
                answer[i] = arr[i] / 2;
                continue;
            }
            if(arr[i] < 50 && arr[i] % 2 == 1)
            {
                answer[i] = arr[i] * 2;
                continue;
            }
            answer[i] = arr[i];
        }
    return answer;
}