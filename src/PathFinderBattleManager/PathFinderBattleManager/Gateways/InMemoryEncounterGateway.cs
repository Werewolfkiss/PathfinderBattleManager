using PathFinderBattleManager.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathFinderBattleManager.Models;

namespace PathFinderBattleManager.Gateways
{
    public class InMemoryEncounterGateway : IEncounterGateway
    {
        private List<Encounter> encounters = new List<Encounter>();

        public void CreateEncounter(Guid id, string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new EncounterNeedsANameException();
            var encounter = new Encounter() { Id = id, Name = name };
            encounters.Add(encounter);
        }

        public Encounter RetrieveEncounter(Guid id)
        {
            return encounters.Single(x => x.Id == id);
        }

        public void AddCharacterToEncounter(Guid id, Character character)
        {
            var encounter = encounters.Single(x => x.Id == id);
            encounter.AddParticipant(character);
        }
    }
}
