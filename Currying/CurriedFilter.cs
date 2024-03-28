public static class CurriedFilter
{
    public static Func<T, TResult> Curry<TResult>(Func<T, TResult> func)
    {
        return func;
    }

    public static Func<T1, Func<TResult>> Curry<T1, TResult>(Func<T, T1, TResult> func, T arg)
    {
        return arg1 => () => func(arg, arg1);
    }

    public static Func<T1, T2, Func<TResult>> Curry<T1, T2, TResult>(Func<T, T1, T2, TResult> func, T arg)
    {
        return (arg1, arg2) => () => func(arg, arg1, arg2);
    }

    public static Func<TInput1, TOutput> Curry<TInput1, TOutput>(this Func<TInput1, TOutput> f)
    {
        return x => f(x);
    }
}


