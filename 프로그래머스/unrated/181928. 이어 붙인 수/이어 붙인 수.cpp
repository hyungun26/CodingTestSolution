#include <string>
#include <vector>

using namespace std;

int solution(vector<int> num_list) {
    int answer = 0;
    string sOdd = "";
    string sEven = "";
    for(int i = 0; i < num_list.size(); i++)
    {

        if(num_list[i] % 2 == 0)
        {
            sEven += to_string(num_list[i]);
        }
        else 
        {
            sOdd += to_string(num_list[i]); 
        }
    }
    answer = stoi(sEven) + stoi(sOdd);
    return answer;
}