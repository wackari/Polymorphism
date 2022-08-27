namespace Polymorphism.Models
{
    public class Phone : Device
    {
        public bool IsSmartPhone { get; set; }
        public int NumberOfSimCard { get; set; }
        public List<string> Sensors { get; set; }
    }
}
