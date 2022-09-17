using ListCollection;

class Program
{
    static void Main(string[] args)
    {
        Topic topic = new Topic();
        Console.WriteLine(topic.topic("Today`s voting topic is" + " "));

        Voting voting = new Voting();
        voting.dec();
    }
}