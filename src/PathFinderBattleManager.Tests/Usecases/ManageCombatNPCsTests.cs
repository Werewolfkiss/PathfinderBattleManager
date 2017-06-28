using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PathFinderBattleManager.Gateways;
using PathFinderBattleManager.Models;
using PathFinderBattleManager.Tests.TestHelpers;
using PathFinderBattleManager.Usecases;

namespace PathFinderBattleManager.Tests.Usecases
{
    [TestClass]
    public class ManageCombatNPCsTests : BaseUseCaseUnitTestClass
    {
        private NonPlayerCharacter goblin;
        private RetrieveEncounters retrieve;
        private Guid encounterId;

        [TestInitialize]
        public void Initialize()
        {
            base.Initialize();

            encounterId = Guid.NewGuid();
            var useCase = new AddNPCsToEncounter(encounterGateway);
            var create = new CreateEncounter(encounterGateway);
            retrieve = new RetrieveEncounters(encounterGateway);
            create.Create(encounterId, "Name");

            goblin = NPCBuilder.Default();
            useCase.Add(encounterId, goblin);
        }
        [TestMethod]
        public void DealDamage()
        {
            var mockGateway = new Mock<INPCGateway>();
            mockGateway.Setup(x => x.Retrieve(goblin.Id)).Returns(goblin);
            var useCase = new ManageCombatNPCs(mockGateway.Object);
            useCase.DealDamage(goblin.Id, 1);
            goblin.Hp -= 1;
            mockGateway.Verify(x => x.Update(goblin), Times.Once);
        }
    }
}
