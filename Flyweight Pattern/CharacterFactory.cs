using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    internal class CharacterFactory
    {
        private Dictionary<string, Character> _characterMap = new Dictionary<string, Character>();
        public Character GetCharacter(string name,Types type,string image)
        {
            string key = $"{name}_{type}";
            if(!_characterMap.ContainsKey(key))
            {
                _characterMap[key] = new Character(name, type, image);
            }
            return _characterMap[key];
        }
    }
}
