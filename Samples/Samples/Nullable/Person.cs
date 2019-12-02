namespace Samples.Nullable
{
    internal class Person
    {
        public Person(string first, string last)
        {
            (this.FirstName, this.LastName) = (first, last);
        }

        public Person(string first, string middle, string last)
        {
            (this.FirstName, this.MiddleName, this.LastName) = (first, middle, last);
        }

        public string FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.MiddleName} {this.LastName}";
        }
    }
}