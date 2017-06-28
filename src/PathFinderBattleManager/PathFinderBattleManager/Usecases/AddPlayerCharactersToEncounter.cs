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
    public class AddPlayerCharactersToEncounter : IAddPlayerCharactersToEncounter
    {
        private IEncounterGateway encounterGateway;

        public AddPlayerCharactersToEncounter(IEncounterGateway encounterGateway)
        {
            this.encounterGateway = encounterGateway;
        }

        public void Add(Guid encounterId, PlayerCharacter character)
        {
            encounterGateway.AddCharacterToEncounter(encounterId, character);
        }
    }
}
