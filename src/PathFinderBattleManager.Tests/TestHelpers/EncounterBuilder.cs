using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathFinderBattleManager.Models;

namespace PathFinderBattleManager.Tests.TestHelpers
{
    public static class EncounterBuilder
    {
        public static Encounter ReturnEmptyEncounter()
        {
            return new Encounter() { Id = Guid.NewGuid() };
        }

        public static Encounter ReturnEmptyEncounter(string name)
        {
            return new Encounter() {Id = Guid.NewGuid(), Name = name };
        }
    }
}
