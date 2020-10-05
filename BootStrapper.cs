using System.Windows;
using Assignment5.ViewModels;
using Caliburn.Micro;

namespace Assignment5
{
    public class BootStrapper : BootstrapperBase
    {
        public BootStrapper()
            => Initialize();
        protected override void OnStartup(object sender, StartupEventArgs e)
            => DisplayRootViewFor<MultiMediaShellViewModel>();

    }
}
