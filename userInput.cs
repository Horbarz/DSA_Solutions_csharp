using System.Collections.Generic;

namespace csharpFundamentals{
    //write a class that can accept user input of any data type and can add item to 
    //a class and return d input
    public class NumericInput: userInput
    {
        public override void addInput(char i){
            if(char.IsDigit(i)){
                list.Add(i);
            }
        }
    }

    public class userInput
    {
        public List<char> list= new List<char>();
        public virtual void addInput(char i){
            list.Add(i);
        }

        public string getInput(){
            var r = "";
            foreach(var x in list){
                r+=x;
            }
            return r;
        }
        
    }

}