using System.Windows.Forms;
using LoginSocialNetwork.AbstractFactories;
using LoginSocialNetwork.Concrete;
using LoginSocialNetwork.Interfaces;

namespace LoginSocialNetwork.ConcreteFactories
{
    class FacebookFactory : ISocialNetworkAbstractFactory
    {
        private UcFacebookLogin _ucFacebookLogin = new UcFacebookLogin();

        public Control MakeLoginUI()
        {
            return _ucFacebookLogin;
        }

        public ILogin MakeSocialNetwork()
        {
            return _ucFacebookLogin;
        }
    }
}
