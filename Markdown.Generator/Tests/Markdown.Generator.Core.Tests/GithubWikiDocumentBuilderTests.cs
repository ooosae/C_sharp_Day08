using Moq;

using Markdown.Generator.Core.Documents;
using Markdown.Generator.Core.Markdown;
using Markdown.Generator.Core.Markdown.Elements;

namespace Markdown.Generator.Core.Tests;

public class GithubWikiDocumentBuilderTests
{
    [Fact]
    public void Generate_WithTypeArray_CallsLoadOnce()
    {
        // Arrange
        var markdownGeneratorMock = new Mock<IMarkdownGenerator>();
        var documentBuilder = new GithubWikiDocumentBuilder<IMarkdownGenerator>(markdownGeneratorMock.Object);

        // Act
        documentBuilder.Generate(new Type[] { typeof(Link) }, "LinkWiki");

        // Assert
        markdownGeneratorMock.Verify(x => x.Load(It.IsAny<Type[]>()), Times.Once);
    }
    
    [Fact]
    public void Generate_WithStringParameters_CallsLoadWithStringParametersOnce()
    {
        // Arrange
        var markdownGeneratorMock = new Mock<IMarkdownGenerator>();
        var documentBuilder = new GithubWikiDocumentBuilder<IMarkdownGenerator>(markdownGeneratorMock.Object);
        var dllPath = "DllPath";
        var namespaceMatch = "NamespaceMatch";
        var folder = "Folder";

        // Act
        documentBuilder.Generate(dllPath, namespaceMatch, folder);

        // Assert
        markdownGeneratorMock.Verify(x => x.Load(dllPath, namespaceMatch), Times.Once);
    }
    
    [Fact]
    public void Generate_WithAssemblyParameters_CallsLoadWithAssemblyParametersOnce()
    {
        // Arrange
        var markdownGeneratorMock = new Mock<IMarkdownGenerator>();
        var documentBuilder = new GithubWikiDocumentBuilder<IMarkdownGenerator>(markdownGeneratorMock.Object);
    
        var assemblies = new [] { typeof(Link).Assembly };
        var namespaceMatch = "NamespaceMatch";
        var folder = "Folder";

        // Act
        documentBuilder.Generate(assemblies, namespaceMatch, folder);

        // Assert
        markdownGeneratorMock.Verify(x => x.Load(assemblies, namespaceMatch), Times.Once);
    }
}
