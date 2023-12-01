using ProyectoFinal.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Logica
{
    class Animal
    {
        Datos dt = new Datos();
        public int ingresarAnimal(int codigo, string especie, string nombre, string tipo, int idHabitat, Char genero)
        {
            int res;
            string consulta;
            consulta = "INSERT INTO animal(codigoanimal, nombreespanimal, nombreanimal, generoanimal, tipoanimal, codigohabitat) VALUES("
                +codigo+", '"+especie+"', '"+nombre+"', '"+genero+"', '"+tipo+"', "+idHabitat+")";

            //Enviar consulta a Datos para Ejecutarla
            res = dt.ejecutarDML(consulta);

            return res;
        }

        public DataSet consultarAnimales()
        {
            DataSet miDs = new DataSet();
            String consulta;
            consulta = "select codigoanimal,nombreanimal,nombreespanimal,generoanimal,tipoanimal from animal";
            miDs = dt.ejecutarSELECT(consulta);
            return miDs;
        }

        internal DataSet consultarAnimalXId(int id)
        {
            DataSet miDs = new DataSet();
            string consulta;
            consulta = "select * from animal a inner join Habitat h on a.codigohabitat = h.codigohabitat where a.codigoanimal = " + id;

            miDs = dt.ejecutarSELECT(consulta);
            return miDs;
        }

        internal DataSet consultarCronograma()
        {
            DataSet miDs = new DataSet();
            String consulta;
            consulta = "select nombreanimal,nombreEspanimal as Especie,nombretrabajador as NombreVeterinario," +
                "apellidotrabajador as ApellidoVeterinario,fechaatiende as FechaAtencion from trabajador t inner join " +
                "(select * from atiende at inner join animal a on at.codigoanimal = a.codigoanimal) t1 on t.codigotrabajador = t1.codigotrabajador";
            miDs = dt.ejecutarSELECT(consulta);
            return miDs;
        }
    }
}
