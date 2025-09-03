namespace TaskLec9
{ class DoctorMode
    {

    }
    class StudentMode
    {

    }
    class Qutions
    {
        public string Header{ get; set; }
        public int Mark{ get; set; }
        
        public QuationLevel Level{ get; set; }

    }
    public enum QuationLevel
    {
        Easy,
        MedMedium,
        Hard,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
