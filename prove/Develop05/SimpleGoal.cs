public class SimpleGoal:Goal{

    private string _goalType = "Simple Goal";
    public override bool IsComplete(){
        return true;
    }

    public override string GetGoalType(){
        return _goalType;
    }

    public SimpleGoal(int points, string goalName, string goalDescription):base(points,goalName,goalDescription){

    }

    public override int RecordEvent(){
        base.SetCheBox("[X]");
        return base.GetPoints();
        
    }
    public void CreateSimpleGoal(){

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
        SimpleGoal simpleGoal = new SimpleGoal(goalPoints,goalName,goalDescription);
        return simpleGoal;
    }
}