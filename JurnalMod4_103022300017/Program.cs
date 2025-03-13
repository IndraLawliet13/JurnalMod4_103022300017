using JurnalMod4_103022300017;

class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine(KodeProduk.getKodeProduk("Laptop"));
        Console.WriteLine(KodeProduk.getKodeProduk("Mouse"));
        FanLaptop fan = new FanLaptop();
        fan.TurboShortcut();
        fan.TurboShortcut();
        fan.ModeUp();
        fan.ModeUp();
        fan.ModeDown();
    }
}