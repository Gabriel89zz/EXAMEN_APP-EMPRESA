string nombre, apellido, direccion, tipo_empleado;
int empleado_a = 78, empleado_b = 62,horas,hijos;
double hijos_pago = 31.05,nomina;

Console.WriteLine("BIENVENIDO AL SISTEMA DE ADMINISTRACION DE EMPLEADO");

do
{
    Console.WriteLine("INGRESE SU NOMBRE:");
    nombre = Console.ReadLine();

    foreach (char letra in nombre)
    {
        if (char.IsNumber(letra))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("EL NOMBRE NO PUEDE CONTENER NUMEROS");
            Console.ForegroundColor = ConsoleColor.White;
            nombre = "";
            break;
        }
    }
} while (string.IsNullOrEmpty(nombre));

do
{
    Console.WriteLine("INGRESE SUS APELLIDOS:");
    apellido = Console.ReadLine();

    foreach (char letra in apellido)
    {
        if (char.IsNumber(letra))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("EL APELLIDO NO PUEDE CONTENER NUMEROS");
             Console.ForegroundColor = ConsoleColor.White;
            apellido = "";
            break;
        }
    }
} while (string.IsNullOrEmpty(apellido));


Console.WriteLine("INGRESE SU DIRECCION:");
direccion= Console.ReadLine();

Console.WriteLine("¿QUE TIPO DE EMPLEADO ES A Ó B?");
tipo_empleado = Console.ReadLine();

while (tipo_empleado!="a" && tipo_empleado!="b")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("TIPO DE EMPLEADO NO EXISTENTE, INGRESE DE NUEVO EL TIPO DE EMPLEADO");
    Console.ForegroundColor = ConsoleColor.White;
    tipo_empleado = Console.ReadLine();
}

Console.WriteLine("¿CUANTOS HIJOS TIENE?");
hijos = int.Parse(Console.ReadLine());

Console.WriteLine("¿CUANTAS HORAS TRABAJÓ EN LA SEMANA?");
horas= int.Parse(Console.ReadLine());

while (horas>70)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("SOBREPASASTE EL LIMITE DE HORAS, INGRESA NUEVAMENTE LAS HORAS:");
    Console.ForegroundColor = ConsoleColor.White;
    horas = int.Parse(Console.ReadLine());
}    

if (tipo_empleado=="a")
{
    nomina = (empleado_a * horas )+ (hijos * hijos_pago);
    Console.WriteLine(nombre+" "+apellido+" TU PAGO SEMANAL ES DE: $" + nomina);
}

else if (tipo_empleado == "b")
{
    nomina = (empleado_b * horas) + (hijos * hijos_pago);
    Console.WriteLine(nombre  + " "+ apellido + " TU PAGO SEMANAL ES DE: $" + nomina);
}

Console.ReadKey();

