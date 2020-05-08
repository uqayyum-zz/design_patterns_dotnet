/**
 * @author: UMAIR QAYYUM
 * 
 */

namespace design_patterns_dotnet.momento
{
    //The Object that holds the information and the object for which we want to resstore and save the state for.
    public class Originator
    {
        public string content { get; set; }

        public Momento createState()
        {
            return new Momento(content);
        }

        public void restore(Momento state)
        {
            // To block the undo functions when reach the beginning
            this.content = (state == null) ? this.content : state.content;
        }
    }
}
