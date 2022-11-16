float[] floatArray = new float[5];
floatArray[0] = 3.4F;
floatArray[1] = 6.7F;
floatArray[2] = 8.3F;
floatArray[3] = 9.0F;
floatArray[4] = 2.4F;

float result = 0.0F;

for (int i = 0; i < floatArray.Length; i++)
{
    result += floatArray[i];
}

Console.WriteLine(result / floatArray.Length);


Console.ReadKey();