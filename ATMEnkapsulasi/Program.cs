Rekening rekening = new Rekening("12345678");

bool ulang = true;
int jumlah;
string pilihan;

while (ulang)
{
    Console.WriteLine("Menu");
    Console.WriteLine("1. Display Info \n2. Setor Uang \n3. Tarik Uang \n4. Keluar");
    Console.WriteLine("Input pilihan: ");
    pilihan = Console.ReadLine();

    switch (pilihan)
    {
        case "1":
            rekening.DisplayInfo();
                break;
        case "2":
            Console.WriteLine("Masukkan jumlah uang: Rp");
            jumlah = int.Parse(Console.ReadLine());
            rekening.SetorUang(jumlah);
            break;
        case "3":
            Console.WriteLine("Masukkan jumlah uang: Rp ");
            jumlah = int.Parse(Console.ReadLine());
            rekening.TarikUang(jumlah);
            break;
        case "4":
            Console.WriteLine("Terimakasih sudah Menggunakan layanan kami");
            ulang = false;
            break;
        default:
            Console.WriteLine("Pilihan Tidak Valid");
            break;
    
    }
}

class Rekening
{
    private string _noRekening;
    private int _saldo;

    public int Saldo
    {
        get { return _saldo; }
        set
        {
            if (value < 0) Console.WriteLine("Saldo tidak boleh negatif!");
            else _saldo = value;
        }
    }

    public string NoRekening
    {
        get { return _noRekening; }
    }

    public Rekening(string no_rekening)
    {
        _noRekening = no_rekening;
        _saldo = 100000;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Menampilkan Info...");
        Console.WriteLine($"Saldo saat ini{NoRekening} ");
        Console.WriteLine($"Saldo saat ini: Rp {Saldo}");
    }

    public void SetorUang (int jumlah)
    {
        if (jumlah < 0)
        {
            Console.WriteLine("Jumlah uang tidak boleh negatif!!");
        }
        else
        {
            Saldo += jumlah;
            Console.WriteLine("Berhasil setor uang");
            Console.WriteLine($"Saldo saat ini: Rp {Saldo}");
        }
    }

    public void TarikUang (int jumlah)
    {
        if (jumlah > Saldo)
        {
            Console.WriteLine("Saldo tidak mencukupi!!");
        }
        else
        {
            Saldo -= jumlah;
            Console.WriteLine("Tarik Uang berhasil");
            Console.WriteLine($"Saldo saat ini: Rp {Saldo}");
        }

    }

}