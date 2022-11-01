using System.Collections;

class mystring
{
    public static void tolower(string metin)
    {
        double a = 0;
        foreach (char eleman in metin)
        {
            a = System.Convert.ToInt32(eleman);
            if (a >= 65 && a <= 90)
            {
                a = a + 32;
                Console.Write((char)a);
            }
            else
            {
                Console.Write((char)a);
            }

        }

    }

    public static void toupper(string metin)
    {
        double a = 0;
        foreach (char eleman in metin)
        {
            a = System.Convert.ToInt32(eleman);
            if (a >= 97 && a <= 122)
            {
                a = a - 32;
                Console.Write((char)a);
            }
            else
            {
                Console.Write((char)a);
            }

        }

    }

    public static void sub(string kelime, int a, int b)
    {
        for (int i = a; i <= b; i++)
        {
            Console.Write(kelime[i]);
        }
    }

    public static int length(string b)
    {
        int i = 0;
        foreach (var c in b)
        {
            i++;
        }
        return i;
    }

    public static void insert(int a, string kelime, string kelime2)
    {
        for (int i = 0; i < a; i++)
        {
            Console.Write(kelime[i]);
        }

        Console.Write(" " + kelime2 + " ");
        for (int b = a; b < mystring.length(kelime); b++)
        {
            Console.Write(kelime[b]);
        }
    }
    static public void remove(this string kelime, int a, int b)
    {
        ArrayList dizi= new ArrayList();
        foreach(char c in kelime)
        {
            dizi.Add(c);
        }
        dizi.RemoveRange(a, b);
        foreach(char c in dizi)
        {
            Console.Write(c);
        }
    }

    public static void remove1(string kelime,int a, int b)
    {

        for (int i = 0; i < a; i++)
        {

            Console.Write(kelime[i]);


        }
        int toplam = a + b;
        for (int i = toplam; i < mystring.length(kelime); i++)
        {
            Console.Write(kelime[i]);


        }
    }

    static public void split(this string metin, char aranan)
    {
        ArrayList dizi = new ArrayList();
        int a = mystring.length(metin);
        string gecicim = "";
        for (int i = 0; i < a; i++)
        {
            if (metin[i] != aranan)
            {
                gecicim += metin[i];
                if (i == a - 1)
                {
                    dizi.Add(metin[i]);
                }
                continue;
            }
            dizi.Add(gecicim);
            gecicim = "";
        }
        foreach (var c in dizi)
        {
            Console.WriteLine(c);
        }
    }
    public static ArrayList split1(string kelime,char arasına)
    {

        int len = mystring.length(kelime);

        ArrayList arrayList = new ArrayList();
        string temp = "";

        for (int i = 0; i < len; i++)
        {
            if (kelime[i] != arasına)
            {
                temp += kelime[i];
                if (i == (len - 1))

                    arrayList.Add(temp);
                continue;

            }
            arrayList.Add(temp);
            temp = "";
        }
        foreach (char c in arrayList)
        {
            if (c == arasına)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.Write(c);
            }
        }

        return arrayList;
        foreach (char eleman in kelime)
        {
            if (eleman == ' ')
            {

                Console.WriteLine(eleman);
            }
            else
            {
                Console.Write(eleman);
            }
        }
    }
    public static void join(char ara, ArrayList dizi2)
    {

        int adet = 0;
        foreach (var eleman in dizi2)
        {
            adet++;
            Console.Write(eleman);
            if (adet == dizi2.Count)
            {
                break;
            }
            else
            {
                Console.Write(ara);
            }

        }
    }
     static public void trimend(this string metin)
    {
        int i = 0;
        int adet = mystring.length(metin);
      

            for (i = adet - 1; i > 0; i--)
            {
                if (metin[i] == ' ')
                {

                }

                else if (metin[i] != ' ')
                {
                    break;
                }
            }
    

        for (int e = 0; e < i + 1; e++)
        {
            Console.Write(metin[e]);
        }
        
    }
    static public void trim(this string metin)
    {

        int adet = 0;
        foreach (char c in metin)
        {

            if (c != ' ')
            {
                break;
            }
            else
                adet++;
        }
        int adet2 = mystring.length(metin);
        for (int i = adet2 - 1; i > 0; i--)
        {
            if (metin[i] == ' ')
            {
                adet2--;
            }

            else if (metin[i] != ' ')
            {
                break;
            }
        }
        Console.WriteLine(adet2-1);
        mystring.sub(metin, adet, adet2);
    } 


    public static void trimstart(string kelime)
    {
        int adet = 0;
        foreach (char eleman in kelime)
        {
            if (eleman == ' ')
            {
                adet++;
            }
            else if(eleman !=' ')
            {
                for(int i = adet;i<=mystring.length(kelime);i++)
                {
                    Console.Write(kelime[i]);
                }
            }
  
        }
     
    }
    public static void replace(string metin, string b, string c)
    {

        ArrayList dizi2=new ArrayList();
        dizi2 = mystring.split(metin,' ');
        Console.Write(dizi2.Count);
        foreach (string eleman in dizi2)
        {
            if (eleman == b)
            {

                Console.Write(c + ' ');

            }
            else
            {
                Console.Write(eleman + ' ');
            }
        }

    }
    public static int indexof(string metin, string aranan,int p)
    {
        bool sonuc;

        for (int i = p; i < mystring.length(metin) - mystring.length(aranan) + 1; ++i)
        {
            sonuc = true;
            for (int j = 0; j < mystring.length(aranan); ++j)
            {
                if (metin[i + j] != aranan[j])
                {
                    sonuc = false;
                    break;
                }
            }
            if (sonuc)
            {
                return i;
            }
        }

        return -1;
    }
    public static void padleft(string kelime,int tamamlanan,char neyazilsin)
    {
        for (int i = 0; i < tamamlanan - mystring.length(kelime); i++)
        {
            Console.Write(neyazilsin);
        }
        Console.Write(kelime);
    }
    public static void padright(string kelime,int tamamlanan,char neyazilsin)
    {
        Console.Write(kelime);
        for (int i = 0; i < tamamlanan - mystring.length(kelime); i++)
        {
            Console.Write(neyazilsin);
        }
    }
    public static void icindeara(string kelime,string varmı)
    {
        int a=mystring.indexof(kelime, varmı,0);
        if(a>=0)
        {
            Console.WriteLine(true);
        }
        if (a ==-1)
        {
            Console.WriteLine(false);
        }
    }
}

class program
    {
        static void Main(string[] args)
        {
       
        }
    }
