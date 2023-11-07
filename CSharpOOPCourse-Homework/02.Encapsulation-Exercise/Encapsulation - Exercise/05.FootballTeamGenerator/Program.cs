using FootballTeamGenerator.Models;

Dictionary<string, Team> teams = new();
string command;
while ((command = Console.ReadLine()) != "END")
{
    string[] commandArguments = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
    try
    {
        switch (commandArguments[0])
        {
            case "Add":
                AddPlayer(
                   commandArguments[2],
                    int.Parse(commandArguments[3]),
                    int.Parse(commandArguments[4]),
                    int.Parse(commandArguments[5]),
                    int.Parse(commandArguments[6]),
                    int.Parse(commandArguments[7]),
                    commandArguments[1],
                    teams);
                break;
            case "Remove":
                RemovePlayer(commandArguments[1], commandArguments[2], teams);
                break;
            case "Team":
                AddTeam(commandArguments[1], teams);
                break;
            case "Rating":
                GetRating(commandArguments[1], teams);   
                break;
        }
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

static void AddPlayer(
    string name,
    int endurance,
    int sprint,
    int dribble,
    int passing,
    int shooting,
    string teamName,
    Dictionary<string, Team> teams)
{
    if (teams.ContainsKey(teamName))
    {
         Player player = new(name, endurance, sprint, dribble, passing, shooting);

        teams[teamName].AddPlayer(player);
    }
    else
    {
        throw new ArgumentException($"Team {teamName} does not exist.");
    }
}

static void RemovePlayer(string team, string player, Dictionary<string, Team> teams)
{
    if (teams.ContainsKey(team))
    {
        teams[team].RemovePlayer(player);
    }
    else
    {
        throw new ArgumentException($"Team {team} does not exist.");
    }
}

static void AddTeam(string teamName, Dictionary<string, Team> teams)
{
    Team team = new Team(teamName);

    if (!teams.ContainsKey(teamName))
    {
        teams.Add(teamName, team);
    }
}

static void GetRating(string team, Dictionary<string, Team> teams)
{
    if (teams.ContainsKey(team))
    {
        Console.WriteLine(teams[team].ToString());
    }
    else
    {
        throw new ArgumentException($"Team {team} does not exist.");
    }
}