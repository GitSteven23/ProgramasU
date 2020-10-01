using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramasCorteII
{
    public class NominaEmpleados
    {
        public void EmpleadoNomina()
        {

            #region Variables

            int documentoEmpleado, sueldo, salario, diasTrabajados, hExtraD, hExtraN, hExtraF, auxilios, prestamo, fondo;
            decimal valorExtraD, valorExtraN, recargoNocturno, totalSalario, valorSalud, valorPension, totalDescuentos, valorNeto;
            string nombreEmpleado;

            #endregion

            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("PROGRAMAS CORTE II - C#");
            Console.WriteLine("Nomina de Empleados");
            Console.WriteLine("==============================================");

            Console.WriteLine("Digite documento del empleado: ");
            documentoEmpleado = int.Parse(Console.ReadLine());
        }
    }
}
