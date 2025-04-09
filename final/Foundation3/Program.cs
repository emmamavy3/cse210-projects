using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Ocean Ave", "Miami", "FL", "USA");
        Address address3 = new Address("789 Forest Rd", "Portland", "OR", "USA");

        Lectures lecture = new Lectures("Tech Talk", "A talk on AI and the future", "April 20", "6:00 PM", address1, "Dr. Smith", 100);
        Receptions reception = new Receptions("Networking Night", "Meet and greet with professionals", "May 5", "7:00 PM", address2, "rsvp@example.com");
        OutdoorGathering outdoor = new OutdoorGathering("Spring Festival", "Celebrate the season outdoors", "June 1", "12:00 PM", address3, "Sunny with light breeze");

        List<Event> events = new List<Event> { lecture, reception, outdoor };

        foreach (var ev in events)
        {
            Console.WriteLine("STANDARD DETAILS:");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();

            if (ev is Lectures)
            {
                Lectures lec = (Lectures)ev;
                Console.WriteLine("FULL DETAILS:");
                Console.WriteLine(lec.GetLectureDetails());
            }
            else if (ev is Receptions)
            {
                Receptions rec = (Receptions)ev;
                Console.WriteLine("FULL DETAILS:");
                Console.WriteLine(rec.GetReceptionDetails());
            }
            else if (ev is OutdoorGathering)
            {
                OutdoorGathering outg = (OutdoorGathering)ev;
                Console.WriteLine("FULL DETAILS:");
                Console.WriteLine(outg.GetOutdoorGatheringDetails());
            }

            Console.WriteLine();
            Console.WriteLine("SHORT DESCRIPTION:");
            Console.WriteLine(ev.GetShortDetails());
            Console.WriteLine("\n-------------------------\n");
        }
    }
}
