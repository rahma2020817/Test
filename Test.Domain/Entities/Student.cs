using System.Collections.Generic;

namespace Test.Domain
{
    public class Student : Base
    {
        public string? FullName { get; set; }
        public IEnumerable<Course>? Courses { get; set; }
    }
}