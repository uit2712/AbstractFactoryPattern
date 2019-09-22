using LoginSocialNetwork.AbstractFactories;
using LoginSocialNetwork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSocialNetwork
{
    public class SocialNetwork
    {
        protected ISocialNetworkAbstractFactory _socialNetworkFactory;
        protected ILogin _socialNetwork;
        protected Control _loginUI;

        public SocialNetwork(ISocialNetworkAbstractFactory socialNetworkFactory)
        {
            _socialNetworkFactory = socialNetworkFactory;
            if (_socialNetworkFactory != null)
            {
                _socialNetwork = _socialNetworkFactory.MakeSocialNetwork();
                _loginUI = _socialNetworkFactory.MakeLoginUI();
            }
        }

        public void Login()
        {
            if (_socialNetwork != null)
                _socialNetwork.Login();
        }

        public Control GetUI()
        {
            return _loginUI;
        }
    }
}
