using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PathFinderBattleManager.Tests.TestHelpers;
using PathFinderBattleManager.Usecases;

namespace PathFinderBattleManager.Tests.Usecases
{
    [TestClass]
    public class AddNPCsToEncounterTests : BaseUseCaseUnitTestClass
    {
        [TestMethod]
        public void Add()
        {
            var encounterId = Guid.NewGuid();
            var useCase = new AddNPCsToEncounter(encounterGateway);
            var create = new CreateEncounter(encounterGateway);
            var retrieve = new RetrieveEncounters(encounterGateway);
            create.Create(encounterId, "Name");

            var goblin = NPCBuilder.Default();
            useCase.Add(encounterId, goblin);

            var result = retrieve.Retrieve(encounterId);

            Assert.IsNotNull(result.Participants);
            Assert.AreEqual(1, result.Participants.Count());
            var character = result.Participants.First();
            Assert.AreEqual(goblin.Id, character.Id);
            Assert.AreEqual(goblin.Name, character.Name);
            Assert.AreEqual(goblin.Hp, character.Hp);
            Assert.AreEqual(goblin.Initiative, character.Initiative);
        }
    }
}
