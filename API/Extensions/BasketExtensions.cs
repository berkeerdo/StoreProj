using API.DTOs;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class BasketExtensions
    {
        public static BasketDto MapBasketToDto(this Basket basket)
        {
            if (basket == null)
            {
                return null; // veya hata yönetimi için uygun bir işlem yapabilirsiniz
            }


            var basketDto = new BasketDto
            {
                Id = basket.Id,
                BuyerId = basket.BuyerId,
                Items = new List<BasketItemDto>()
            };

            if (basket.Items != null)
            {
                foreach (var item in basket.Items)
                {
                    if (item.Product != null)
                    {
                        var basketItemDto = new BasketItemDto
                        {
                            ProductId = item.ProductId,
                            Name = item.Product.Name,
                            Price = item.Product.Price,
                            PictureUrl = item.Product.PictureUrl,
                            Type = item.Product.Type,
                            Brand = item.Product.Brand,
                            Quantity = item.Quantity
                        };

                        basketDto.Items.Add(basketItemDto);
                    }
                }
            }


            return basketDto;
        }

        public static IQueryable<Basket> RetrieveBasketWithItems(this IQueryable<Basket> query, string buyerId)
        {
            return query.Include(i => i.Items)
            .ThenInclude(p => p.Product)
            .Where(x => x.BuyerId == buyerId);
        }

    }

}
