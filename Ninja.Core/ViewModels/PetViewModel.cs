using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace Ninja.Core.ViewModels
{
    public class PetViewModel : BaseViewModel
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _sex;

        public string Sex
        {
            get { return _sex; }
            set { SetProperty(ref _sex, value); }
        }

        private bool _antiepidemic;

        public bool Antiepidemic
        {
            get { return _antiepidemic; }
            set { SetProperty(ref _antiepidemic, value); }
        }

        public ICommand ClickCommand => new MvxCommand(Show);

        private void Show() => Name += ".";

    }
}
