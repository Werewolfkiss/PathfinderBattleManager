using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PathFinderBattleManager.Gateways;
using PathFinderBattleManager.Tests.TestHelpers;
using PathFinderBattleManager.Usecases;

namespace PathFinderBattleManager.Tests.Usecases
{
    [TestClass]
    public class AddPlayerCharactersToEncounterTests : BaseUseCaseUnitTestClass
    {
        [TestMethod]
        public void Add()
        {
            var encounterId = Guid.NewGuid();
            var useCase = new AddPlayerCharactersToEncounter(encounterGateway);
            var create = new CreateEncounter(encounterGateway);
            var retrieve = new RetrieveEncounters(encounterGateway);
            create.Create(encounterId, "Name");

            var playerCharacter = PCBuilder.Default();
            useCase.Add(encounterId, playerCharacter);

            var result = retrieve.Retrieve(encounterId);

            Assert.IsNotNull(result.Participants);
            Assert.AreEqual(1, result.Participants.Count());
            var character = result.Participants.First();
            Assert.AreEqual(playerCharacter.Id, character.Id);
            Assert.AreEqual(playerCharacter.Name, character.Name);
            Assert.AreEqual(playerCharacter.Hp, character.Hp);
            Assert.AreEqual(playerCharacter.Initiative, character.Initiative);
        }
    }
}
