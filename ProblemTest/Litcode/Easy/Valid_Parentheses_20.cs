namespace ProblemTest.Litcode.Easy;

public class Valid_Parentheses_20
{
    private readonly TaskString[] _tasksString = {
        new TaskString(true, "()"),
        new TaskString(true, "()[]{}"),
        new TaskString(false, "(]"),
        new TaskString(true, "([])"),
        // new TaskString(false, "([)]"),
    };

    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void ValidParenthesesTest()
    {
        var solution = new ConsoleProject.Litcode.Easy.Valid_Parentheses_20.Solution();

        foreach (TaskString taskString in _tasksString)
        {
            bool result = solution.IsValid(taskString.Content);
            Assert.That(result == taskString.Result, $"Результат метода '{result}' не равен ожидаемому '{taskString.Result}'.");
        }

        Assert.Pass();
    }

    class TaskString
    {
        public TaskString(bool result, string content)
        {
            Result = result;
            Content = content;
        }

        public bool Result { get; set; }

        public string Content { get; set; }
        
    }
}
