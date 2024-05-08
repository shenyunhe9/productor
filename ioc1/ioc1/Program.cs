namespace ioc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
    public interface ITestService {
        public String Name { get; set; }
        public void SayHello();
    }

    public class ITestServiceImp : ITestService {
    public String Name { get; set; }
    public void SayHello()
    {
        Console.WriteLine($"Hi im{Name}");
    }
}
    public interface ITestService2
    {
        public String Name { get; set; }
        public void SayHello();
    }

public class ITestServiceImp2 : ITestService2
{
    public String Name { get; set; }
    public void SayHello()
    {
        Console.WriteLine($"Hi im{Name}");
    }
}
