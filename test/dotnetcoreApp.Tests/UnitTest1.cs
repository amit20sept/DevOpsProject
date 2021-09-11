using System;
using Xunit;
using dotnetcoreApp.Controllers;

namespace dotnetcoreApp.Tests
{
    public class UnitTest1
    {
        WeatherForecastController obj = new WeatherForecastController();
        [Fact]
        public void Test1()
        {
          var test =  obj.Get(101);
          Assert.Equal("Amit",test);

          //A3-> Assign, Assert ,Act
        }
    }
}
