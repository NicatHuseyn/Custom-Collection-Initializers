


using System.Collections;


MyClass ints = new MyClass()
{
    {5,"salam" },
    {3,"sagol" },
};

class MyClass : IEnumerable<int>
{
    List<int> numbers;

    public void Add(int i, string j)=>numbers.Add(i);
    public IEnumerator<int> GetEnumerator()=>numbers.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator()=> numbers.GetEnumerator();
}



