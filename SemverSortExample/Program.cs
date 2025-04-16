using SemverLib;

namespace SemverSortExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CoreLibCaller.Caller.Run();
            var semver = new Semver.SemVersion(1, 2, 3);
            SortService2.Run();
        }
    }
}
