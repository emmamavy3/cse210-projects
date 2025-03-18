// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bob", "Bubba", 97);
        Console.WriteLine($"{myPerson.DisplayPersonInfo()}");

        Policeman mypoliceMan = new Policeman("taser", "Joe", "Mama", 77);
        mypoliceMan.SetHeight(73);
        // mypoliceMan._height =76;
        Console.WriteLine($"Police Man Height {mypoliceMan.GetHeight()} inches");
        Console.WriteLine($"{mypoliceMan.DisplayPoliceinfo()}");

        Doctor myDoctor = new Doctor("Peditation","Stella", "Dreiser", 36);
        Console.WriteLine($"{myDoctor.DisplayDoctorInfo}");
    }
}
