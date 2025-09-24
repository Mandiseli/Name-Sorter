using FluentAssertions;
using NameSort.App.Utils;   

namespace NameSort.Tests.Utils
{
    public class FileHelperTests
    {
        [Fact]
        public void Should_ReadAndWriteNames()
        {
            var tempFile = Path.GetTempFileName();
            var names = new[] { "Test Name" };

            FileHelper.WriteNames(tempFile, names);
            var readNames = FileHelper.ReadNames(tempFile);

            readNames.Should().ContainSingle().Which.Should().Be("Test Name");
        }
    }
}
