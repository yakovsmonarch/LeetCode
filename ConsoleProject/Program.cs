using Problems;

RunTask(NumberTask.ClimbStairs_70).Run();

ITask RunTask(NumberTask numberTask)
{
    return numberTask switch
    {
        NumberTask.ClimbStairs_70 => new Problems.Easy.ClimbStairs_70.Solution(),
        NumberTask.RemoveDuplicatesFromSortedList_83 => new Problems.Easy.RemoveDuplicatesFromSortedList_83.Solution(),
        _ => throw new Exception()
    };
}