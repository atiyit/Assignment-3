using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Assignment.Data
{
    public interface IAdultService
    {

        Task AddAdultAsync(Adult adult);

        Task<IList<Adult>> GetAdultAsync();



    }
}