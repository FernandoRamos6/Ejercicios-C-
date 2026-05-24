
int val1 = 5;
Console.WriteLine(val1); //Aumenta 1 por 1
val1++;     //Se puede usar pre incremento y post incremento
//++val1++
Console.WriteLine(val1);

int val2 = 5;
Console.WriteLine(val2);    //Resta 1 por 1
--val2;     //Pre decremento y post decremento funciona igual
Console.WriteLine(val2);

//SUMA
int val3 = 10;
Console.WriteLine("Valor original: " + val3);
val3 += 5;  //Se suma y se asigna los valores (agrega o disminuye valores especificos)
Console.WriteLine("Valor aumentado: " + val3); //Solo funciona como postdecremento o aumento

//RESTADO
int val4 = 10;
Console.WriteLine("Valor original: " + val4);
val4 -= 5;  
Console.WriteLine("Valor decrementado: " + val4);

//MULTIPLICACION
int val5 = 10;
Console.WriteLine("Valor original: " + val5);
val5 *= 5;
Console.WriteLine("Valor multiplicado: " + val5);


//DIVISION
int val6 = 10;
Console.WriteLine("Valor original: " + val6);
val6 /= 5;
Console.WriteLine("Valor dividido: " + val6);





Console.ReadKey();