﻿namespace MVC_TemplateApp.DTOs
{
    public class BasketDto
    {
        public Guid Id { get; set; }
        public string BuyerId { get; set; }
        public List<BasketItemDto> Items { get; set; } = new();
    }
}
