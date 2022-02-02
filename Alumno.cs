using System;

namespace Program1
{
    class alumno
    {

        static void Main(string[] args)
        {
            int tamvec;
            int op;
            Console.WriteLine("ingrese numero de estudiantes en su grupo");
            tamvec = int.Parse(Console.ReadLine());
            Console.Clear();
            alumno[] Estudiante = new alumno[tamvec];
            do
            {
                Console.WriteLine("\t******MENU******");
                Console.WriteLine("1. Ingresar datos de nuevo estudiante ");
                Console.WriteLine("2. Ver listado de estudiantes inscritos ");
                Console.WriteLine("3. Reporte de estudiantes ");
                Console.WriteLine("4. Salir");
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Console.WriteLine("SECCION DE INGRESO");
                        for (int i = 0; i < Estudiante.Length; i++)
                        {
                            Estudiante[i] = new alumno();
                            Estudiante[i].ingresarDatos();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        Console.WriteLine("\n-------------------------------");
                        Console.WriteLine("\nLISTADO ALUMNOS");
                        Console.WriteLine("\n-------------------------------");
                        for (int i = 0; i < Estudiante.Length; i++)
                        {
                            Console.WriteLine("Estudiantes numero " + (i + 1) + ": ");
                            Console.WriteLine(Estudiante[i].Nombre + " " + Estudiante[i].Apellido);
                            Console.WriteLine("\n");
                        }
                        Console.WriteLine("\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("\nREPORTE DE ESTUDIANTES");
                        for (int i = 0; i < Estudiante.Length; i++)
                        {
                            Estudiante[i].mostrar();
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        break;

                    default:
                        Console.WriteLine("\n Escriba opcion valida");
                        Console.ReadKey();
                        break;
                }

            } while (op != 4);
            Console.ReadKey();
        }

        string carnet;
        public string Carnet
        {

            get { return carnet; }
            set { carnet = value; }
        }

        string nombre;
        public string Nombre
        {

            get { return nombre; }
            set { nombre = value; }
        }

        string apellido;
        public string Apellido
        {

            get { return apellido; }
            set { apellido = value; }
        }

        string materia;
        public string Materia
        {

            get { return materia; }
            set { materia = value; }
        }

        float[] calificaciones = new float[3];
        public float[] Calificaciones
        {
            get { return calificaciones; }
            set { calificaciones = value; }
        }

        public void ingresarDatos()
        {
            Console.WriteLine("\n Ingrese el carnet del estudiante");
            carnet = Console.ReadLine();
            Console.WriteLine("\n Ingrese el nombre del estudiante");
            nombre = Console.ReadLine();
            Console.WriteLine("\n Ingrese el apellido del estudiante");
            apellido = Console.ReadLine();
            Console.WriteLine("\n Ingrese la materia del estudiante");
            materia = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\n Ingrese la nota {0} de la materia {1} del estudiante {2}: ", i + 1, materia , nombre);
                calificaciones[i] = float.Parse(Console.ReadLine());
            }

        }
        public void mostrar()
        {
            float acumula = 0;
            Console.WriteLine("\nEL alumno: " + Nombre + " " + Apellido + " con carnet" + Carnet);
            Console.WriteLine("\n Esta cursando la materia " + Materia);
            Console.WriteLine("\nSus notas en esta asignatura son:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(calificaciones[i] + " ");
                acumula += calificaciones[i] ;
            }
            float promedio = acumula / calificaciones.Length;
            Console.WriteLine("\n\n Y su promedio es: " + promedio);
            Console.WriteLine("\n\n ------------------------------------");
        }

    }
    }

