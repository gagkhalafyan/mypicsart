using System.Drawing;

public class InkReservoir
{
    private string Color { get; set; }
    private double InkAmount { get; set; }

    public InkReservoir(string Color, double InkAmount)
    {
        this.Color = Color;
        this.InkAmount = InkAmount;

    }

    public static InkReservoir operator +(InkReservoir pen1, InkReservoir pen2)
    {
        if (pen1.Color == pen2.Color)
        {
            return new InkReservoir(pen1.Color, pen1.InkAmount + pen2.InkAmount);
        }
        else
        {
            return new InkReservoir(pen1.Color, pen1.InkAmount);
        }
    }

    public static InkReservoir operator -(InkReservoir pen, double ink)
    {
        if (pen.InkAmount > ink)
        {
            return new InkReservoir(pen.Color, pen.InkAmount - ink);
        }
        else
        {
            return new InkReservoir(pen.Color, pen.InkAmount);
        }
    }

    public override string ToString()
    {
        return $"{Color}, {InkAmount}";
    }
}

class Program
{
    static void Main()
    {
        InkReservoir pen = new InkReservoir("red", 10.2);
        InkReservoir pen1 = new InkReservoir("blue", 2.6);
        InkReservoir pen2 = new InkReservoir("red", 5.2);

        Console.WriteLine(pen +  pen2);
        Console.WriteLine(pen + pen1);
        Console.WriteLine(pen - 10.3);
    }
}