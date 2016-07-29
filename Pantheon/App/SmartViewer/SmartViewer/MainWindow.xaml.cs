using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Pantheon.Service.Contract;
using Pantheon.Service.Contract.Objects;

namespace SmartViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructor/Deconstructor 

        public MainWindow()
        {
            InitializeComponent();
            var reloadTimer = new Timer
            {
                AutoReset = true,
                Enabled = true,
                Interval = 1000
            };
            reloadTimer.Elapsed += ReloadTimerOnElapsed;
            Reload();
        }



        #endregion

        #region Fields

        #endregion

        #region Properties

        public SmartData SmartData { get; set; }



        #endregion

        #region Methods

        private void ReloadTimerOnElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            Reload();
        }

        private void Reload()
        {
            Stopwatch stp = new Stopwatch();
            stp.Start();

            //var client = new SmartServiceClient();
            var smartData = new SmartData()
            {
                RobotName = "HI",
                DisplayDictionary = new Dictionary<string, string>()
            };
            if (SmartData == null)
                SmartData = smartData;
            else if (smartData != SmartData)
            {
                foreach (var pair in smartData.DisplayDictionary)
                {
                    var x = SmartData.DisplayDictionary[pair.Key];
                    if (x == null)
                    {
                        SmartData.DisplayDictionary.Add(pair.Key, pair.Value);
                    }
                    else
                        x = pair.Value;
                }
            }



            Console.WriteLine($"Time Per Reload Call: {stp.Elapsed:g}");
        }

        #endregion
    }
}
