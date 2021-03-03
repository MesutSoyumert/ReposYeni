using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // Bu class ebebeyn görevine sahiptir
    // bu yüzden interface olarak tanımlamalıyız
    // interface isimlerini I ile başlat
    // operasyonel işlemlerde genellikle interface kullanırız
    // Interface'ler referans tutsun ve bütün kredi işlemlerin yapması zorunlu olsun diye kullanılır
    // Interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız
    // bütün kredi türlerinde ödeme planı vardır ama kredi türlerinin uygulamaya yönelik kodları farklıdır
    // Projede loglama yapmak isterseniz interface kullanılır
    // veritabanına, text file'a, sms gönderme, e-mail gönderme buna örnektir

    interface IKrediManager
    {
        void Hesapla();
        void BiSeyYap();
    }
}
