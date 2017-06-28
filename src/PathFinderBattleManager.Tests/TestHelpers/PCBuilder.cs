using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathFinderBattleManager.Models;

namespace PathFinderBattleManager.Tests.TestHelpers
{
    public static class PCBuilder
    {
        public static PlayerCharacter Default()
        {
            return new PlayerCharacter() {Id = Guid.NewGuid(), Name = "Bram", Hp = 15, Initiative = 10 };
        }
    }
}
