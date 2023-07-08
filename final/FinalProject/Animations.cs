public class Animations{
    private int _startTime;
    private int _endTime;
    private int _duration;

    public Animations(int startTime, int endTime){
        _startTime = startTime;
        _endTime = endTime;


    }
    public void PauseSpinner(int duration){
        _duration = duration;
    }
    public void PauseCountDown(int timer){
        _duration = timer;
    }


}