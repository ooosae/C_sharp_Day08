using System;
using System.IO;
using System.Linq;
using System.Text;
using Markdown.Generator.Core;
using Markdown.Generator.Core.Documents;
using Markdown.Generator.Core.Markdown;

namespace Markdown.Generator.Application;

class Program
{
    
    static void Main(string[] args)
    {
        var dllPath = String.Empty;
        var folder = "docs";
        var namespaceMatch = string.Empty;
        
        switch (args.Length)
        {
            case 1:
                dllPath = args[0];
                break;
            case 2:
                dllPath = args[0];
                folder = args[1];
                break;
            case 3:
                dllPath = args[0];
                folder = args[1];
                namespaceMatch = args[2];
                break;
            default:
                Console.WriteLine("Usage: dotnet run <dll src path> [<dest root>] [<namespace>]");
                return;
        }

        var documentBuilder = new GithubWikiDocumentBuilder<MarkdownGenerator>(
            new MarkdownGenerator()
        );
        
        documentBuilder.Generate(dllPath, namespaceMatch, folder);
    }
}
