using cv8;

class Program
{
    public static void Main()
    {
        ArchivTeplot archiv = new ArchivTeplot();

        archiv.Load("D:\\teploty.txt");


        archiv.TiskTeplot();
        archiv.TiskPrumernychRocnichTeplot();
        archiv.TiskPrumernychMesicnichTeplot();
        archiv.Kalibrace(-0.1);
        archiv.TiskTeplot();
        archiv.Vyhledej(2018);
        archiv.Save("D:\\teplotyNew.txt");
    }
}
