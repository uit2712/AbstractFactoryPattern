using LoginSocialNetwork.AbstractFactories;
using LoginSocialNetwork.ConcreteFactories;
using System.Windows.Forms;

namespace LoginSocialNetwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ISocialNetworkAbstractFactory _facebookFactory = new FacebookFactory();
        private ISocialNetworkAbstractFactory _twitterFactory = new TwitterFactory();
        private SocialNetwork _socialNetwork;

        private void cbbSocialNetwork_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            int selectedIndex = cbbSocialNetwork.SelectedIndex;
            if (selectedIndex < 0)
                return;

            if (selectedIndex == 0)
            {
                _socialNetwork = new SocialNetwork(_facebookFactory);
                pnlLoginUI.Controls.Clear();
                pnlLoginUI.Controls.Add(_socialNetwork.GetUI());
                btnLogin.Enabled = true;
            }

            if (selectedIndex == 1)
            {
                _socialNetwork = new SocialNetwork(_twitterFactory);
                pnlLoginUI.Controls.Clear();
                pnlLoginUI.Controls.Add(_socialNetwork.GetUI());
                btnLogin.Enabled = true;
            }
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            if (_socialNetwork != null)
                _socialNetwork.Login();
        }
    }
}
