using Join.InnerJoins;

namespace Join
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SimpleKeyJoin s = new SimpleKeyJoin();
            s.KeyJoin();
        }
    }
}
