using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings
{
    public class RemoveAllOccurencesOfDuplicateString
    {
        //This Method will remove all occurances of a duplicate string. For example if the input list is {"Hello","World","Hello"} then it will return {"Hello"}
        //This is different from LINQ function distinct() because it only removes the duplicates
        public List<string> RemoveDuplicates(List<string> duplicates)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            for (int i = 0; i < duplicates.Count; i++)
            {
                duplicates.Distinct().ToList();
                string item = duplicates[i];
                if (!keyValuePairs.Keys.Contains(item))
                {
                    keyValuePairs.Add(item, i.ToString());
                }
                else
                {
                    keyValuePairs.Remove(item);
                    duplicates.RemoveAll(c => c == item);
                }
            }
            return duplicates;
        }
    }
}
