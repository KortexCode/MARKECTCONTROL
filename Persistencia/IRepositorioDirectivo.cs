using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRepositorioDirectivo
    {
        IEnumerable<Directivo> getAllDirectivo();
        Directivo addDirectivo(Directivo directivo);
        Directivo updateDirectivo(Directivo directivo);
        Directivo getDirectivo(int idDirectivo);
        void deleteDirectivo(int idDirectivo);
    }
}