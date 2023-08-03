
namespace Linq_workshop
{
    internal class Item
    {
        public Item(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public int Price { get; set; }
    }

    internal class Order
    {
        public Order(string firstName, Item[] items)
        {
            FirstName = firstName;
            Items = items;
        }

        public string FirstName { get; set; }
        public Item[] Items { get; set; }

        public static List<Order> GetOrders()
        {
            return new List<Order>
            {
                new Order("Regina", new Item[]{new Item("Hide of Curses", 152), new Item("Scroll of Dementia", 86), new Item("Box of Blinding", 109)}),
                new Order("Matej", new Item[]{new Item("Rebirth Necklace", 4), new Item("Cylinder of Resistance", 248), new Item("Equinox Sword", 184)}),
                new Order("Jarka", new Item[]{new Item("Shield of Destruction", 216), new Item("Staff of Strength", 43), new Item("Obsidian Boots", 104)}),
                new Order("Marianna", new Item[]{new Item("Disc of Specters", 126), new Item("Letters of Enthrallment", 149), new Item("Exile Chest", 226)}),
                new Order("Viliam", new Item[]{new Item("Jar of Honesty", 190), new Item("Inscriptions of Chaos", 201), new Item("Pillar of Corruption", 199)}),
                new Order("Regina", new Item[]{new Item("Chalice of Spellbinding", 153), new Item("Hand of Blessings", 24), new Item("Sandals of Exiles", 66)}),
                new Order("Matej", new Item[]{new Item("Azure Disc", 252), new Item("Grimoire of Peace", 124), new Item("Sword of Sanctity", 74)}),
                new Order("Jarka", new Item[]{new Item("Ring of Ice", 134), new Item("Elixir of Courage", 79), new Item("Door of Light", 113)}),
                new Order("Marianna", new Item[]{new Item("Necklace of Virility", 95), new Item("Key of Passion", 21), new Item("Temptation Cup", 40)}),
                new Order("Viliam", new Item[]{new Item("le Manteau de Mal", 255), new Item("Arch of the Aether", 198), new Item("Monolith of Invocation", 46)}),
                new Order("Regina", new Item[]{new Item("Runes of Luminosity", 100), new Item("Urn of Blessings", 22), new Item("Robes of Riddles", 217)}),
                new Order("Matej", new Item[]{new Item("Robes of the Gods", 199), new Item("Statue of Silence", 201), new Item("Statue of Curses", 91)}),
                new Order("Jarka", new Item[]{new Item("Canopic Jar of Birth", 3), new Item("Box of Eternal Health", 215), new Item("Invisible Sword", 64)}),
                new Order("Marianna", new Item[]{new Item("Band of Gluttony", 161), new Item("Crown of Lightning", 68), new Item("Hand of Lifeblood", 55)}),
                new Order("Viliam", new Item[]{new Item("Goblet of Invincibility", 199), new Item("Amulet of Malady", 16), new Item("Crown of Angels", 86)}),
                new Order("Regina", new Item[]{new Item("Cloak of Doom", 90), new Item("Book of Remedies", 174), new Item("Microlith of Ruination", 90)}),
                new Order("Matej", new Item[]{new Item("Lucky Mask", 210), new Item("Pillar of Riddles", 93), new Item("Tablet of Dread", 38)}),
                new Order("Jarka", new Item[]{new Item("Amulet of Vice", 229), new Item("Sandals of Fear", 1), new Item("Grimoire of Damnation", 25)}),
                new Order("Marianna", new Item[]{new Item("Restoration Amulet", 234), new Item("Shield of Spellbinding", 125), new Item("Ring of Mending", 212)}),
                new Order("Viliam", new Item[]{new Item("Chest of Invisibility", 186), new Item("Inscriptions of Evil", 58), new Item("Burning Rod", 191)}),
                new Order("Regina", new Item[]{new Item("le Cylindre de Cauchemar", 20), new Item("Goblet of Delusion", 13), new Item("Grail of Death", 198)}),
                new Order("Matej", new Item[]{new Item("Cup of Persecution", 68), new Item("Angel Boots", 180), new Item("Urn of Valor", 175)}),
                new Order("Jarka", new Item[]{new Item("Fleece of Destruction", 254), new Item("Runes of Persecution", 75), new Item("Hide of Black Magic", 153)}),
                new Order("Marianna", new Item[]{new Item("Goblet of Eternal Slumber", 35), new Item("Cloak of Sanctification", 117), new Item("Canopic Jar of Wishes", 120)}),
                new Order("Viliam", new Item[]{new Item("Sword of the Creed", 126), new Item("l’Urne de Métamorphose", 37), new Item("Root of Misery", 186)}),
                new Order("Regina", new Item[]{new Item("Robes of Eternal Slumber", 44), new Item("Ring of Toxi", 86), new Item("Mantle of Decadence", 179)}),
                new Order("Matej", new Item[]{new Item("Canopic Jar of Lightning", 72), new Item("Canopic Chest of Transmutation", 85), new Item("Nightmare Cube", 68)}),
                new Order("Jarka", new Item[]{new Item("Runed Rod", 133), new Item("Necklace of Enthrallment", 234), new Item("Thunder Circlet", 213)}),
                new Order("Marianna", new Item[]{new Item("Microlith of Eternal Slumber", 103), new Item("Enigma Door", 50), new Item("Amulet of Evil", 154)}),
                new Order("Viliam", new Item[]{new Item("Skull of Evils", 31), new Item("Dominion Tiara", 79), new Item("Tiara of Misfortune", 187)}),
            };
        }
    }
}
