namespace MasteringLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var GroupByUsingMultiKey = Student.GetStudents().GroupBy(x => new { x.Gender, x.Barnch }).Select(g => new
            {
                Branch = g.Key.Barnch,
                Gender = g.Key.Gender,
                Student = g.OrderBy(x => x.Name)
            });

            foreach (var group in GroupByUsingMultiKey)
            {
                Console.WriteLine($"{group.Branch} && {group.Gender}");

                foreach (var item in group.Student)
                {
                    Console.WriteLine( item.Name );
                }
            }
        }
    }
}
