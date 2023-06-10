public class BreathingActivity: Activity{
    private string _breatheIn;
    private string _breatheOut;

     public BreathingActivity(string breathIn, string breathOut,string actType, string sMsg, string eMsg):base(actType,sMsg,eMsg){
        _breatheIn = breathIn;
        _breatheOut = breathOut;
    }

    public void StartBreathingSequence(){
        Console.Write($"\n \n{_breatheIn}...");
        PauseCountDown(4);
        Console.Write($"\n{_breatheOut }...");
        PauseCountDown(6);
    }

}