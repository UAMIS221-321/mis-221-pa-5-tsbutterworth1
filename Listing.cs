namespace mis_221_pa_5_tsbutterworth1
{
    public class Listing
    {
        private int listingID;
        private string trainerFullName;
        private string sessionDate;
        private string sessionTime;
        private string sessionCost;
        private string bookedStatus;
        static private int count;
        public Listing(){

        }
        public Listing(int listingID, string trainerFullName, string sessionDate, string sessionTime, string sessionCost, string bookedStatus){
            this.listingID = listingID;
            this.trainerFullName = trainerFullName;
            this.sessionDate = sessionDate;
            this.sessionTime = sessionTime;
            this.sessionCost = sessionCost;
            this.bookedStatus = bookedStatus;

        }
        public void SetListingID(int listingID){
            this.listingID = listingID;
        }
        public int GetListingID(){
            return listingID;
        }
        public void SetTrainerFullName(string trainerFullName){
            this.trainerFullName = trainerFullName;
        }
        public string GetTrainerFullName(){
            return trainerFullName;
        }
        public void SetSessionDate(string sessionDate){
            this.sessionDate = sessionDate;
        }
        public string GetSessionDate(){
            return sessionDate;
        }
        public void SetSessionTime(string sessionTime){
            this.sessionTime = sessionTime;
        }
        public string GetSessionTime(){
            return sessionTime;
        }
        public void SetSessionCost(string sessionCost){
            this.sessionCost = sessionCost;
        }
        public string GetSessionCost(){
            return sessionCost;
        }
        public void SetBookedStatus(string bookedStatus){
            this.bookedStatus = bookedStatus;
        }
        public string GetBookedStatus(){
            return bookedStatus;
        }
        static public void ListingSetCount(int count)
        {
            Listing.count = count;
        }
        static public void ListingIncCount()
        {
            Listing.count++;
        }
        static public int ListingGetCount()
        {
            return Listing.count;
        }
        // public override string ListingToString()
        // {
        //     return $"Listing ID: {listingID} will be hosted by {trainerFullName} on {listingDate} at {listingTime}, costing ${listingCost} and {bookedStatus} booked.";
        // }
        public string ListingToFile()
        {
            return $"{listingID}#{trainerFullName}#{sessionDate}#{sessionTime}#{sessionCost}#{bookedStatus}";
        }
    }
}