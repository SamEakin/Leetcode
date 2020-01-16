namespace RomanNumerals
{
    public class Converter
    {
        int digit; // loop placeholder
        char[] numeral; // character array roman numeral ['X', 'I', 'V]

        public Converter(string s){
            this.numeral = s.ToCharArray();
            this.digit = 0;
        }

        public int RomanToInt(){
            int output = 0;
            while (this.digit < this.numeral.Length){ // loop through characters -->
                output += CheckNext();    
            }
            return output;
        }

        private int CheckNext(){
            char current = this.numeral[this.digit];
            char next = ' ';
            if(this.digit+1 != this.numeral.Length) {
                next = this.numeral[digit+1];
            }
            switch(current){
                case 'I':
                    if(next.Equals('V')){ 
                        this.digit += 2;
                        return 4; // IV = 4
                    }
                    else if (next.Equals('X')){ 
                        this.digit += 2;
                        return 9; // IX = 9
                    }
                    this.digit += 1;
                    return 1; // I = 1
                case 'V':                
                    this.digit += 1;
                    return 5; // V = 5
                case 'X':
                    if(next.Equals('L')){ 
                        this.digit += 2;
                        return 40; // XL = 40
                    }
                    else if (next.Equals('C')){ 
                        this.digit += 2;
                        return 90; // XC = 90
                    }
                    this.digit += 1;
                    return 10; // X = 10
                case 'L':
                    this.digit += 1;
                    return 50; // L = 50              
                case 'C':
                    if(next.Equals('D')){
                        this.digit += 2;
                        return 400; // CD = 400
                    }
                    else if (next.Equals('M')){
                        this.digit += 2;
                        return 900; // CM = 900
                    }
                    this.digit += 1;
                    return 100; // C = 100             
                case 'D':
                    this.digit += 1;
                    return 500; // D = 500               
                case 'M':
                    this.digit += 1;
                    return 1000; // M = 1000               
                default:
                    this.digit += 1;
                    return 0; // default 
            } ///switch
        } ///CheckList()
    } ///class
} ///namespace
