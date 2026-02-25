namespace Module5_Collections.Task5_CollectionMerger;

public class Task5CollectionMerger
{
    public void Run()
    {
        string[] numberArray1 = new string [5] { "1", "2", "3", "4", "5" };
        string[] numberArray2 = new string [5] { "9", "3", "3", "7", "6" };

        HashSet<string> numberSet = new HashSet<string>();

        HashSetAddNumber(ref numberArray1, ref numberSet);
        HashSetAddNumber(ref numberArray2, ref numberSet);
        ShowNumberSet(numberSet);
    }

    void HashSetAddNumber(ref string[] number, ref HashSet<string> numberSet)
    {
        foreach (string item in number)
        {
            numberSet.Add(item);
        }
    }

    void ShowNumberSet(HashSet<string> numberSet)
    {
        foreach (string item in numberSet)
        {
            Console.WriteLine(item);
        }
    }
}