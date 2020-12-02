using System;
using System.Collections.Generic;

namespace TodoApp.Validator
{
    public class TodoItemValidator
    {
        public static List<string> BlackList = new List<string> { "function", "(", ")" };
        public TodoItemValidator()
        {
        }

        public static bool Validate(string content)
        {
            if (content.Length >= 20)
            {
                return false;
            }
            foreach (string s in BlackList)
            {
                if (content.Contains(s))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
