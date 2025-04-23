using System;
using System.Collections.Generic;
using System.Linq;

namespace baejoon_10814
{
    class 나이순_정렬
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            List<Tuple<int, string>> list = new List<Tuple<int, string>>();
            for (int i = 0; i < input; i++)
            {
                string[] s = Console.ReadLine().Split();
                list.Add(new Tuple<int, string>(int.Parse(s[0]), s[1]));
            }

            MergeSort(list);
            foreach(var i in list)
                Console.Write(i.Item1 + " " + i.Item2 +"\n");
        }

        //게이트 메서드        
        //구조를 외부로 노출시키지 않기 위해, 관문 메서드를 사용        
        private static void MergeSort(List<Tuple<int, string>> list)
        {
            MergeSort(list, 0, list.Count - 1);
        }

        private static void MergeSort(List<Tuple<int, string>> list, int left, int right)
        {
            if (left >= right)
                return;

            int middle = (left + right) / 2;
            MergeSort(list, left, middle);
            MergeSort(list, middle + 1, right);

            // 병합 로직
            Merge(list, left, middle, right);
        }

        private static void Merge(List<Tuple<int, string>> list, int left, int middle, int right)
        {
            List<Tuple<int, string>> mergeCache = new List<Tuple<int, string>>();
            int leftIndex = left;
            int rightIndex = middle + 1;

            // 1. 두 구역의 요소 비교 후 병합
            while (leftIndex <= middle && rightIndex <= right)
            {
                if (list[leftIndex].Item1 <= list[rightIndex].Item1)
                {
                    mergeCache.Add(list[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    mergeCache.Add(list[rightIndex]);
                    rightIndex++;
                }
            }

            // 2. 남은 왼쪽 구역 요소 처리
            while (leftIndex <= middle)
            {
                mergeCache.Add(list[leftIndex]);
                leftIndex++;
            }

            // 3. 남은 오른쪽 구역 요소 처리
            while (rightIndex <= right)
            {
                mergeCache.Add(list[rightIndex]);
                rightIndex++;
            }

            // 4. 병합 결과를 원본 리스트에 반영
            for (int i = 0; i < mergeCache.Count; i++)
            {
                list[left + i] = mergeCache[i];
            }
        }
    }
}
