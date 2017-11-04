using System;

namespace csharp_monads
{
    public interface Applicative<F> : Functor<F>
    {
        HK<F, B> Ap<A, B>(HK<F, Func<A, B>> ff, HK<F, A> fa);

        HK<F, A> Pure<A>(A a);

        new HK<F, B> Map<A, B>(HK<F, A> fa, Func<A, B> f);
    }
}