using Problems;

RunTask(NumberTask.BinaryTreeInorderTraversal_94).Run();

ITask RunTask(NumberTask numberTask)
{
    return numberTask switch
    {
        NumberTask.ClimbStairs_70 => new Problems.Easy.ClimbStairs_70.Solution(),
        NumberTask.RemoveDuplicatesFromSortedList_83 => new Problems.Easy.RemoveDuplicatesFromSortedList_83.Solution(),
        NumberTask.BinaryTreeInorderTraversal_94 => new Problems.Easy.BinaryTreeInorderTraversal_94.Solution(),

        _ => throw new Exception()
    };
}