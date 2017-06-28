using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PathFinderBattleManager.Gateways;

namespace PathFinderBattleManager.Tests.Usecases
{
    [TestClass]
    public class BaseUseCaseUnitTestClass
    {
        public InMemoryEncounterGateway encounterGateway;

        [TestInitialize]
        public void Initialize()
        {
            encounterGateway = new InMemoryEncounterGateway();
        }
    }
}
