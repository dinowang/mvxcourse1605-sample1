using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MvvmCross.Plugins.File;
using Newtonsoft.Json;
using Ninja.Core.Interfaces;
using Ninja.Core.ViewModels;

namespace Ninja.Core.Services
{
    public class PetStoreService : IPetStoreService
    {
        private IMvxFileStore _fileStore;

        private string _storedFile = "pets.json";

        public PetStoreService(IMvxFileStore fileStore)
        {
            _fileStore = fileStore;
        }

        public IEnumerable<PetViewModel> GetPets()
        {
            var json = string.Empty;

            if (_fileStore.TryReadTextFile(_storedFile, out json))
            {
                return JsonConvert.DeserializeObject<IEnumerable<PetViewModel>>(json);
            }

            return new[]
            {
                new PetViewModel { Name = "Pet 1" },
                new PetViewModel { Name = "Pet 2" },
                new PetViewModel { Name = "Pet 3" },
                new PetViewModel { Name = "Pet 4" },
                new PetViewModel { Name = "Pet 5" }
            };
        }

        public void Save(IEnumerable<PetViewModel> pets)
        {
            var narrowed = pets.Select(x => new { x.Name, x.Antiepidemic });

            var json = JsonConvert.SerializeObject(narrowed);

            _fileStore.WriteFile(_storedFile, json);
        }
    }
}