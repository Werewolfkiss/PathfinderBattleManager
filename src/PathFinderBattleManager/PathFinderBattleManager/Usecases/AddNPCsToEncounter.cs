using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathFinderBattleManager.Gateways;
using PathFinderBattleManager.Models;
using PathFinderBattleManager.Usecases.Interfaces;

namespace PathFinderBattleManager.Usecases
{
    public class AddNPCsToEncounter : IAddNPCsToEncounter
    {
        private IEncounterGateway encounterGateway;

        public AddNPCsToEncounter(IEncounterGateway encounterGateway)
        {
            this.encounterGateway = encounterGateway;
        }
        public void Add(Guid encounterId, NonPlayerCharacter character)
        {
            encounterGateway.AddCharacterToEncounter(encounterId, character);
        }
    }
}
