System.Console.WriteLine("Programa para saber si un numero es par o impar");
System.Console.Write("Digite el numero: ");
int numero_Par_o_Impar = Convert.ToInt32(Console.ReadLine());

if (Convert.ToBoolean (numero_Par_o_Impar % 2))
{
    System.Console.WriteLine("ES IMPAR");
}
else
{
    System.Console.WriteLine("ES PAR");
}

System.Console.WriteLine("Programa para saber que dia es dependiendo que numero usted eliga");
System.Console.Write("Digite un numero entre 1 y 7: ");
int numeroEntre1y7 = Convert.ToInt32(Console.ReadLine());

switch (numeroEntre1y7)
{
    case 1:
    System.Console.WriteLine("HOY ES LUNES");
    break;
     case 2:
    System.Console.WriteLine("HOY ES MARTES");
    break;
     case 3:
    System.Console.WriteLine("HOY ES MIERCOLES");
    break;
     case 4:
    System.Console.WriteLine("HOY ES JUEVES");
    break;
     case 5:
    System.Console.WriteLine("HOY ES VIERNES");
    break;
     case 6:
    System.Console.WriteLine("HOY ES SABADO");
    break;
     case 7:
    System.Console.WriteLine("HOY ES DOMINGO");
    break;
    default:
    System.Console.WriteLine("POR FAVOR INTRODUZCA UN NUMERO ENTRE 1 Y 7 :)");
    break;
}


System.Console.WriteLine("Que usted desea calcular perimetro o area: OJO DEBE ESCRIBIRLO EN MINUSCULA");
string decision = Console.ReadLine();

if (decision == "perimetro")
{
    System.Console.WriteLine("Programa para calcular  perimetro");

    System.Console.Write("Digite el numero de lados: ");
int numeroLadosPerimetro = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Digite el numero de largo de los lados: ");
int largoDeLosLados = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"El perimetro de un poligono regular es: {numeroLadosPerimetro * largoDeLosLados} ");

}
else if (decision == "area")
{
    System.Console.WriteLine("Programa para calcular aerea");

System.Console.Write("Digite numeros de lados: ");
int numeroLadosArea = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Digite largo de lados tiene: ");
int largoDeLosLadosArea = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Digite el apotema: ");
int apotema = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"El area del poligono regular es: {numeroLadosArea * largoDeLosLadosArea * apotema /2}");

}

else{
    System.Console.WriteLine("RECUERDE ESCRIBE SOLO area o perimetro ASI EN MINUSCULA");
}



