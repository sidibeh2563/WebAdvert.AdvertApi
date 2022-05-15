using AdvertApi.Models;
using System.Threading.Tasks;

namespace AdvertApi.services
{
    public interface IAdvertStorageService
    {
        Task<string> Add(AdvertModel model);
        Task<bool> Confirm(ConfirmAdvertModel model);
    }
}
