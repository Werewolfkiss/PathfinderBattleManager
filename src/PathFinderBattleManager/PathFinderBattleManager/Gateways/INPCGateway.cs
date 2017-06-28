using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathFinderBattleManager.Models;

namespace PathFinderBattleManager.Gateways
{
    public interface INPCGateway
    {
        void Create(Guid id, string Name, int Hp);
        NonPlayerCharacter Retrieve(Guid id);
        void Update(NonPlayerCharacter character);
    }
}
