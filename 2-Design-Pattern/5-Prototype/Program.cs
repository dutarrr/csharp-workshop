using System;

namespace _5_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deep Copy Sample\n");
            AuthorForDeepCopy o = new AuthorForDeepCopy()
            {
                Name = "Düzgün Tutar",
                TwitterAccount = "https://twitter.com/duzgun",
                Website = "http://www.duzgun.tutar.com",
                HomeAddress = new Address()
                {
                    City = "İstanbul",
                    State = "Maltepe"
                }
            };
            Console.WriteLine("Original Copy");
            Console.WriteLine(o);
            AuthorForDeepCopy clonedObject = (AuthorForDeepCopy)o.Clone();

            Console.WriteLine("\nCloned Copy");
            Console.WriteLine(clonedObject);

            Console.WriteLine("\nMake Changes to clone copy address");
            clonedObject.Name = "Ahmet Metin";
            clonedObject.TwitterAccount = "https://twitter.com/ahmet";
            clonedObject.Website = "https://ahmetmetin.com";
            clonedObject.HomeAddress.State = "Karşıyaka";
            clonedObject.HomeAddress.City = "İzmir";

            Console.WriteLine("\nOriginal Copy");
            Console.WriteLine(o);

            Console.WriteLine("\nCloned Copy");
            Console.WriteLine(clonedObject);
        }
    }

    /*
    Eğer Address kendi içinde Clone olmaz ise orjinal objenin referansı gösterdiği için orjinalinde içeriği değişir.
    İç içe objelerde herpsinin clone yapılması gerekir.
    */
    public class Address
    {
        public string State { get; set; }
        public string City { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class AuthorForDeepCopy : ICloneable
    {
        public string Name { get; set; }
        public string TwitterAccount { get; set; }
        public string Website { get; set; }
        public Address HomeAddress { get; set; }
        public object Clone()
        {
            AuthorForDeepCopy objPriCopy = (AuthorForDeepCopy)this.MemberwiseClone();
            objPriCopy.HomeAddress = (Address)this.HomeAddress.Clone();
            return objPriCopy;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.TwitterAccount} {this.Website} {this.HomeAddress.City} {this.HomeAddress.State}";
        }
    }
}

