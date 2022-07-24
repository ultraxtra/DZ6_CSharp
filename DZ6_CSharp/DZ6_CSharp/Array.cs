using System;
namespace DZ6_CSharp
{
    internal class Array : ICalc, IOutput2, ICalc2
    {
        public int[] TestArr;
        public int? Length;
        public Array(int Length)
        {
            this.Length = Length;
            TestArr = new int[Length];
        }

        public int Greater(int valueToCompare)
        {
            int CounterGreaterValue = 0;
            for (int i = 0; i < TestArr.Length; i++)
            {
                if (TestArr[i] > valueToCompare)
                {
                    CounterGreaterValue++;
                }
            }
            return CounterGreaterValue;
        }

        public int Less(int valueToCompare)
        {
            int CounterLessValue = 0;
            for (int i = 0; i < TestArr.Length; i++)
            {
                if (TestArr[i] < valueToCompare)
                {
                    CounterLessValue++;
                }
            }
            return CounterLessValue;
        }

        public void FillRandom(int Max)
        {
            Random random = new Random();
            for (int i = 0; i < TestArr.Length; i++)
            {
                TestArr[i] = random.Next(Max);
            }
        }

        public void Output()
        {
            foreach (int i in TestArr)
            {
                Console.Write($" {i}");
            }
        }

        public void ShowEven()
        {
            foreach (int i in TestArr)
            {
                if (i % 2 == 0)
                {
                    Console.Write($" {i}");
                }
            }
        }

        public void ShowOdd()
        {
            foreach (int i in TestArr)
            {
                if (i % 2 != 0)
                {
                    Console.Write($" {i}");
                }
            }
        }
        public int CountDistinct()
        {
            int Count = 0;
            for(int i = 0; i < TestArr.Length; i++)
            {
                bool Distinct = true;
                for(int j = 0; j < TestArr.Length; j++)
                {
                    if (TestArr[i] == TestArr[i] && i != j)
                    {
                        Distinct = false;
                    }
                }
                if (Distinct)
                {
                    Count++;
                }
            }
            return Count;
        }
        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            for(int j = 0; j  <TestArr.Length; j++)
            {
                if (TestArr[j] == valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

