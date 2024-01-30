// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");




Console.Write("Input: ");
int input = Convert.ToInt32 ( Console.ReadLine());
int rivi = 0; 
int sarake = 0;
int kierros = 0;


for (kierros = 0; kierros <= input; kierros++) {
    
    
    int star = (2 * kierros - 1);
    int space = (input - kierros);

    //1. kierros = input (3) - 0 = 3 tyhjää
    //2. kierros = input (3) - 1 = 2 tyhjää
    //3. kierros = 3 - 2 = 1 tyhjä
    //4. kierros = 3 - 3 = 0     
    for (sarake = 1; sarake <= space; sarake++){
        Console.Write(" ");
    }

    //1. kierros = 2 * 0 - 1 = 0 
    //2. kierros = 2 * 1 - 2 = 1 tähti
    //3. kierros = 2 * 2 - 1 = 3 tähteä
    //4. kierros = 2 * 3 - 1 = 5 tähteä
    for (rivi = 1; rivi <= star; rivi++){
        Console.Write("*");
    }
    Console.WriteLine();
}


for (kierros = 1; kierros <= input; kierros++)
{
    int space = kierros;
    int star = (input * 2 - 1) - (space * 2);
    
    for (sarake = 1; sarake <= space; sarake++) {        
		Console.Write(" ");
    }

    for (rivi = 1; rivi <= star; rivi++) {
		Console.Write("*");
    }
    
    Console.WriteLine();	
    
}




Console.ReadLine();

