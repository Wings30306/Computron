using System;

namespace Computron
{
    class TodoList : IDisplayable
    {
        public string[] Todos
        { get; private set; }

        private int nextOpenIndex;

        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        public void Add(string todo)
        {
            Todos[nextOpenIndex] = todo;
            nextOpenIndex++;
            if (nextOpenIndex >= Todos.Length)
            {
                nextOpenIndex = 0;
            }
        }

        public void Display()
        {
            foreach (string item in Todos)
            {
                if (String.IsNullOrEmpty(item))
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void Reset()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }
    }
}