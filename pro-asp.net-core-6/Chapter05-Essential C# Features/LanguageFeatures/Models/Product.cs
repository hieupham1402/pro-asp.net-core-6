namespace LanguageFeatures.Models
{
    // Định nghĩa một lớp Product để biểu diễn thông tin về sản phẩm.
    public class Product
    {
        public string Name { get; set; } = string.Empty;

        public decimal? Price { get; set; }

        // Phương thức static GetProducts để trả về một mảng các sản phẩm.
        public static Product?[] GetProducts()
        {
            // Tạo một đối tượng Product (kayak) và thiết lập các thuộc tính của nó.
            Product kayak = new Product()
            {
                Name = "Kayak",
                Price = 275M
            };

            // Tạo một đối tượng Product (lifejacket) và thiết lập các thuộc tính của nó.
            Product lifejacket = new Product()
            {
                Name = "Lifejacket",
                Price = 48.95M
            };

            // Trả về một mảng các sản phẩm, bao gồm kayak, lifejacket và một sản phẩm null.
            return new Product?[] { kayak, lifejacket, null };
        }
    }
}
