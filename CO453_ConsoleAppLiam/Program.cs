using CO453_ConsoleAppLiam.Unit_4;
using CO453_ConsoleAppLiam.Unit_5;
using CO453_ConsoleAppLiam.Project;
using System;

namespace CO453_ConsoleAppLiam
{
    class Program
    {
        static void Main()
        {
            //RunDistanceConverter(); //Task 4.1 Done //Class/Methods fully commented
            //RunHorrorStory(); //Task 4.2 & 4.3 Done //Class/Methods fully commented
            //RunBMI(); //Task 4.4 Done //Class/Methods fully commented
            //RunTournament(); //Task 5.1 & 5.3 Done //Class/Methods fully commented
            //RunMP3Chart(); //Task 5.2 Done //Class/Methods fully commented
            //RunBubble(); //Doesn't work :/ //Class/Methods fully commented
            //RunTraffic(); //Task 5.5 Done //Class/Methods fully commented
            //RunMotel(); //Task 5.6 Done //Class/Methods fully commented
            //RunSPSGame(); //Task Basic Project Done //Class/Methods fully commented
        }

        static void RunDistanceConverter()
        {
            DistanceConverter myConverter = new DistanceConverter();
            myConverter.Test();
        }

        static void RunHorrorStory()
        {
            HorrorStory horrorstory = new HorrorStory();
            horrorstory.GetDetails();
            horrorstory.ConfirmGender();
            horrorstory.WriteChapter1();
            horrorstory.WriteChapter2();
        }
        static void RunBMI()
        {
            BMI bmi = new BMI();
            bmi.GetDetails();
            bmi.CalcBMI();
            bmi.DisplayBMI();
        }
        static void RunTournament()
        {
            Tournament tournament = new Tournament();
            tournament.GetDetails();
            tournament.ShowDetails();
        }
        static void RunMP3Chart()
        {
            MP3Chart mp3chart = new MP3Chart();
            mp3chart.ShowMusicList();
            mp3chart.GetVotes();
            mp3chart.ShowVotes();
        }
        static void RunBubble()
        {
            Bubble bubble = new Bubble();
            bubble.InputNumbers();
            bubble.Display();
        }
        static void RunTraffic()
        {
            Traffic traffic = new Traffic();
            traffic.EnterCounts();
            traffic.ShowData();
            traffic.ShowTotal();
            traffic.Busiest();
        }
        static void RunMotel()
        {
            Motel motel = new Motel();
            motel.RunMotel();
        }
        static void RunSPSGame()
        {
            SPSGame sps = new SPSGame();
            sps.Play();
        }
    }
}
