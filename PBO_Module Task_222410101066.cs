class Program
{
    static void Main(String[] args)
    {
        //Processor
        Processor intel = new Intel();
        Intel coreI3 = new CoreI3();
        Intel coreI5 = new CoreI5();
        Intel coreI7 = new CoreI5();
        Processor amd = new AMD();
        AMD ryzen = new Ryzen();
        AMD athlon = new Athlon();
        //VGA
        Vga nvidia = new Nvidia();
        Vga amd1 = new Amd();
        //Laptop
        Laptop laptop1 = new Vivobook();
        Laptop laptop2 = new IdeaPad();
        Predator predator = new();
        ACER acer = new Predator();

        //Spesifikasi laptop1
        laptop1.vga = nvidia;
        laptop1.tipe = coreI5.tipe;
        laptop1.merk = intel.merk;

        //Output
        //laptop2.LaptopDinyalakan();
        //laptop2.LaptopDimatikan();
        //((Vivobook)laptop1).Ngoding();
        //Console.WriteLine($"VGA             = {laptop1.vga}");
        //Console.WriteLine($"Merk Processor  = {laptop1.merk}");
        //Console.WriteLine($"Tipe Processor  = {laptop1.tipe}");
        //predator.BermainGame();
        //((Predator)acer).BermainGame();
    }
}


//Processor
class Processor
{
    public string? merk;
    public string? tipe;
}
class Intel : Processor
{
    public Intel()
    {
        merk = "Intel";
    }
}
class AMD : Processor
{
    public AMD()
    {
        merk = "AMD";
    }
}
class CoreI3 : Intel
{
    public CoreI3()
    {
        tipe = "Core I3";
    }
}
class CoreI5 : Intel
{
    public CoreI5()
    {
        tipe = "Core I5";
    }
}
class CoreI7 : Intel
{
    public CoreI7()
    {
        tipe = "Core I7";
    }
}
class Ryzen : AMD
{
    public Ryzen()
    {
        tipe = "Ryzen";
    }
}
class Athlon : AMD
{
    public Athlon()
    {
        tipe = "Athlon";
    }
}

//VGA
class Vga
{
    public string? merk;
}
class Nvidia : Vga
{
    public Nvidia()
    {
        merk = "Nvidia";
    }
}
class Amd : Vga
{
    public Amd()
    {
        merk = "AMD";
    }
}

//Laptop
class Laptop
{
    public string? merk;
    public string? tipe;
    public Vga? vga;
    public Processor? processor;
    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala");
    }
    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} mati");
    }
}
class ASUS : Laptop
{
    public ASUS()
    {
        merk = "ASUS";
    }
}
class ACER : Laptop
{
    public ACER()
    {
        merk = "ACER";
    }
}
class Lenovo : Laptop
{
    public Lenovo()
    {
        merk = "Lenovo";
    }
}
class ROG : ASUS
{
    public ROG()
    {
        tipe = "ROG";
    }
}
class Vivobook : ASUS
{
    public Vivobook()
    {
        tipe = "Vivobook";
    }
    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}
class Swift : ACER
{
    public Swift()
    {
        tipe = "Swift";
    }
}
class Predator : ACER
{
    public Predator()
    {
        tipe = "Predator";
    }
    public void BermainGame()
    {
        Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
    }
}
class IdeaPad : Lenovo
{
    public IdeaPad()
    {
        tipe = "IdeaPad";
    }
}
class Legion : Lenovo
{
    public Legion()
    {
        tipe = "Legion";
    }
}