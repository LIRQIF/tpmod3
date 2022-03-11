public enum Kelurahan
{
    Batununggal,
    Kujangsari,
    Mengger,
    Wates,
    Cijaura,
    Jatisari,
    Margasari,
    Sekejati,
    Kebonwaru,
    Maleer,
    Samoja,
}

public class KodePos
{
    public Kelurahan kelurahan;

    public KodePos(Kelurahan kelurahan)
    {
        this.kelurahan = kelurahan;
    }

    public String getKodePos()
    {
        switch (this.kelurahan)
        {
            case Kelurahan.Batununggal:
                return "40266";
            case Kelurahan.Kujangsari:
                return "40287";
            case Kelurahan.Mengger:
                return "40267";
            case Kelurahan.Wates:
                return "40256";
            case Kelurahan.Cijaura:
                return "40287";
            case Kelurahan.Jatisari:
                return "40286";
            case Kelurahan.Margasari:
                return "40286";
            case Kelurahan.Sekejati:
                return "40286";
            case Kelurahan.Kebonwaru:
                return "40272";
            case Kelurahan.Maleer:
                return "40274";
            default:
                return "40273";
        }

    }
}
