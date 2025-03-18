using System.Diagnostics;

class main()
{
    //103022300083
    public static void Main(string[] args)
    {
        
        pemrosesData test = new pemrosesData();
        test.DapatkanNilaiTerbesar<double>(10,30,22);
    }
}

class pemrosesData {

    public void DapatkanNilaiTerbesar<T>(T data, T data1, T data2) {
        dynamic a = data;
        dynamic b = data1;
        dynamic c = data2;
        dynamic akhir = 0;
        if (a > b && a > c)
        {
            akhir = a;
        }
        else if (b > c && b > a)
        {
            akhir = b;
        }
        else if (c > a && c > b) {
            akhir = c;
        }
        Console.WriteLine("nilai terbesar adalah " + akhir);
    }
}

