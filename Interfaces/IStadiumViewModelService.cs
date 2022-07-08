using System.Collections.Generic;
using FootballStarz.ViewModels;

namespace FootballStarz.Interfaces
{
    public interface IStadiumViewModelService
    {

        List<StadiumViewModel> GetStadiums();         
    }
}
