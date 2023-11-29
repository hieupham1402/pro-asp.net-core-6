namespace PartyInvites.Models
{
    // Đây là một class tĩnh (static class) chứa dữ liệu khách mời và các phương thức để quản lý dữ liệu.
    public static class Repository
    {
        // Dữ liệu khách mời được lưu trữ trong một danh sách (List).
        private static List<GuestResponse> responses = new();

        // Thuộc tính Responses trả về một IEnumerable chứa danh sách các phản hồi từ khách mời.
        public static IEnumerable<GuestResponse> Responses => responses;

        // Phương thức AddResponse được sử dụng để thêm một phản hồi mới vào danh sách.
        public static void AddResponse(GuestResponse response)
        {
            // In thông tin phản hồi ra console (điều này có thể được loại bỏ trong ứng dụng thực tế).
            Console.WriteLine(response);

            // Thêm phản hồi vào danh sách.
            responses.Add(response);
        }
    }
}
