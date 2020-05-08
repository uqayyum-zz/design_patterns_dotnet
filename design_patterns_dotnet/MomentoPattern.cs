using design_patterns_dotnet.momento;
using System;

/**
 * @author: UMAIR QAYYUM
 * 
 */

namespace design_patterns_dotnet
{
    public static class MomentoPattern
    {
        public static void TestMomentoFlow()
        {
            Originator editor = new Originator();
            Caretaker history = new Caretaker();

            editor.content = "a";
            history.Push(editor.createState());

            editor.content = "b";
            history.Push(editor.createState());

            editor.content = "c";

            Console.WriteLine(editor.content);
            
            editor.restore(history.Pop());
            Console.WriteLine(editor.content);

            editor.restore(history.Pop());
            Console.WriteLine(editor.content);

            editor.restore(history.Pop());
            Console.WriteLine(editor.content);
        }
    }
}
