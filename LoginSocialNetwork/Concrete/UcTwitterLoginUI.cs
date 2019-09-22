using System.Windows.Forms;
using LoginSocialNetwork.Interfaces;

namespace LoginSocialNetwork.Concrete
{
    public partial class UcTwitterLoginUI : UserControl, ILogin
    {
        public UcTwitterLoginUI()
        {
            InitializeComponent();
        }

        public void Login()
        {
            MessageBox.Show(string.Format("Login twitter successful with username='{0}', password='{1}'", txtUsername.Text, txtPassword.Text));
        }
    }
}
