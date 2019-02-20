using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTransformTask
{
    //it was possible to create a static class (with some changes)
    class TextTransformer : IEnumerable
    {
        private string str = null;

        public TextTransformer(string str)
        {
            this.str = str;
        }
        public TextTransformer()
        {
        }

        //transforms input text into uppercase text
        public string ToUpper()
        {
            if (str != null && str != "")
                return str.ToUpper();
            else
                //converts null(or empty) strings into something valuable
                return "Your string is empty or points to null";
        }
        //transforms input text into uppercase text(using iterator)
        public string CustomToUpper()
        {
            if (str != null && str != "")
            {
                string res = null;
                foreach (var character in str)
                {
                    res += char.ToUpper(character);
                }
                return res;
            }
            else
                return "Your string is empty or points to null";
        }

        public override string ToString()
        {
            return str;
        }

        //to be able to return all characters using foreach.
        public IEnumerator GetEnumerator()
        {
            return str.GetEnumerator();
        }
    }
}
