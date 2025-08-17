namespace challeange1Lec6
{
    class mobile
    {
        string model;
        string release;
        double price;
        string color;
        // creatin instractor 
        public mobile(string model, string release, double price, string color)
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
                mobile mobile1 =  new mobile("iphone ", "2019", 11000, "green ");
                mobile mobile2 = new mobile("sams", "2020", 16000, "red ");
            }
        }
    }
}
