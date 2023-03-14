using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTask.Abstractions.Services
{
    public interface IBaseService
    {
        void Create();
        void Show();
        void GetById();
        void Delete();


    }
}
