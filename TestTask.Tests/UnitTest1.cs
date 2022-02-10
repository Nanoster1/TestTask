using System.Collections.Generic;
using NUnit.Framework;
using TestTask;

namespace TestTask.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var array = new int[] {1, 2, 2, 2, 3, 4, 4, 5, 5, 5, 5};
        var task = new TestTask();
        var result = task.ChooseNums(array);
        var exceptedArray = new int[] { 1, 2, 3 };
        var counter = 0;
        foreach (var excepted in exceptedArray)
        {
            Assert.AreEqual(excepted, result[counter++]);
        }
    }
}