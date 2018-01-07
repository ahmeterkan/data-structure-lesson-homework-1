using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Otomasyonu
{
    public interface IQueue
    {
        void Insert(Musteri o);
        Musteri Remove();
        Musteri Peek();
        Boolean IsEmpty();
    }
}
