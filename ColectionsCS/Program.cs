using System.Collections;

static void ParamsMethod(params string[] sentence)
{
    for (int i = 0; i < sentence.Length; i++)
    {
        Console.Write(sentence[i].ToString() + " " );
    }
    Console.WriteLine();
}

static void ParamsMethod2(params object[] stuff)
{
    foreach (var obj in stuff)
    {
        Console.Write(obj.ToString() + " " );
    }
    Console.WriteLine();
}

ParamsMethod("Ja", "Bardzo", "lubie", "jabłka");
ParamsMethod2('c', 1, 1.3f, 4.77d);

ArrayList array1 = new ArrayList();
ArrayList array2 = new ArrayList(100);
array1.Add(25);
array1.Add(25);
array1.Add("Talon");
array1.Add(15.667);
array1.Add(15.0f);
array1.Add(15.0f);
array1.Add(15.6d);

array1.Remove(25);
array1.RemoveAt(4);

Console.WriteLine("Capacity: " + array1.Capacity);

foreach (object obj in array1)
{
    Console.Write(obj + " ");
}
// var numbers = new List<int>{1,4,7,9};

List<int> arrayGenerator()
{
    List<int> array = new List<int>();
    for (int i = 100; i < 171; i += 2)
    {
        array.Add(i);
    }

    return array;
}

List<int> a = arrayGenerator();
foreach (var value in a)
{
    Console.Write(value + " ");
}
