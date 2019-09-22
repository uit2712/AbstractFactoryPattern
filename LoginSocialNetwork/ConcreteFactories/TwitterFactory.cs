using LoginSocialNetwork.AbstractFactories;
using LoginSocialNetwork.Concrete;
using LoginSocialNetwork.Interfaces;
using System.Windows.Forms;

namespace LoginSocialNetwork.ConcreteFactories
{
    class TwitterFactory : ISocialNetworkAbstractFactory
    {
        private UcTwitterLoginUI _ucTwitterLoginUI = new UcTwitterLoginUI();

        public Control MakeLoginUI()
        {
            return _ucTwitterLoginUI;
        }

        public ILogin MakeSocialNetwork()
        {
            return _ucTwitterLoginUI;
        }
    }
}
