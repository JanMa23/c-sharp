
class Motorcycle : Vehicle {

     public Motorcycle (string aColour, string aManufacturer, int aGasLevel) {
        colour = aColour;
        manufacturer = aManufacturer;
        gasLevel = aGasLevel;

    }

    public void PutHelmetOn() {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Helmet suits well \nNice and safe \n");
        Console.ResetColor();
    }
}