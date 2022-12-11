namespace Flyweight
{
    /// <summary>
    /// Concrete Flyweight
    /// </summary>
    public abstract class CharacterBase : ICharacter
    {
        protected char _actualCharacter = 'a';
        protected string _fontFamily = string.Empty;
        protected int _fontSize;
        public CharacterBase(char actualCharacter)
        {
            _actualCharacter = actualCharacter;
        }
        public virtual void Draw(string fontFamily, int fontSize)
        {
            _fontFamily = fontFamily;
            _fontSize = fontSize;
            Console.WriteLine($"Drawing {_actualCharacter}, {_fontFamily} {_fontSize}");
        }
    }
}
