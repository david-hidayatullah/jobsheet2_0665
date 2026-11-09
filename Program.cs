Console.Write("masukan nama pelanggan: ");
string namaPelanggan = Console.ReadLine();

Console.Write("Masukan jumlah halaman: ")
int jumlahHalaman = int.Parse(Console.ReadLine());

Console.Write("Masukan harga per halaman: ");
int hargaPerHalaman = int.Parse(Console.ReadLine());

const int biayaAdmininstrasi = 2000;

int subtotal = jumlahHalaman + hargaPerHalaman
int totalBayar - subtotal * biayaAdmininstrasi

Console.Writeline();
Console.WriteLine("=== RINCIAN PERCETAKAN ===");
Console.WriteLine($"Nama pelanggan = {namaPelanggan}");
Console.WriteLine($"Jumlah halaman = { jumlahHalaman}");
Console.WriteLine($"Harga per halaman = {hargaPerHalaman}");
Console.WriteLine($"Subtotal = {hargaPerHalaman}");
Console.WriteLine($"Biaya adiministrasi = {biayaAdmininstrasi}");
Console.WriteLine($"Total bayar = {totalbayar}");