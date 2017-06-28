using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathFinderBattleManager.Gateways;
using PathFinderBattleManager.Usecases.Interfaces;

namespace PathFinderBattleManager.Usecases
{
    public class ManageCombatNPCs : IManageCombatNPCs
    {
        private INPCGateway npcGateway;

        public ManageCombatNPCs(INPCGateway npcGateway)
        {
            this.npcGateway = npcGateway;
        }
        public void ChangeInitiative(int initiative, int dexModifier)
        {
            throw new NotImplementedException();
        }

        public void DealDamage(Guid npcId, int damage)
        {
            var npc = npcGateway.Retrieve(npcId);
            npc.Hp -= damage;
            npcGateway.Update(npc);
        }

        public void Heal(Guid npcId, int heal)
        {
            throw new NotImplementedException();
        }

        public bool IsDead(Guid npcId)
        {
            throw new NotImplementedException();
        }
    }
}
