using mis_221_pa_5_tsbutterworth1;

Trainer[] trainers = new Trainer[100];
TrainerUtility utility = new TrainerUtility(trainers);
//utility.GetAllTrainers();
utility.UpdateTrainer();

// //start main

// int userChoice = GetUserChoice();

// //end main 

// // keeps main menu running while user doesn't press 4 to exit
// do
// {
//     RouteEm(userChoice);
//     userChoice = GetUserChoice();
// } 
// while (userChoice!=4);

// // reads main menu choice from user, if it is one of the valid options
// static int GetUserChoice()
// {
//     DisplayMenu();
//     string userChoice = Console.ReadLine();
//     if (IsValidChoice(userChoice)) {
//         return int.Parse(userChoice);
//     }
//     else return 0;
// }

// // method that displays main menu
// static void DisplayMenu()
// {
//     Console.Clear();
//     Console.WriteLine("Enter (1) to Manage Trainer Data\nEnter (2) to Manage Listing Data\nEnter (3) to Manage Customer Booking Data\nEnter (4) to Run Reports\nEnter (5) To Exit");
// }

// // decides whether or not the user's main menu input is valid, is usesd in GetUserChoice()
// static bool IsValidChoice(string userChoice)
// {
//     if(userChoice == "1" || userChoice == "2" || userChoice == "3" || userChoice == "4" || userChoice == "5") {
//         return true;
//     }
//     return false;
// }

// // lets the user know if their main menu choice is invalid
// static void SayInvalid()
// {
//     Console.WriteLine("Invalid choice");
//     PauseAction();
// }

// // calls the method corresponding with the users input 
// static void RouteEm(int userChoice)
// {
//     if(userChoice==1)
//     {
//         System.Console.WriteLine("hey");
//     }
//     else if(userChoice==2)
//     {
//         //ManageListingData();
//     }
//     else if(userChoice==3)
//     {
//         //ManageBookingData();
//     }
//     else if(userChoice!=4)
//     {
//         //RunReports();
//     }
//     else if(userChoice!=5)
//     {
//         SayInvalid();
//     }
// }
// static void PauseAction()
// {
//     Console.WriteLine("Press any key to return to the main menu...");
//     Console.ReadKey();
// }