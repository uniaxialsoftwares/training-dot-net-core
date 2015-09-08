# Why Generics?

## Performance
  * No boxing and unboxing as in ArrayList
  * Using List vs. ArrayList
  Consider following code to make an list from ArrayList
  ````
  var list = new ArrayList();
  list.Add(44);
  list.Add("mystring");
  list.Add(new MyClass());

  ```
  And consider you are traversing through the items in list as below.
  ```
  foreach (int i in list)
  {
      Console.WriteLine(i);
  }
  ```
  It causes an error at runtime becasue list does not only contains integers.

I
## Type safety
Following does not happen in C# if you use List instead of ArrayList

````
var list = new List<int>()
list.Add(44);
list.Add("mystring");  // compile time error
list.Add(new MyClass()); // compile time error

```

## Code Reuse
As an example, here the List<T> class from the namespace System.Collections.Generic is instantiated with an int , a string , and a MyClass type


```
var list = new List<int>();
list.Add(44);
var stringList = new List<string>();
stringList.Add("mystring");
var myClassList = new List<MyClass>();
myClassList.Add(new MyClass());
```
## Working with Generics
We will only deal with methods :(
### Generic Methods
```
static void Swap<T>(ref T lhs, ref T rhs)
{
  T temp;
  temp = lhs;
  lhs = rhs;
  rhs = temp;
}
```
Use the function as
```
int a=10, b=200;
Swap<int>(ref a, ref b);
// OR
Swap(ref a, ref b);

```

### Generics and Arrays
In C# 2.0 and later, single-dimensional arrays that have a lower bound of zero automatically implement IList<T>
```
class Program
{
    static void Main()
    {
        int[] arr = { 0, 1, 2, 3, 4 };
        List<int> list = new List<int>();

        for (int x = 5; x < 10; x++)
        {
            list.Add(x);
        }

        ProcessItems<int>(arr);
        ProcessItems<int>(list);
    }

    static void ProcessItems<T>(IList<T> coll)
    {
        // IsReadOnly returns True for the array and False for the List.
        System.Console.WriteLine
            ("IsReadOnly returns {0} for this collection.",
            coll.IsReadOnly);

        // The following statement causes a run-time exception for the  
        // array, but not for the List.
        //coll.RemoveAt(4);

        foreach (T item in coll)
        {
            System.Console.Write(item.ToString() + " ");
        }
        System.Console.WriteLine();
    }
}
```
