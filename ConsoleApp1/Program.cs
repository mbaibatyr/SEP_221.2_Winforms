namespace ConsoleApp1
{
    public class ForTest
    {
        public static void Hello()
        {
            Console.WriteLine("Hello, World!");
        }

        public static void Main()
        {
            //Hello();
            Calculate calculate = new Calculate();
            var result = calculate.getSum(2, 3);
            Console.WriteLine(result);
        }
    }

    public class Calculate
    {
        public int getSum(int a, int b)
        {
            if (a == 10)
            {
                throw new Exception("Длина имени меньше 2 символов");                
            }
            return a + b;
        }

        public ClassResult getDivision(double a, double b)
        {
            if (b == 0)
                return new ClassResult()
                {
                    error = "Делить на ноль нельзя",
                    resultEnum = ResultEnum.ERROR
                };
            else
                return new ClassResult()
                {
                    result = a / b,
                    resultEnum = ResultEnum.OK
                };
        }
    }

    public class ClassResult
    {
        public double result { get; set; }
        public string error { get; set; }
        public ResultEnum resultEnum { get; set; }
    }

    public enum ResultEnum
    {
        OK = 1,
        ERROR = 2
    }
}
