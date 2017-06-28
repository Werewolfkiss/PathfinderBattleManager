using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathFinderBattleManager.Models;

namespace PathFinderBattleManager.Tests.TestHelpers
{
    public static class NPCBuilder
    {
        public static NonPlayerCharacter Default()
        {
            return new NonPlayerCharacter() { Id = Guid.NewGuid(), Name = "Goblin", Hp = 9, Initiative = 13 };
        }
    }
}
