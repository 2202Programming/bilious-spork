using System;
using System.Windows;
using System.Timers;
using System.Threading.Tasks;
using DataViewer.ServiceReference1;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Collections;

namespace DataViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string GETNAME = "Tim";

        public MainWindow()
        {
            InitializeComponent();
        }

        Timer _refresher;

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);


            _refresher = new Timer();
            _refresher.Elapsed += _refresher_Elapsed;
            _refresher.Interval = 1000;
            _refresher.Enabled = true;
        }

        private void _refresher_Elapsed(object sender, ElapsedEventArgs e)
        {
            _refresher.Enabled = false;
            var client = new RobotServiceClient();
            var robot = new RobotContainer() { Name = "Tim" };
            robot = client.GetRobotContainer(robot);

            App.Current.Dispatcher.Invoke((Action)delegate
            {
                name.Text = robot.Name;

                if (ControlObjects.ItemsSource == null)
                    ControlObjects.ItemsSource = robot.ControlObjects;
                else
                {
                    // TODO Iterate through and only update the values
                    ControlObjects.ItemsSource = robot.ControlObjects;
                }

                if (SmartDashboard.ItemsSource == name)
                    SmartDashboard.ItemsSource = robot.SmartDashboardOutput;
                else
                {
                    // TODO Iterate through and only update the values
                    SmartDashboard.ItemsSource = robot.SmartDashboardOutput;
                }
            });
            _refresher.Enabled = true;

        }

        private RobotContainer GetRobotState()
        {
            var client = new RobotServiceClient();
            var temp = new RobotContainer()
            {
                Name = GETNAME,
            };
            return client.GetRobotContainer(temp);
        }
    }
}
