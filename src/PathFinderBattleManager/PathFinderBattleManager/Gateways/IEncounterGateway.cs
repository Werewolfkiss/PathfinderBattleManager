using PathFinderBattleManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinderBattleManager.Gateways
{
    public interface IEncounterGateway
    {
        void CreateEncounter(Guid id, string name);
        Encounter RetrieveEncounter(Guid id);
        void AddCharacterToEncounter(Guid id, Character character);
    }
}
