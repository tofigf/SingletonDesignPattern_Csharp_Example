
//new Example();
//new Example();
//new Example();
//new Example();
//new Example();

Example ex1 = Example.GetInstance;
Example ex2 = Example.GetInstance;
Example ex3 = Example.GetInstance;
Example ex4 = Example.GetInstance;
Example ex5 = Example.GetInstance;
Example ex6 = Example.GetInstance;
Example ex7 = Example.GetInstance;
Example ex8 = Example.GetInstance;

class Example
{
    private Example()
    {
        Console.WriteLine($"{nameof(Example)} object created.");
    }
    static Example _example;
    static Example()
    {
        _example = new Example();   
    }
   
    public static Example GetInstance
    {
        get
        {
            #region 1.  way
            //if (_example == null)
            //    _example = new Example();
            //return _example;
            #endregion
            #region 2. way
            return _example;
            #endregion

        }
    }
}