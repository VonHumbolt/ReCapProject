using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Message
    {
        public static string SuccessfullyAdded = "Araba başarıyla eklendi!";

        public static string CarNameAndPriceError = "Araba ismi minimum 2 harften oluşmalı ve günlük fiyatı 0 dan büyük olmalıdır.";

        public static string ErrorReturnDateNull = "Araba şu anda kiralanmış durumda!";

        public static string SuccessfullyRented = "İşlem başarılı, Araba kiralandı!";
    }
}
