public class Customer{
    private string _name;
    private string _surname;

    public Customer(string name, string surname){
        _name = name;
        _surname = surname;
    }
    public string GetName(){
        return _name;
    }
    public string GetSurname(){
        return _surname;
    }

    public string GetFullName(){
        return _name+ " "+ _surname;
    }

    public void DisplayFullName(){
        Console.WriteLine($"{_name} {_surname}");
    }
}