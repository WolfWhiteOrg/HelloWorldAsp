using System.Xml.Serialization;

namespace HelloWorldAspTestProject
{
    public class HtmlRenderTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var expected =
                 @"<form method=""post"" action=""/Pages/TagHelper/SubDirectoryLinks""></form>
                 <form method=""post"" action=""/HelloWorld""></form>
                 <a href=""/Pages/Redirects/RedirectToIndex"" />
                 <input type=""image"" formaction=""/Pages/Admin#my-fragment"" />";

            // Act
            var response = "Some response";

            // Assert
            Assert.Equal(expected, response.Trim(), ignoreLineEndingDifferences: true);

        }
    }
}