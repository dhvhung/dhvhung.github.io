using System;
namespace Buoi8
{
	public class Code
	{
		public static void Bai2()
		{
			Dictionary<string, string> info = new Dictionary<string, string>();

            //Thêm 10 phần tử vào danh sách
            info.Add("09123", "Nguyễn Văn A");
            info.Add("08124", "Đỗ Văn B");
            info.Add("07912", "Đào Văn C");
            info.Add("09876", "Phạm Thị D");
            info.Add("06543", "Trần Văn E");
            info.Add("03421", "Lê Văn F");
            info.Add("09765", "Vũ Thị G");
            info.Add("08321", "Ngô Văn H");
            info.Add("05678", "Bùi Thị I");
            info.Add("09124", "Hoàng Văn J");


            //Kiểm tra sự tồn tại của 1 sđt
            string num_check = "09765";
            if (info.ContainsKey(num_check))
                Console.WriteLine("- SĐT: {0} có tồn tại với Họ tên: {1}", num_check, info[num_check]);
            else
                Console.WriteLine("- SĐT: {0} không tồn tại", num_check);

            //Kiểm tra sự tồn tại của 1 họ tên
            string name_check = "Đào Văn C";
            if (info.ContainsValue(name_check))
                Console.WriteLine("\n- Họ tên: {0} có tồn tại", name_check);
            else
                Console.WriteLine("\n- Họ tên: {0} không tồn tại", num_check);

            //Hiển thị danh sách các phần tử
            Console.WriteLine("\n- Hiển thị thông tin danh bạ: ");
            for (int i = 0; i < info.Count; i++)
			{
                Console.WriteLine("{0}. Tên: {1} - Số điện thoại: {2}", i + 1, info.ElementAt(i).Value, info.ElementAt(i).Key);
            }

            //Xoá 1 số điện thoại theo tên
            string name_del = "Bùi Thị I";
            string keyRemove = null;
            foreach (var tmp in info)
            {
                if (tmp.Value == name_del)
                {
                    keyRemove = tmp.Key;
                }
            }
            info.Remove(keyRemove);
            Console.WriteLine("\n- Danh bạ sau khi xoá một số điện thoại theo tên {0}: ", name_del);
            for (int i = 0; i < info.Count; i++)
            {
                Console.WriteLine("{0}. Tên: {1} - Số điện thoại: {2}", i + 1, info.ElementAt(i).Value, info.ElementAt(i).Key);
            }

            //Xoá cả danh sách
            info.Clear();
            Console.WriteLine("\n- Danh bạ sau khi xoá tất cả liên hệ: ");
            for (int i = 0; i < info.Count; i++)
            {
                Console.WriteLine("{0}. Tên: {1} - Số điện thoại: {2}", i + 1, info.ElementAt(i).Value, info.ElementAt(i).Key);
            }
        }
    }
}

