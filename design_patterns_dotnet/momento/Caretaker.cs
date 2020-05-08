using System.Collections.Generic;

/**
 * @author: UMAIR QAYYUM
 * 
 */

namespace design_patterns_dotnet.momento
{
    // The list of Objects that have the history from where we can restore contents
    public class Caretaker
    {
        private List<Momento> states;

        public Caretaker()
        {
            states = new List<Momento>();
        }

        public void Push(Momento state)
        {
            states.Add(state);
        }

        public Momento Pop()
        {
            Momento lastState = null;
            int lastIndex = states.Count - 1;

            if (states.Count > 0)
            {
                lastState = states[lastIndex];
                states.Remove(lastState);
            }
            return lastState;
        }
    }
}
