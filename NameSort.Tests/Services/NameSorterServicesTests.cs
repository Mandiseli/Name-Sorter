using FluentAssertions;
using NameSort.App.Services;


namespace NameSort.Tests.Services
{
    public class NameSorterServiceTests
    {
        [Fact]
        public void Should_SortNames_ByLastName_ThenGivenNames()
        {
            var names = new[]
            {
                "Janet Parsons",
                "Vaughn Lewis",
                "Adonis Julius Archer"
            };

            var service = new NameSorterService();  // 👈 fixed
            var result = service.SortNames(names);

            result[0].ToString().Should().Be("Adonis Julius Archer");
            result[1].ToString().Should().Be("Vaughn Lewis");
            result[2].ToString().Should().Be("Janet Parsons");
        }
    }
}
