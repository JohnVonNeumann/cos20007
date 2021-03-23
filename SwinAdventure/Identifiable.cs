using System.Collections.Generic;

namespace SwinAdventure
{
    public class Identifiable
    {
        private List<string> _identifiers;

        public Identifiable(string[] idents)
        {
            
        }

        public bool AreYou(string id)
        {
            bool areYou = false;

            return areYou;
        }

        public string FirstId
        {

            get
            {
                string identifier = "";
                if (_identifiers.Count != 0)
                {
                    identifier = _identifiers[0];
                }

                return identifier;
            }
        }

        public void AddIdentifier(string id)
        {
            
        }
    }
}