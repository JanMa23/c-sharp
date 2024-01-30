class Ecar : Vehicle {

    public Ecar(string aColour, string aManufacturer,int aGasLevel) {
        colour = aColour;
        manufacturer = aManufacturer;
        gasLevel = aGasLevel;

    }

    
    public override void Drive() {
        
            Console.WriteLine($"\n{colour} {manufacturer}");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{colour} {manufacturer} goes sshhhh\n");
            Console.ResetColor();
            
        


    }


}