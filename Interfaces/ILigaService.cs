using FootballStarz.Models;

namespace FootballStarz.Interfaces
{
    public interface ILigaService
    {
        Liga GetSingleLigaById(int ligaId);
    }
}
