int arrayLength = 0;
do
{
    Console.WriteLine("How many numbers do you want to enter?");
    try
    {
        arrayLength = Convert.ToInt32(Console.ReadLine());
    }
    catch (System.FormatException) //If the user doesn't input an integer value, it will show them this error, then ask them again for the array length.
    {
        arrayLength = 0;
        Console.WriteLine("Please only enter integer values.");
    }
}
while (arrayLength < 1);

float[] floatArray = new float[arrayLength];
for (int i = 0; i < floatArray.Length; i++)
{
    bool floatParseSuccessful = true;
    do
    {
        floatParseSuccessful = true; //Every time the loop starts this is true. It only goes to false if an exception is caught.
        Console.WriteLine("Enter a value for float "+(i+1));
        try
        {
            floatArray[i] = Single.Parse(Console.ReadLine()); //Created by adapting examples shown at
            //https://learn.microsoft.com/en-us/dotnet/api/system.single.parse?view=net-6.0
        }
        catch (System.FormatException)
        {
            floatParseSuccessful = false;
            floatArray[i] = 0;
            Console.WriteLine("Please only enter float values.");
        }
    }
    while (floatParseSuccessful == false);
}

float result = 0.0F;

for (int i = 0; i < floatArray.Length; i++)
{
    result += floatArray[i];
}

Console.WriteLine(result / floatArray.Length);


Console.ReadKey();