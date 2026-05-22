using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        Alumno a1 = new Alumno(1, "Campos Ana Sofia", 10);
        Alumno a2 = new Alumno(2, "Gomez Carlos", 7);
        Alumno a3 = new Alumno(3, "Diaz Ana Maria", 8);

        casoList.AgregarAlumnos(a1);
        casoList.AgregarAlumnos(a2);
        casoList.AgregarAlumnos(a3);

        //LISTA DE ALUMNOS
       List<Alumno> lista = casoList.RetornarLista();
        Console.WriteLine("\nALUMNOS:");
        for(int i=0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }

        //ALUMNO EXISTENTE
        Console.WriteLine("\nBuscar a: Gomez Carlos");
        Alumno encontrado = casoList.BuscarPorNombre("Gomez Carlos");
        if (encontrado != null)
        {
            Console.WriteLine(encontrado);
        }

        //ALUMNO INEXISTENTE
        Console.WriteLine("\nBuscar a: Mariani Gisella");
        Alumno noEncontrado = casoList.BuscarPorNombre("Mariani Gisella");
        if(noEncontrado == null)
        {
            Console.WriteLine("\nNo existe");
        }

        //ELIMINAR ALUMNO
        casoList.EliminarAlumno(a2);
        Console.WriteLine("\nEliminar a Gomez Carlos");
        lista = casoList.RetornarLista();

        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }

        //ELIMINAR PRIMER ELEMENTO
        casoList.EliminarPorLista(0);
        Console.WriteLine("\nEliminar primer elemento");
        lista = casoList.RetornarLista();

        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDictionary = new CasoDictionary();

        Alumno a1 = new Alumno(1, "Campos Ana Sofia", 10);
        Alumno a2 = new Alumno(2, "Gomez Carlos", 7);
        Alumno a3 = new Alumno(3, "Diaz Ana Maria", 8);

        casoDictionary.AgregarAlumno(60240, a1);
        casoDictionary.AgregarAlumno(60241, a2);
        casoDictionary.AgregarAlumno(60242, a3);

        //LISTA
        Console.WriteLine("\nDICCIONARIO DE ALUMNOS");

        List<int> claves = casoDictionary.RetornarDiccionario().Keys.ToList();

        for (int i = 0; i < claves.Count; i++)
        {
            int clave = claves[i];
            Alumno alumno = casoDictionary.RetornarDiccionario()[clave];

            Console.WriteLine($"Legajo: {clave} - {alumno}");
        }

        //ALUMNO EXISTENTE
        Console.WriteLine("\nBUSCAR LEGAJO 60242");

        Alumno encontrado = casoDictionary.BuscarAlumno(60242);

        Console.WriteLine(encontrado);

        //ALUMNO INEXISTENTE
        Console.WriteLine("\nBUSCAR LEGAJO 60248");

        if (casoDictionary.RetornarDiccionario().ContainsKey(60248))
        {
            Console.WriteLine(casoDictionary.BuscarAlumno(60248));
        }
        else
        {
            Console.WriteLine("\nNo existe");
        }

        //ELIMINAR ALUMNO
        casoDictionary.EliminarAlumno(60240);

        Console.WriteLine("\nELIMINAR LEGAJO 60240");

        claves = casoDictionary.RetornarDiccionario().Keys.ToList();

        for (int i = 0; i < claves.Count; i++)
        {
            int clave = claves[i];
            Alumno alumno = casoDictionary.RetornarDiccionario()[clave];

            Console.WriteLine($"Legajo: {clave} - {alumno}");
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine("Primer libro");
        Console.WriteLine(casoLinq.GetPrimero());

        Console.WriteLine("\nUltimo libro");
        Console.WriteLine(casoLinq.GetUltimo());

        Console.WriteLine("\nSuma total de los precios");
        Console.WriteLine(casoLinq.GetTotalPrecios());

        Console.WriteLine("\nPromedio");
        Console.WriteLine(casoLinq.GetPromedio());

        Console.WriteLine("\nLibro con ID mayor a 15");

        List<Libro> listaId = casoLinq.GetListById();

        for (int i = 0; i < listaId.Count; i++)
        {
            Console.WriteLine(listaId[i]);
        }

        Console.WriteLine("\nLibros");

        List<string> listaLibros = casoLinq.GetLibro();

        for (int i = 0; i < listaLibros.Count; i++)
        {
            Console.WriteLine(listaLibros[i]);
        }

        Console.WriteLine("\nLibro con mayor precio");
        Console.WriteLine(casoLinq.GetMayorPrecio());

        Console.WriteLine("\nLibro con menor precio");
        Console.WriteLine(casoLinq.GetMenorPrecio());

        Console.WriteLine("\nLibros mayores al promedio");

        List<Libro> listaPromedio = casoLinq.GetMayorPromedio();

        for (int i = 0; i < listaPromedio.Count; i++)
        {
            Console.WriteLine(listaPromedio[i]);
        }

        Console.WriteLine("\nLibros ordenados por titulo");

        List<Libro> listaOrdenada = casoLinq.GetOrdenadosPorTitulo();

        for (int i = 0; i < listaOrdenada.Count; i++)
        {
            Console.WriteLine(listaOrdenada[i]);
        }
    }
}
