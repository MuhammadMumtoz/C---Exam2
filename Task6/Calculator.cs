public class Calculator
{
    long N { get; set; }
    double A { get; set; }
    double B { get; set; }
    int C { get; set; }
    int D { get; set; }
    public long Factorial(long N)
    {
        if (N==1 || N==0){
            return 1;
        }
        else{
            return N*Factorial(N-1);
        }
    }
    public double Multiple(double A, double B){
        return A*B;
    }
    public double Division(int C, int D){
        var Ddouble = Convert.ToDouble(D);
        var Cdouble = Convert.ToDouble(C);
        double result = Cdouble/Ddouble;
        return result;
    }
}