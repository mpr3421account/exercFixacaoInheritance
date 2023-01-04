/*Fazer um programa para ler os dados de N
produtos (N fornecido pelo usuário). Ao final,
mostrar a etiqueta de preço de cada produto na
mesma ordem em que foram digitados.
Todo produto possui nome e preço. Produtos
importados possuem uma taxa de alfândega, e
produtos usados possuem data de fabricação.
Estes dados específicos devem ser
acrescentados na etiqueta de preço conforme
exemplo (próxima página). Para produtos
importados, a taxa e alfândega deve ser
acrescentada ao preço final do produto.
*/
using exercFixacaoInheritance.Entities;
using System.Globalization;
using System.Net.Http.Headers;


Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

List<Product> list = new List<Product>();

for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product #{i} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    char c = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if(c == 'i')
    {
        Console.Write("Custom fee: ");
        double customFee = double.Parse(Console.ReadLine());
        list.Add(new ImportedProduct(name,price, customFee));
    }
    else if(c == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY):");
        DateTime date = DateTime.Parse(Console.ReadLine());
        list.Add(new UsedProduct(name, price, date));
    }
    else
    {
        list.Add(new Product(name, price));
    }
}
Console.WriteLine();
Console.WriteLine("PRICE TAGS:");
foreach(Product prod in list)
{
    Console.WriteLine(prod.PriceTag);
}
