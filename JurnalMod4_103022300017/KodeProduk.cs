namespace JurnalMod4_103022300017
{
    class KodeProduk
    {
        public static string getKodeProduk(string kelurahan)
        {
            switch (kelurahan.ToLower())
            {
                case "laptop":
                    return "E100";
                case "smartphone":
                    return "E101";
                case "tablet":
                    return "E102";
                case "headset":
                    return "E103";
                case "keyboard":
                    return "E104";
                case "mouse":
                    return "E105";
                case "printer":
                    return "E106";
                case "monitor":
                    return "E107";
                case "smartwatch":
                    return "E108";
                case "kamera":
                    return "E109";
                default:
                    return "Kode Produk Tidak Ditemukan";
            }
        }
    }
}
