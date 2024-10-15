﻿namespace Solid.App
{
    public abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Arama Yapıldı");
        }

        public abstract void TakePhoto();
    }
    public  class IPhone : BasePhone
    {
        public override void TakePhoto()
        {
            Console.WriteLine("Fotoğraf Çekildi");
        }
        
    }

    public class Nokia : BasePhone
    {
        public override void TakePhoto()
        {
            throw new NotImplementedException();
        }
    }
}
