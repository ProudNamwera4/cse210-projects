public class PromptGenerator{
    List<int> numbers = new List<int>();
    public string Prompt(){
        string prompt1 = "What was the best part of my day?";
        string prompt2 = "Who was the most interesting person I interacted with today?";
        string prompt3 = "How did I see the hand of the Lord in my life today?";
        string prompt4 = "What was the strongest emotion I felt today?";
        string prompt5 = "If I had one thing I could do over today, what would it be?";


        Random rnd = new Random();
        if (numbers.Count >= 5){
            numbers.Clear();
        }
        int num; 
        do{
            num = rnd.Next(1,6);
            
        }while (numbers.Contains(num));
                
            
        
        
        if (num == 1){
            numbers.Add(num);
            return prompt1;
           
        }else if (num ==2){
             numbers.Add(num);
            return prompt2;
        }else if(num == 3){
             numbers.Add(num);
            return prompt3;
        }else if(num == 4){
             numbers.Add(num);
            return prompt4;
        }else if(num == 5){
            numbers.Add(num);
            return prompt5;
        }else{
            return "Enter Anything else you wish to add.";
        }
    }
   

}