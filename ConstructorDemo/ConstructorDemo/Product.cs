using System.Security.Cryptography;

namespace OOP_Programs
{
    class Product
    {
        int prodictId;
        string productName;
        int productQuantity;
        int productStock;
        double productPrice;

        public Product()
        {
            System.Console.WriteLine("Hello World");
        }
        public Product(int productId, string productName,int productQuantity,int productStock,double productPrice)
        :this()
        {
            this.prodictId = prodictId;
            this.productName = productName;
            this.productQuantity = productQuantity;
            this.productStock = productStock;
            this.productPrice = productPrice;
        }
        public void display()
        {
            System.Console.WriteLine("Instance Method");
        }
        public static void displayStatic()
        {
            System.Console.WriteLine("Static Method");
        }
        
    }
}
