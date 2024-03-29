namespace Markdown.Generator.Core.Markdown.Elements
{
    /// <summary>
    /// Represents markdown header
    /// e.g ## header\n
    /// </summary>
    public class Header : ElementBase
    {
        private readonly int _level;
        private readonly string _text;

        public Header(int level, string text)
        {
            _level = level;
            _text = text;
        }
        
        public Header(int level, Link link) : this(level, link.Create())
        {
        }
        
        public Header(int level, CodeQuote codeQuote): this(level, codeQuote.Create())
        {
        }

        public override string Create()
        {
            for (var i = 0; i < _level; i++)
            {
                Builder.Append('#');
            }
            Builder.Append(' ');
            Builder.Append(_text);
            Builder.Append("\n");

            return Builder.ToString();
        }
    }
}