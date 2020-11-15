using System.Runtime.CompilerServices;

namespace Samples.DefaultInterfaces.DiamondProblem
{
    public interface A
    {
        string Method();
    }

    public interface B : A
    {
        new string Method() => "B";
    }

    public interface C : A
    {
        new string Method() => "C";
    }

    public class D : B, C
    {
        public string Method() => "D";
    }
}