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
        var actual = testObj.IsLeapYear(1973);
        var expected = false;

        //assert
        Assert.Equal(actual,expected);
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
        Assert.Equal(actual,expected);
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
        Assert.Equal(actual,expected);
    }
    [Fact]
    public void IsLeapYear_Given1004_returnTrue()
    {
        //Arrange
        int input = 1004;
        Year testObj = new Year(){};

        //act
        var actual = testObj.IsLeapYear(input);
        var expected = true;

        //assert
        Assert.Equal(actual,expected);
    }
}