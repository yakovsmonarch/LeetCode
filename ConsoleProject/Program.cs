using ConsoleProject;
using ConsoleProject.Data;

Console.WriteLine("Begin");

var solution = new Solution();
var dict = new Dictionary<int, string>();
int numLimin = 3999;

for (int i = 1; i <= numLimin; i++)
{
    dict.Add(i, solution.IntToRoman(i));
}

var switchGenetate = new SwitchGenetate(dict);
switchGenetate.GenerateCodeText();

Console.WriteLine("End");