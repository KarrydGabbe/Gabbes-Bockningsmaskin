using Projekt;

List<Originalpart> parts = new List<Originalpart>();

Originalpart f =new Originalpart();

int PressKor = 1;

//Inmatning

Console.WriteLine("Godstjocklek (mm):");
int Otj = Int32.Parse (Console.ReadLine());
f.setOtjocklek(Otj);
Console.WriteLine("");

Console.WriteLine("Katet X (mm):");
int OKX = Int32.Parse (Console.ReadLine());
f.setOKatetX(OKX);
Console.WriteLine("");

Console.WriteLine("Katet Y (mm):");
int OKY = Int32.Parse (Console.ReadLine());
f.setOKatetY(OKY);
Console.WriteLine("");

Console.WriteLine("Längd (km):");
int OL = Int32.Parse (Console.ReadLine());
f.setOlängd(OL);
Console.WriteLine("");

Console.WriteLine("Anal:");
int A = Int32.Parse (Console.ReadLine());
f.setAntal(A);
Console.WriteLine("");

parts.Add(f);


//plåtplockning 

if(f.getOtjocklek() == 3)
{
    Metoder.tremmplåt();
}

if(f.getOtjocklek() == 2)
{
    Metoder.tvåmmplåt();
}

Console.WriteLine(" ");


//Laserskärning
int orientation = Metoder.plåt_åtgång(f.getOKatetX() , f.getOKatetY(), f.getOlängd());

if(orientation == 1)
{
    Console.WriteLine("Plåtarna skärs ut stående");
}
else
{
    Console.WriteLine("Plåtarna skärs ut Liggande");
}

Console.WriteLine(" ");



//Bockning och korochering
for(int i =0;i<=f.getAntal();i++)
{
    
    PressKor=( Metoder.Bockning(f.getOtjocklek(), f.getOlängd(), PressKor,f.getOKatetX(),i));
    Console.WriteLine(" ");

} 

Console.WriteLine(" ");


//palletering
Metoder.palletering(f.getOKatetX(), f.getOKatetY(),f.getOlängd());



