namespace Polymorphism.Models
{
    public class Laptop : Device
    {
        public int NumborOfUsbPort { get; set; }
        public bool HasHdmiPort { get; set; }
        public bool HasDvdReader { get; set; }
    }
}
