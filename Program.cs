using LeetCode.ThreeSum;

var solution = new Solution();

var a = solution.ThreeSum([-1,0,1,2,-1,-4]);

foreach (var b in a)
{
    foreach (var c in b)
    {
        Console.Write(c + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("");