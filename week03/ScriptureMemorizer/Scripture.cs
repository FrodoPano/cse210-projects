
using System.Runtime.CompilerServices;

public class Scripture{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text){
        _reference = reference;
    }

    public void HideRandomWords(int numberToHide){

    }

    public string GetDisplayText(){
        return null;
    }

    public bool IsCompletelyHidden(){
        return true;
    }
}