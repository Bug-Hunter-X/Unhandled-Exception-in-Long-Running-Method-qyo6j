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
            try
            {
                if (i == 5)
                {
                    //Simulate an unexpected exception
                    throw new Exception("Something went wrong!");
                }
                i++;
            }
            catch (Exception ex)
            {
                //Log the exception
                Console.WriteLine($"An error occurred: {ex.Message}");
                //Handle the exception appropriately. You could retry, use a fallback, etc.
                // For this example, we just continue.
            }
        }
    }
} 