public class ListingActivity: Activity{
    private List<string> _items = new List<string>();
    private string _prompt;
    private List<string> _listingPrompts = new List<string>();

     public ListingActivity(string actType, string sMsg, string eMsg):base(actType,sMsg,eMsg){
        
    }

    public void AddListingPrompts(){
        _listingPrompts.Add("--- Who are people that you appreciate? ---");
        _listingPrompts.Add("--- What are personal strengths of yours? ---");
        _listingPrompts.Add("--- Who are people that you have helped this week ---?");
        _listingPrompts.Add("--- When have you felt the Holy Ghost this month? ---");
        _listingPrompts.Add("--- Who are some of your personal heroes? ---");
    }
    public void ShowRandomListingPrompt(){
        AddListingPrompts();
        Random random = new Random();
        int randomNum = 0;
        string prompt = "";
        do{
            randomNum = random.Next(_listingPrompts.Count());
            prompt = _listingPrompts[randomNum];
        }while(GetDuplicatePromptsList().Contains(prompt));
        GetDuplicatePromptsList().Add(prompt);
        Console.Write($"\n>{prompt}");
       
    }

    public void AddItemToList(string item){
        _items.Add(item);
    }

    public int ComputeNumberListTotal(){
        return _items.Count;
    }
    
}

