﻿namespace BlazorASPHostedApp.Shared
{
    [Serializable]
    public class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
