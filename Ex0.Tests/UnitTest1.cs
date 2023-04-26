using System;
using System.IO;
using Xunit;
using Ex0;

namespace Ex0.Tests;

public class UnitTest1
{
    [Fact]
    public void IsLeapYear_GivenYear1973_returnFalse()
    {
        //Arrange
        int input = 1973;
        Year testObj = new Year(){};

        //act
        var actual = testObj.IsLeapYear(input);
        var expected = false;

        //assert
        Assert.Equal(expected,actual);
    }
    [Fact]
    public void IsLeapYear_Given1900_returnFalse()
    {
        //Arrange
        int input = 1900;
        Year testObj = new Year(){};

        //act
        var actual = testObj.IsLeapYear(input);
        var expected = false;

        //assert
        Assert.Equal(expected,actual);
    }
    [Fact]
    public void IsLeapYear_Given1600_returnTrue()
    {
        //Arrange
        int input = 1600;
        Year testObj = new Year(){};

        //act
        var actual = testObj.IsLeapYear(input);
        var expected = true;

        //assert
        Assert.Equal(expected,actual);
    }
    [Fact]
    public void IsLeapYear_Given1812_returnTrue()
    {
        //Arrange
        int input = 1812;
        Year testObj = new Year(){};

        //act
        var actual = testObj.IsLeapYear(input);
        var expected = true;

        //assert
        Assert.Equal(expected,actual);
    }
    [Fact]
    public void IsLeapYear_GivenUserInput1720_returnTrue()
    {
        //Arrange
        StringWriter writer = new StringWriter();
        Console.SetOut(writer);

        var input = new StringReader("1720");
        Console.SetIn(input);


        //act
        Year testObj = new Year(){};
        Year.Main(new String[0]);
        
        string[] output = writer.ToString().Split(Environment.NewLine);

        var actual = testObj.IsLeapYear(1720);

        //assert
        Assert.True(actual);
        Assert.Equal("yay", output[0].Trim());
    }
    [Fact]
    public void IsLeapYear_GivenUserInput1200_returnError()
    {
        //Arrange
        StringWriter writer = new StringWriter();
        Console.SetOut(writer);

        var input = new StringReader("1200");
        Console.SetIn(input);


        //act
        Year testObj = new Year(){};
        Year.Main(new String[0]);
        
        string[] output = writer.ToString().Split(Environment.NewLine);

        //assert
        Assert.Equal("Input invalid. Please only enter years starting from 1582. Please ONLY input integer numbers.", output[0].Trim());
    }
}