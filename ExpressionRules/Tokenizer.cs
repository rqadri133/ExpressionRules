using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionRules
{
    public class Tokenizer
    {
         List<string> expressionRule;
         string inputStr;
         // this could be done by stack way
         // by matching pop sequence
         // also by Regex rules
        public Tokenizer(string input)
        {
            
            inputStr = input;
            expressionRule = new List<string>() { "{[()]}", "{[]}", "[()]", "()" , "()[]{}" , "[]" , "{}" }; 
            

        }

        public bool VerifyExpression()
        {
                bool _found = false;
                if(expressionRule.Contains(inputStr))
                {
                    _found = true;
                    
                }

            return _found;
         
        }
            
           
    

        


    }
}
