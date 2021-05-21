using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShellTabBug
{
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();
            //::Todo If some condition is hit then dogs page should be disabled !

            PerformOperation();
        }

        private void PerformOperation()
        {

            MyDogPage.IsEnabled = false;

        }
    }
}
