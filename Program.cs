using System.Diagnostics;

class main()
{
    //103022300083
    public static void Main(string[] args)
    {
        
        pemrosesData test = new pemrosesData();
        int terbesar = test.DapatkanNilaiTerbesar(10, 30, 22);
        DapatkanNilaiTerbsear();

    }
}

class pemrosesData {

    static void DapatkanNilaiTerbesar<T>(T data, T data1, T data2) {
        dynamic a = data;
        dynamic b = data1;
        dynamic c = data2;
        dynamic akhir = 0;
        if (a > b && a > c)
        {
            a = akhir;
        }
        else if (b > c && b > a)
        {
            b = akhir;
        }
        else if (c > a && c > b) {
            c = akhir;
        }
        Console.WriteLine(akhir);
    }
}

