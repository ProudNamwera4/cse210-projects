public class Activity{
    private string _activityType;
    private string _startMessage;
    private string _endMessage;
    private int _duration;
    private List<string> _duplicatePrompts= new List<string>();
    


    public List<string> GetDuplicatePromptsList(){
            return _duplicatePrompts;
    }
    public string GetActivityType(){
            return _activityType;
        }

    public string GetStartMessage(){
        return $"Welcome to the {_activityType}\n \n" + _startMessage;
    }

    public string GetEndMessage(){
        return _endMessage;
    }

    public void SetDuration(int duration){
        _duration = duration;

    }
    public int GetDuration(){
        return _duration;
    }

    public Activity(string activityType,string startMessage, string endMessage){
        _activityType = activityType;
        _startMessage = startMessage;
        _endMessage = endMessage;
    }

    public void PauseCountDown(int timer){
        for(int i = timer; i > 0;i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void PauseSpinner(int timer){
        List<string> animations = new List<string>();
        animations.Add("|");
        animations.Add("\\");
        animations.Add("-");
        animations.Add("/");
        animations.Add("|");
        animations.Add("\\");
        animations.Add("-");
        animations.Add("/");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timer);

        int i =0;
        while (DateTime.Now < endTime){
            string a = animations[i];
            Console.Write(a);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if (i >= animations.Count){
                i=0;
            }
        }
    }

    public void GetReady(){
        Console.WriteLine("Get Ready...");
    }
    public void ShowEndMessage(){
        Console.WriteLine(_endMessage);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityType}.");
        
    }


}