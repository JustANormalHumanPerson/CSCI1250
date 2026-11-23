/*
* Name: Jocie Marino
* Course: CSCI 1250, Section 002
* Assignment: Lab 08, Game Night
* Date: November 18, 2026
* Description: Keeps a game night leaderboard in three text files. Shows the
* season so far, records tonight's points, saves the new totals,
* and adds tonight's result to a history that grows every week.
*/

const string PLAYERS_FILE = "players.txt";
const string POINTS_FILE = "points.txt";
const string HISTORY_FILE = "history.txt";
const int MAX_POINTS = 20;

// Look for the data files next to Program.cs, however the program is started.
string projectFolder = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
Directory.SetCurrentDirectory(projectFolder);

string[] players = File.ReadAllLines(PLAYERS_FILE);
string[] points = File.ReadAllLines(POINTS_FILE);

//part 1
Console.WriteLine("PLAYER".PadRight(11)+"POINTS");
for(int i = 0; i < players.Length; i++)
{
    Console.WriteLine(players[i].PadRight(11)+points[i]);
}
Console.WriteLine($"Leader: {players[LeaderIndex(points)]} with {points[LeaderIndex(points)]}");
Console.WriteLine($"Season Total: {TotalPoints(points)}");


static int LeaderIndex(string[] points)
{
    int leaderPosition = 0;
    int leaderPoints = 0;
    for(int i=0; i < points.Length; i++)
    {
        if(Convert.ToInt32(points[i]) > leaderPoints)
        {
        leaderPoints = Convert.ToInt32(points[i]);
        leaderPosition = i;
        };
    }
    return leaderPosition;
}
static int TotalPoints(string[] points)
{
    int totalPoints = 0;
    foreach(string point in points)
    {
        totalPoints += Convert.ToInt32(point);
    }
    return totalPoints;
}


Console.WriteLine(players[i].PadRight(11)+points[i]);
Console.WriteLine($"Leader: {players[LeaderIndex(points)]} with {points[LeaderIndex(points)]}");
Console.WriteLine($"Season Total: {TotalPoints(points)}");
Console.WriteLine("")




static int LeaderIndex(string[] points)
{
    {
    static int TotalPoints(string[] points)
    }
    return totalPoints;
}

static string HistoryEntry(int night, string winner, int points)
{
    
}