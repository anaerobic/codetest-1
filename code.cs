using System;

class Code {
    // Returns "Hello World!"
    public static string HelloWorld() {
        return "Hello World!";
    }

    // Take a single-spaced <sentence>, and capitalize every <n>th word starting with <offset>.
	public static string CapitalizeEveryNthWord(string sentence, int offset, int n) {
                
        var splits = sentence.Split(' ');
        
        string value = String.Empty;
        
        for (int i = 0; i < splits.Length; i++) {
            
            var word = splits[i];
            
            if (i < offset) value += word;
            else {
                var firstChar = word.Substring(0,1);
                
                value += (i % n == 0) ? firstChar.ToUpper() : firstChar;
                
                if (word.Length > 1) {
                    var theRest = word.Substring(1);
                    value += theRest;
                }
            }
            if (i < splits.Length - 1) value += " ";
        }
        return value;
	}
    
    // Determine if a number is prime
    public static bool IsPrime(int n) {
        
        if (n <= 1) return false;
        else if (n == 2) return true;
        else if (n % 2 == 0) return false; 
        
        return huntForPrime(n, 7);
    }
    
    private static bool huntForPrime(int x, int t) {
               
        if (t > 2) {
             if (x != t && x % t == 0) return false;
             
            return huntForPrime(x, t - 2);
        }
        
        return true;
    }
    
    // Calculate the golden ratio.
    // Given two numbers, a and b, the ratio is b / a. 
    // Let c = a + b, then the ratio c / b is closer to the golden ratio.
    // Let d = b + c, then the ratio d / c is closer to the golden ratio. 
    // Let e = c + d, then the ratio e / d is closer to the golden ratio.
    // If you continue this process, the result will trend towards the golden ratio.
    public static double GoldenRatio(double a, double b) {
        
        return derp(a, b, 0);
    }
    
    private static double derp(double a, double b, double? rLast = null) {
        
        var r = b / a;
        if (a != b) {
            if (!rLast.HasValue) rLast = r;
            
            var diff = r > rLast ? r - rLast : rLast - r;
            
            if (diff == 0) {
                return r;
            }
        }
        return derp(b, a + b, r);  
    }
    
    // Give the nth Fibonacci number
    // Starting with 0, 1, 1, 2, ... a Fibonacci number is the sum of the previous two.
    public static int Fibonacci(int n) {
        
        return wat(n);
    }
    
    private static int wat(int n) {
        
        if (n == 1) return 1;
        if (n == 0) return 0;
        
        return wat(n - 1) + wat(n - 2);
    }
    
    // Give the square root of a number
    // Using a binary search algorithm, search for the square root of a given number.
    // Do not use the built-in square root function.
    public static double SquareRoot(double n) {
        
        return test(0, n + 1, n);
    }
    
    private static double test(double low, double high, double n) {

        if (high == low)
            return low;
            
        var mid = low / 2 + high / 2;
        if (mid * mid <= n){
            if (low == mid) 
                return mid;
            return test(mid, high, n);
        }
        else {
            if (high == mid)
                return mid;
            return test(low, mid, n);
        }
    }
}
