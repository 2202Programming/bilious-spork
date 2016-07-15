using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceTest.ServiceReference1;

namespace ServiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TestInput();
        }

        private static void TestInput()
        {
            var client = new RobotServiceClient();
            var robot = new RobotContainer() { Name = "Tim" };
            robot = client.GetRobotContainer(robot);

            robot.ControlObjects.Add("Fish", "Duck");
            client.UpDateRobotContainers(robot);
        }

        private static void TestOutput()
        {
            var client = new RobotServiceClient();
            Console.WriteLine("{0} {1}", "Hello", client.GetValue("Hello"));
            Console.WriteLine("{0} {1}", "Goodby", client.GetValue("Goodby"));

            var robot = new RobotContainer() { Name = "Tim" };
            robot = client.GetRobotContainer(robot);

            var defaultConsoleForeground = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Control Objects, Count:{0}", robot.ControlObjects.Count);
            Console.ForegroundColor = defaultConsoleForeground;

            foreach (var pair in robot.ControlObjects)
                Console.WriteLine("Key:{0}, Value:{1}", pair.Key, pair.Value);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Smart Dashboard Output, Size:{0}", robot.SmartDashboardOutput.Count);
            Console.ForegroundColor = defaultConsoleForeground;

            foreach (var pair in robot.SmartDashboardOutput)
                Console.WriteLine("Key:{0}, Value:{1}", pair.Key, pair.Value);

            Console.ReadLine();
        }
    }
}
