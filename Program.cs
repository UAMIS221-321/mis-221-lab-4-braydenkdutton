/*// start demo 
for (int i = 1; i < 5; i++){
    System.Console.Write(i + "     ");
    for (int j = 0; j < 10; j++){
        System.Console.Write(i*j + " ");
    }
    System.Console.WriteLine();
}
// end demo*/

//start main
DisplayMenu();
string userChoice = GetMenuChoice();
while (userChoice != "4"){  // condition controlled loop
    RouteEm(userChoice);
    DisplayMenu();
    userChoice = GetMenuChoice(); // update read
}
SayBye();
//end main 

static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("1. Display a plain no-topping pizza slice");
    System.Console.WriteLine("2. Display a cheese pizza slice");
    System.Console.WriteLine("3. Display a pepperoni pizza slice");
    System.Console.WriteLine("4. Exit");
}

static string GetMenuChoice(){
    System.Console.WriteLine("Enter your choice");
    return Console.ReadLine(); 
}

static void RouteEm(string userChoice){
    switch (userChoice){
        case "1":
            DisplayNoTopping();
            break;
        case "2":
            DisplayCheese();
            break;
        case "3":
            DisplayPepperoni();
            break;
        default: 
            System.Console.WriteLine("Invalid menu choice");
            Pause(); 
            break;
    }
}

static void DisplayNoTopping(){
    Random rnd = new Random();
    int number = rnd.Next(8,13);
    for (int i = number; i > 0; i--){
        System.Console.Write("*");
        for (int j = i-1; j > 0; j--){
            System.Console.Write("*");
        }
        System.Console.WriteLine();
    }
    Pause();
}

static void DisplayCheese(){
    Random rnd = new Random();
    int number = rnd.Next(8,13);
    for (int i = number; i > 0; i--){
        System.Console.Write("*");
        for (int j = i-1; j > 0; j--){
            if (i == number || j-1 == 0){
                System.Console.Write("*");
            }
            else{
                System.Console.Write("#");
            }
        }
        System.Console.WriteLine();
    }
    Pause();
}

static void DisplayPepperoni(){
    Random rnd = new Random();
    int number = rnd.Next(8,13);
    for (int i = number; i > 0; i--){
        System.Console.Write("*");
        for (int j = i-1; j > 0; j--){
            int pepPlacement = rnd.Next(9,12);
            if (i==number || j-1 == 0){
                System.Console.Write("*");
            }
            else if (j == pepPlacement){
                System.Console.Write("O");
            }
            else{
                System.Console.Write("#");
            }
        }
        System.Console.WriteLine();
    }
    Pause();
}

static void SayBye() {
    System.Console.WriteLine("Bye-bye bro-bro");
}

static void Pause() {
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
}

