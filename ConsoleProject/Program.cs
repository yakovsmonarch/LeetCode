using ConsoleProject;

RunTask(NumberTask.ClimbStairs_70).Run();

ITask RunTask(NumberTask numberTask)
{
    return numberTask switch
    {
        NumberTask.ClimbStairs_70 => new ConsoleProject.Litcode.Easy.ClimbStairs_70.Solution(),
        _ => throw new Exception()
    };
}
