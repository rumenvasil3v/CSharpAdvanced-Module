using PersonsInfo;

Team team = new Team();

Person player1 = new("Gergi", "Gergiev", 20, 2300);
Person player2 = new("Pesi", "Gergiev", 19, 2300);

team.AddPlayer(player1);
team.AddPlayer(player2);

foreach (var player in team.Players)
{
    Console.WriteLine(player);
}

public class Team
{
    private List<Person> players;

    public Team()
    {
        this.players = new();
    }

    public IReadOnlyCollection<Person> Players
    {
        get { return this.players.AsReadOnly(); }
    }

    public void AddPlayer(Person player)
    => this.players.Add(player); // mutable now
}