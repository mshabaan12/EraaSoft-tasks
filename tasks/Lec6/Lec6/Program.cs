namespace Lec6
{    
   class mobile
    {
        string model;
        string release;
        int price;
        string color;


         public mobile(string model,string release,int price ,string color) //instractor
      {
            this.model = model;
            this.release = release;
            this.price = price;
            this.color = color;


    }
    internal class Program
    {
            static void Main(string[] args)
            {
                mobile mobile1 = new mobile("iphone", "fff", 30000, "green");
                mobile mobile2 = new mobile("iphone", "hh", 70000, "red");
            }
        }
    }
}
