using System.Collections.Immutable;

var numbers = Enumerable.Range(-10000, 20001).ToList();
Action task1 = () => Console.WriteLine(numbers.Sum());
//Action task2 = () => { numbers.Sort(); Console.WriteLine(numbers.Sum()); };
//Parallel.Invoke(task1, task2);


Action task3 = () => Console.WriteLine(numbers.OrderBy(x => x).Sum());
Parallel.Invoke(task1, task3);


//sample of immutable collection
ImmutableList<int> immutableList = ImmutableList<int>.Empty.Add(1).Add(2).Add(3);
