﻿namespace Genshin_Site.Data
{
    public class Character
    {
        public string CharacterName { get; }
        public string Element { get; }
        public string Weapon { get; }
        public bool Show { get; set; }

        public Character(string CharacterName1, string Element1, string Weapon1, bool Show1)
        {
            CharacterName = CharacterName1;
            Element = Element1;
            Weapon = Weapon1;
            Show = false;
        }
    }
}