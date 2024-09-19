namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(basePowerCalc(2, 3));

        }
        //1
        static void Greet(string name)
        {
            Console.WriteLine($"Greetings {name}");
        }


        //2
        static int SumOfTwoInt(int x, int y)
        {
            return x + y;
        }

        //3
        static double circleAreaCalc(double rad)
        {
            double pi = Math.PI;
            double area = Math.Round(pi * rad * rad, 2);
            return area;
        }

        //4
        static bool isEven(double number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //5
        static int numLargChecker(int x, int y)
        {
            int num = x > y ? x : y;

            return num;
        }

        //6
        static bool palindrome(string word)
        {

            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            string revWord = new string(charArray);

            if (word == revWord)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //7
        static int sumOfArray(Array array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                sum += item;
            }
            return sum;
        }

        //8
        static int[] sortIntArray(int[] array)
        {
            int[] arr = array;
            Array.Sort(arr);

            return arr;
        }

        //9
        static double avrgCalc(int[] array)
        {
            double sum = 0;
            int len = array.Length;

            foreach (int item in array)
            {
                sum += item;
            }
            return sum / len;
        }

        //10
        static double basePowerCalc(int baseNumber, int exponent)
        {
            double sum = 1;

            for (int i = 0; i < exponent; i++)
            {
                sum *= baseNumber;
            }
            return sum;
        }

    }
}
