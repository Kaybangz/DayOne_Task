using System;

namespace BreakAndContinue {
    class Program{
        public static void Main(){
            int[] numbers = new int[] {0,1,2,3,4,5,6,7,8,9,10,11,12};

            for(int i = 0; i<numbers.Length; i++){

                if(numbers[i] % 2 == 0){
                    continue;
                }
                else if(numbers[i] > 10){
                    break;
                }

                Console.WriteLine(numbers[i]);
            }

        }
    }
}