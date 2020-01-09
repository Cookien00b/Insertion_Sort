using System;
using System.Linq;

namespace Challange_one
{
    class Sorting
    {
        public static void Main(){
            int[] testSet = new int[10];

            for (int i = 0; i < 10; i++)
                testSet[i] = i; 
            Random rnd=new Random();
            int[] MyRandomArray = testSet.OrderBy(x => rnd.Next()).ToArray();
            Console.WriteLine("Unsorted array: " + string.Join("", MyRandomArray.Select(x => x.ToString()).ToArray()));
            MyRandomArray = Sort(MyRandomArray);
            Console.WriteLine("Sorted array: " + string.Join("", MyRandomArray.Select(x => x.ToString()).ToArray()));

        }
        public static bool complete = false;
        static int[] Sort(int[] unsortedSet)
        {
            int sorted = 1;
            for (int i = 1; i<unsortedSet.Length; i++){
                int g = i;
                for (int j = sorted - 1; j >= 0 && unsortedSet[g] <= unsortedSet[j]; j--, g--){
                    if (unsortedSet[g] <= unsortedSet[j]){
                        string temp = string.Join("", unsortedSet.Select(x => x.ToString()).ToArray());
                        temp = temp.Insert(j, unsortedSet[g].ToString());
                        temp = temp.Remove(g+1, 1);
                        int[] tmp = new int[temp.Length];
                        tmp = temp.Select(n => Int32.Parse(n.ToString())).ToArray();
                        unsortedSet = tmp;
                    }
                }
                complete = false;
                sorted = sorted + 1;
            }
            return unsortedSet;
        }
    }
}