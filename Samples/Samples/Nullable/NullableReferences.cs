using System;

namespace Samples.Nullable
{
    internal class NullableReferences
    {
        internal int NullableTestBed()
        {
            var miguel = new Person("Miguel", "de Icaza");
            var length = GetLengthOfMiddleName(miguel);
            Console.WriteLine(length);

            return 0;
        }

        private static int GetLengthOfMiddleName(Person p)
        {
            var middleName = p.MiddleName;
            return middleName.Length;
        }
    }
}