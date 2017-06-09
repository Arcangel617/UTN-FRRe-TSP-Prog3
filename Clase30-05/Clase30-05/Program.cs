using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Clase30_05
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable editoriales = new DataTable("Editoriales");
            editoriales.Columns.Add("nombre", typeof(string));
            editoriales.Columns.Add("dirección", typeof(string));
            editoriales.Columns.Add("telefono", typeof(string));
            editoriales.Columns.Add("cod_editorial", typeof(int));

            DataTable libros = new DataTable("Libros");
            libros.Columns.Add("isbn", typeof(long));
            libros.Columns.Add("titulo", typeof(string));
            libros.Columns.Add("autor", typeof(string));
            libros.Columns.Add("cod_editorial", typeof(int));

            editoriales.Rows.Add("Editoria_1", "Ed1dir 1234", "11223344", 1);
            editoriales.Rows.Add("Editoria_2", "Ed2dir 5678", "11223345", 2);
            editoriales.Rows.Add("Editoria_3", "Ed3dir 9012", "11223346", 3);
            editoriales.Rows.Add("Editoria_4", "Ed4dir 3456", "11223347", 4);
            editoriales.Rows.Add("Editoria_5", "Ed5dir 7890", "11223348", 5);

            libros.Rows.Add(112233445566, "Libro_1", "Autor_Libro1", 2);
            libros.Rows.Add(772233445566, "Libro_2", "Autor_Libro2", 1);
            libros.Rows.Add(882233445566, "Libro_3", "Autor_Libro3", 1);
            libros.Rows.Add(992233445566, "Libro_4", "Autor_Libro4", 5);
            libros.Rows.Add(110033445566, "Libro_5", "Autor_Libro5", 4);


            DataRow[] editorialesResult = editoriales.Select(null, "cod_editorial desc", DataViewRowState.CurrentRows);

            if (editorialesResult.Length < 1)
                Console.WriteLine("No Current Rows Found");
            else
            {
                foreach (DataColumn column in editoriales.Columns)
                    Console.Write("\t{0}", column.ColumnName);

                Console.WriteLine("\tRowState");

                foreach (DataRow row in editorialesResult)
                {
                    foreach (DataColumn column in editoriales.Columns)
                        Console.Write("\t{0}", row[column]);

                    Console.WriteLine("\t" + row.RowState);
                }
            }

            //DataRow[] librosResult = libros.Select(null, null, DataViewRowState.CurrentRows);
            DataRow[] librosResult = libros.Select("cod_editorial = 1");

            if (librosResult.Length < 1)
                Console.WriteLine("No Current Rows Found");
            else
            {
                foreach (DataColumn column in libros.Columns)
                    Console.Write("\t{0}", column.ColumnName);

                Console.WriteLine("\tRowState");

                foreach (DataRow row in librosResult)
                {
                    foreach (DataColumn column in libros.Columns)
                        Console.Write("\t{0}", row[column]);

                    Console.WriteLine("\t" + row.RowState);
                }
            }

            DataSet ds = new DataSet();
            ds.Tables.Add(libros);
            ds.Tables.Add(editoriales);

            // Get the DataColumn objects from two DataTable objects 
            // in a DataSet. Code to get the DataSet not shown here.
            DataColumn parentColumn = ds.Tables["Editoriales"].Columns["cod_editorial"];
            DataColumn childColumn = ds.Tables["Libros"].Columns["cod_editorial"];
            
            // Create DataRelation.
            DataRelation dr;
            dr = new DataRelation("LibrosxEditorial", parentColumn, childColumn);
            // Add the relation to the DataSet.
            ds.Relations.Add(dr);


            foreach (DataRow row in librosResult)
            {
                foreach (DataColumn column in libros.Columns)
                    Console.Write("\t{0}", row[column]);

                Console.WriteLine("\t" + row.RowState);
            }


            Console.ReadLine();







            //que es un datatable
            //como está compuesto

            //Un objeto DataTable representa una tabla de datos relacionales de la memoria;

            //un datacolumn necesita de un datatable no asi un datatable de un dataset.

            //las relaciones entre datatables solo tienen sentido si hay un dataset.


            //Ejercicio

            //-Para el sistema de una biblioteca, se deben almacenar, las editoriales y sus
            //libros.
            //-Para cada editorial se desea guardar su nombre, dirección, telefono, y código
            //de editorial
            //-Para cada libro se desea guardar su ISBN, Titulo, Autor y el código de la editorial
            //-Cargue todos los datos en dos DataTables.
        }
    }
}