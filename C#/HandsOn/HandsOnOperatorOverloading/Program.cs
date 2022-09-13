namespace HandsOnOperatorOverloading
{
    class Employee
    {
        int Sal;
        public Employee(int x)
        {
            Sal = x;
        }
        public Employee()
        {
        }
        public void Show()
        {
            Console.WriteLine("Salary=" + Sal);

        }
        //Operator Overloadable method
        public static int operator +(Employee e1, Employee e2)
        {
           
            int salry = e1.Sal + e2.Sal;
            return salry;
        }
        public static bool operator ==(Employee e1, Employee e2)
        {

            if (e1.Sal == e2.Sal)
                return true;
            else
                return false;
        }
        public static bool operator !=(Employee e1, Employee e2)
        {

            if (e1.Sal != e2.Sal)
                return true;
            else
                return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(50000);
            Employee e2 = new Employee(40000);

            
            int total = e1 + e2;
            e1.Show();
            e2.Show();

            Console.WriteLine("Total Salary: " + total);
            Console.ReadKey();
            DateTime d1 = new DateTime(2000, 12, 21);
            DateTime d2 = new DateTime(2010, 1, 12);
            bool b = d1 == d2;
            bool result = e1 == e2;
        }
    }
}