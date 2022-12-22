using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Web.Models.Dtos
{
    public class OrderDto
    {
        [DisplayName("Ad")]
        [Required(ErrorMessage ="{0} alanı boş bırakılmamalıdır.")]
        public string Firstname { get; set; }

        [DisplayName("Soyad")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalıdır.")]
        public string Lastname { get; set; }

        [DisplayName("Adres")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalıdır.")]
        public string Address { get; set; }

        [DisplayName("Şehir")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalıdır.")]
        public string City { get; set; }

        [DisplayName("Telefon Numarası")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalıdır.")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalıdır.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Kartın üzerindeki Ad ve Soyad")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalıdır.")]
        public string CardName { get; set; }

        [DisplayName("Kart Numarası")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalıdır.")]
        public string CardNumber { get; set; }

        [DisplayName("Kartın Geçerlilik Tarihi Ay")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalıdır.")]
        public string ExpirationMonth { get; set; }

        [DisplayName("Kartın Geçerlilik Tarihi Yıl")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalıdır.")]
        public string ExpirationYear { get; set;}

        [DisplayName("Kartın Arkasındaki 3 Haneli Güvenlik Numarası")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalıdır.")]
        public string Cvc { get; set; }
        public CardDto CardDto { get; set; }

    }
}
