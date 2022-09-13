namespace HandsOnExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n1;
            byte n2;
           try
            {
                Console.WriteLine("Enter a,b values");
                n1 = byte.Parse(Console.ReadLine());
                n2 = byte.Parse(Console.ReadLine());
                int result = n1 / n2;
                Console.WriteLine("Result= " + result);
                Console.WriteLine("Good Morning students");
            }
            //catch block is executed only when exception occure
            catch(DivideByZeroException ex) //ex is the object name
            {
                Console.WriteLine("n2 value should not be 0");
                Console.WriteLine(ex.Message); //return build in message
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Value should between 1 to 255");
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex) //handle all exceptions
            {
                Console.WriteLine("Error Occured");
                Console.WriteLine(ex.Message);

            }
        }
    }
}