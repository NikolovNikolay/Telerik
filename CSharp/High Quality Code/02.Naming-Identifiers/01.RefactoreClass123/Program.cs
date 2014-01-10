using System;
using System.Linq;

public class MainClass
{
    public const int MaximumValueOfCounter = 6;
    
    public static void Main()
    {
        MainClass.FirstNestedClassInMainClass firstNestedClassInstance =
          new MainClass.FirstNestedClassInMainClass();
        firstNestedClassInstance.ConvertBoolVariableToString(true);
    }

    private class FirstNestedClassInMainClass
    {
        public void ConvertBoolVariableToString(bool variableBoolState)
        {
            string variableBoolValueConvertedToString = variableBoolState.ToString();
            Console.WriteLine(variableBoolValueConvertedToString);
        }
    }
}