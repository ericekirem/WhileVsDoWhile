
// While Döngüsü

Console.Write("Bir limit değeri giriniz: ");
int limit = int.Parse(Console.ReadLine());
int counter = 0;

while (counter <= limit)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    counter++;
}





// Do-While Döngüsü:

Console.Write("Bir limit değeri giriniz: ");
        int limit = int.Parse(Console.ReadLine());
        int counter = 0;

        do
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            counter++;
        } while (counter <= limit);




// While döngüsünde kod baştan kontrol edildiği için -5 yazıldığında hata veriyor.
// Do-While döngüsünde ise şartı sağlamamasına rağmen döngü yine de bir kez "Ben bir Patika'lıyım" yazdırıyor.
// İki döngüde de "10" değerini yazdığımda, ekrana 11 kez "Ben bir Patika'lıyım" yazdırıyor.