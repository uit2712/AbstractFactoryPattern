using System.Windows.Forms;
using LoginSocialNetwork.Interfaces;

namespace LoginSocialNetwork.Concrete
{
    public partial class UcFacebookLogin : UserControl, ILogin
    {
        public UcFacebookLogin()
        {
            InitializeComponent();
        }

        public void Login()
        {
            MessageBox.Show(string.Format("Login facebook successful with username='{0}', password='{1}'", txtUsername.Text, txtPassword.Text));
        }
    }
}
