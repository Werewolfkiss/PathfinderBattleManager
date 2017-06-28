using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinderBattleManager.Usecases.Interfaces
{
    public interface ICreateEncounter
    {
        void Create(Guid id, string name);
    }
}
