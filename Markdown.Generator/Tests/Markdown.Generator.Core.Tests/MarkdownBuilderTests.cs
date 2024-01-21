using Markdown.Generator.Core.Markdown;
using Markdown.Generator.Core.Markdown.Elements;

namespace Markdown.Generator.Core.Tests;

public class MarkdownBuilderTests
{
    [Fact]
    public void Given_CodeQuote_When_CodeQuoteMethodCalled_Then_CodeQuoteElementInElements()
    {
        // Arrange
        var builder = new MarkdownBuilder();

        // Act
        builder.CodeQuote("some code");

        // Assert
        Assert.Single(builder.Elements);
        Assert.IsType<CodeQuote>(builder.Elements.Single());
    }

    [Fact]
    public void Given_Code_When_CodeMethodCalled_Then_CodeElementInElements()
    {
        // Arrange
        var builder = new MarkdownBuilder();

        // Act
        builder.Code("csharp", "some code");

        // Assert
        Assert.Single(builder.Elements);
        Assert.IsType<Code>(builder.Elements.Single());
    }

    [Fact]
    public void Given_Link_When_LinkMethodCalled_Then_LinkElementInElements()
    {
        // Arrange
        var builder = new MarkdownBuilder();

        // Act
        builder.Link("Example", "http://example.com");

        // Assert
        Assert.Single(builder.Elements);
        Assert.IsType<Link>(builder.Elements.Single());
    }

    [Fact]
    public void Given_Header_When_HeaderMethodCalled_Then_HeaderElementInElements()
    {
        // Arrange
        var builder = new MarkdownBuilder();

        // Act
        builder.Header(2, "Header Text");

        // Assert
        Assert.Single(builder.Elements);
        Assert.IsType<Header>(builder.Elements.Single());
    }
}