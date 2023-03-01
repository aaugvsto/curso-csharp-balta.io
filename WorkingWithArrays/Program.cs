using System;

namespace WorkingWithArrays
{
    class Program
    {
        public void Main(String[] args)
        {
            Console.Clear();

            var suppliers = new Supplier[5];
            suppliers[0] = new Supplier() { Id=123, Name="Augusto" };

            foreach(Supplier supplier in suppliers)
            {
                Console.WriteLine(supplier.Id);
                Console.WriteLine(supplier.Name);
            }
        }

        public struct Supplier
        {
            public int Id;
            public string Name;
        }
    }
}