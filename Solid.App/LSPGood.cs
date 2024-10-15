using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.SLPBad
{
    public interface ITakePhoto
    {
        void TakePhoto();
    }
    public abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Arama Yapıldı");
        }

    }
    public class IPhone : BasePhone, ITakePhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("Foto Çekildi");
        }
    }

    public class Nokia : BasePhone
    {
    }
}
