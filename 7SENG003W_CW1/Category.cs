using System;
namespace _7SENG003W_CW1
{
    public class Category
    {
        private string name;

        public Category(string n)
        {
            name = n;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string n)
        {
            name = n;
        }
    }
}
