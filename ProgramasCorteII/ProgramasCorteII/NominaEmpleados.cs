using System;

namespace ProgramasCorteII
{
    public class NominaEmpleados
    {
        public void EmpleadoNomina()
        {

            #region Variables

            int documentoEmpleado, sueldo, salario, diasTrabajados, hExtraD, hExtraN, hExtraF, prestamo;
            double valorExtraD, valorExtraN, valorExtraF, recargoNocturno, totalSalario, valorSalud, valorPension, totalDescuentos, valorNeto;
            string nombreEmpleado;

            int fondo = 0;
            int auxilioTransporte = 0;
            int salarioDerechoAuxilio = 1755604;
            int salarioDescuentoFondo = 3511208;
            int valorAuxilioMes = 102853;

            #endregion

            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("PROGRAMAS CORTE II - C#");
            Console.WriteLine("Nomina de Empleados");
            Console.WriteLine("==============================================");

            Console.WriteLine("Digite documento del empleado: ");
            documentoEmpleado = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite nombre del empleado: ");
            nombreEmpleado = Console.ReadLine();
            Console.WriteLine("Digite salario del empleado: " + nombreEmpleado);
            salario = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite días laborados del empleado en el mes: ");
            diasTrabajados = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite horas extras diurnas laboradas en el mes: ");
            hExtraD = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite horas extras nocturnas laboradas en el mes: ");
            hExtraN = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite horas extras en festivos laboradas en el mes: ");
            hExtraF = int.Parse(Console.ReadLine());

            //Calculo de los valores adicionales a la nómina del empleado
            if (salario <= salarioDerechoAuxilio)
            {
                auxilioTransporte = (valorAuxilioMes / 30) * diasTrabajados;
            }

            //Sueldo empleado
            sueldo = (salario / 30) * diasTrabajados;

            //Horas extras
            valorExtraD = salario / 240 * hExtraD * 1.25;
            valorExtraN = salario / 240 * hExtraD * 1.75;
            valorExtraF = salario / 240 * hExtraD * 2;

            //Otros calculos
            recargoNocturno = salario / 30 * 0.35;
            totalSalario = auxilioTransporte + sueldo + valorExtraD + valorExtraN + valorExtraF + recargoNocturno;

            //Descuentos
            valorSalud = (totalSalario - auxilioTransporte) * 4 / 100;
            valorPension = (totalSalario - auxilioTransporte) * 4 / 100;
            prestamo = salario * 20 / 100;
            if (salario >= salarioDescuentoFondo)
            {
                fondo = salario * 1 / 100;
            }

            //Valor a pagar menos descuentos
            totalDescuentos = valorSalud + valorPension + prestamo + fondo;
            valorNeto = totalSalario - totalDescuentos;

            Console.WriteLine("==============================================");
            Console.WriteLine("Nomina de Empleado " + nombreEmpleado);
            Console.WriteLine("==============================================");
            Console.WriteLine("Cedula:" + documentoEmpleado);
            Console.WriteLine("Nombre:" + nombreEmpleado);
            Console.WriteLine("Salario:" + salario);
            Console.WriteLine("Dias trabajados:" + diasTrabajados);
            Console.WriteLine("Horas Extras Diurnas:" + hExtraD);
            Console.WriteLine("Horas Extras Nocturnas:" + hExtraN);
            Console.WriteLine("Horas Extras festivas:" + hExtraF);
            Console.WriteLine("Sueldo:" + sueldo);
            Console.WriteLine("Auxilio de Transporte:" + auxilioTransporte);
            Console.WriteLine("Valor Horas Extras Diurnas:" + valorExtraD);
            Console.WriteLine("Valor Horas Extras Nocturnas:" + valorExtraN);
            Console.WriteLine("Valor Horas Extras Festivas:" + valorExtraF);
            Console.WriteLine("Recargo Nocturno:" + recargoNocturno);
            Console.WriteLine("Total Devengado:" + totalSalario);
            Console.WriteLine("Aporte Salud:" + valorSalud);
            Console.WriteLine("Aporte Pension:" + valorPension);
            Console.WriteLine("Prestamos:" + prestamo);
            Console.WriteLine("Fondo de Solidaridad:" + fondo);
            Console.WriteLine("Total Deducido:" + totalDescuentos);
            Console.WriteLine("Neto Pagado:" + valorNeto);
        }
    }
}
