public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int i = 0;
        while (i < 10)
        {
            //Simulate some work
            Thread.Sleep(100);
            if (i == 5)
            {
                //Simulate an unexpected exception
                throw new Exception("Something went wrong!");
            }
            i++;
        }
    }
}