namespace mis_221_pa_5_tsbutterworth1
{
    public class ListingUtility
    {
        private Listing[] listings;
        public ListingUtility(Listing[] books)
        {
            this.listings = listings;
        }
        public void GetAllListings()
        {
            Listing.ListingSetCount(0);
            System.Console.WriteLine("Please enter the Listing ID or 'stop' to stop.");
            string userInput = Console.ReadLine();
            while(userInput.ToUpper()!="STOP")
            {
                listings[Listing.ListingGetCount()] = new Listing();
                listings[Listing.ListingGetCount()].SetListingID(int.Parse(userInput));
                System.Console.WriteLine("Please enter the full name of the Trainer:");
                listings[Listing.ListingGetCount()].SetTrainerFullName(Console.ReadLine());
                System.Console.WriteLine("Please enter the date of the session:");
                listings[Listing.ListingGetCount()].SetSessionDate(Console.ReadLine());
                System.Console.WriteLine("Please enter the time of the session:");
                listings[Listing.ListingGetCount()].SetSessionTime(Console.ReadLine());
                System.Console.WriteLine("Please enter the cost of the session:");
                listings[Listing.ListingGetCount()].SetSessionCost(Console.ReadLine());
                System.Console.WriteLine("Please enter 'booked' to book the session, or 'open' to make the session available:");
                listings[Listing.ListingGetCount()].SetBookedStatus(Console.ReadLine());
                Listing.ListingIncCount();
                System.Console.WriteLine("Please enter another Listing ID or 'stop' to stop");
            }
        }
        public void GetAllListingsFromFile()
        {
            StreamReader inFile = new StreamReader("listings.txt");
            int listingCount = 0;
            Listing.ListingSetCount(0);
            string line = inFile.ReadLine();
            while(line != null)
            {
                string[] temp = line.Split('#');
                listings[Listing.ListingGetCount()] = new Listing(int.Parse(temp[0]), temp[1], temp[2], temp[3], temp[4], temp[5]);
                Listing.ListingIncCount();
                line = inFile.ReadLine();
            }
            inFile.Close();
        }
        public void AddListing()
        {
            System.Console.WriteLine("Please enter the Listing ID:");
            Listing myListing = new Listing();
            myListing.SetListingID(int.Parse(Console.ReadLine()));
            System.Console.WriteLine("Please enter the Trainer's full name:");
            myListing.SetTrainerFullName(Console.ReadLine());
            System.Console.WriteLine("Please enter the session's date:");
            myListing.SetSessionDate(Console.ReadLine());
            System.Console.WriteLine("Please enter the session's time:");
            myListing.SetSessionTime(Console.ReadLine());
            System.Console.WriteLine("Please enter the session's cost:");
            myListing.SetSessionCost(Console.ReadLine());
            System.Console.WriteLine("Please enter the session's booked status ('booked' or 'open'):");
            myListing.SetBookedStatus(Console.ReadLine());
            listings[Listing.ListingGetCount()] = myListing;
            Listing.ListingIncCount();
            SaveListing();
        }
        private void SaveListing()
        {
            StreamWriter outFile = new StreamWriter("listings.txt");
            for(int i = 0; i < Listing.ListingGetCount(); i++)
            {
                outFile.WriteLine(listings[i].ListingToFile());
            }
            outFile.Close();
        }
        // private int FindListing(string searchVal)
        // {
        //     // for(int i = 0; i < Listing.ListingGetCount(); i++)
        //     // {
        //     //     if(listings[i].GetListingID().ToUpper() == searchVal.ToUpper())
        //     //     {
        //     //         return i;
        //     //     }
        //     // }
        //     // return -1;
        // }
        // public void UpdateListing()
        // {
        //     System.Console.WriteLine("What is the ID of the listing you would like to update?");
        //     string searchVal = Console.ReadLine();
        //     int foundIndex = FindListing(searchVal);

        //     if(foundIndex != -1)
        //     {
        //         listings[foundIndex].SetListingID(int.Parse(userInput));
        //         System.Console.WriteLine("Please enter the full name of the Trainer:");
        //         listings[foundIndex].SetTrainerFullName(Console.ReadLine());
        //         System.Console.WriteLine("Please enter the date of the session:");
        //         listings[foundIndex].SetSessionDate(Console.ReadLine());
        //         System.Console.WriteLine("Please enter the time of the session:");
        //         listings[foundIndex].SetSessionTime(Console.ReadLine());
        //         System.Console.WriteLine("Please enter the cost of the session:");
        //         listings[foundIndex].SetSessionCost(Console.ReadLine());
        //         System.Console.WriteLine("Please enter 'booked' to book the session, or 'open' to make the session available:");
        //         listings[foundIndex].SetBookedStatus(Console.ReadLine());
        //         SaveListing();
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Listing not found.");
        //     }
        // } 
        // public void SortListing()
        // {
        //     for(int i = 0; i < Listing.ListingGetCount()-1; i++)
        //     {
        //         int min = i;
        //         for(int j = i+1; j < Listing.ListingGetCount(); j++)
        //         {
        //             if(listings[j].GetGenre().CompareTo(listings[min].GetGenre()) < 0 || 
        //             (listings[j].GetGenre() == listings[min].GetGenre() && listings[j].GetPages() < listings[min].GetPages()))
        //             {
        //                 min = j;
        //             }
        //         }
        //         if(min != i)
        //         {
        //             Swap(min, i);
        //         }
        //     }
        //}
        private void SwapListing(int x, int y)
        {
            Listing temp = listings[x];
            listings[x] = listings[y];
            listings[y] = temp;
        }
    }
}