﻿//DO NOT MODIFY THIS CLASS
//This class automatically calls your robot class. Please place all user
//code in the Robot1.cs class. Any changes made in here most likely
//will cause the program to not run.

using System.Reflection;
using WPILib;

namespace Robot1
{
    public class Program
    {
        static void Main()
        {
            RobotBase.Main(null, typeof(Robot1));
        }
    }
}
