using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PathFinderBattleManager.Exceptions;
using PathFinderBattleManager.Gateways;
using PathFinderBattleManager.Usecases;

namespace PathFinderBattleManager.Tests.Usecases
{
    [TestClass]
    public class CreateEncounterTests
    {
        [TestMethod]
        public void CanCreateEncounter()
        {
            var id = Guid.NewGuid();
            var encounterGateway = new InMemoryEncounterGateway();
            var usecase = new CreateEncounter(encounterGateway);
            
            usecase.Create(id, "Title");

            var retrieve = new RetrieveEncounters(encounterGateway);
            var result = retrieve.Retrieve(id);

            Assert.IsNotNull(result);
            Assert.AreEqual("Title", result.Name);
            Assert.AreEqual(id, result.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(EncounterNeedsANameException))]
        public void CantCreateEncounterWithoutName()
        {
            var id = Guid.NewGuid();
            var encounterGateway = new InMemoryEncounterGateway();
            var usecase = new CreateEncounter(encounterGateway);

            usecase.Create(id, null);
        }

        [TestMethod]
        [ExpectedException(typeof(EncounterNeedsANameException))]
        public void CantCreateEncounterWithEmptyName()
        {
            var id = Guid.NewGuid();
            var encounterGateway = new InMemoryEncounterGateway();
            var usecase = new CreateEncounter(encounterGateway);

            usecase.Create(id, "");
        }
    }
}
