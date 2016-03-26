using HAL.Simulator;
using WPILib;

namespace Sim
{
    public static class Program
    {
        public static void Main()
        {
            RobotBase.Main(null, typeof(Pantheon.Pantheon));
        }
    }

    public class Simulator : ISimulator
    {
        public void Initialize()
        {
        }

        public void Start()
        {
            SimHooks.WaitForProgramStart();
            DriverStationGUI.DriverStation.StartDriverStationGui();
            using (var game = new Sim())
                game.Run();
        }

        public string Name => "Mono Game Simulator";
    }
}