using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpressionRules;
namespace ExpressionRuleTest
{
    /*   Input: s = "()"
Output: true
Example 2:
Input: s = "()[]{}"
Output: true
Example 3:
Input: s = "(]"
Output: false
Example 4:
Input: s = "([)]"
Output: false
Example 5:
Input: s = "{[]}"
Output: true
*/

    [TestClass]
    public class ExpressionTest
    {
        [TestMethod]
        public void CheckParenthesis()
        {
            string s = "()";
            Tokenizer tokenizer = new Tokenizer(s);
            bool found = tokenizer.VerifyExpression();

            Assert.IsTrue(found);




        }

        [TestMethod]
        public void CheckParenthesisCurlySqaures()
        {
            string s = "()[]{}";
            Tokenizer tokenizer = new Tokenizer(s);
            bool found = tokenizer.VerifyExpression();

            Assert.IsTrue(found);



        }

        [TestMethod]
        public void CheckParenthesisSquare()
        {
            string s = "(]";
            Tokenizer tokenizer = new Tokenizer(s);
            bool found = tokenizer.VerifyExpression();

            Assert.IsFalse(found);



        }


        [TestMethod]

        public void CheckParenthesisWrongOrder()
        {
            string s = "([)]";
            Tokenizer tokenizer = new Tokenizer(s);
            bool found = tokenizer.VerifyExpression();

            Assert.IsFalse(found);



        }

        [TestMethod]
        public void CheckParenthesisRightOrder()
        {
            string s = "{[]}";
            Tokenizer tokenizer = new Tokenizer(s);
            bool found = tokenizer.VerifyExpression();

            Assert.IsTrue(found);



        }



    }
}
