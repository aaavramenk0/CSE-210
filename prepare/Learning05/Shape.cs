public abstract class Shape
{
    string _color;

    public string GetColor() {
        return _color;
    }

    public void SetColor(string color) {
        _color = color;
    }

    public Shape(string color) {
        SetColor(color);
    }

    public abstract double GetArea();
}