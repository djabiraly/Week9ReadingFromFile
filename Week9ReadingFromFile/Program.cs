
string fileDirectoryPath = @"C:\data";
string fileName = "chuck.txt";

string fullFilePath = Path.Combine(fileDirectoryPath, fileName);

//if (File.Exists(fullFilePath))
//{
//    Console.WriteLine($"File {fileName} exists in {fileDirectoryPath}");
//    string[] chuckJokes = File.ReadAllLines(fullFilePath);
//    Console.WriteLine($"There are {chuckJokes.Length} jokes about Chuck Norris in the file.");
//    foreach (string joke in chuckJokes)
//    {
//        Console.WriteLine(joke);
//    }
//}
//else
//{
//    Console.WriteLine($"File {fileName} was not found.");
//}


ReadFromFile(fullFilePath);

static void DisplayDataFromArray(string[] array)
{
    foreach (string line in array)
    {
        Console.WriteLine(line);
    }
}

static void ReadFromFile(string filePath)
{
    if (File.Exists(filePath))
    {
        string[] tempArray = File.ReadAllLines(filePath);
        Console.WriteLine($"There are {tempArray.Length} lines in the file.");
        Console.WriteLine("Do you want to see all lines or pick up a random one? all/random");
        string userChoice = Console.ReadLine();

        if (userChoice == "all")
        {
            DisplayDataFromArray(tempArray);
        }
        else if (userChoice == "random")
        {
            displayRandomElement(tempArray);
        }
        else
        {
            Console.WriteLine("Try again");
        }     
    }
    else
    {
        Console.WriteLine($"File was not found.");
    }
}

static void displayRandomElement(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    Console.WriteLine(someArray[randomIndex]);
}