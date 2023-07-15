public class BankAccount: Customer{
    private int _accountNumber;
    private string _accountType;
    private float _totalAmount;
    private float _cartPrize;

    public BankAccount(string name, string surname,int accountNumber, float totalAmount): base(name,surname){
        _accountNumber = accountNumber;
        _totalAmount = totalAmount;
    }
    public void SetCartPrize(float cartPrize){
        _cartPrize = cartPrize;
    }
    public float GetCartPrize(){
        return _cartPrize;
    }

    public void Pay(){
        float newTotal = _totalAmount - _cartPrize;
        SetTotalAmount(newTotal);
        Console.WriteLine($"Your payed items costed ${_cartPrize}. You now have ${newTotal} left in your accound!");
    }
    public float GetTotalAmount(){
        return _totalAmount;
    }


    public void DisplayAmount(){
        Console.WriteLine($"Total amount: {_totalAmount}");

    }
    public void ShowCustomerBankingDetails(){
        Console.WriteLine($"Customer :{base.GetFullName()} /nAccount Number: {_accountNumber} /nAccount Total: {_totalAmount}");

    }
    public void SetAccNumber( int accNumber){
        _accountNumber = accNumber;

    }
    public void SetAccType( string accType){
        _accountType = accType;
    }
    public void SetTotalAmount(float accTotal){
        _totalAmount = accTotal;

    }

}