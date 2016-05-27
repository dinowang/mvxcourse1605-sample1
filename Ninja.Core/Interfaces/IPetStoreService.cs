using System.Collections.Generic;
using Ninja.Core.ViewModels;

namespace Ninja.Core.Interfaces
{
    public interface IPetStoreService
    {
        IEnumerable<PetViewModel> GetPets();
        void Save(IEnumerable<PetViewModel> pets);
    }
}