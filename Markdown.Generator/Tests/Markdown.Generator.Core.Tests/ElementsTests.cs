using Markdown.Generator.Core.Markdown.Elements;

namespace Markdown.Generator.Core.Tests;

public class ElementsTests
{
    [Fact]
    public void Given_Code_When_LanguageAndCodeAsParameter_Then_ReturnMarkdownCodeMarkup()
    {
        // Arrange
        string expected = "```csharp\nsome code\n```\n";

        // Act
        Code codeElement = new Code("csharp", "some code");
        string actual = codeElement.Create();

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given_CodeQuote_When_QuoteAsParameter_Then_ReturnMarkdownCodeQuoteMarkup()
    {
        // Arrange
        string expected = "`quote`";

        // Act
        CodeQuote codeQuoteElement = new CodeQuote("quote");
        string actual = codeQuoteElement.Create();

        // Assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Given_Header_When_LevelAndTextAsParameter_Then_ReturnMarkdownHeaderMarkup()
    {
        // Arrange
        string expected = "## Header Text\n";

        // Act
        Header headerElement = new Header(2, "Header Text");
        string actual = headerElement.Create();

        // Assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Given_List_When_TextAsParameter_Then_ReturnMarkdownListMarkup()
    {
        // Arrange
        string expected = "- List Item\n";

        // Act
        List listElement = new List("List Item");
        string actual = listElement.Create();

        // Assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Given_Link_When_TitleAndUrlAsParameters_Then_ReturnMarkdownLinkMarkup()
    {
        // Arrange
        string expected = "[Link Text](http://example.com)";

        // Act
        Link linkElement = new Link("Link Text", "http://example.com");
        string actual = linkElement.Create();

        // Assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Given_Image_When_TitleAndUrlAsParameters_Then_ReturnMarkdownImageMarkup()
    {
        // Arrange
        string expected = "![Image Alt](http://example.com/image.jpg)";

        // Act
        Image imageElement = new Image("Image Alt", "http://example.com/image.jpg");
        string actual = imageElement.Create();

        // Assert
        Assert.Equal(expected, actual);
    }
}

