using System;
using System.Collections.Generic;
using System.Linq;

namespace SwinAdventure.Abstract
{
    /// <summary>
    /// class <c> IdentifiableObject </c>
    /// Players of Swin Adventure need to be able to "identify" a number of things in the game.
    /// This includes commands the user will perform, items they will interact with, location, paths, etc.
    /// </summary>
    public class IdentifiableObject
    {
        private List<string> _identifiers = new List<string>();

        public IdentifiableObject(string[] idents)
        {
            foreach (string ident in idents)
            {
               _identifiers.Add(ident);
            }
        }

        /// <summary>
        /// method <c> AreYou </c> checks if the passed in identifier is in the _identifiers
        /// </summary>
        /// <param name="id"> identifier used to refer to an identifiable object </param>
        /// <returns> bool - true if the identifer is in _identifiers </returns>
        public bool AreYou(string id)
        {
            return _identifiers.Contains(id, StringComparer.OrdinalIgnoreCase);
        }

        /// <summary>
        /// property <c> FirstId </c> returns the first identifier from _identifiers or an empty string
        /// <returns> string - the first identifier from _identifiers </returns>
        /// </summary>
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

        /// <summary>
        /// method <c> AddIdentifier </c> converts the identifier to lowercase and stores it in _identifiers
        /// </summary>
        /// <param name="id"> string - the identifier to be added to _identifiers, before lowercase conversion </param>
        public void AddIdentifier(string id)
        {
            _identifiers.Add(id);
        }
    }
}