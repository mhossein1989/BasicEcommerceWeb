using SadeghiBasicMarket.Common.Dto;
using System.Text;
using System.Threading.Tasks;

namespace SadeghiBasicMarket.Application.Services.Queries.GetProductForSite
{
    public interface IGetProductForSiteService
    {
        ResultDto<ResultProductForSiteDto> Execute(Ordering ordering, string SearchKey, int Page, int pageSize , long? CatId);
    }
}
