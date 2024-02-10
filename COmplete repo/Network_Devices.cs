using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Project_Simulator_OOP
{
    //Abstract Class
    public abstract class NetworkDevice
    {
        public string Name { get; set; }
        public string IPAddress { get; set; }
        public string Port { get; set; }
        public PictureBox PictureBox { get; set; }

        
       
        public NetworkDevice(string name, string ipAddress, string port)
        {
            Name = name;
            IPAddress = ipAddress;
            Port = port;
            PictureBox = new PictureBox();
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox.Size = new Size(80, 80);
            // Set the image for the picture box based on device type
            PictureBox.Image = GetDeviceImage();
            PictureBox.Name = $"PictureBox_{Name}";
            PictureBox.Tag = this; // Store a reference to the network device object in the picture box's tag
            PictureBox.DoubleClick += PictureBox_DoubleClick; // Attach the event handler for double-click
        }

        public abstract void SendData(string data);

        public abstract Image GetDeviceImage();

        private void PictureBox_DoubleClick(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            NetworkDevice networkDevice = (NetworkDevice)pictureBox.Tag;
            MessageBox.Show($"Name: {networkDevice.Name}\nDescription: {networkDevice.GetDescription()}", "Device Information");
        }

        public abstract string GetDescription();

        public override string ToString()
        {
            return $"{Name} ({IPAddress}:{Port})";
        }
    }


    //Derived Classes
    public class Workstation : NetworkDevice
    {
        public Workstation(string name, string ipAddress, string port) : base(name, ipAddress, port)
        {
        }

        public override void SendData(string data)
        {
            Console.WriteLine($"Sending data from {Name} to central server: {data}");
        }

        public override Image GetDeviceImage()
        {
            return Image.FromFile("C:\\Users\\Fast Computer\\Documents\\Visual Studio 2022\\new projects c#\\rrrrr\\Resources\\workstation.png");
        }

        public override string GetDescription()
        {
            return "This is a workstation device.";
        }
    }
    public class Switch : NetworkDevice
    {
        public Switch(string name, string ipAddress, string port) : base(name, ipAddress, port)
        {
        }

        public override void SendData(string data)
        {
            Console.WriteLine($"Broadcasting data from {Name} to connected devices: {data}");
        }

        public override Image GetDeviceImage()
        {
            return Image.FromFile("C:\\Users\\Fast Computer\\Documents\\Visual Studio 2022\\new projects c#\\rrrrr\\Resources\\switch.png");
        }

        public override string GetDescription()
        {
            return "This is a switch device.";
        }
    }
    public class Firewall : NetworkDevice
    {
        public Firewall(string name, string ipAddress, string port) : base(name, ipAddress, port)
        {
        }

        public override void SendData(string data)
        {
            Console.WriteLine($"Filtering data from {Name} and forwarding to central server: {data}");
        }

        public override Image GetDeviceImage()
        {
            return Image.FromFile("C:\\Users\\Fast Computer\\Documents\\Visual Studio 2022\\new projects c#\\rrrrr\\Resources\\firewall.jpg");
        }

        public override string GetDescription()
        {
            return "This is a firewall device.";
        }
    }
    public class Router : NetworkDevice
    {
        public Router(string name, string ipAddress, string port) : base(name, ipAddress, port)
        {
        }

        public override void SendData(string data)
        {
            Console.WriteLine($"Routing data from {Name} to appropriate network segment: {data}");
        }

        public override Image GetDeviceImage()
        {
            return Image.FromFile("C:\\Users\\Fast Computer\\Documents\\Visual Studio 2022\\new projects c#\\rrrrr\\Resources\\router.jpg");
        }

        public override string GetDescription()
        {
            return "This is a router device.";
        }



    }
    public class Pc : NetworkDevice
    {

        public Pc(string name, string ipAddress, string port) : base(name, ipAddress, port)
        {
        }

        public override void SendData(string data)
        {
            Console.WriteLine($"Routing data from {Name} to appropriate network segment: {data}");
        }

        public override Image GetDeviceImage()
        {
            return Image.FromFile("C:\\Users\\Fast Computer\\Documents\\Visual Studio 2022\\new projects c#\\rrrrr\\Resources\\pc.jpg");
        }

        public override string GetDescription()
        {
            return "This is a PC device.";
        }

    }





}
