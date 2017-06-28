using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinderBattleManager.Usecases.Interfaces
{
    public interface IManageCombatNPCs
    {
        void DealDamage(Guid npcId, int damage);
        void Heal(Guid npcId, int heal);
        bool IsDead(Guid npcId);
        void ChangeInitiative(int initiative, int dexModifier);
    }
}
