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
                Price = 129900,
                PictureUrl =
                "https://www.apple.com/newsroom/images/product/iphone/standard/Apple_iPhone-13-Pro_Midnight-Sierra-Blue_Gold_09142021.jpg.large.jpg",
                Type = "Smartphone",
                Brand = "Apple",
                QuantityInStock = 50
            },
            new Product
            {
                Name = "Samsung Galaxy S21 Ultra",
                Description =
                "The Samsung Galaxy S21 Ultra is a powerful smartphone with a 6.8-inch Dynamic AMOLED display and a quad-camera system featuring a 108MP primary sensor.",
                Price = 119900,
                PictureUrl =
                "https://images.samsung.com/is/image/samsung/assets/tr/smartphones/galaxy-s21-ultra-5g/gallery/galaxy-s21-ultra-5g_gallery_kv-02.jpg",
                Type = "Smartphone",
                Brand = "Samsung",
                QuantityInStock = 30
            },
            new Product
            {
                Name = "Dell XPS 13",
                Description =
                "The Dell XPS 13 is a premium ultrabook with a 13.4-inch InfinityEdge display and 11th Gen Intel Core processors.",
                Price = 129900,
                PictureUrl =
                "https://www.dell.com/en-us/shop/dell-laptops/xps-13-laptop/spd/xps-13-9310-laptop/xn9310cto210s",
                Type = "Laptop",
                Brand = "Dell",
                QuantityInStock = 20
            },
            new Product
            {
                Name = "Apple MacBook Pro",
                Description =
                "The Apple MacBook Pro is a powerful laptop with a 16-inch Retina display and 10th Gen Intel Core processors.",
                Price = 239900,
                PictureUrl = "https://www.apple.com/v/macbook-pro-16/e/images/overview/hero__fghq4ngcqvmq_large_2x.jpg",
                Type = "Laptop",
                Brand = "Apple",
                QuantityInStock = 10
            },
            new Product
            {
                Name = "Sony WH-1000XM4",
                Description =
                "The Sony WH-1000XM4 is a high-end pair of noise-cancelling headphones with exceptional sound quality.",
                Price = 34900,
                PictureUrl =
                "https://www.sony.com/image/3155b262daaecc06cd3876c5039358b7?fmt=pjpeg&wid=660&bgcolor=F1F5F9&bgc=F1F5F9",
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
                "https://www8.hp.com/us/en/images/consumer/laptops-tablets/laptops/hp-spectre-x360-laptop-14t-eb000-8sl16av-1-1600x1600.jpg",
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
                PictureUrl = "https://store.google.com/product/pixel_6_pro?hl=en-US",
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
                "https://images.samsung.com/is/image/samsung/tr-galaxy-tab-s7-plus-t975-sm-t975nznamid-261277864?$720_576_PNG$",
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
                "https://www.playstation.com/en-us/images/ps5-tout-desktop-and-mobile-01-ps5-en-us-07sep20_tcm215-364613.png",
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
                "https://www.nintendo.com/content/dam/noa/en_US/hardware/nintendo_switch_oled_model/images/switch-oled-01-screens-tv-v2.jpg",
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
                "https://www.microsoft.com/en-us/p/surface-pro-7/8n17j0m5zzqs?activetab=pivot%3aoverviewtab",
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
                PictureUrl = "https://www.lg.com/us/images/monitors/md07000019/gallery/desktop-01.jpg",
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
                "https://www.dell.com/en-us/shop/dell-laptops/xps-13-laptop/spd/xps-13-9310-laptop/xn9310cto220s",
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
                "https://www.apple.com/newsroom/images/product/watch/standard/Apple_watch_series7_09142021.jpg.large.jpg",
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
                "https://www.logitech.com/content/dam/logitech/en/products/mice/mx-master-3/mx-master-3-hero.png",
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
                "https://www.canon.com.cy/-/media/cysite/product-stories/product-pages/eos-r5/overview/eos-r5_silver_front-product-image_left-image.png",
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
                "https://www.microsoft.com/en-us/p/xbox-wireless-controller/8vfgjvx71s0p?activetab=pivot%3aoverviewtab",
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
                "https://assets.bose.com/content/dam/Bose_DAM/Web/consumer_electronics/global/products/headphones/quietcomfort_35_ii/product_silo_images/qc35ii_black_EC_hero_1800x1200.png/_jcr_content/renditions/cq5dam.web.1200.1200.png",
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
