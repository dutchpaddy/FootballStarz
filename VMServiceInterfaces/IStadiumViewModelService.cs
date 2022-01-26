using System.Collections.Generic;
using FootballStarz.ViewModels;

namespace FootballStarz.VMServiceInterfaces
{
    public interface IStadiumViewModelService
    {

        List<StadiumViewModel> GetStadiums();         
    }
}
