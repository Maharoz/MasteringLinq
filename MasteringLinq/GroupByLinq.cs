using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasteringLinq
{
    public class GroupByLinq
    {
        public void GroupBy()
        {

            IEnumerable<IGrouping<string, Student>> StudentGroupByBranch = Student.GetStudents()
                                                                          .GroupBy(x => x.Barnch);

            foreach (IGrouping<string, Student> group in StudentGroupByBranch)
            {
                Console.WriteLine($"Group name is {group.Key}");
                foreach (Student student in group)
                {
                    Console.WriteLine($"{student.Name},{student.Barnch}");
                }
            }
        }
    }
}
