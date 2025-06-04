using System.ComponentModel;
using ConsoleProject.Litcode.Easy.Find_the_Index_of_the_First_Occurrence_in_a_String_28;

namespace ProblemTest.Litcode.Easy;

public class Find_the_Index_of_the_First_Occurrence_in_a_String_28
{
    private readonly DataSet[] _dataSets =
    {
        new DataSet(0, "sadbutsad", "sad"),
        new DataSet(-1, "leetcode", "leeto"),
        new DataSet(2, "hello", "ll"),
        new DataSet(-1, "aa", "aaa"),
        new DataSet(-1, "mississippi", "issipi"),
        new DataSet(-1, "mississippi", "sippia"),
        new DataSet(0, "a", "a"),
        
    };

    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void StrStrTest()
    {
        var solution = new Solution();

        foreach (DataSet dataSet in _dataSets)
        {
            int result = solution.StrStr(dataSet.Haystack, dataSet.Needle);
            Assert.That(result == dataSet.Output);
        }
        Assert.Pass();
    }

    class DataSet
    {
        public readonly int Output;
        public readonly string Haystack;
        public readonly string Needle;

        public DataSet(int output, string haystack, string needle)
        {
            Output = output;
            Haystack = haystack;
            Needle = needle;
        }
    }
}
