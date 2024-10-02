List<string> Davetliler = new List<string>()
{ "Bülent Ersoy","Ajda Pekkan","Ebru Gündeş","Hadise","Hande Yener","Tarkan","Funda Arar","Demet Akalın"};

Console.WriteLine("Patika Plus Gala Gecesine Davetli Olanlar:");
for (int i = 0; i < Davetliler.Count; i++)
{
    Console.WriteLine($"{i + 1}- {Davetliler[i]}");
}