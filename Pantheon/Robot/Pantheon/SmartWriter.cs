﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Pantheon
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
    using WPILib;
    using WPILib.SmartDashboard;

	public class SmartWriter
	{


		public static void WriteString(string label, string value, DebugMode Debug)
		{
            if (Global.DMode >= Debug)
            {
                SmartDashboard.PutString(label, value);
                if (Global.DisplayConsoleOutput) Console.WriteLine(label + " : " + value);

                
            }
        }

		public static void WriteBool(string label, bool value, DebugMode Debug)
		{
			if(Global.DMode >= Debug)
            {
                SmartDashboard.PutBoolean(label, value);
                if (Global.DisplayConsoleOutput) Console.WriteLine(label + " : " + value);
            }
        }

		public static void WriteNumber(string label, double value, DebugMode Debug)
		{
            if (Global.DMode >= Debug)
            {
                SmartDashboard.PutNumber(label, value);
                if (Global.DisplayConsoleOutput) Console.WriteLine(label + " : " + value);
            }
        }

	}
}

