
class Vehicle {
    public string colour;
    public string manufacturer;
    public int gasLevel = 4;
    public int i =0;

    public virtual void Drive() {
        
        if (i < 1) {
            Console.WriteLine($"{colour} {manufacturer}");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Motor is running!");
            Console.ResetColor();
            i++;
        }

        if (gasLevel > 0) {
            Console.WriteLine($"Gas level: {gasLevel}");
            gasLevel--;

            
        } else {
            Console.WriteLine($"Gas level: {gasLevel}");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Out of gas \n");
            Console.ResetColor();
            return;
        }

        Console.WriteLine("Continue driving? y / n :");
        string continueDriving = Console.ReadLine();

        if (continueDriving == "y") {
            Drive();
        } else {
            return;
        }


    }
}




