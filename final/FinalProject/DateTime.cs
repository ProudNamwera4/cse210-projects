public class DateAndTime{
    private string _date;
    private DateTime _time;

    public void DisplayTime(){

    }
    public void DisplayDateAndTime(){

    }
    public DateTime GetTime(){
        return _time;
    }
    public string GetDate(){
        return _date;
    }
    public void SetDate(){
        DateTime startTime = DateTime.Now;
        _date = startTime.ToString();
    }

    
}