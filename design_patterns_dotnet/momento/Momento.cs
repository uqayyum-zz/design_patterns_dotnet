/**
 * @author: UMAIR QAYYUM
 * 
 */

namespace design_patterns_dotnet.momento
{
    // The class that has the current contents of the object .
    public class Momento
    {
        public string content { get; }

        public Momento(string content)
        {
            this.content = content;
        }
    }
}
