public class WaterTanks
{
    private double capacity { get; set; }
    private double currentLevel { get; set; }
    
    public WaterTanks(double capacity, double currentLevel)
    {
        this.capacity = capacity;
        this.currentLevel = currentLevel;

    }

    public static WaterTanks operator +(WaterTanks bottle1, WaterTanks bottle2)
    {
        if (bottle1.currentLevel + bottle2.currentLevel < bottle1.capacity)
        {
            return new WaterTanks(bottle1.capacity, bottle1.currentLevel + bottle2.currentLevel);
        }
        else
        {
            return new WaterTanks(bottle1.capacity, bottle1.currentLevel);
        }
    }

    public static WaterTanks operator -(WaterTanks bottle1,double water)
    {
        if (bottle1.currentLevel > water)
        {
            return new WaterTanks(bottle1.capacity, bottle1.currentLevel - water);
        }
        else
        {
            return new WaterTanks(bottle1.capacity, bottle1.currentLevel);
        }
    }

    public override string ToString()
    {
       return $"{capacity} {currentLevel}";
    }

}

class Program
{
    static void Main()
    {
        WaterTanks bottle1 = new WaterTanks(125, 78);
        WaterTanks bottle2 = new WaterTanks(125, 4);
        Console.WriteLine(bottle2 + bottle1);
        Console.WriteLine(bottle1 - 77);
    }
}