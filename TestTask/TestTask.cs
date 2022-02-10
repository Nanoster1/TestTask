namespace TestTask;

public class TestTask
{
    public IList<int> ChooseNums(IEnumerable<int> array)
    {
        var numsWithoutPair = new List<int>();
        foreach (var num in array)
        {
            if (numsWithoutPair.Contains(num)) numsWithoutPair.Remove(num);
            else numsWithoutPair.Add(num);
        }

        return numsWithoutPair;
    }
}