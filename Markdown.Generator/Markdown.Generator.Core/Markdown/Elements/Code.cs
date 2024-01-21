using System;

namespace Markdown.Generator.Core.Markdown.Elements
{
    /// <summary>
    /// Represents markdown code-block
    /// e.g ```csharp\nRandom string\n```\n 
    /// </summary>
    public class Code: ElementBase
    {
        private readonly string _language;
        private readonly string _code;

        public Code(string language, string code)
        {
            _language = language;
            _code = code;
        }
        
        public override string Create()
        {
            Builder.AppendLine("```" + _language);
            Builder.AppendLine(_code);
            Builder.AppendLine("```");

            string result = Builder.ToString();
            string normalizedResult = result.Replace("\r\n", "\n").TrimEnd('\n');

            return normalizedResult + "\n";
        }


    }
}