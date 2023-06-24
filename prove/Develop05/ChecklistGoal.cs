public class ChecklistGoal:Goal{
    private int _bonusPoints;
    private int _nComplete;

    private int _nToComplete;
    private string _goalType = "Checklist Goal";

    public override string GetGoalType(){
        return _goalType;
    }
    public ChecklistGoal(int points, string goalName, string goalDescription,int bonusPoints, int nToCompleted):base(points,goalName,goalDescription){
        _bonusPoints = bonusPoints;
        _nToComplete = nToCompleted;
    }
    public void SetNComplete(int number){
        _nComplete = number;
    }

    public override string ShowGoalList(){
        return $"{base.GetCheckBox()} {base.GetGoalName()} ({base.GetGoalDescription()} -- Currently Completed: {_nComplete}/{_nToComplete})";
    }

    public override string GetStringRepresentation(){
        return $"{_goalType}:{base.GetGoalName()},{base.GetGoalDescription()},{base.GetPoints()},{_bonusPoints},{_nToComplete},{_nComplete}";

    }
    public override Goal CreateGoal(string details){
       string[] parts = details.Split(":");

        string[] part2 = parts[1].Split(",");
        string goalName = part2[0];
        string goalDescription = part2[1];
        int goalPoints = int.Parse(part2[2]);
        int bonusPoints = int.Parse(part2[3]);
        int nToComplete = int.Parse(part2[4]);
        ChecklistGoal cGoal = new ChecklistGoal(goalPoints, goalName, goalDescription,bonusPoints, nToComplete);
        cGoal.SetNComplete(int.Parse(part2[5]));
        if (cGoal.IsComplete()){
            cGoal.SetCheBox("[X]");
        }
        return cGoal;
    }

    public override bool IsComplete(){
        if(_nComplete == _nToComplete) {
            return true;
        }else{
       return false;
        }
    }
    public override int RecordEvent(){
        _nComplete += 1;
        if(IsComplete()){
            
            base.SetCheBox("[X]");
            return base.GetPoints() + _bonusPoints;
            
        }else{
            return base.GetPoints();
        }
    }

}