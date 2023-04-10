using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Parent
    {
        protected internal string testAttribute;
    }
    public class child : Parent {
        public child()
        {
            Parent p = new Parent();
            p.testAttribute = "any value you want";
        }
    
    }
}
