using BenchmarkDotNet.Attributes;

namespace Algoritms_and_DataStructure.Lesson4.HashSet_Task1_;

public class HashSetTest
{
    public HashSet<string> FillHashSetRandomString()
    {
        HashSet<string> hashSetStr = new HashSet<string>();
        for (int i = 0; i < 1000; i++)
        {
            hashSetStr.Add($"str{i}");
        }

        return hashSetStr;
    }
    [Benchmark]
    public void TestFindStrInHashSet()
    {
        FillHashSetRandomString().Contains("str555");
    }

    public string[] FillArrayRandomString()
    {
        string[] arrStr = new string[1000];
        for (int i = 0; i < arrStr.Length; i++)
        {
            arrStr[i] = $"str{i}";
        }

        return arrStr;
    }
    [Benchmark]
    public void TestFindStrInArray()
    {
        FillArrayRandomString().Contains("str555");
    }
}