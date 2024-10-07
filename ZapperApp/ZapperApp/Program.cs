static bool IsnotificationSet(string settings, int setting)
{
    return settings[setting] == '1';
}

static void WriteFile(List<string> text, string filePath)
{
    File.WriteAllLines(filePath, text);
}

static void ReadFile(string fileNAme)
{
    using (var reader = new StreamReader(fileNAme))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
}


string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
string projectPath = appDirectory.Substring(0, appDirectory.IndexOf("\\bin"));
var filePath = projectPath + "\\Settings.txt";
List<string> linesTowrite = new List<string>();

string settings = "00000000";
int setting = 7;


linesTowrite.Add("Settings = " + settings + "setting = " + setting);
linesTowrite.Add($"Output : {IsnotificationSet(settings, setting)}");



settings = "00000010";//hh
setting = 7;
linesTowrite.Add("Settings = " + settings + "setting = " + setting);
linesTowrite.Add($"Output : {IsnotificationSet(settings, setting)}");


settings = "11111111";
setting = 4;
linesTowrite.Add("Settings = " + settings + "setting = " + setting);
linesTowrite.Add($"Output : {IsnotificationSet(settings, setting)}");
WriteFile(linesTowrite, filePath);
ReadFile(filePath);


Console.ReadLine();