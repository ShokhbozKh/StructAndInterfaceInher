namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fegure fegure = new Fegure();
            fegure.x = 12;
            fegure.y = 4.5m;
            fegure.Area();
            Console.WriteLine(fegure.Area2());// bu decimal tipida
        }
    }
    interface IFunks1
    {
        void Area();
    }
    interface IFunks2
    {
        public decimal Area2();
        
    }
    struct Fegure : IFunks2, IFunks1 //faqat interfacelardan voris oladi
    {
        public decimal x;
        public decimal y;
        public void Area()
        {
            Console.WriteLine(x*y);
        }

        public decimal Area2()
        {
            return x*y;
        }
    }
}