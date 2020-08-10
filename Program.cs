using System;
using System.Collections;

namespace PruebaVehiculos
{
    class Program
    {
        private static readonly ArrayList _motocicletas = new ArrayList();
        private static readonly string username = "admin";
        private static readonly string pass = "abc123";
        private static int exitCode = 0;
        static void Main(string[] args)
        {
            const int intentosMaximos = 3;
            int intentosRealizados = 0;
            while (true)
            {
                intentosRealizados++;
                
                Console.WriteLine("Ingrese el nombre de usuario:");
                string tmpUsername = Console.ReadLine();

               
                Console.WriteLine("Ingrese la contraseña:");
                string tmpPass = Console.ReadLine();

                
                if (Login(tmpUsername, tmpPass))
                    IniciarMenuPrincipal();
                else
                {
                    Console.WriteLine("El usuario y/o la contraseña son incorrectos. Intentelo de nuevo.");
                    if (intentosRealizados >= intentosMaximos) Environment.Exit(exitCode);
                    break;
                }
            }
        }


        private static bool Login(string username, string pass)
        {
            return Program.username == username && Program.pass == pass;
        }

        private static void IniciarMenuPrincipal()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Bienvenido a mi app de motocicletas, elija una opcion:");
                Console.WriteLine("1. Ingresar motocicleta.");
                Console.WriteLine("2. Listar motocicletas.");
                Console.WriteLine("3. Salir.");


                int opcion;
                string input = Console.ReadLine();
                if (int.TryParse(input, out opcion))
                {

                    
                    int minDurometro = 0;
                    int maxDurometro = 0;


                    switch (opcion)
                    {
                        case 1:
                            
                            Console.WriteLine("Ingrese numero de motor:");
                            string id = Console.ReadLine();



                            Console.WriteLine("Ingrese el tipo de motor:");
                            Console.WriteLine("1. Cuatro tiempos.");
                            Console.WriteLine("2. Dos tiempos.");



                            TipoMotor tipoMotor = Console.ReadLine() == "2" ?
                                TipoMotor.DOS_TIEMPOS : TipoMotor.CUATRO_TIEMPOS;



                            Console.WriteLine("Ingrese la cilindrada:");
                            int cilindrada = int.Parse(Console.ReadLine());


                            //(string.Join(string.Empty, Encoding.UTF8.GetByteo

                            Console.WriteLine("Ingrese el ano:");
                            int ano = int.Parse(Console.ReadLine());



                            Console.WriteLine("Ingrese la marca:");
                            string marca = Console.ReadLine();



                            Console.WriteLine("Ingrese el kilometraje:");
                            int kilometraje = int.Parse(Console.ReadLine());



                            //clase Mezclador

                            Console.WriteLine("Ingrese el tipo de mezclador:");
                            Console.WriteLine("1. Carburador.");
                            Console.WriteLine("2. Inyector.");



                            TipoMezclador tipoM = Console.ReadLine() == "1" ?
                                TipoMezclador.CARBURADOR : TipoMezclador.INYECTOR;

                            //Clase Estanque

                            Console.WriteLine("Ingrese la capasidad:");
                            int capacidad = int.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese los litros:");
                            double litros = double.Parse(Console.ReadLine());



                            //clase Rueda

                            Console.WriteLine("Ingrese el tipo de recubrimiento:");
                            Console.WriteLine("1. Fenol.");
                            Console.WriteLine("2. Hule.");
                            Console.WriteLine("3. Poliuretano.");
                            TipoRecubrimiento recubrimiento;
                            string b = Console.ReadLine();
                            if (Enum.TryParse(b, out recubrimiento))
                            {

                                switch (recubrimiento)
                                {
                                    case (TipoRecubrimiento)1:
                                        recubrimiento = TipoRecubrimiento.FENOL;
                                        break;
                                    case (TipoRecubrimiento)2:
                                        recubrimiento = TipoRecubrimiento.HULE;
                                        break;
                                    default:
                                        recubrimiento = TipoRecubrimiento.POLIUTERANO;
                                        break;
                                }
                            }

                            Console.WriteLine("Ingrese los valores del durometro");



                            do
                            {
                                Console.WriteLine("El valor minimo siempre debe ser menor al valor maximo");

                                Console.WriteLine("Ingre el valor minimo del durometro: ");
                                minDurometro = int.Parse(Console.ReadLine());

                                Console.WriteLine("Ingre el valor maximo del durometro: ");
                                maxDurometro = int.Parse(Console.ReadLine());
                            }
                            while (minDurometro > maxDurometro);


                            Motocicleta motocicleta = new Motocicleta(id, tipoMotor,
                                cilindrada, marca, ano, kilometraje, tipoM, capacidad,
                                litros, recubrimiento, minDurometro, maxDurometro);



                            _motocicletas.Add(motocicleta);

                            break;



                        case 2:
                            if (_motocicletas.Count > 0)
                                foreach (Motocicleta tmpMotocicleta in _motocicletas)
                                {
                                    Console.WriteLine("ID del motor: " + tmpMotocicleta.Motor.Id);
                                    Console.WriteLine("Tipo del motor: " + tmpMotocicleta.Motor.TipoMotor);
                                    Console.WriteLine("Cilindrada: " + tmpMotocicleta.Motor.Cilindrada);
                                    Console.WriteLine("Estado del motor: " + tmpMotocicleta.Motor.Estado + "%");
                                    Console.WriteLine("Marca: " + tmpMotocicleta.Marca);
                                    Console.WriteLine("Año: " + tmpMotocicleta.Ano);
                                    Console.WriteLine("Kilometraje: " + tmpMotocicleta.Kilometraje);
                                    Console.WriteLine("Tipo de Mezclador: " + tmpMotocicleta.TipoM);
                                    Console.WriteLine("Capacidad del tanque: " + tmpMotocicleta.Estanque.Capacidad);
                                    Console.WriteLine("Cantidad de Comnustible: " + tmpMotocicleta.Estanque.Litros);
                                    Console.WriteLine("Tipo recubrimiento: " + tmpMotocicleta.Rueda.Recubrimiento);
                                    Console.WriteLine("Valor minimo del durometro: " + tmpMotocicleta.Rueda.MinDurometro);
                                    Console.WriteLine("Valor maximo del durometro: " + tmpMotocicleta.Rueda.MaxDurometro);
                                    Console.WriteLine("______________________________________________");
                                    Console.WriteLine(string.Empty);
                                }
                            else
                                Console.WriteLine("No hay motocicletas registradas.");
                            Console.WriteLine("* Presione cualquier tecla para continuar *");
                            Console.ReadLine();

                            break;



                        case 3:

                            if (exitCode == 0)
                                Console.WriteLine("La aplicación finalizó correctamente.");
                            else
                                Console.WriteLine("Hubo errores al finalizar el programa.");
                            Environment.Exit(exitCode); 
                            break;

                        default:
                            break;
                    }
                }
                else Console.WriteLine("Opcion no valida");
            }
        }
    }
}
        
    

