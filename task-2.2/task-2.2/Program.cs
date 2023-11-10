using System.Xml.Linq;

public abstract class Worker
{
    public Worker(string name, string position, int workDay)
    { 
        this.name = name;
        this.position = position;
        this.workDay = workDay;
    }

    public string name { get; }
    public string position { get; }
    public int workDay { get; }

    public void Call()
    {
        Console.WriteLine($"{name} is making a phone call.");
    }

    public void WriteCode()
    {
        Console.WriteLine($"{name} is writing code.");
    }

    public void Relax ()
    {
        Console.WriteLine($"{name} is relaxing.");
    }

    public abstract void FillWorkDay();
}

public class Developer : Worker
{
    public Developer(string name) : base(name, "Developer", 8)
    {

    }

    public override void FillWorkDay()
    {
        WriteCode();
        Call();
        Relax();
        WriteCode();
    }
}

public class Manager : Worker
{
    public Manager(string name) : base(name, "Manager", 8)
    {

    }

    private Random random = new Random();

    public override void FillWorkDay()
    {
        int callCount1 = random.Next(1, 11);

        for (int i = 0; i < callCount1; i++)
        {
            Call();
        }

        Relax();

        int callCount2 = random.Next(1, 6);

        for (int i = 0; i < callCount2; i++)
        {
            Call();
        }
    }
}

public class Team
{
    string symbol = new string('-', 100);
    public Team(string teamName)
    {
        this.teamName = teamName;
    }

    public string teamName { get; }

    private List<Worker> teamMembers = new List<Worker>();

    public void AddTeamMember(Worker worker)
    {
        teamMembers.Add(worker);
    }

    public void DisplayTeamInfo()
    {
        Console.WriteLine(symbol);
        Console.WriteLine($"Team: {teamName}");
        foreach (var member in teamMembers)
        {
            Console.WriteLine(symbol);
            Console.WriteLine($"{member.name} - {member.position} - {member.workDay} hours");
            member.FillWorkDay();
        }
    }

}

public class Program
{
    public static void Main()
    {
        Dictionary<string, Team> teams = new Dictionary<string, Team>();
        string symbol = new string('-', 100);

        while (true)
        {         
            Console.WriteLine(symbol);
            Console.WriteLine("1. Add team");
            Console.WriteLine("2. Add developer");
            Console.WriteLine("3. Add manager");
            Console.WriteLine("4. Show information about team");
            Console.WriteLine("5. Exit");
            Console.WriteLine(symbol);

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the name of the team:");
                    string teamName = Console.ReadLine();
                    Team team = new Team(teamName);
                    teams.Add(teamName, team);
                    Console.WriteLine("The team is created.");
                    break;

                case 2:
                    Console.WriteLine("Enter the name of the developer:");
                    string developerName = Console.ReadLine();
                    Console.WriteLine("Enter the name of the team in which you want to add a developer:");
                    string teamToAddToD = Console.ReadLine();

                    if (teams.ContainsKey(teamToAddToD))
                    {
                        Developer developer = new Developer(developerName);
                        teams[teamToAddToD].AddTeamMember(developer);
                        Console.WriteLine("Developer is added to the team.");
                    }
                    else
                    {
                        Console.WriteLine("Such a team does not exist.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Enter the name of the manager:");
                    string managerName = Console.ReadLine();
                    Console.WriteLine("Enter the name of the team in which you want to add a manager:");
                    string teamToAddToM = Console.ReadLine();

                    if (teams.ContainsKey(teamToAddToM))
                    {
                        Manager manager = new Manager(managerName);
                        teams[teamToAddToM].AddTeamMember(manager);
                        Console.WriteLine("Manager is added to the team.");
                    }
                    else
                    {
                        Console.WriteLine("Such a team does not exist.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Enter the name of the team, the information about you want to get:");
                    string teamToDisplay = Console.ReadLine();

                    if (teams.ContainsKey(teamToDisplay))
                    {
                        teams[teamToDisplay].DisplayTeamInfo();
                    }
                    else
                    {
                        Console.WriteLine("Such a team does not exist.");
                    }
                    break;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Incorrect choice. Please choose an action from 1 to 5.");
                    break;
            }
        }
    }
}