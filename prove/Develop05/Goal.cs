public abstract class Goal{
    private int _points;
    private int _totalPoints;
    private string _goalName;
    private string _goalDescription;
    private string _checkBox = "[]";

    public void DisplayScore(){
        Console.WriteLine($"You have {_totalPoints} points.");
    }
    public void SetTotalPoints(int totalPoints){
        _totalPoints = totalPoints;
    }
    public int GetTotalPoints(){
        return _totalPoints;
    }

    public Goal(int points, string goalName, string goalDescription){
        _points = points;
        _goalDescription = goalDescription;
        _goalName = goalName;

    }
    public abstract string ShowGoalList();
    
    public abstract string GetStringRepresentation();
    public abstract Goal CreateGoal(string line);
    public string GetGoalName(){
        return _goalName;
    }
    public abstract string GetGoalType();
    
    public string GetGoalDescription(){
        return _goalDescription;
    }

    public int GetPoints(){
        return _points;
    }
    public abstract bool IsComplete();
    public abstract int RecordEvent();
    public string GetCheckBox(){
        return _checkBox;
    }
    public void SetCheBox(string box){
         _checkBox = box;

    }
    



}