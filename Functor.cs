using System;

namespace csharp_monads
{
    public interface Functor<F>
    {
        HK<F, B> Map<A, B>(HK<F, A> fa, Func<A, B> f);
    }

}