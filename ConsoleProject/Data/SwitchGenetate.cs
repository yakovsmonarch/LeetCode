using System.Text;

namespace ConsoleProject.Data;

public class SwitchGenetate
{
    private readonly Dictionary<int, string> _nums;

    public SwitchGenetate(Dictionary<int, string> nums)
    {
        _nums = nums;
    }

    public void GenerateCodeText()
    {
        const string dir = "Data";
        const string filename = "SwitchCaseCode.txt";
        string path = Path.Combine(dir, filename);

        if (Directory.Exists(dir) == false)
        {
            Directory.CreateDirectory(dir);
        }

        string strBegin =
            "private int ConvertRomanToInt(string romanNum)" + Environment.NewLine +
            "{" + Environment.NewLine +
            "switch (romanNum)" + Environment.NewLine +
            "{" + Environment.NewLine;

        StringBuilder strMid = GenarateLineCaseReturn();

        string strEnd =
        "}" + Environment.NewLine +
        "return 0;" + Environment.NewLine +
        "}";

        string content = strBegin + strMid.ToString() + strEnd;

        File.WriteAllText(path, content);
    }

    private StringBuilder GenarateLineCaseReturn()
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (var item in _nums)
        {
            stringBuilder.AppendLine($"case \"{item.Value}\": return {item.Key};");
        }

        return stringBuilder;
    }

    
}
