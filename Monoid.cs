namespace csharp_monads
{
    public interface Monoid<A> : SemiGroup<A>
    {
        A Empty();
    }

    public class IntMonoid : IntSemiGroup, Monoid<int>
    {
        public int Empty()
          => 0;
    }
}