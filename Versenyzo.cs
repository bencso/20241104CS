namespace _20241104GYA;

internal class Versenyzo
{
    public string Nev { get; set; }
    public int SzulEv { get; set; }
    public int RajtSzam { get; set; }
    public bool Nem { get; set; }
    public string Kategoria { get; set; }
    public  Dictionary<string,TimeSpan> VersenyIdok { get; set; }

    public int OsszIdoSec => 
        (int)VersenyIdok.Values.Sum(p => p.TotalSeconds);

    public override string ToString() =>
        $"[{RajtSzam}] {Nev} ({(Nem ? "Férfi" : "Nő")} {Kategoria})";

    public Versenyzo(string sor)
    {
        string[] v = sor.Split(';');
        Nev = v[0];
        SzulEv = int.Parse(v[1]);
        RajtSzam = int.Parse(v[2]);
        Nem = v[3] == "f";
        Kategoria = v[4];
        VersenyIdok = new()
        {
            {   "úszás",      TimeSpan.Parse(v[5])},
            {   "I. depó",    TimeSpan.Parse(v[6])},
            {   "kerékpár",    TimeSpan.Parse(v[7])},
            {   "II. depó",    TimeSpan.Parse(v[8])},
            {   "futás",      TimeSpan.Parse(v[9])}
        };
    }
}
