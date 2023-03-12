internal class Program
{
    private static void Main(string[] args)
    {
        KodePos kode = new KodePos();
        Console.WriteLine("Kelurahan : Batununggal");
        Console.WriteLine("Kode Pos : "+kode.getKodePos(KodePos.Kelurahan.Batununggal));
    }
}

public class KodePos
{
    public enum Kelurahan { Batununggal, Kujangsari, Menggel, 
        Wates, Cijaura, Jatisari, Margasari, Sekejati, 
        Kebonwaru, Maleer, Semoja }
    public int getKodePos(Kelurahan kelurahan)
    {
        int[] kodePos = { 40266, 40287, 40267, 40256, 40287,
        40286, 40286, 40286, 40272, 40274, 40273 };
        return kodePos[(int)kelurahan];
    }
}