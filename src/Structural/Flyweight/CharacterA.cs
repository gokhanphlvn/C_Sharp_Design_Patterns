namespace Flyweight
{
    /// <summary>
    /// Concrete Flyweight
    /// </summary>
    public class CharacterA : CharacterBase, ICharacter
    {
        public CharacterA() : base('a') { }
    }
}
