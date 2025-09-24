using System;
using System.Linq;

namespace NameSort.App.Models
{
    public class PersonName
    {
        public string LastName { get; }
        public string[] GivenNames { get; }

        public PersonName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Invalid name: name cannot be empty or whitespace.");

            var parts = fullName.Trim()
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < 2 || parts.Length > 4)
                throw new ArgumentException(
                    $"Invalid name '{fullName}'. A name must have 1–3 given names and 1 last name."
                );

            LastName = parts[^1]; // last element is last name
            GivenNames = parts.Take(parts.Length - 1).ToArray();
        }

        public override string ToString() => $"{string.Join(" ", GivenNames)} {LastName}";
    }
}

