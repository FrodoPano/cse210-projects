
public class Comment {
    private string _text;
    private string _user;

    public Comment(string text, string user){
        _user = user;
        _text = text;
    }

    public string CommenterName(){
        return _user;
    }

    public string GetText(){
        return _text;
    }

    public string GetDisplayText(){
        return $"{_user}: {_text}";
    }

}