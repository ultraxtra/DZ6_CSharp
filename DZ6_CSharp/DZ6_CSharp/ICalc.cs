using System;
namespace DZ6_CSharp
{
    internal interface ICalc
    {
        int Less(int ValueToCompare);
        int Greater(int valueToCompare);
    }

    internal interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }
    internal interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }
}

