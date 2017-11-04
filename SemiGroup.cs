namespace csharp_monads
{
    public interface SemiGroup<A>
    {
         A Combine(A x, A y);
    }

    public class IntSemiGroup : SemiGroup<int> {
        public int Combine(int x, int y)
          =>  x + y;
    }
}
