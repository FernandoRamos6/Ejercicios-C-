//Ejercicios do - while

//Ingresar contrasena correcta


int contrasena = 1234;
int entrada;

do
{
    
    Console.WriteLine("Enter your password: ");
    entrada = Convert.ToInt32(Console.ReadLine());
} while 
(entrada != contrasena);

//️⃣ Cajero automático

/*Simula un menú:

1.Consultar saldo
2. Depositar dinero
3. Retirar dinero
4. Salir


Usa switch dentro de un do-while.*/

int opcion = 0;
//int saldo = 100;
int saldo_actual = 0 ;
int depositado;
int retirado;
do
{
    Console.WriteLine("*** MENU ***");
    Console.WriteLine("1. Consultar Saldo \n2. Depositar dinero \n3. Retirar dinero \n4. Salir");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Su saldo es: " + saldo_actual);
            break;
        case 2:
            Console.WriteLine("Ingrese la cantidad a depostar: ");
            depositado = Convert.ToInt32(Console.ReadLine());
            saldo_actual = depositado;
            Console.WriteLine("Saldo nuevo:" + saldo_actual);
            break;
        case 3:
            Console.WriteLine("Ingrese cantidad a retirar");
            retirado = Convert.ToInt32(Console.ReadLine());
            if (saldo_actual < retirado)
            {
                Console.WriteLine("No dispone de saldo suficiente");
                break;
            }
            
            else  saldo_actual = saldo_actual - retirado;
            Console.WriteLine("Saldo nuevo:" + saldo_actual);
            break;

        
    }
} while (opcion != 4);


 