namespace zoo;
class Program
{
    static void Main(string[] args)
    {
        Fox foxMan = new Fox()
        {
            Weight = 20,
            Colour = (Enums.Colour)3,
            Role = "Alfa",
            Voice = "RRR"
        };

        foxMan.GetVoice();
    }
}

