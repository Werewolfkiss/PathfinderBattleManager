using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathFinderBattleManager.Gateways;
using PathFinderBattleManager.Usecases.Interfaces;

namespace PathFinderBattleManager.Usecases
{
    public class CreateEncounter : ICreateEncounter
    {
        private IEncounterGateway gateway;

        public CreateEncounter(IEncounterGateway encounterGateway)
        {
            this.gateway = encounterGateway;
        }
        public void Create(Guid id, string name)
        {
            gateway.CreateEncounter(id, name);
        }
    }
}
