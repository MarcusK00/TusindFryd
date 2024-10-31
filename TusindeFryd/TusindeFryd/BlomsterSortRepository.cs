using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TusindeFryd
{
    public class BlomsterSortRepository
    {
        public List<BlomsterSort> blomsterSorts = new List<BlomsterSort>();

        public void AddToList(BlomsterSort blomsterSort)
        {
            blomsterSorts.Add(blomsterSort);
        }
        // hov hov
        public void RemoveFromList(BlomsterSort blomsterSort)
        {
            blomsterSorts.Remove(blomsterSort);
        }
    }
}
