using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinderBattleManager.Models
{
    public class Encounter
    {
        public Encounter()
        {
            participants = new List<Character>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        private List<Character> participants;
        public IEnumerable<Character> Participants
        {
            get { return participants; }
            set { participants = value.ToList(); }
        }
        public void AddParticipant(Character participant)
        {
            participants.Add(participant);
        }
    }
}
