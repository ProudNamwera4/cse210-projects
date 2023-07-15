public class Animations{
    private int _startTime;
    private int _endTime;
    private int _duration;
    
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
    public void PauseCountDown(int timer){
        for(int i = timer; i > 0;i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }


}