public class Word{
       private string _word;

    public string Hide(){
            //string hiddenWord = "";
            string hidden = "";
            string[] word = _word.Split("");
            for(int i = 0; i< word.Count();i++){
                foreach(char alpha in word[i]){
                hidden = hidden + "_";
                }
        }
        return _word = hidden;
        
    }
    public void SetWord(string word){
        _word = word;
    }
    public string GetWord(){
        return _word ;
    }


    public void DisplayWord(){
        Console.WriteLine(_word);
    }

    public string toString(){
        return _word.ToString();
    }

    public Word(string word){
        _word = word;

    }





}   