using Semver;

namespace SemverLib
{
    public class SortService2
    {

        public static IEnumerable<SemVersion> GetSemVersion3List()
        {
            return new List<SemVersion>
            {
                new (1, 0, 2),
                new (1, 0, 0),
                new (1, 0, 1),
                new (1, 0, 1),
                new (1, 0, 6),
                new (1, 0, 3),
                new (1, 0, 3),
                new (1, 0, 4),
                new (1, 0, 4),
                new (1, 0, 5)
            };
        }

        public static void Run()
        {
            Console.WriteLine("############### F0 ################");
            var f0 = GetSemVersion3List().OrderByDescending(c => c, SemVersion.SortOrderComparer);
            foreach (var f in f0)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine("############### F1 ################");
            var f1 = GetSemVersion3List().OrderByDescending(c => c, SemVersion.PrecedenceComparer);
            foreach (var f in f1)
            {
                Console.WriteLine(f);
            }

            var f3 = GetSemVersion3List().OrderByDescending(c => c);
            Console.WriteLine("############### F3 ################");
            foreach (var f in f3)
            {
                Console.WriteLine(f);
            }
        }
    }
}
