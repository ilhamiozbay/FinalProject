using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static readonly string ProductAdded = "Ürün eklendi";
        public static readonly string ProductNameInvalid = "Ürün ismi geçersiz";
        public static readonly string MaintenanceTime = "Sistem bakımda";
        public static readonly string ProductsListed = "Ürünler listelendi";
        public static readonly string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün eklenebilir";
        public static readonly string ProductUpdated = "Ürün güncellendi";
        public static readonly string ProductNameAlreadyExists = "Aynı isimde ürün eklenemez";
        public static readonly string CategoriesListed = "Kategoriler listelendi";
        public static readonly string CategoryLimitExceeded = "Kategori limiti aşıldığı için yeni ürün eklenemez";
        public static readonly string AuthorizationDenied = "Yetkiniz yok";
        public static readonly string AccessTokenCreated="Token oluşturuldu";
        public static readonly string UserNotFound="Kullanıcı bulunamadı";
        public static readonly string PasswordError="Parola hatalı";
        public static readonly string SuccessfulLogin="Giriş başarılı";
        public static readonly string UserRegistered="Kullanıcı oluşturuldu";
        public static readonly string UserAlreadyExists="Kullanıcı zaten var";
    }
}
