
class Car : Vehicle {

    public Car(string aColour, string aManufacturer, int aGasLevel) {
        colour = aColour;
        manufacturer = aManufacturer;
        gasLevel = aGasLevel;

    }

    public void OpenRadio(){
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Turn car radio on \nrock'n roll \n");
        Console.ResetColor();

    }

    public void OpenWindow(){
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Opening the window \nfresh air!\n");
        Console.ResetColor();

    }
}