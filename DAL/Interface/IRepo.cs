using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IRepo<CLASS,ID,RET>
    {
       
           
            List<CLASS> Get();
            CLASS Get(ID id);
            bool Delete(ID id);
            RET Add(CLASS obj);
            RET update(CLASS obj);
        
    }
}
