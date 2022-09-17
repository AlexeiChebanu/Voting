using ListCollection;

class Program
{
    static void Main(string[] args)
    {
        Theme topic = new Theme();
        Console.WriteLine(topic.topic("Electing of "));

        Voting voting = new Voting();
        voting.dec();
    }
}