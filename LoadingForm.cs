using ComponentFactory.Krypton.Toolkit;

namespace Community_Task_Management_System
{
    public partial class LoadingForm : KryptonForm
    {
        public LoadingForm()
        {
            InitializeComponent();
            
            guna2WinProgressIndicator1.Start();
        }

    }
}
