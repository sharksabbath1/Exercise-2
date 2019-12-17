
class Person
{
    
    public string Name { get; set; }
    public int Age { get; set; }

    public float Money { get; set; }


    public string Gender { get; set;}

    public float Deposit (float number)
    {
        return Money = Money +number;
    }
    
    public float Withdraw (float number)
    {
        return Money = Money -number;
    }



}


