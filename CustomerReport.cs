// namespace mis_221_pa_5_tsbutterworth1
// {
//     public class TrainerReport
//     {
//         Trainer[] trainers;

//         public TrainerReport(Trainer[] trainers)
//         {
//             this.trainers = trainers;
//         }
//         public void PrintAllTrainers()
//         {
//             for(int i = 0; i < Trainer.GetCount(); i++)
//             {
//                 System.Console.WriteLine(trainers[i].ToString());
//             }
//         }
//         public void PagesByGenre()
//         {
//             string curr = trainers[0].GetGenre();
//             int count = trainers[0].GetPages();
//             for(int i = 1; i < Trainer.GetCount(); i++)
//             {
//                 if(trainers[i].GetGenre()==curr)
//                 {
//                     count += trainers[i].GetPages();
//                 }
//                 else
//                 {
//                     ProcessBreak(ref curr, ref count, trainers[i]);
//                 }
//             }
//             ProcessBreak(curr, count);
//         }

//         public void ProcessBreak(ref string curr, ref int count, Trainer newTrainer)
//         {
//             System.Console.WriteLine($"{curr}\t{count}");
//             curr = newTrainer.GetGenre();
//             count = newTrainer.GetPages();
//         }
//         public void ProcessBreak(string curr, int count)
//         {
//             System.Console.WriteLine($"{curr}\t{count}");

//         }
//     }
// }