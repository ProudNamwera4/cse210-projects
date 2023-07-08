public class BankAccount: Customer{
    private int _accountNumber;
    private string _accountType;
    private float _totalAmount;

    public BankAccount(string name, string surname,int accountNumber, float totalAmount): base(name,surname){
        _accountNumber = accountNumber;
        _totalAmount = totalAmount;
    }
    public void ShowAmountPayed(){

    }
    public void DisplayAmount(){

    }
    public void ShowCustomerBankingDetails(){
        
    }
}