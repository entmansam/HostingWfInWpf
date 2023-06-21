using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace HostingWfInWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Windows_Loaded(object sender, RoutedEventArgs e)
        {
            // Create the interop host control.
            System.Windows.Forms.Integration.WindowsFormsHost host =
                new System.Windows.Forms.Integration.WindowsFormsHost();

            // Create the MaskedTextBox control.
            MaskedTextBox mtbDate = new MaskedTextBox("00/00/0000");

            // Assign the MaskedTextBox control as the host control's child.
            host.Child = mtbDate;

            // Add the interop host control to the Grid
            // control's collection of child controls.
            this.grid1.Children.Add(host);


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //start the Process(in this case Notepad)
            Process notepad = Process.Start("notepad.exe");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //start the Process(in this case Notepad)
            Process chrome = Process.Start("chrome.exe");
        }
    }
}
