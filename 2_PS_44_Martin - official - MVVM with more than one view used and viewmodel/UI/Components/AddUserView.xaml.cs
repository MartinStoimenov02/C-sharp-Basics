using System;
using System.Windows;
using System.Windows.Controls;

namespace UI.Components
{
    public partial class AddUserView : System.Windows.Controls.UserControl
    {
        public AddUserView()
        {
            InitializeComponent();
        }

        public void ClosePopUp_CLick(object sender, EventArgs e)
        {
            MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.closePopUp();
            }
        }
    }
}
