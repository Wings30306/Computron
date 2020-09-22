namespace Computron
{
    using System;

    internal class Program
    {
        internal static void Main(string[] args)
        {
            TodoList tdl = new TodoList();
            tdl.Add("Invite friends");
            tdl.Add("Buy decorations");
            tdl.Add("Party");
            tdl.Add("Eat");
            tdl.Add("Sleep");
            tdl.Add("Code");

            tdl.Display();
            tdl.Reset();
            tdl.Display();

            PasswordManager pm = new PasswordManager("iluvpie", true);
            pm.Display();
            pm.Reset();
            pm.Display();
            pm.ChangePassword("", "ILuvCake");
            pm.Display();
        }
    }
}
