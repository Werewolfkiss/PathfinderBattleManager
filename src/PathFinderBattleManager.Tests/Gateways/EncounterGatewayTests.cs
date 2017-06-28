using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PathFinderBattleManager.Gateways;
using PathFinderBattleManager.Exceptions;
using PathFinderBattleManager.Models;
using System.Linq;

namespace PathFinderBattleManager.Tests.Gateways
{
    [TestClass]
    public class EncounterGatewayTests
    {
        private IEncounterGateway gateway;

        [TestMethod]
        public void CanCreateEncounter()
        {
            gateway = new InMemoryEncounterGateway();
            gateway.CreateEncounter(Guid.NewGuid(), "Name");
        }

        [TestMethod]
        [ExpectedException(typeof(EncounterNeedsANameException))]
        public void CantCreateEncounterWithoutName()
        {
            gateway = new InMemoryEncounterGateway();
            gateway.CreateEncounter(Guid.NewGuid(), null);
        }

        [TestMethod]
        public void CanRetrieveCreatedEncounter()
        {
            gateway = new InMemoryEncounterGateway();
            var id = Guid.NewGuid();
            gateway.CreateEncounter(id, "Name");
            var encounter = gateway.RetrieveEncounter(id);
            Assert.IsNotNull(encounter);
            Assert.AreEqual("Name", encounter.Name);
        }

        [TestMethod]
        public void EncountersShouldBeUniquelyIdentifiable()
        {
            gateway = new InMemoryEncounterGateway();
            var id = Guid.NewGuid();
            gateway.CreateEncounter(id, "Name");
            gateway.CreateEncounter(Guid.NewGuid(), "Name");
            var encounter = gateway.RetrieveEncounter(id);
            Assert.IsNotNull(encounter);
            Assert.AreEqual("Name", encounter.Name);
        }

        [TestMethod]
        public void CanAddPCsToEncounter()
        {
            gateway = new InMemoryEncounterGateway();
            var id = Guid.NewGuid();
            gateway.CreateEncounter(id, "Name");
            gateway.AddCharacterToEncounter(id, new Character() { Name = "Player1", Hp = 15, Initiative = 14 });
            var encounter = gateway.RetrieveEncounter(id);
            Assert.AreEqual(1, encounter.Participants.Count());
            Assert.AreEqual("Player1", encounter.Participants.First().Name);
        }
    }
}
