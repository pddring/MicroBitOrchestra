using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidiMicrobitOrchestra
{
    internal class MessageFilter
    {
        /// <summary>
        /// Stores a list of rules that determine whether a message is allowed or blocked.
        /// </summary>
        public List<MessageRule> rules = new List<MessageRule>();
        
        /// <summary>
        /// Check if a message is allowed or blocked based on the rules in the filter.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool IsAllowed(string message)
        {
            bool allowed = true;
            foreach(MessageRule r in rules)
            {
                switch(r.CheckMessage(message)) {                     
                    case RuleAction.Allowed:
                        allowed = true;
                        break;
                    case RuleAction.Blocked:
                        allowed = false;
                        break;
                    case RuleAction.Unaffected:
                        break;
                }
            }
            return allowed;
        }
    }
}
