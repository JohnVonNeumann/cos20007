using System.Collections.Generic;
using Library.Abstract;

namespace Library
{
    public class Library
    {
        private string _name;
        private List<LibraryResource> _resources;

        public Library(string name)
        {
            _name = name;
            _resources = new List<LibraryResource>();
        }

        public void AddResource(LibraryResource resource)
        {
            _resources.Add(resource);
        }

        public bool HasResource(string name)
        {
            foreach (LibraryResource resource in _resources)
            {
                if (resource.Name == name)
                {
                    return true;
                }
            }

            return false;
        }
    }
}