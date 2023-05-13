public class Journal{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry,List<Entry> entries){
        entries.Add(entry);

    }


    public void DisplayEntries(){
        for (int i = 0; i < _entries.Count; i++){
            _entries[i].DisplayEntry();
        }
    }
}