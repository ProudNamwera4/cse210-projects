public class Scripture{
    private Random _random = new Random();
    private Reference _reference;
    private List<Word> _verseWords = new List<Word>();
    private List<int> _generatedNumbers = new List<int>();

    public bool IsCompletelyHidden(){
        
        return true;
    }
    public void HideWords(){
        
        int random;
         
        do{  
            random = _random.Next(0,_verseWords.Count);
        }while (_generatedNumbers.Contains(random));

        _generatedNumbers.Add(random);
        int index = _generatedNumbers.IndexOf(_generatedNumbers.Last());
        if (index > _verseWords.Count){
            System.Environment.Exit(0);
        }


            for(int i = 0; i< _verseWords.Count;i++){
            
                string hidden = _verseWords[random].Hide();
                _verseWords[random].SetWord(hidden);
            
            }
            
    }

    public void GetRenderedText(){
        Console.Write($"{_reference.toString()}:");
        for (int i = 0; i < _verseWords.Count; i++){

        Console.Write($" {_verseWords[i].GetWord()}");
    }
    }

    public Scripture(string scripture, Reference reference){
        _reference = reference;
       
            string[] scriptureWords= scripture.Split();
            for(int i = 0; i< scriptureWords.Length; i++){
                Word word = new Word(scriptureWords[i].ToString());

                _verseWords.Add(word);
        }
    }

}