namespace mis_221_pa_5_tsbutterworth1
{
    public class Trainer
    {
        //instance variables
        private string trainerID; 
        private string trainerFirst;
        private string trainerLast;
        private string trainerStreetAddress;
        private string trainerEmail;

        // class variables
        static private int count;
        // no arg constructor
        public Trainer()
        {

        }
        // arg constructor
        public Trainer(string trainerID, string trainerFirst, string trainerStreetAddress, string trainerLast, string trainerEmail)
        {
            this.trainerID = trainerID;
            this.trainerFirst = trainerFirst;
            this.trainerLast = trainerLast;
            this.trainerStreetAddress = trainerStreetAddress;
            this.trainerEmail = trainerEmail;
        }
        public void SetTrainerID(string trainerID)
        {
            this.trainerID = trainerID;
        }
        public string GetTrainerID()
        {
            return trainerID;
        }
        public void SetTrainerFirst(string trainerFirst)
        {
            this.trainerFirst = trainerFirst;
        }
        public string GetTrainerFirst()
        {
            return trainerFirst;
        }
        public void SetTrainerLast(string trainerLast)
        {
            this.trainerLast = trainerLast;
        }
        public string GetTrainerLast()
        {
            return trainerLast;
        }
        public void SetTrainerEmail(string trainerEmail)
        {
            this.trainerEmail = trainerEmail;
        }
        public string GetTrainerEmail()
        {
            return trainerEmail;
        }
        public void SetTrainerStreetAddress(string trainerStreetAddress)
        {
            this.trainerStreetAddress = trainerStreetAddress;
        }
        public string GetTrainerStreetAddress()
        {
            return trainerStreetAddress;
        }
        static public void TrainerSetCount(int count)
        {
            Trainer.count = count;
        }
        static public void TrainerIncCount()
        {
            Trainer.count++;
        }
        static public int TrainerGetCount()
        {
            return Trainer.count;
        }
        // public override string TrainerToString()
        // {
        //     return $"{trainerFirst} {trainerLast}'s ID is {trainerID}, they live at {trainerStreetAddress}, and their email is {trainerEmail}";
        // }
        public string TrainerToFile()
        {
            return $"{trainerID}#{trainerFirst}#{trainerLast}#{trainerStreetAddress}#{trainerEmail}";
        }
    }
}