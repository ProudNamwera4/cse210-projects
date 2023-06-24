public class EternalGoal:Goal{

    private string _goalType = "Eternal Goal";
    public override string GetGoalType(){
        return _goalType;
    }

    public EternalGoal(int points,string goalName, string goalDescription):base(points,goalName, goalDescription){

    }

    public override string ShowGoalList(){
        return $"{base.GetCheckBox()} {base.GetGoalName()} ({base.GetGoalDescription()})";
    }

    public override string GetStringRepresentation(){
        return $"{_goalType}:{base.GetGoalName()},{base.GetGoalDescription()},{base.GetPoints()}";

    }
    public override Goal CreateGoal(string details){
       string[] parts = details.Split(":");

        string[] part2 = parts[1].Split(",");
        string goalName = part2[0];
        string goalDescription = part2[1];
        int goalPoints = int.Parse(part2[2]);
        EternalGoal EGoal = new EternalGoal(goalPoints,goalName,goalDescription);
        return EGoal;
    }
     public override int RecordEvent(){
        return base.GetPoints();
    }

    public override bool IsComplete(){
        return false;
    }



}