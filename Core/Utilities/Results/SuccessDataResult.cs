using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
   public class SuccessDataResult<T> : DataResult<T> 
    {
        public SuccessDataResult(T data , string message): base(data,true,message) //  data ve mesaj ver
        {

        }

        public SuccessDataResult(T data): base(data,true)  //  data ver. Mesaj göndermek istemez isek. Sadece data ve true döner
        {
               
        }

        public SuccessDataResult(string message): base(default,true,message) // mesaj  ver
        {

        }

        public SuccessDataResult(): base(default,true) // hiç parametre verme. 
        {

        }
    }
}
