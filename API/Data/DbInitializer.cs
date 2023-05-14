using API.Entities;

namespace API.Data;

public static class DbInitializer
{
    public static void Initialize(StoreContext context)
    {
        if (context.Products.Any()) return;

        var products = new List<Product>
        {
            new Product
            {
                Name = "Apple iPhone 13 Pro",
                Description =
                "The Apple iPhone 13 Pro is the latest flagship smartphone from Apple, featuring a 6.1-inch Super Retina XDR display and A15 Bionic chip.",
                Price = 1299,
                PictureUrl =
                "https://www.apple.com/tr/shop/buy-iphone/iphone-13/iphone-13-pro-siyah-128gb#gallery-image-1",
                Type = "Smartphone",
                Brand = "Apple",
                QuantityInStock = 50
            },
            new Product
            {
                Name = "Samsung Galaxy S21 Ultra",
                Description =
                "The Samsung Galaxy S21 Ultra is a powerful smartphone with a 6.8-inch Dynamic AMOLED display and a quad-camera system featuring a 108MP primary sensor.",
                Price = 1199,
                PictureUrl =
                 "https://images.samsung.com/is/image/samsung/tr-galaxy-s21-ultra-5g-g988-sm-g998bzkgtur-frontphantomblack-368021284?7205​76P​NG",
                Type = "Smartphone",
                Brand = "Samsung",
                QuantityInStock = 30
            },
            new Product
            {
                Name = "Dell XPS 13",
                Description =
                "The Dell XPS 13 is a premium ultrabook with a 13.4-inch InfinityEdge display and 11th Gen Intel Core processors.",
                Price = 1299,
                PictureUrl =
                "https://i.dell.com/is/image/DellContent//content/dam/global-site-design/product_images/dell_client_products/notebooks/xps_notebooks/13_9310/global_spi/notebook-xps-13-9310-laptop-silver-hero-504x350.psd?fmt=jpg&wid=570&hei=400",
                Type = "Laptop",
                Brand = "Dell",
                QuantityInStock = 20
            },
            new Product
            {
                Name = "Apple MacBook Pro",
                Description =
                "The Apple MacBook Pro is a powerful laptop with a 16-inch Retina display and 10th Gen Intel Core processors.",
                Price = 2399,
                PictureUrl = "https://www.apple.com/tr/shop/buy-mac/macbook-pro/14-in%C3%A7-macbook-pro-m1-pro-%C3%A7ip-8-%C3%A7ekirdekli-cpu-ve-14-%C3%A7ekirdekli-gpu-512gb#gallery-image-1",
                Type = "Laptop",
                Brand = "Apple",
                QuantityInStock = 10
            },
            new Product
            {
                Name = "Sony WH-1000XM4",
                Description =
                "The Sony WH-1000XM4 is a high-end pair of noise-cancelling headphones with exceptional sound quality.",
                Price = 349,
                PictureUrl =
                "https://www.sony.com.tr/image/9a6c9f2b8f6c4a2d8a2f5b6e9c9f9b0e?fmt=pjpeg&bgcolor=FFFFFF&bgc=FFFFFF&wid=2515&hei=1320",
                Brand = "Sony",
                Type = "Headphones",
                QuantityInStock = 40
            },
            new Product
            {
                Name = "HP Spectre x360",
                Description =
                "The HP Spectre x360 is a versatile 2-in-1 laptop with a 14-inch OLED display and 11th Gen Intel Core processors.",
                Price = 1399,
                PictureUrl =
                "https://ssl-product-images.www8-hp.com/digmedialib/prodimg/lowres/c06624581.png",
                Type = "Laptop",
                Brand = "HP",
                QuantityInStock = 15
            },
            new Product
            {
                Name = "Google Pixel 6 Pro",
                Description =
                "The Google Pixel 6 Pro is a high-end Android smartphone with a 6.7-inch OLED display and Google's custom Tensor chip.",
                Price = 1099,
                PictureUrl = "https://store.google.com/product/pixel_6_pro?hl=tr#gallery-image-1",
                Type = "Smartphone",
                Brand = "Google",
                QuantityInStock = 25
            },
            new Product
            {
                Name = "Samsung Galaxy Tab S7+",
                Description =
                "The Samsung Galaxy Tab S7+ is a powerful Android tablet with a 12.4-inch Super AMOLED display and a Snapdragon 865+ processor.",
                Price = 849,
                PictureUrl =
                "https://images.samsung.com/is/image/samsung/tr-galaxy-tab-s7-plus-t970-sm-t970nzkatur-frontmysticblack-thumb-368021282?$PD_GALLERY_L_JPG",
                Type = "Tablet",
                Brand = "Samsung",
                QuantityInStock = 10
            },
            new Product
            {
                Name = "Sony PlayStation 5",
                Description =
                "The Sony PlayStation 5 is the latest generation of Sony's popular video game console, featuring an AMD Zen 2 processor and a custom RDNA 2 GPU.",
                Price = 499,
                PictureUrl =
                "https://www.sony.com.tr/image/4a4d4e9a2f8c4b0b8c2f5b6e9c9f9b0e?fmt=pjpeg&bgcolor=FFFFFF&bgc=FFFFFF&wid=2515&hei=1320",
                Type = "Gaming Console",
                Brand = "Sony",
                QuantityInStock = 5
            },
            new Product
            {
                Name = "Nintendo Switch OLED Model",
                Description =
                "The Nintendo Switch OLED Model is a new version of Nintendo's popular hybrid console with a 7-inch OLED display and enhanced audio features.",
                Price = 349,
                PictureUrl =
                "https://www.nintendo.com.tr/content/dam/noa/en_US/hardware/switch/nintendo-switch-oled-model/nintendo-switch-oled-model-white-set/gallery/bundle/nintendo-switch-oled-model-white-set-gallery-01.jpg",
                Type = "Gaming Console",
                Brand = "Nintendo",
                QuantityInStock = 8
            },
            new Product
            {
                Name = "Microsoft Surface Pro 7",
                Description =
                "The Microsoft Surface Pro 7 is a versatile 2-in-1 tablet with a 12.3-inch PixelSense display and 10th Gen Intel Core processors.",
                Price = 749,
                PictureUrl =
                "https://img-prod-cms-rt-microsoft-com.akamaized.net/cms/api/am/imageFileData/RE4sYmY?ver=c3d1&q=90&m=6&h=270&w=270&b=%23FFFFFFFF&l=f&o=t&aim=true",
                Type = "Tablet",
                Brand = "Microsoft",
                QuantityInStock = 20
            },
            new Product
            {
                Name = "LG UltraFine 5K Display",
                Description =
                "The LG UltraFine 5K Display is a high-quality 27-inch monitor with a resolution of 5120x2880 pixels and Thunderbolt 3 connectivity.",
                Price = 1299,
                PictureUrl = "https://www.lg.com/us/images/monitors/md05988112/gallery/desktop-01.jpg",
                Type = "Monitor",
                Brand = "LG",
                QuantityInStock = 7
            },
            new Product
            {
                Name = "Dell XPS 13",
                Description =
                "The Dell XPS 13 is a powerful and compact laptop with a 13.4-inch display and 11th Gen Intel Core processors.",
                Price = 1199,
                PictureUrl =
                "https://i.dell.com/is/image/DellContent//content/dam/global-site-design/product_images/dell_client_products/notebooks/xps_notebooks/13_9310/global_spi/notebook-xps-13-9310-laptop-silver-hero-504x350.psd?fmt=jpg&wid=570&hei=400",
                Type = "Laptop",
                Brand = "Dell",
                QuantityInStock = 12
            },
            new Product
            {
                Name = "Apple Watch Series 7",
                Description =
                "The Apple Watch Series 7 is the latest version of Apple's popular smartwatch, featuring a larger Retina display and faster charging.",
                Price = 399,
                PictureUrl =
                "https://www.apple.com/tr/shop/buy-watch/apple-watch/case-size-yap%C4%B1land%C4%B1rma#gallery-image-1",
                Type = "Smartwatch",
                Brand = "Apple",
                QuantityInStock = 20
            },
            new Product
            {
                Name = "Logitech MX Master 3",
                Description =
                "The Logitech MX Master 3 is a high-end wireless mouse with a precision scroll wheel and customizable buttons.",
                Price = 99,
                PictureUrl =
                "https://www.logitech.com/assets/65536/mx-master-3.png",
                Type = "Computer Accessory",
                Brand = "Logitech",
                QuantityInStock = 30
            },
            new Product
            {
                Name = "Canon EOS R5",
                Description =
                "The Canon EOS R5 is a professional-grade mirrorless camera with a 45-megapixel sensor and 8K video recording capabilities.",
                Price = 3899,
                PictureUrl =
                " https://www.canon-europe.com/media/EOS_R5_01_tcm13-1875148_w2000.png",
                Type = "Camera",
                Brand = "Canon",
                QuantityInStock = 3
            },
            new Product
            {
                Name = "Microsoft Xbox Wireless Controller",
                Description =
                "The Microsoft Xbox Wireless Controller is the latest version of Microsoft's popular gaming controller, with improved ergonomics and reduced latency.",
                Price = 59,
                PictureUrl =
                "https://compass.xbox.com/assets/23/0d/230d52da-bf11-497d-b5fc-faa41d379e25.jpg?n=Xbox-Series-X_Accessories_Hero_1920x1080.jpg",
                Type = "Gaming Controller",
                Brand = "Microsoft",
                QuantityInStock = 15
            },
            new Product
            {
                Name = "Bose QuietComfort 35 II",
                Description =
                "The Bose QuietComfort 35 II is a high-end noise-cancelling headphone with built-in Amazon Alexa and Google Assistant.",
                Price = 299,
                PictureUrl =
                "https://assets.bose.com/content/dam/Bose_DAM/Web/consumer_electronics/global/products/headphones/qc35_ii_wireless_headphones/product_silo_images/qc35_ii_black_EC_hero.psd/_jcr_content/renditions/cq5dam.web.320.320.png",
                Type = "Headphones",
                Brand = "Bose",
                QuantityInStock = 10
            },
        };

        context.Products.AddRange(products);

        // foreach (var product in products)
        // {
        //     context.Products.Add(product);
        // }

        context.SaveChanges();
    }
}
