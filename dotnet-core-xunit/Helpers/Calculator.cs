namespace dotnet_core_xunit.Helpers
{
    /// <summary>
    /// Small top-level (non-nested) class so the Test Intelligence agent can record it as a
    /// source file in the call graph (the agent does not support nested classes).
    /// </summary>
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public bool IsEven(int value)
        {
            return value % 2 == 0;
        }
    }
}
