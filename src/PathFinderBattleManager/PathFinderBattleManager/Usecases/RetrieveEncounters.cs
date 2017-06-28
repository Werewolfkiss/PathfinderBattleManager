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
    public class RetrieveEncounters : IRetrieveEncounters
    {
        private IEncounterGateway gateway;

        public RetrieveEncounters(IEncounterGateway encounterGateway)
        {
            this.gateway = encounterGateway;
        }
        public Encounter Retrieve(Guid id)
        {
            return gateway.RetrieveEncounter(id);
        }
    }
}
