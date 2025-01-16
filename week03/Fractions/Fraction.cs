

public class Fractions{
    private int _numTop;
    private int _numBottom;

    public Fractions(){
        _numTop=1;
        _numBottom=1;
    }

    public Fractions(int wholeNumber){
        _numTop= wholeNumber;
        _numBottom = 1;
    }

    public Fractions(int top, int bottom){
        _numTop= top;
        _numBottom= bottom;
    }

    public string GetFractionString(){
        string form = $"{_numTop}/{_numBottom}";
        return form;
    }

    public double GetDecimalValue() {
        double num = (double)_numTop/_numBottom;
        return num;
    }
}