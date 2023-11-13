namespace moodleOppgave02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integer      = 1;
            long longInteger = 1;

            float floatInteger     = 1.5f;
            double doubleInteger   = 1.5d;
            decimal decimalInteger = 1.5m;

            char character    = 'a';
            string characters = "abcd";

            bool isTrue = true;


            Console.WriteLine($"integer: {integer}\nlong integer: {longInteger}\n");
            Console.WriteLine($"float: {floatInteger}\ndouble: {doubleInteger}\ndecimal: {decimalInteger}\n");
            Console.WriteLine($"character: {character}\ncharacters: {characters}\n");
            Console.WriteLine($"isTrue: {isTrue}");

            Console.ReadKey();
        }
    }
}