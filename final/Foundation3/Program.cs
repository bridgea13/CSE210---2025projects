using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Generating Events:\nLecture\nReception\nOutdoor Gathering\n################################\n");
        //public Lectures(string title, string description, string time, string streetAddress, string city, string state, int zipCode, string speaker, int capacity) : base(title, description, time, streetAddress, city, state, zipCode)
        Lectures lectures = new Lectures("BonJovi teaches Physics", "Renowened guitarist Jon BonJovi teaches phyiscs to all","May 1st, 2025", "6PM", "209 South 33rd Street", "Philadelphia", "PA", 19104, "Jon BonJovi", 200);
        Receptions receptions = new Receptions("Alice Graduates from College", "Alice is done with college finally","April 12, 2025", "2 PM", "123 Main Street", "Holly Springs", "NC", 27540, "abc@gmail.com");
        OutdoorGatherings outdoorGatherings = new OutdoorGatherings("Activity Day Day Camp", "Bring your 7-11 year olds for a day of fun and learning", "June 22, 2025","8 AM", "2540 N Broad St.", "Fuquay Varina", "NC", 27526, "Weather will be sunny high of 80 F");
        
        lectures.OutputMarketing(1);
        receptions.OutputMarketing(2);
        outdoorGatherings.OutputMarketing(3);

    }
}