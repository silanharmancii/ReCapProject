using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string UserAdded = "Müşteri eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string UserNameInvalid = "Müşteri ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Arabalar listelendi";
        public static string UsersListed = "Müşteriler listelendi";
        public static string CarNoRent = "Araba kiralanamıyor";
        public static string CarRent = "Arabayı kiralayabilirsiniz.";
        internal static string CarImageLimitExceeded = "5'ten fazla resim eklenemez.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered="Kayıt yapıldı";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Şifre hatalı";
        public static string UserAlreadyExists="Kullanıcı zaten var";
        public static string AccessTokenCreated="Access token oluşturuldu";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string AddedCarImage = "Araba resmi eklendi.";
        public static string DeletedCarImage = "Araba resmi silindi";
        public static string FailedCarImageAdd = "Resim ekleme başarısız oldu";
        public static string NotFoundCreditCard = "Kredi Karti bulunamadi";
        public static string SuccessPay = "Odeme Basarili";
        public static string InsufficientBalance = "Yetersiz Bakiye";
        public static string SuccessAdded = "Ekleme Basarili.";
        public static string SuccessUpdated = "Guncelleme Basarili.";
        public static string SuccessDeleted = "Silme basarili.";
        public static string SuccessListed = "Listeleme Basarili.";
        public static string CarIsNotFound = "Araç bulunamadı";
        public static string CarUpdated = "Araç güncellendi";
    }
}
