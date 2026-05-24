//Convertir un tipo de dato a otro
//texto-numero  float-decimal   etc


//casting implicito
int value = 200;
double total = value;
Console.WriteLine("Implicito: " + value);


//casting explicito
double price = 500.23;
int discount = (int)price;
Console.WriteLine("Explicito " +discount); 
Console.ReadKey();

//textos
char letter  = 'A';
int codigoAsci = letter;
Console.WriteLine(codigoAsci);

string palabra = "12345";
int numero = Convert.ToInt32(palabra);
Console.WriteLine(palabra);

string texto_Decimal = "140.05";
double valor3 = double.Parse(texto_Decimal);
Console.WriteLine(valor3);
