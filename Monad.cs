using System;

namespace csharp_monads
{
    public interface Monad<F>: Applicative<F>
    {
        HK<F, B> FlatMap<A, B>(HK<F,A> fa, Func<A,HK<F,B>> f);

        // HK<F, B> TailRecM<A, B>(A a, Func<A, HK<F, Either<A,B>>> f);
    }

    public static class MonadOps
    {
        public static HK<F, A> Flatten<F, A>(this Monad<F> m, HK<F,HK<F,A>> ffa)
             => m.FlatMap(ffa, fa => fa);

        public static HK<F, A> Pure<F, A>(this Monad<F> m, A a)
             => m.Pure(a);

        public static HK<F, B> Ap<F, A, B>(this Monad<F> m, HK<F, Func<A, B>> ff, HK<F, A> fa)
             => m.FlatMap(ff, f => m.Map(fa, f));

        public static HK<F, B> Map<F, A, B>(this Monad<F> m, HK<F, A> fa, Func<A, B> f)
             => m.FlatMap(fa, a => m.Pure(f(a)));
    }
}