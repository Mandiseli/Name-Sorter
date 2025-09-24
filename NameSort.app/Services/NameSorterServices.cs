using NameSort.App.Models;


namespace NameSort.App.Services
{
    public class NameSorterService
    {
        public List<PersonName> SortNames(IEnumerable<string> names)
        {
            var people = names.Select(n => new PersonName(n)).ToList();

            return people
                .OrderBy(p => p.LastName)
                .ThenBy(p => string.Join(" ", p.GivenNames))
                .ToList();
        }
    }
}
