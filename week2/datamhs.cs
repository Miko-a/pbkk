using System;
using System.Collections.Generic;

class Mahasiswa
{
    public string Nama { get; set; }
    public string Nrp { get; set; }
    public string Prodi { get; set; }
    public double IPK { get; set; }

    public Mahasiswa(string nama, string nrp, string prodi, double ipk)
    {
        Nama = nama;
        Nrp = nrp;
        Prodi = prodi;
        IPK = ipk;
    }

    static void Main()
    {
        List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();
        bool berjalan = true;

        while (berjalan)
        {
            TampilkanMenu();
            Console.Write("Pilih menu: ");
            string pilihan = Console.ReadLine() ?? "";

            switch (pilihan)
            {
                case "1":
                    TambahMahasiswa(daftarMahasiswa);
                    break;
                case "2":
                    TampilkanMahasiswa(daftarMahasiswa);
                    break;
                case "3":
                    CariMahasiswa(daftarMahasiswa);
                    break;
                case "4":
                    HapusMahasiswa(daftarMahasiswa);
                    break;
                case "5":
                    berjalan = false;
                    Console.WriteLine("Program selesai.");
                    break;
                default:
                    Console.WriteLine("Pilihan menu tidak valid.");
                    break;
            }

            if (berjalan)
            {
                Console.WriteLine("Tekan Enter untuk melanjutkan...");
                Console.ReadLine();
            }
        }
    }

    static void TampilkanMenu()
    {
        Console.Clear();
        Console.WriteLine("=== DATA MAHASISWA ===");
        Console.WriteLine("1. Tambah mahasiswa");
        Console.WriteLine("2. Tampilkan semua mahasiswa");
        Console.WriteLine("3. Cari mahasiswa");
        Console.WriteLine("4. Hapus mahasiswa");
        Console.WriteLine("5. Keluar");
    }

    static void TambahMahasiswa(List<Mahasiswa> daftarMahasiswa)
    {
        Console.Write("Masukkan nama mahasiswa: ");
        string nama = Console.ReadLine() ?? "";
        Console.Write("Masukkan NRP mahasiswa: ");
        string nrp = Console.ReadLine() ?? "";
        Console.Write("Masukkan prodi mahasiswa: ");
        string prodi = Console.ReadLine() ?? "";
        double ipk = BacaIpk();

        daftarMahasiswa.Add(new Mahasiswa(nama, nrp, prodi, ipk));
        Console.WriteLine("Data mahasiswa berhasil ditambahkan.");
    }

    static double BacaIpk()
    {
        while (true)
        {
            Console.Write("Masukkan IPK mahasiswa (0.00 - 4.00): ");
            string input = (Console.ReadLine() ?? "").Replace(',', '.');
            if (double.TryParse(input, System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture, out double ipk)
                && ipk >= 0 && ipk <= 4)
            {
                return ipk;
            }

            Console.WriteLine("IPK harus berupa angka antara 0.00 dan 4.00.");
        }
    }

    static void TampilkanMahasiswa(List<Mahasiswa> daftarMahasiswa)
    {
        if (daftarMahasiswa.Count == 0)
        {
            Console.WriteLine("Belum ada data mahasiswa.");
            return;
        }

        Console.WriteLine("\n=== DAFTAR MAHASISWA ===");
        for (int i = 0; i < daftarMahasiswa.Count; i++)
        {
            Mahasiswa mahasiswa = daftarMahasiswa[i];
            Console.WriteLine($"{i + 1}. Nama: {mahasiswa.Nama}, NRP: {mahasiswa.Nrp}, " +
                $"Prodi: {mahasiswa.Prodi}, IPK: {mahasiswa.IPK:F2}");
        }
    }

    static void CariMahasiswa(List<Mahasiswa> daftarMahasiswa)
    {
        Console.Write("Masukkan nama atau NRP yang dicari: ");
        string kataKunci = (Console.ReadLine() ?? "").Trim();
        List<Mahasiswa> hasil = daftarMahasiswa.FindAll(mahasiswa =>
            mahasiswa.Nama.Contains(kataKunci, StringComparison.OrdinalIgnoreCase) ||
            mahasiswa.Nrp.Contains(kataKunci, StringComparison.OrdinalIgnoreCase));

        if (hasil.Count == 0)
        {
            Console.WriteLine("Mahasiswa tidak ditemukan.");
            return;
        }

        foreach (Mahasiswa mahasiswa in hasil)
        {
            Console.WriteLine($"Nama: {mahasiswa.Nama}, NRP: {mahasiswa.Nrp}, " +
                $"Prodi: {mahasiswa.Prodi}, IPK: {mahasiswa.IPK:F2}");
        }
    }

    static void HapusMahasiswa(List<Mahasiswa> daftarMahasiswa)
    {
        Console.Write("Masukkan NRP mahasiswa yang akan dihapus: ");
        string nrp = (Console.ReadLine() ?? "").Trim();
        Mahasiswa? mahasiswa = daftarMahasiswa.Find(item => item.Nrp.Equals(nrp, StringComparison.OrdinalIgnoreCase));

        if (mahasiswa == null)
        {
            Console.WriteLine("Mahasiswa tidak ditemukan.");
            return;
        }

        daftarMahasiswa.Remove(mahasiswa);
        Console.WriteLine("Data mahasiswa berhasil dihapus.");
    }
}