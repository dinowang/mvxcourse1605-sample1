using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Ninja.Core.Interfaces;

namespace Ninja.Core.ViewModels
{
    public class PetStoreViewModel : BaseViewModel
    {
        private IPetStoreService _petStoreService;

        public PetStoreViewModel(IPetStoreService petStoreService)
        {
            _petStoreService = petStoreService;

            Pets = _petStoreService.GetPets();
        }

        private IEnumerable<PetViewModel> _pets;

        public IEnumerable<PetViewModel> Pets
        {
            get { return _pets; }
            set { SetProperty(ref _pets, value); }
        }


        public ICommand SaveCommand => new MvxCommand(Save);

        private void Save()
        {
            _petStoreService.Save(Pets);
            Close(this);
        }
    }
}