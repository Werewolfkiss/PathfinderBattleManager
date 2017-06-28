using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathFinderBattleManager.Models;

namespace PathFinderBattleManager.Usecases.Interfaces
{
    public interface IAddPlayerCharactersToEncounter
    {
        void Add(Guid encounterId, PlayerCharacter character);
    }
}
