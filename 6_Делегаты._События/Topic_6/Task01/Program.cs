namespace Task01 {
    class Program
    {
        delegate int MathOperation(int a, int b);

        public static void Main()
        {
            MathOperation math;

            math = Addition.Add;
            math += Multiplication.Mul;
            math(20, 15);
        }
    }
}