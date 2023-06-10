using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        string choice = "";
        int actCount = 0;
        do{
            Console.Clear();
            Console.WriteLine("Menu Option:"); 
            Console.WriteLine(" 1. Start breathing activity"); 
            Console.WriteLine(" 2. Start reflecting activity"); 
            Console.WriteLine(" 3. Start listing activity \n 4. Quit");
        
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            Console.Clear();

            string actStartMsg = "Welcome to the Breathing Activity \n \n";
            string actEndMsg = "\n \nWell done!!\n \n";

            

            Activity activity = new Activity("Mindful Activity",actStartMsg,actEndMsg);

            if (choice =="1" ){
                actCount++;
                
                BreathingActivity bAct = new BreathingActivity("Breathe in",
                "Breathe out","Beathing Activity",
                "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing",
                "\n \nWell done!!\n \n");

                Console.WriteLine(bAct.GetStartMessage());
                Console.Write("\n \nHow long, in seconds, would you like for your session? ");
                int duration = int.Parse(Console.ReadLine());
                bAct.SetDuration(duration);

                Console.Clear();
                bAct.GetReady();
                bAct.PauseSpinner(3);

                
                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(duration);
                while (DateTime.Now < endTime){
                bAct.StartBreathingSequence();
                }

                bAct.ShowEndMessage();
                Console.WriteLine($"Number of sessions: {actCount}");
                bAct.PauseSpinner(3);

            }else if (choice == "2"){
                actCount++;

                ReflectionActivity refAct = new ReflectionActivity("Reflecting Activity",
                "This actvity will help you reflect on things in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.",
                "\n \nWell done!!\n \n");

                Console.WriteLine(refAct.GetStartMessage());
                Console.Write("\n \nHow long, in seconds, would you like for your session? ");
                int duration = int.Parse(Console.ReadLine());
                refAct.SetDuration(duration);

                Console.Clear();
                refAct.GetReady();
                refAct.PauseSpinner(3);

                Console.WriteLine("\nConsider the following prompt: \n");
                refAct.ShowRandomPrompt();
                Console.Write("\nWhen you have something in mind, press enter to continue.");
                string userResponse = Console.ReadLine();
                if(userResponse == ""){
                    Console.WriteLine(
                        "\nNow ponder on each of the following questions as they relate to this experience.");
                        Console.Write("You may begin in: ");
                        refAct.PauseCountDown(5);
                        Console.Clear();

                        DateTime startTime = DateTime.Now;
                        DateTime endTime = startTime.AddSeconds(duration);
                        while (DateTime.Now < endTime){
                        refAct.ShowRandomReflectionPrompts();
                        }
                        refAct.ShowEndMessage();
                        Console.WriteLine($"Number of sessions: {actCount}");
                        refAct.PauseSpinner(3);
                        

                }





            }else if (choice == "3"){
                actCount++;

                ListingActivity listAct = new ListingActivity("Listing Activity",
                "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.","\n \nWell done!!\n \n");

                Console.Write("\n \nHow long, in seconds, would you like for your session? ");
                int duration = int.Parse(Console.ReadLine());
                listAct.SetDuration(duration);

                Console.Clear();
                listAct.GetReady();
                listAct.PauseSpinner(3);
                
                Console.WriteLine("List as many responses as you can to the following prompt:");
                listAct.ShowRandomListingPrompt();
                Console.Write("You may begin in: \n");
                listAct.PauseCountDown(8);
                string item = "";
                int items = 0;

                DateTime startTime = DateTime.Now;
                DateTime endTime = startTime.AddSeconds(duration);
                while (DateTime.Now < endTime){
                    items ++;
                Console.Write("> ");
                item = Console.ReadLine();
                listAct.AddItemToList(item);
                }
                Console.WriteLine($"You listed {items} items");

                listAct.ShowEndMessage();
                Console.WriteLine($"Number of sessions: {actCount}");
                listAct.PauseSpinner(10);




            }else if(choice == "4"){
                break;
                
            }else{
                Console.WriteLine("Please select a valid option: "); 
                activity.PauseSpinner(3); 
            }
        }while(choice != "4");
    }
}



/*-Made sure no random prompts/questions are selected until 
they have all been used at least once in that session.
    - The program tracks the number of times the user completes 
    of a particular activity.*/