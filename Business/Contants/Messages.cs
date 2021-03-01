using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Contants
{
    public static class Messages
    {
        public static string BrandNameInvalid = "Marka ismi geçersiz.";
        public static string BrandAdded = "Marka bilgileri eklendi.";
        public static string BrandDeleted = "Marka bilgileri silindi.";
        public static string BrandUpdated = "Marka bilgileri güncellendi.";
        public static string BrandListed = "Markalar listelendi";
        public static string CarAdded = "Araç bilgileri eklendi.";
        public static string CarDeleted = "Araç bilgileri silindi.";
        public static string CarUpdated = "Araç bilgileri güncellendi.";
        public static string CarNameInvalid = "Araç ismi geçersiz";
        public static string CarListed = "Araçlar listelendi.";
        public static string ColorAdded = "Renk bilgileri eklendi.";
        public static string ColorDeleted = "Renk bilgileri silindi.";
        public static string ColorUpdated = "Renk bilgileri güncellendi.";
        public static string ColorListed = "Renkler listelendi.";
        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomerListed = "Müşteriler listelendi.";
        public static string RentalAdded = "Yeni liralama eklendi.";
        public static string RentalDeleted = "Kiralama silindi.";
        public static string RentalUpdated = "Kiralama güncellendi.";
        public static string RentalListed = "Tüm kiralamalar listelendi.";
        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string UserListed = "Kullanıcılar listelendi.";
        public static string ReturnDateNull = "Dönüş tarihi belirsiz.";
        public static string CarImageAdded = "Araç resmi eklendi.";
        public static string CarImageDeleted = "Araç resmi silindi.";
        public static string CarImageListed = "Araç resimleri listelendi.";
        public static string CarImageUpdated = "Araç resmi güncellendi.";
        public static string ImageLimitExceded = "Resim limiti aşıldı.";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string ProductNameAlreadyExists = "Ürün ismi zaten mevcut";
    }
}
