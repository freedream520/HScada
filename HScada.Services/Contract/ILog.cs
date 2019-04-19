using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HScada.Services.Contract
{
    public interface ILog
    {
        void Info(string mesg);
        void Fualt(string mesg);
        void Debug(string mesg);
        void Waring(string mesg);
    }
}
