using System.Xml.Serialization;

namespace HelloWorldAspTestProject
{
    public class HtmlRenderTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true, "Test Ok!" + "><IMG SRC=\"https://upload.wikimedia.org/wikipedia/commons/a/a8/Green_shield_bug_%28Palomena_prasina%29_3.jpg\">");
        }

        [Fact]
        public void Test2()
        {
            Assert.True(false, "Test Failed!" + "><IMG SRC=\"https://upload.wikimedia.org/wikipedia/commons/a/a8/Green_shield_bug_%28Palomena_prasina%29_3.jpg\">");
            Assert.True(false, "Test Failed!" + "><a SRC=\"https://bing.com\">clickme</a>");
            Assert.True(false, "Test Failed!" + "123/><s>\\${9*9}[<!--+*)(&Test Failed!)");
        }

        [Fact]
        public void Test3()
        {
           Assert.True(false, "Test Failed!" + "><a SRC=\"https://bing.com\">clickme</a>");
        }

        [Fact]
        public void Test4()
        {
            Assert.True(false, "Test Failed!" + "123/><s>\\${9*9}[<!--+*)(&Test Failed!)");
        }

        [Fact]
        public void Test10()
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