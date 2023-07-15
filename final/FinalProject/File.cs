
public class Files{
    private string _filename;

    public Files(string filename){
        _filename = filename;
    }

    public void SetFilename(string filename){
         _filename = filename;
    }
    public string GetFilename(){
        return _filename;
    }
    public void DeleteFile(string filename){
        File.Delete(_filename);
    }
    public void CreateFile(string filename){
        FileStream fs = File.Create(filename);
    }
    
}