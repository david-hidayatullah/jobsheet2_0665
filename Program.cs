Console.Write("masukan nama pelanggan: ");
string namaPelanggan = Console.ReadLine();

Console.WriteLine("masukan nama dokumen");
string NamaDokumen = Console.ReadLine();

Console.Write("Masukan jumlah halaman: ");
int jumlahHalaman = int.Parse(Console.ReadLine());

Console.Write("Masukan harga per halaman: ");
int hargaPerHalaman = int.Parse(Console.ReadLine());

const int biayaAdministrasi = 2000;

int subtotal = jumlahHalaman * hargaPerHalaman;
int totalBayar = subtotal + biayaAdministrasi;

Console.WriteLine();
Console.WriteLine("=== RINCIAN PERCETAKAN ===");
Console.WriteLine($"Nama pelanggan = {namaPelanggan}");
Console.WriteLine($"Nama Dokumen   = {NamaDokumen}");
Console.WriteLine($"Jumlah halaman = { jumlahHalaman}");
Console.WriteLine($"Harga per halaman = {hargaPerHalaman}");
Console.WriteLine($"Subtotal = {subtotal}");
Console.WriteLine($"Biaya Administrasi = {biayaAdministrasi}");
Console.WriteLine($"Total Bayar = {totalBayar}");