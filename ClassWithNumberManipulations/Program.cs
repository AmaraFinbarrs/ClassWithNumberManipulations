//create a c# class that represents a numeric value as a field and provides several methods to manipulate that numeric value.

class Number
{
    private int value; 

    public void SetValue(int val)
    {
        this.value = val;
    }

    public double GetValue()
    {
        return value;
    }

    public bool IsZero()
    {
        return value == 0;
    }

    public bool IsPositive()
    {
        //if the value is +ve, it is greater than zero
        //else it is less then zero
        return value > 0;
    }

    public bool IsNegative()
    {
        return value < 0;
    }

    public bool IsOdd()
    {
        //if value % 2 is 1, it is odd
        //else it is not odd, but is even.
        return value % 2 != 0;
       
    }

    public bool IsEven()
    {
        return value % 2 == 0;
    }

    public bool IsPrime()
    {
        if (value == 1 || value < 0)
        {
            return false; //1 is not a prime number and negative numbers are not prime numbers
        }
        else
        {
            int factors = 0;
            for (int i = 1; i <= value; i++)
            {
                if (value % i == 0)
                {
                    factors++;
                }
            }
            if (factors == 2)
            {
                return true;
            }
            return false;
        }

    }

    public static int Power(int basenumber, int exponent, bool recursive = false)
    {
       // if recursion is true
       //using for loop up to the exponent number
       //return number*MethodName()
       int e = exponent;
        int power= basenumber;

        if (recursive == true)
        {
            if (exponent == 0)
            {
                return 1;
            }
            else
            {
                return basenumber * Power(basenumber, exponent - 1, recursive);
            }
        }

        for (int i = 1; i < e; i++)
        {
            power *= basenumber;
        }
        return b;

    }

    public int GetCountOfDigit()
    {
        int val = value;
        //using while loop
        //we need to divide the argument by 10
        //increment the counter
        //if the value returns 0, then we return the counter
        int iter = 0;
        while (val != 0)
        {
            val = val / 10;
            ++iter;
        }
        return iter;
    }

    public int GetSumOfDigit()
    {
        int sum = 0;
        int val = value;
        while (val != 0)
        {
            sum = sum + val % 10; // the modulus is used to retrieve the last digit
            val = val / 10; // the division is used to remove the last digit completely
        }
        return sum;
    }
    public int GetReverse()
    {
        int rev_num = 0;
        int val = value;
        while(val > 0)
        {
            rev_num = rev_num * 10 + val % 10; //multiplication is used to add a last digit of zero(0)
            val = val / 10;
        }
        return rev_num;
    }
    public string ToWords()
    {
        //initialize local variables
        int val = value;
        int rem;
        string num_words;
        string full_word = null;

        if (value == 0)
        {
            return "zero";
        }
        while (val != 0)
        {
            rem = val % 10;
            val = val / 10;

            switch (rem)
            {
                case 0: num_words = " Zero "; break;
                case 1: num_words = " One "; break;
                case 2: num_words = " Two "; break;
                case 3: num_words = " Three "; break;
                case 4: num_words = " Four "; break;
                case 5: num_words = " Five "; break;
                case 6: num_words = " Six "; break;
                case 7: num_words = " Seven "; break;
                case 8: num_words = " Eight "; break;
                case 9: num_words = " Nine "; break;
                default: num_words = "NaN"; break;
            }

            full_word = num_words + full_word;
        }

        return full_word;
    }

    public bool IsArmstrong()
    {
        int val = value;
        int rem;
        int sum = 0;
        int noOfDigit = GetCountOfDigit();
        while (val != 0)
        {
            rem = val % 10;
            val = val / 10;
            sum = sum + Power(rem, noOfDigit);

        }
        return value == sum;
    }

    public string GetFibonacci()
    {
        int val = value;
        //since there are always two numbers, lets assign those numbers
        int num1 = 0; //first number
        int num2 = 1;//second number
        int result=0; // sum of the two numbers
        string resultWords = "0, 1"; //base cases
        string zero;

        while (result <= val)
        {
            if (val != 0 && val != 1)
            {
                result = num1 + num2;
                if (result >= val) { break; }
                resultWords = resultWords + ", " + result.ToString();
                num1 = num2;
                num2 = result;
            }
            else if (val == 0)
            {
                zero = "0";
                return zero;
            }
            else if (val == 1)
            {
                return resultWords;
            }
        }
        return resultWords;
    }

    public bool isPalindrome()
    {
        int val = value;
        int reverseVal = GetReverse();
        return val == reverseVal;
    }

}

class Program
{
    static void Main()
    {
          Number number = new Number();
          number.SetValue(371); //you can set any integer value
          System.Console.WriteLine("Value: " + number.GetValue()); //Output: 371
          System.Console.WriteLine("IsZero: " + number.IsZero()); //Output: False
          System.Console.WriteLine("IsPositive: " + number.IsPositive()); //Output: True
          System.Console.WriteLine("IsNegative: " + number.IsNegative()); //Output: False
          System.Console.WriteLine("IsOdd: " + number.IsOdd()); //Output: True
          System.Console.WriteLine("IsEven: " + number.IsEven()); //Output: False
          System.Console.WriteLine("IsPrime: " + number.IsPrime()); //Output:False
          System.Console.WriteLine("GetCountOfDigits: " + number.GetCountOfDigit()); //Output: 3
          System.Console.WriteLine("GetSumOfDigits: " + number.GetSumOfDigit()); //Output: 11
          System.Console.WriteLine("GetReverse: " + number.GetReverse()); //Output: 173
          System.Console.WriteLine("ToWords: " + number.ToWords()); //Output:Three Seven One
          System.Console.WriteLine("IsArmstrong: " + number.IsArmstrong()); //Output: True
          System.Console.WriteLine("GetFibonacci: " + number.GetFibonacci()); //Output: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233
          System.Console.WriteLine("isPalindrome: " + number.isPalindrome()); //Output: False
          System.Console.WriteLine("Power: " + Number.Power(4,3,true)); //Output: False

        System.Console.ReadKey();
       
    }
}
