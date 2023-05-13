public class Entry{
    public string _date;
    public int _userChoice;
    public string _prompt;
    public string _userResponse;

    public void DisplayMenu(){
    Console.WriteLine("\nPlease select one of the following choices:");
    Console.WriteLine($"1. Write\n2. Display \n3. Load \n4. Save \n5. Quit");

    }
    public string GetCurrentDate(){
        DateTime now = DateTime.Now;
        _date = now.ToString("d/M/yyyy");
        return _date;
    }



    public void DisplayEntry(){
        Console.WriteLine($"{_date} - Prompt: {_prompt} \n{_userResponse}");
    }

    public string FormatEntry(){
        string formatedEntry = $"{_date} - Prompt: {_prompt} \n{_userResponse}";
        return formatedEntry;
    }


}