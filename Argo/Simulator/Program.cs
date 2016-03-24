using HAL.Simulator;
using WPILib;

namespace Simulator
{
    public static class Program
    {
        public static void Main()
        {
            RobotBase.Main(null, typeof(Persusus.Persusus));
        }
    }

    public class Sim : ISimulator
    {
        public void Initialize()
        {
        }

        public void Start()
        {
            SimHooks.WaitForProgramStart();
            DriverStationGUI.DriverStation.StartDriverStationGui();
            using (var game = new Simulator())
            {
                game.Run();
            }
            


        }

        public string Name => "Mono Game Simulator";
    }
}