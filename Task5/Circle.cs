public class Circle
{
    double _radius;
    const double pi=3.14;
    public Circle(){

    }
    public Circle(double radius){
        _radius = radius;
    }
    public double GetArea(){
        return _radius*_radius*pi;
    }
    public double GetDiameter(){
        return _radius*2;
    }
    public double GetCircumference(){
        return 2*pi*_radius;
    }
    public double GetRadius(){
        return _radius;
    }

}