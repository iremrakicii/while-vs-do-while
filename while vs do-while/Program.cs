Console.Write("Bir limit değeri giriniz: ");
int limit = Convert.ToInt32(Console.ReadLine());

int sayac = 0;

while (sayac <= limit) // koşulu döngünün başında kontrol eder.
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
}
if (limit < 0)
{
    Console.WriteLine("Girilen limit değeri negatif olduğu için sayaç çalışmadı.");
}



Console.Write("Bir limit değeri giriniz: ");
int limit2 = Convert.ToInt32(Console.ReadLine());

int sayac2 = 0;

do //koşulu döngünün sonunda kontrol eder ve döngünün en az 1 kez çalışmasını garanti eder.
{
    if (limit2 < 0)
    {
        Console.WriteLine("Girilen limit değeri negatif olduğu için sayaç çalışmadı.");
        return;
    }

    Console.WriteLine("Ben bir Patika'lıyım");
    sayac2++;

} while (sayac2 <= limit2);


Console.ReadKey();
