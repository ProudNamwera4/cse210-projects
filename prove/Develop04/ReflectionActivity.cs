public class ReflectionActivity: Activity{
    private List<string> _prompts = new List<string>();
    private List<string> _reflectionPrompts= new List<string>();
    //private List<string> _duplicatePrompts= new List<string>();

    public ReflectionActivity(string actType, string sMsg, string eMsg):base(actType,sMsg,eMsg){
        
    }

    public void AddReflectionPrompts(){
        _reflectionPrompts.Add("Why was this experience meaningful to you?");
        _reflectionPrompts.Add("Have you ever done anything like this before?");
        _reflectionPrompts.Add("How did you get started?");
        _reflectionPrompts.Add("How did you feel when it was complete?");
        _reflectionPrompts.Add("What made this time different than other times when you were not as successful?");
        _reflectionPrompts.Add("What is your favorite thing about this experience?");
        _reflectionPrompts.Add("What could you learn from this experience that applies to other situations?");
        _reflectionPrompts.Add("What did you learn about yourself through this experience?");
        _reflectionPrompts.Add("How can you keep this experience in mind in the future?");
    }

    public void AddPrompts(){
        _prompts.Add("--- Think of a time when you stood up for someone else. ---");
        _prompts.Add("--- Think of a time when you did something really difficult. ---");
        _prompts.Add("--- Think of a time when you helped someone in need. ---");
        _prompts.Add("--- Think of a time when you did something truly selfless. ---");
    }

    public void ShowRandomPrompt(){
        AddPrompts();
        Random random = new Random();
        int randomNum = 0;
        string prompt = "";
        do{
            randomNum = random.Next(_prompts.Count());
            prompt = _prompts[randomNum];
        }while(GetDuplicatePromptsList().Contains(prompt));
        GetDuplicatePromptsList().Add(prompt);
        Console.WriteLine(_prompts[randomNum]);

    }

    public void ShowRandomReflectionPrompts(){
        AddReflectionPrompts();
        Random random = new Random();
        int randomNum = 0;
        string prompt = "";
        do{
            randomNum = random.Next(_reflectionPrompts.Count());
            prompt = _reflectionPrompts[randomNum];
        }while(GetDuplicatePromptsList().Contains(prompt));
        GetDuplicatePromptsList().Add(prompt);
        Console.Write($"\n>{prompt}");
        PauseSpinner(10);
    }



}