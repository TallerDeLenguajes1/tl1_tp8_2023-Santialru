using lasTareas;
using System;

List<tareas> TodasTareas = new List<tareas>();
List<tareas> TareasPendientes = new List<tareas>();
List<tareas> TareasRealizadas = new List<tareas>();

Console.WriteLine("Cuantas tareas desea cargar?");
int canti = int.Parse(Console.ReadLine());

string[] tipo = {"limpiar", "reponer", "contar"};


for (int i = 0; i < canti; i++)
{
    Random random = new Random();
    tareas band = new tareas();
    band.TareaID = i;
    band.Duracion = random.Next(10,100);
    band.Descripcion = tipo[1];
    TodasTareas.Add(band);
}

foreach (tareas tarea in TodasTareas)
{
    Console.WriteLine(tarea);
}