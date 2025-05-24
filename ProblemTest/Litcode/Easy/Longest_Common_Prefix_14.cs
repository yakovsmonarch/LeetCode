namespace ProblemTest.Litcode.Easy;

public class Longest_Common_Prefix_14
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void LongestCommonPrefix()
    {
        var solution = new ConsoleProject.Litcode.Easy.Longest_Common_Prefix_14.Solution();

        var tasks = new Dictionary<string, string[]>()
        {
            {"fl", ["flower", "flow", "flight"]},
            {"", ["dog","racecar","car"]},
            {"flo", ["flower", "flow", "floight"]},
            {"flod", ["flodi", "flod"]},
            
        };

        foreach (var item in tasks)
        {
            string result = solution.LongestCommonPrefix(item.Value);
            Assert.That(result == item.Key, $"Ожидаемое значение '{item.Key}' и результат '{result}' не равны.");
        }

        Assert.Pass();
    }
}
