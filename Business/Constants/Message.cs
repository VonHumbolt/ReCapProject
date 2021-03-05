using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Message
    {
        public static string SuccessfullyAdded = "Araba başarıyla eklendi!";

        public static string CarNameAndPriceError = "Araba ismi minimum 2 harften oluşmalı ve günlük fiyatı 0 dan büyük olmalıdır.";

        public static string ErrorReturnDateNull = "Araba şu anda kiralanmış durumda!";

        public static string SuccessfullyRented = "İşlem başarılı, Araba kiralandı!";

        public static string CarImageCountIsFull = "Arabanın resim sayısı en fazla 5 olabilir.";

        public static string AuthorizationDenied = "Yetkilendirme Başarısız!";

        public static string UserRegistered = "Kayıt olundu";

        public static string UserNotFound = "Kullanıcı bulunamadı";

        public static string PasswordError = "Password Hatalı";

        public static string SuccessfulLogin = "Giriş Başarılı";

        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";

        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
