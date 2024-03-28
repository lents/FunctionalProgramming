using System;

// Maybe monad representing a computation that may or may not produce a result
//Это базовый пример того, как монада Maybe может использоваться для представления вычислений, которые могут давать или не давать результат,
//функционально обрабатывая нулевые значения, обеспечивая при этом неизменяемость и избегая исключений нулевых ссылок.
public struct Maybe<T>
{
    private readonly T _value;
    private readonly bool _hasValue;

    private Maybe(T value)
    {
        _value = value;
        _hasValue = value != null; // Check if value is not null
    }

    public static Maybe<T> Some(T value)
    {
        return new Maybe<T>(value);
    }

    public static Maybe<T> None()
    {
        return new Maybe<T>();
    }

    public bool HasValue => _hasValue;

    public T Value
    {
        get
        {
            if (!_hasValue)
            {
                throw new InvalidOperationException("Maybe does not contain a value.");
            }
            return _value;
        }
    }

    public Maybe<TResult> Select<TResult>(Func<T, TResult> selector)
    {
        return _hasValue ? Maybe<TResult>.Some(selector(_value)) : Maybe<TResult>.None();
    }

    public Maybe<TResult> SelectMany<TResult>(Func<T, Maybe<TResult>> selector)
    {
        return _hasValue ? selector(_value) : Maybe<TResult>.None();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Maybe<int> maybeNumber = Maybe<int>.Some(5);
        Maybe<int> result = maybeNumber.Select(x => x * 2);

        if (result.HasValue)
        {
            Console.WriteLine("Result: " + result.Value); // Output: Result: 10
        }
        else
        {
            Console.WriteLine("No result");
        }
    }
}
