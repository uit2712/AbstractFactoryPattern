using LoginSocialNetwork.Interfaces;
using System.Windows.Forms;

namespace LoginSocialNetwork.AbstractFactories
{
    public interface ISocialNetworkAbstractFactory
    {
        ILogin MakeSocialNetwork();
        Control MakeLoginUI();
    }
}
