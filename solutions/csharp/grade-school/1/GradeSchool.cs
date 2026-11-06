using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private readonly Dictionary<string, int> students = new Dictionary<string, int>();

    public bool Add(string student, int grade)
    {
        if (students.ContainsKey(student))
            return false;

        students[student] = grade;
        return true;
    }

    public IEnumerable<string> Roster()
    {
        return students
            .OrderBy(s => s.Value)
            .ThenBy(s => s.Key)
            .Select(s => s.Key)
            .ToList();
    }

    public IEnumerable<string> Grade(int grade)
    {
        return students
            .Where(s => s.Value == grade)
            .Select(s => s.Key)
            .OrderBy(name => name)
            .ToList();
    }
}