using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PathFinderBattleManager.Gateways;
using PathFinderBattleManager.Models;
using PathFinderBattleManager.Tests.TestHelpers;
using PathFinderBattleManager.Usecases;

namespace PathFinderBattleManager.Tests.Usecases
{
    [TestClass]
    public class RetrieveEncountersTests
    {
        [TestMethod]
        public void RetrieveEncounter()
        {
            var id = Guid.NewGuid();
            var mockGateway = new Mock<IEncounterGateway>();
            var encounter = EncounterBuilder.ReturnEmptyEncounter("Name");

            mockGateway.Setup(x => x.RetrieveEncounter(id)).Returns(encounter);
            var useCase = new RetrieveEncounters(mockGateway.Object);
            var result = useCase.Retrieve(id);

            Assert.IsNotNull(result);
            Assert.AreEqual(encounter.Name, result.Name);
            Assert.AreEqual(encounter.Id, result.Id);
            Assert.AreEqual(encounter.Notes, result.Notes);
        }
    }
}
