int listNumber = 10000;

Console.WriteLine($"Loop Simple Operation for {listNumber} registers");
Console.WriteLine("");

var tradicionalLoopSimpleOperation = TradicionalLoop.TotalSecondsSimpleOperation(listNumber);
Console.WriteLine($"Tradicional loop time for simple operation: {tradicionalLoopSimpleOperation.ToString("N6")}");

var parallelLoopSimpleOperation = ParallelLoop.TotalSecondsSimpleOperation(listNumber);
Console.WriteLine($"Parallel foreach time simple operation: {parallelLoopSimpleOperation.ToString("N6")}");

Console.WriteLine("");

Console.WriteLine($"Loop Complex Operation for {listNumber} registers");
Console.WriteLine("");

var tradicionalLoopComplexOperation = TradicionalLoop.TotalSecondsComplexOperation(listNumber);
Console.WriteLine($"Tradicional loop time for complex operation: {tradicionalLoopComplexOperation.ToString("N6")}");

var parallelLoopComplexOperation = ParallelLoop.TotalSecondsComplexOperation(listNumber);
Console.WriteLine($"Parallel foreach time for complex operation: {parallelLoopComplexOperation.ToString("N6")}");

//Console.WriteLine(new String('#', 60));

Console.ReadKey();