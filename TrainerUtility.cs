namespace mis_221_pa_5_tsbutterworth1
{
    public class TrainerUtility
    {
        private Trainer[] trainers;

        public TrainerUtility(Trainer[] trainers) {
            this.trainers = trainers;
        }
        public void GetAllTrainers() { 
            Trainer.TrainerSetCount(0);
            System.Console.WriteLine("Please enter the new Trainer ID, or 'stop' to stop.");
            string userInput = Console.ReadLine();
            while(userInput.ToUpper()!="STOP")
            {
                trainers[Trainer.TrainerGetCount()] = new Trainer();
                trainers[Trainer.TrainerGetCount()].SetTrainerID(userInput);
                System.Console.WriteLine("Please enter the first name of the Trainer:");
                trainers[Trainer.TrainerGetCount()].SetTrainerFirst(Console.ReadLine());
                System.Console.WriteLine("Please enter the last name of the Trainer:");
                trainers[Trainer.TrainerGetCount()].SetTrainerLast(Console.ReadLine());
                System.Console.WriteLine("Please enter the email of the Trainer:");
                trainers[Trainer.TrainerGetCount()].SetTrainerEmail(Console.ReadLine());
                System.Console.WriteLine("Please enter the street adress of the Trainer:");
                trainers[Trainer.TrainerGetCount()].SetTrainerStreetAddress(Console.ReadLine());
                Trainer.TrainerIncCount();
                System.Console.WriteLine("Please enter another Trainer ID or 'stop' to stop");
            }
        }
        public void GetAllTrainersFromFile()
        {
            StreamReader inFile = new StreamReader("trainers.txt");
            int trainerCount = 0;
            Trainer.TrainerSetCount(0);
            string line = inFile.ReadLine();
            while(line != null)
            {
                string[] temp = line.Split('#');
                trainers[Trainer.TrainerGetCount()] = new Trainer(temp[0], temp[1], temp[2], temp[3], temp[4]);
                Trainer.TrainerIncCount();
                line = inFile.ReadLine();
            }
            inFile.Close();
        }
        public void AddTrainer()
        {
            System.Console.WriteLine("Please enter the Trainer ID:");
            Trainer myTrainer = new Trainer();
            myTrainer.SetTrainerID(Console.ReadLine());
            System.Console.WriteLine("Please enter the Trainer's first name:");
            myTrainer.SetTrainerFirst(Console.ReadLine());
            System.Console.WriteLine("Please enter the Trainer's last name:");
            myTrainer.SetTrainerLast(Console.ReadLine());
            System.Console.WriteLine("Please enter the Trainer's street address:");
            myTrainer.SetTrainerStreetAddress(Console.ReadLine());
            System.Console.WriteLine("Please enter the Trainer's email adress:");
            myTrainer.SetTrainerEmail(Console.ReadLine());
            trainers[Trainer.TrainerGetCount()] = myTrainer;
            Trainer.TrainerIncCount();
            Save();
        }
        private void Save()
        {
            StreamWriter outFile = new StreamWriter("trainers.txt");
            for(int i = 0; i < Trainer.TrainerGetCount(); i++)
            {
                outFile.WriteLine(trainers[i].TrainerToFile());
            }
            outFile.Close();
        }
        private int Find(string searchVal)
        {
            for(int i = 0; i < Trainer.TrainerGetCount(); i++)
            {
                if(trainers[i].GetTrainerID().ToUpper() == searchVal.ToUpper())
                {
                    return i;
                }
            }
            return -1;
        }
        public void UpdateTrainer()
        {
            System.Console.WriteLine("What is the ID of the Trainer you would like to update?");
            string searchVal = Console.ReadLine();
            int foundIndex = Find(searchVal);

            if(foundIndex != -1)
            {
                System.Console.WriteLine("Please enter the Trainer ID:");
                trainers[foundIndex].SetTrainerID(Console.ReadLine());
                System.Console.WriteLine("Please enter the Trainer's first name:");
                trainers[foundIndex].SetTrainerFirst(Console.ReadLine());
                System.Console.WriteLine("Please enter the Trainer's last name:");
                trainers[foundIndex].SetTrainerLast((Console.ReadLine()));
                System.Console.WriteLine("Please enter the Trainer's street adress:");
                trainers[foundIndex].SetTrainerStreetAddress(Console.ReadLine());
                System.Console.WriteLine("Please enter the Trainer's email adress:");
                trainers[foundIndex].SetTrainerEmail(Console.ReadLine());
                Save();
            }
            else
            {
                System.Console.WriteLine("Trainer not found.");
            }
        } 
        // public void Sort()
        // {
        //     for(int i = 0; i < Trainer.TrainerGetCount()-1; i++)
        //     {
        //         int min = i;
        //         for(int j = i+1; j < Trainer.TrainerGetCount(); j++)
        //         {
        //             if(trainers[j].GetGenre().CompareTo(trainers[min].GetGenre()) < 0 || 
        //             (trainers[j].GetGenre() == trainers[min].GetGenre() && trainers[j].GetPages() < trainers[min].GetPages()))
        //             {
        //                 min = j;
        //             }
        //         }
        //         if(min != i)
        //         {
        //             Swap(min, i);
        //         }
        //     }
        // }            ((((use for customer reports))))
        private void Swap(int x, int y)
        {
            Trainer temp = trainers[x];
            trainers[x] = trainers[y];
            trainers[y] = temp;
        }
    }
}