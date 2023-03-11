using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    
    public Fraction()
    { /* Constructor that has no parameters that initializes the number to 1/1. */
        // Set variables to 1/1 by default
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    { /* Constructor that has one parameter for the top and that initializes the denominator to 1. So that if you pass in the number 5, the fraction would be initialized to 5/1. */
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    { /* Constructor that has two parameters, one for the top and one for the bottom */
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    { /* A method called GetFractionString that returns the fraction in the form 3/4 */
        // This is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{_top}/{_bottom}"; // the fraction in 3/4 form
        return text;
    }

    public double GetDecimalValue()
    { /* A method called GetDecimalValue that returns a double that is the result of dividing the top number by the bottom number */
        // This is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)_top / (double)_bottom; // return the fraction in 0.75 form
    }

}