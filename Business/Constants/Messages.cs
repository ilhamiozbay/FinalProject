using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün eklenebilir";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductNameAlreadyExists = "Aynı isimde ürün eklenemez";
        public static string CategoriesListed = "Kategoriler listelendi";
        public static string CategoryLimitExceeded = "Kategori limiti aşıldığı için yeni ürün eklenemez";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string AccessTokenCreated="Token oluşturuldu";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Parola hatalı";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string UserRegistered="Kullanıcı oluşturuldu";
        public static string UserAlreadyExists="Kullanıcı zaten var";
    }
}
