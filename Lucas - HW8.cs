using System;

namespace Lucas___MachineProject
{
    // Base class for machines
    public abstract class Machine
    {
        protected string cpuType;
        protected double cpuSpeed;
        protected int ramCapacity;
        protected int secondaryDriveCapacity;

        // Constructor
        public Machine(string cpuType, double cpuSpeed, int ramCapacity, int secondaryDriveCapacity)
        {
            this.cpuType = cpuType;
            this.cpuSpeed = cpuSpeed;
            this.ramCapacity = ramCapacity;
            this.secondaryDriveCapacity = secondaryDriveCapacity;
        }

        // Abstract method to get the description of the machine
        public abstract string GetDescription();
    }


    // Desktop machine types
    public enum DesktopType
    {
        Regular,
        AIO
    }

    // Form factor types
    public enum FormFactor
    {
        ATX,
        MicroATX,
        MiniITX
    }

    // Desktop machine class
    public class Desktop : Machine
    {
        protected DesktopType desktopType;
        protected FormFactor formFactor;
        protected string secondaryDriveType;

        // Constructor
        public Desktop(DesktopType desktopType, FormFactor formFactor, string cpuType, double cpuSpeed, int ramCapacity, string secondaryDriveType, int secondaryDriveCapacity)
            : base(cpuType, cpuSpeed, ramCapacity, secondaryDriveCapacity)
        {
            this.desktopType = desktopType;
            this.formFactor = formFactor;
            this.secondaryDriveType = secondaryDriveType;
        }

        // Override method to get desktop description
        public override string GetDescription()
        {
            string desktopTypeString = desktopType == DesktopType.Regular ? "Regular Desktop" : "AIO Desktop";
            string description = $"{desktopTypeString} ({formFactor} form factor)\nCPU: {cpuType} {cpuSpeed}GHz\nRAM: {ramCapacity}GB\nSecondary Drive: {secondaryDriveType} {secondaryDriveCapacity}GB";
            return description;
        }
    }

    // Laptop machine class
    public class Laptop : Machine
    {
        protected string wifiCardType;
        protected bool hasTouchScreen;

        // Constructor
        public Laptop(string wifiCardType, bool hasTouchScreen, string cpuType, double cpuSpeed, int ramCapacity, int secondaryDriveCapacity)
            : base(cpuType, cpuSpeed, ramCapacity, secondaryDriveCapacity)
        {
            this.wifiCardType = wifiCardType;
            this.hasTouchScreen = hasTouchScreen;
        }

        // Override method to get laptop description
        public override string GetDescription()
        {
            string touchscreenString = hasTouchScreen ? "Touchscreen" : "Non-touchscreen";
            string description = $"Laptop ({touchscreenString})\nCPU: {cpuType} {cpuSpeed}GHz\nRAM: {ramCapacity}GB\nSecondary Drive: {secondaryDriveCapacity}GB\nWifi Card: {wifiCardType}";
            return description;
        }
    }

    // Driver class
    class Program
    {
        static void Main(string[] args)
        {
            Machine[] machines = new Machine[2];
            machines[0] = new Desktop(DesktopType.Regular, FormFactor.ATX, "Intel Core i5", 3.0, 8, "HDD", 500);
            machines[1] = new Laptop("Intel Dual Band Wireless-AC 7260", true, "Intel Core i7", 2.5, 16, 1000);

            foreach (Machine machine in machines)
            {
                Console.WriteLine(machine.GetDescription());
            }
        }
    }
}

//I used an explanation about OOP from a series of Instagram post I saw a couple months ago. (@lilamontenegro)
//It explained OOP using an analogy with the Avatar movie. The superclass is the "Being" and it can be Human or Na'vi.
//In this case, both had similar attributes such as height, age, gender, name. So Human and Na'vi would be created as a sub-class and inherit the attributes from the superclass and add their own values.
//My line of thought started here. It goes on, explaining how to protect the properties not to be accessed illogically, abstraction (that I can't fully explain although I understand how it works)
//and Polymorphism, where they used the character 'Sully' to exemplify. He can be an Avatar or Human, but it is still the same character.
//The methods (function), determine different abilities depending on his form.
//Then I started coding the "Machine" class for the assignment.
//The code needed two types of machines: desktops and laptops. Each machine has some common properties like CPU type, CPU speed, RAM capacity, and secondary drive capacity.
//I created the "Machine" class as the base class that contains these properties.
//The "Desktop" and "Laptop" classes inherit from the "Machine" class and add their own unique properties like desktop type, form factor, wifi card type, and touchscreen availability.
//The "GetDescription" method is defined as an abstract method in the "Machine" class. This method is overridden in the "Desktop" and "Laptop" classes to return a string that describes each machine.
//Finally, the program demonstrates polymorphic behavior by creating instances of the "Desktop" and "Laptop" classes and storing them in an array of "Machine" objects.
//This allows us to refer to both objects using a base class reference and call the "GetDescription" method, which is overridden in each subclass, to get a description of the specific machine.pecific machine.