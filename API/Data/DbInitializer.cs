using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Data;

public static class DbInitializer
{
    public static async Task Initialize(StoreContext context, UserManager<User> userManager)
    {
        if (!userManager.Users.Any())
        {
            var user = new User { UserName = "bob", Email = "bob@test.com" };

            await userManager.CreateAsync(user, "Pa$$w0rd");
            await userManager.AddToRoleAsync(user, "Member");

            var admin = new User { UserName = "admin", Email = "admin@test.com" };

            await userManager.CreateAsync(admin, "Pa$$w0rd");
            await userManager.AddToRolesAsync(admin, new[] { "Member", "Admin" });
        }

        if (context.Products.Any())
            return;

        var products = new List<Product>
        {
            new Product
            {
                Name = "Apple iPhone 13 Pro",
                Description =
                    "Apple iPhone 13 Pro, 6.1 inçlik Super Retina XDR ekran ve A15 Bionic çip içeren Apple'ın en son amiral gemisi akıllı telefonudur.",
                Price = 46599,
                PictureUrl =
                    "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/iphone-13-pro-family-hero?wid=940&hei=1112&fmt=png-alpha&.v=1631652954000",
                Type = "Akıllı Telefon",
                Brand = "Apple",
                QuantityInStock = 50
            },
            new Product
            {
                Name = "Samsung Galaxy S21 Ultra",
                Description =
                    "Samsung Galaxy S21 Ultra, 6.8 inçlik Dinamik AMOLED ekran ve 108MP ana sensöre sahip dörtlü kamera sistemi ile güçlü bir akıllı telefondur.",
                Price = 19999,
                PictureUrl =
                    "https://productimages.hepsiburada.net/s/54/550/11185810898994.jpg/format:webp",
                Type = "Akıllı Telefon",
                Brand = "Samsung",
                QuantityInStock = 30
            },
            new Product
            {
                Name = "Dell XPS 13",
                Description =
                    "Dell XPS 13, 13.4 inçlik InfinityEdge ekran ve 11. Nesil Intel Core işlemcilerle donatılmış premium bir ultrabook'tur.",
                Price = 35998,
                PictureUrl =
                    "https://www.singular.com.cy/images/detailed/358/6c0baeac-c11a-4510-9e39-cc358110a599.jpg",
                Type = "Dizüstü Bilgisayar",
                Brand = "Dell",
                QuantityInStock = 20
            },
            new Product
            {
                Name = "Apple MacBook Pro",
                Description =
                    "Apple MacBook Pro, 16 inçlik Retina ekran ve 10. Nesil Intel Core işlemcilerle güçlü bir dizüstü bilgisayardır.",
                Price = 34999,
                PictureUrl =
                    "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/mbp14-spacegray-gallery1-202301?wid=2000&hei=1536&fmt=jpeg&qlt=95&.v=1670621031697",
                Type = "Dizüstü Bilgisayar",
                Brand = "Apple",
                QuantityInStock = 10
            },
            new Product
            {
                Name = "Sony WH-1000XM4",
                Description =
                    "Sony WH-1000XM4, olağanüstü ses kalitesine sahip yüksek kaliteli gürültü engelleme özelliklerine sahip üst düzey bir kulaklıktır.",
                Price = 7999,
                PictureUrl =
                    "https://www.sony.com.tr/image/5d02da5df552836db894cead8a68f5f3?fmt=pjpeg&bgcolor=FFFFFF&bgc=FFFFFF&wid=2515&hei=1320",
                Type = "Kulaklık",
                Brand = "Sony",
                QuantityInStock = 40
            },
            new Product
            {
                Name = "HP Spectre x360",
                Description =
                    "HP Spectre x360, 14 inçlik OLED ekran ve 11. Nesil Intel Core işlemcilerle çok yönlü bir 2'si 1 arada dizüstü bilgisayardır.",
                Price = 43999,
                PictureUrl =
                    "https://www.hp.com/ch-de/shop/Html/Merch/Images/c08277622_1750x1285.jpg",
                Type = "Dizüstü Bilgisayar",
                Brand = "HP",
                QuantityInStock = 15
            },
            new Product
            {
                Name = "Xiaomi Redmi Pad",
                Description =
                    "Xiaomi Redmi Pad, 10.1 inçlik IPS LCD ekran ve MediaTek'in Dimensity 1200 çipiyle donatılmış üst seviye bir Android tablettir.",
                Price = 9998,
                PictureUrl =
                    "https://productimages.hepsiburada.net/s/126/550/110000076497632.jpg/format:webp",
                Type = "Tablet",
                Brand = "Xiaomi",
                QuantityInStock = 20
            },
            new Product
            {
                Name = "Samsung Galaxy Tab S7+",
                Description =
                    "Samsung Galaxy Tab S7+, 12.4 inçlik Süper AMOLED ekran ve Snapdragon 865+ işlemciye sahip güçlü bir Android tabletidir.",
                Price = 7840,
                PictureUrl = "https://m.media-amazon.com/images/I/61GR9AZQ7EL.jpg",
                Type = "Tablet",
                Brand = "Samsung",
                QuantityInStock = 10
            },
            new Product
            {
                Name = "Sony PlayStation 5",
                Description =
                    "Sony PlayStation 5, AMD Zen 2 işlemci ve özel RDNA 2 GPU içeren Sony'nin popüler video oyun konsolunun son neslidir.",
                Price = 20299,
                PictureUrl =
                    "https://sharafstore.com/web/image/product.template/1344/image_1024?unique=80f9e41",
                Type = "Oyun Konsolu",
                Brand = "Sony",
                QuantityInStock = 5
            },
            new Product
            {
                Name = "Nintendo Switch OLED Model",
                Description =
                    "Nintendo Switch OLED Model, 7 inçlik OLED ekran ve gelişmiş ses özelliklerine sahip Nintendo'nun popüler hibrit konsolünün yeni bir versiyonudur.",
                Price = 12999,
                PictureUrl = "https://m.media-amazon.com/images/I/61E4b5drxzS.jpg",
                Type = "Oyun Konsolu",
                Brand = "Nintendo",
                QuantityInStock = 8
            },
            new Product
            {
                Name = "Microsoft Surface Pro 7",
                Description =
                    "Microsoft Surface Pro 7, 12.3 inçlik PixelSense ekran ve 10. Nesil Intel Core işlemcilerle çok yönlü bir 2'si 1 arada tablettir.",
                Price = 57502,
                PictureUrl =
                    "https://cdn-dynmedia-1.microsoft.com/is/image/microsoftcorp/MSFT-RWGaM8-Surface-Pro-7-in-Laptop-Mode?scl=1",
                Type = "Tablet",
                Brand = "Microsoft",
                QuantityInStock = 20
            },
            new Product
            {
                Name = "Asus VG248QG",
                Description =
                    "Asus VG248QG, 1920x1080 piksel çözünürlüğe sahip yüksek performanslı 24 inçlik bir monitördür ve 165 Hz yenileme hızı, 0.5 ms tepki süresi ve FreeSync/G-Sync desteği sunar.",
                Price = 4749,
                PictureUrl =
                    "https://images.hepsiburada.net/assets/Bilgisayar/ProductDesc/VG248QG-P_setting_000_1_90_end_500_221104.png",
                Type = "Monitör",
                Brand = "Asus",
                QuantityInStock = 15
            },
            new Product
            {
                Name = "Asus Zenbook 14 OLED UX3402ZA",
                Description =
                    "Asus Zenbook 14 OLED UX3402ZA, 14 inçlik OLED ekrana ve 12. Nesil Intel Core işlemcilere sahip güçlü ve kompakt bir dizüstü bilgisayardır.",
                Price = 20999,
                PictureUrl =
                    "https://dlcdnwebimgs.asus.com/gain/7587b7be-cc5d-405d-8882-4b89ae85ba97/w800",
                Type = "Dizüstü Bilgisayar",
                Brand = "Asus",
                QuantityInStock = 10
            },
            new Product
            {
                Name = "Apple Watch Series 7",
                Description =
                    "Apple Watch Series 7, daha büyük bir Retina ekran ve daha hızlı şarj özelliğine sahip Apple'ın popüler akıllı saatinin son versiyonudur.",
                Price = 9998,
                PictureUrl =
                    "https://www.apple.com/newsroom/images/product/watch/standard/Apple_watch-series7_hero_09142021_big.jpg.large.jpg",
                Type = "Akıllı Saat",
                Brand = "Apple",
                QuantityInStock = 20
            },
            new Product
            {
                Name = "Logitech MX Master 3",
                Description =
                    "Logitech MX Master 3, hassas kaydırma tekerleği ve özelleştirilebilir düğmeleri olan üst düzey bir kablosuz fare.",
                Price = 2849,
                PictureUrl =
                    "https://resource.logitech.com/w_800,c_lpad,ar_1:1,q_auto,f_auto,dpr_1.0/d_transparent.gif/content/dam/logitech/en/products/mice/mx-master-3s-business-wireless-mouse/gallery/mx-master-3s-for-business-gallery-1.png?v=1",
                Type = "Bilgisayar Aksesuarı",
                Brand = "Logitech",
                QuantityInStock = 30
            },
            new Product
            {
                Name = "Canon EOS R5",
                Description =
                    "Canon EOS R5, 45 megapiksel sensöre ve 8K video kaydetme özelliklerine sahip profesyonel sınıf bir aynasız fotoğraf makinesidir.",
                Price = 99975,
                PictureUrl =
                    "https://i1.adis.ws/i/canon/eos-r5_front_rf24-105mmf4lisusm_32c26ad194234d42b3cd9e582a21c99b",
                Type = "Kamera",
                Brand = "Canon",
                QuantityInStock = 3
            },
            new Product
            {
                Name = "Microsoft Xbox Wireless Controller",
                Description =
                    "Microsoft Xbox Kablosuz Kumandası, geliştirilmiş ergonomi ve azaltılmış gecikme ile Microsoft'un popüler oyun kumandasının en son versiyonudur.",
                Price = 2349,
                PictureUrl = "https://m.media-amazon.com/images/I/51JCqvlkqVL.jpg",
                Type = "Oyun Kumandası",
                Brand = "Microsoft",
                QuantityInStock = 15
            },
            new Product
            {
                Name = "Bose QuietComfort 35 II",
                Description =
                    "Bose QuietComfort 35 II, entegre Amazon Alexa ve Google Assistant özelliklerine sahip yüksek kaliteli gürültü engelleme özelliğine sahip bir kulaküstü kulaklıktır.",
                Price = 13390,
                PictureUrl = "https://m.media-amazon.com/images/I/81+jNVOUsJL.jpg",
                Brand = "Bose",
                QuantityInStock = 10
            }
        };

        context.Products.AddRange(products);

        // foreach (var product in products)
        // {
        //     context.Products.Add(product);
        // }

        context.SaveChanges();
    }
}
