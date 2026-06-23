using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MidiMicrobitOrchestra
{
    enum RuleType
    {
        Allow, Block, Invalid
    }

    enum RuleAction
    {
        Allowed, Blocked, Unaffected
    }

    internal class MessageRule
    {
        public RuleType ruleType = RuleType.Invalid;
        string pattern;

        public MessageRule(string fromString)
        {
            Regex constructor = new Regex("(allow|block|\\+|-)\\s+(.*)");
            Match m = constructor.Match(fromString);
            if(m.Success) {
                pattern = m.Groups[2].Value.Trim();
                switch(m.Groups[1].Value.ToLower())
                {
                    case "allow":
                    case "+":
                        ruleType = RuleType.Allow;
                        break;
                    case "block":
                    case "-":
                        ruleType = RuleType.Block;
                        break;
                }

            }
        }

        public RuleAction CheckMessage(string message)
        {
            if (ruleType != RuleType.Invalid && new Regex(pattern).IsMatch(message))
            {
                return ruleType == RuleType.Allow ? RuleAction.Allowed : RuleAction.Blocked;
            }
            else
            {
                return RuleAction.Unaffected;
            }
        }

        public override string ToString()
        {
            return $"{ruleType} {pattern}";
        }
        

    }
}
