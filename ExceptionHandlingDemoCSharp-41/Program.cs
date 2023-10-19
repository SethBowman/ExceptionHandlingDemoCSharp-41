

var numbers = new int[] { 1, 2, 3, 4 };

//try-catch block

try
{
    //trying to do something
    numbers[10] = 39;

    Console.WriteLine($"{numbers[10]}");
}
catch (IndexOutOfRangeException e)
{
    //if we are thrown an exception, we will catch it
    Console.WriteLine($"That was out of bounds, man. {e.Message}");
}
catch (Exception e)
{
    //umbrella catch, catches all errors we may have missed
    Console.WriteLine(e.Message);
}

Console.WriteLine("Continue on..");



try
{
    Console.WriteLine("Please give me a number:");

    var userInput = int.Parse(Console.ReadLine());

    Console.WriteLine($"I like the number {userInput} too!");
}
catch(FormatException e)
{
    Console.WriteLine($"Failed to parse.\n{e.Message}");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    //optional
    //the finally happens no matter what
    Console.WriteLine("This happens no matter what.");
}

Console.WriteLine("Continue on..");


var strNumbers = new string[] { "12", "2", "ten", "twelve", "88", "1000", "64", "twenty", "145"};
var nums = new List<int>();

foreach(var strNum in strNumbers)
{
    try
    {
        var number = int.Parse(strNum);
        nums.Add(number);
    }
    catch(FormatException e)
    {
        Console.WriteLine($"Could not parse: {strNum}.\n{e.Message}");
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

Console.WriteLine("Parsed nums:");

foreach(var number in nums)
{
    Console.WriteLine(number);
}