
Console.WriteLine("JUEGO BATALLA NAVAL\n");
Console.WriteLine("Reglas: \n");
Console.WriteLine("1) Se asignaran 5 barcos enemigos en un tablero de 5 filas por 5 columnas en coordenadas aleatorias.");
Console.WriteLine("2) Tendras 5 Disparos Disponibles.");
Console.WriteLine("3) Si ingresas mal una coordenada perderas ese registro y deberas ingresar datos nuevamente.");
Console.WriteLine("4) Si aciertas mas disparos que los que fallaste, Ganaras.");
Console.WriteLine("Si fallas mas disparos de los que acertaste perderas.");
Console.WriteLine("\nPRESIONE ENTER PARA INICIAR.");
Console.ReadKey();

int[,] tablero = new int[5, 5];

void paso1_crear_tablero()
{
    for (int f = 0; f < tablero.GetLength(0); f++)
    {
        for (int c = 0; c < tablero.GetLength(1); c++)
        {
            tablero[f, c] = 0;
        }
    }
}


void paso2_colocar_barcos()
{
   Random aleatoriof= new Random();
    int barcof;
    barcof= aleatoriof.Next(0,5);
   Random aleatorioc=new Random();
    int barcoc; 
    barcoc=aleatorioc.Next(0,5);
  tablero[barcof, barcoc] = 1; 
   Random aleatoriof2= new Random();
    int barcof2;
    barcof2=aleatoriof2.Next(0,5);
   Random aleatorioc2= new Random();
    int barcoc2;
    barcoc2=aleatorioc2.Next(0,5);
  tablero[barcof2, barcoc2] = 1;
    Random aleatoriof3 = new Random();
    int barcof3;
    barcof3 = aleatoriof3.Next(0, 5);
    Random aleatorioc3 = new Random();
    int barcoc3;
    barcoc3 = aleatorioc3.Next(0, 5);
  tablero[barcof3, barcoc3] = 1;
    Random aleatoriof4 = new Random();
    int barcof4;
    barcof4 = aleatoriof4.Next(0, 5);
    Random aleatorioc4 = new Random();
    int barcoc4;
    barcoc4 = aleatorioc4.Next(0, 5);
  tablero[barcof4, barcoc4] = 1;
    Random aleatoriof5 = new Random();
    int barcof5;
    barcof5 = aleatoriof5.Next(0, 5);
    Random aleatorioc5 = new Random();
    int barcoc5;
    barcoc5 = aleatorioc5.Next(0, 5);
    tablero[barcof5, barcoc5] = 1;


}


void paso3_imprimir_tablero()
{

    string caracter_a_imprimir = " ";

    for (int f = 0; f < tablero.GetLength(0); f++)
    {
        for (int c = 0; c < tablero.GetLength(1); c++)
        {
            switch (tablero[f, c])
            {
                case 0:  //El tablero mostrara el signo ~ para indicar la posición donde no hay barcos
                    caracter_a_imprimir = " ~ ";
                    break;
                case 1: //El tablero mostrara la letra B para indicar donde esta colocado el barco
                    caracter_a_imprimir = " ~ ";
                    break;
                case -1:  // El tablero mostrara el signo * cuando ataquemos y le demos a un barco 
                    caracter_a_imprimir = " X ";
                    break;
                case -2: //El tablero mostrara el 0 cuando ataquemos y fallemos el tiro
                    caracter_a_imprimir = " O ";
                    break;
                default:
                    caracter_a_imprimir = " ~ ";
                    break;
            }
            Console.Write(caracter_a_imprimir + "  ");
        }
        Console.WriteLine();
    }


}



void paso4_ingreso_coordenadas()
{
    int explo= 0;
    int fal = 0;
    int k = 0;
    do
    {
        try
        {
            int fila, columna = 0;
            Console.Clear();
            do 
            {
                do
                {
                    Console.Write("Ingresa El Numero De Fila Donde Desea Atacar, ten en cuenta que tiene que ser en el rango de 0 y 4: ");
                    fila = Convert.ToInt32(Console.ReadLine());
                    if (fila < 0 || fila > 4)
                    {
                        Console.Clear();
                        Console.WriteLine("Tu Disparo esta fuera del rango, ingresa nuevamente la coordenada");
                        

                    } 
                } while (fila < 0 || fila > 4);

                do
                {
                    Console.Write("Ingresa El Numero De Columna Donde Desea Atacar, ten en cuenta que tiene que ser en el rango de 0 y 4: ");
                    columna = Convert.ToInt32(Console.ReadLine());

                    if (columna < 0 || columna > 4)
                    {
                        Console.Clear();
                        Console.WriteLine("Tu Disparo esta fuera del rango, ingresa nuevamente la coordenada");                  
                        
                    } 
                } while (columna < 0 || columna > 4);

                if (tablero[fila, columna] == 1)
                {
                    Console.Beep();
                    tablero[fila, columna] = -1;
                    explo = explo + 1; 
                    
                }
                else
                {
                    tablero[fila, columna] = -2;
                    fal= fal + 1; 
                }
                Console.Clear();
                paso3_imprimir_tablero();

                k = k + 1; 
            }  while (k !=5);


            Console.Clear();

            //FIN JUEGO, MUESTRA RESULTADOS
            Console.WriteLine("Barcos Hundidos: " + explo);
            Console.WriteLine("Tiros fallados: " + fal);

            if (explo > fal)
            {
                Console.WriteLine("\n\nFELICIDADES, GANASTE EL JUEGO, HUNDISTE " + explo + " BARCOS DE 5 POSIBLES");
                Console.WriteLine(":)  :)  :)");
            }
            else
            {
                Console.WriteLine("\n\nHAS PERDIDO, SUERTE LA PROXIMA VEZ");
                Console.WriteLine(":(  :(");
            }
            
            break;
        } 

        catch (Exception ex)
        {
            k = explo + fal;
            Console.WriteLine("Dato ingresado invalido, el dato incorrecto que ingresaste es: " + ex.Message);

        }

        Console.ReadLine();
    } while (true); 


}





    paso1_crear_tablero();
paso2_colocar_barcos();

paso4_ingreso_coordenadas();






// for (int k=0; k<5; k++) { } PRIMER INTENTO DE MI BUCLE PARA CONTADOR DE 5 INTENTOS - - - - - -  ( bucle para 5 oportunidades probar con do while ) 


