internal class Program
{
    private static void Main(string[] args)
    {
        //Table-Driven
        KodePos kode = new KodePos();
        Console.WriteLine("Kelurahan : Batununggal");
        Console.WriteLine("Kode Pos : "+kode.getKodePos(KodePos.Kelurahan.Batununggal));
        //State-Based Construction
        Console.WriteLine("================");
       DoorMachine door = new DoorMachine();
        door.Pintu();
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

public class DoorMachine
{
    enum State { Terkunci, Terbuka };
    public void Pintu()
    {
        State state = State.Terkunci;
        string[] pesan = { "Pintu terkunci", "Pintu tidak terkunci" };
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Kondisi : "+pesan[(int)state]);
            Console.Write("Perintah : ");
            string perintah = Console.ReadLine();
            if (perintah == "KunciPintu")
            {
                state = State.Terkunci;
            } else if (perintah == "BukaPintu")
            {
                state = State.Terbuka;
            }
        }
        Console.WriteLine("Kondisi : " + pesan[(int)state]);
    }
}