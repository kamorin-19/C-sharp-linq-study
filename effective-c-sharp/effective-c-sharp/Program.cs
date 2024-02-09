using effective_c_sharp;

var foo = (from n in Enumerable.Range(0, 100)
           select n * n).ToArray();

foo.ForAll((n) => Console.WriteLine(n.ToString()));