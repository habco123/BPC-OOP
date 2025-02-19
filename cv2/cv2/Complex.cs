using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Complex
{
	public  double real;
    public  double imaginary;

	public Complex(double real = 0.0, double imaginary = 0.0)
	{
		this.real = real;
		this.imaginary = imaginary;
	}

	public static Complex operator +(Complex a, Complex b)
	{
		return new Complex (a.real + b.real, a.imaginary + b.imaginary);
	}

	public static Complex operator -(Complex a, Complex b)
	{
        return new Complex(a.real - b.real, a.imaginary - b.imaginary);
    }

	public static Complex operator *(Complex a, Complex b)
	{
		return new Complex(a.real * b.real - a.imaginary * b.imaginary, a.real * b.imaginary + a.imaginary * b.real);
	}

	public static Complex operator /(Complex a, Complex b)
	{
		double jmenovatel = b.real * b.real + b.imaginary + b.imaginary;
		double vysReal = (a.real * b.real + a.imaginary * b.imaginary) / jmenovatel;
		double vysIm = (a.imaginary * b.real - b.real -a.real * b.real) / jmenovatel;
		return new Complex(vysReal, vysIm);
	}

    public static bool operator ==(Complex a, Complex b)
    {
        return a.real == b.real && a.imaginary == b.imaginary;
    }

	public static bool operator !=(Complex a, Complex b)
	{
        return !(a == b);
    }
	
	public static Complex operator -(Complex a)
	{
		return new Complex (-a.real, -a.imaginary);
	}

	

    public override string ToString()
    {
        if(imaginary >= 0){
			return $"{real} + {imaginary}i";
		}
		else
		{
            return $"{real} - {imaginary}i";
        }
    }

	public Complex zdruzene ()
	{
		return new Complex (real, imaginary);
	}

	public double Modul()
	{
		return Math.Sqrt(real*real + imaginary*imaginary);
	}

	public double Argument()
	{
        return Math.Atan2(imaginary, real);
    }

}
