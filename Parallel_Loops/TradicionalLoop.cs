namespace Parallel_Loops;

public static class TradicionalLoop
{
    private static string path = @"C:\dev\test\";

    public static double TotalSecondsSimpleOperation(int listNumber)
    {
        List<int> myList = new List<int>();

        for (int i = 0; i < listNumber; i++)
        {
            myList.Add(i + 1);
        }

        var watch = Stopwatch.StartNew();

        foreach (var number in myList)
        {
            var operation = number * 100;
        }

        watch.Stop();

        return watch.Elapsed.TotalSeconds;
    }

    public static double TotalSecondsComplexOperation(int listNumber)
    {
        List<int> myList = new List<int>();

        for (int i = 0; i < listNumber; i++)
        {
            myList.Add(i + 1);
        }

        var watch = Stopwatch.StartNew();

        foreach (var number in myList)
        {
            using (FileStream fs = File.Create($"{path}traditional-loop-{number}.txt"))
            {
                // Add some text to file    
                Byte[] title = new UTF8Encoding(true).GetBytes($"My txt number {number}");
                fs.Write(title, 0, title.Length);
                byte[] author = new UTF8Encoding(true).GetBytes(" Complex");
                fs.Write(author, 0, author.Length);
            }
        }

        watch.Stop();

        return watch.Elapsed.TotalSeconds;
    }
}

