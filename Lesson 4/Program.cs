using HomeWork_4;

class Program
{
    static void Main(string[] args)
    {
        Counter counter = new Counter();
        Handler1 handler1 = new Handler1();
        Handler2 handler2 = new Handler2();
        counter.Notify += handler1.Message;
        counter.Notify += handler2.Message;
        counter.Count();
    }
}

