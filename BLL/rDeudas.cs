using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoAplicadaI.BLL;

namespace ProyectoAplicadaI.Registros
{
    public partial class rDeudas : Form
    {
        Deudas deuda = new Deudas();
        Estudiantes estudiante = new Estudiantes();
        Asignaturas asignatura = new Asignaturas();

        public string ValidarCampos()
        {
            string Mensaje = "", Mensaje1 = "", Mensaje2 = "";
            //IdEstudiante
            if (IDEstudianteTextBox.Text.Length == 0)
                Mensaje = "El ID es incorrecto o no existe.";
            else
                Mensaje = "";
            ErrorProvider.SetError(IDEstudianteTextBox, Mensaje);
            //IdAsignatura
            if (IDAsignaturaTextBox.Text.Length == 0)
                Mensaje1 = "El ID es incorrecto o no existe.";
            else
                Mensaje1 = "";
            ErrorProvider.SetError(IDAsignaturaTextBox, Mensaje1);
            //Cantidad
            if (CantidadTextBox.Text.Length == 0)
                Mensaje2 = "Ingrese la cantidad.";
            else
                Mensaje2 = "";
            ErrorProvider.SetError(CantidadTextBox, Mensaje2);

            if (Mensaje == "" && Mensaje1 == "" && Mensaje2 == "")
                return "";
            else return "1";
        }

        public rDeudas()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == "")
            {
                int IDDeuda;
                int.TryParse(IDTextBox.Text, out IDDeuda);

                int IdAsignatura;
                int.TryParse(IDAsignaturaTextBox.Text, out IdAsignatura);

                int IdEstudiante;
                int.TryParse(IDEstudianteTextBox.Text, out IdEstudiante);

                int Cantidad;
                int.TryParse(CantidadTextBox.Text, out Cantidad);

                int Balance;
                int.TryParse(BalanceTextBox.Text, out Balance);

                deuda.IDDeuda = IDDeuda;
                deuda.Fecha = FechaDateTimePicker.Value;
                deuda.Vence = VenceDateTimePicker.Value;
                deuda.IDEstudiante = IdEstudiante;
                deuda.IDAsignatura = IdAsignatura;
                deuda.Cantidad = Cantidad;
                deuda.Balance = Cantidad;

                if (IDDeuda == 0)
                {
                    deuda.Insertar();
                    MessageBox.Show("Los datos se han guardado con éxito.", "Mensaje de Control App");
                    Nuevo();
                }
                else
                {
                    deuda.Modificar();
                    MessageBox.Show("Los datos se han modificado con éxito.", "Mensaje de Control App");
                    Nuevo();
                }
            }
            else
                MessageBox.Show("Los campos están incompleto.", "Mensaje de Control App");
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int IDDeuda = 0;
            int.TryParse(IDTextBox.Text, out IDDeuda);

            if (IDDeuda != 0)
            {
                deuda.IDDeuda = IDDeuda;
                if (deuda.Buscar(IDDeuda) == true)
                {
                    FechaDateTimePicker.Value = deuda.Fecha;
                    VenceDateTimePicker.Value = deuda.Vence;
                    IDEstudianteTextBox.Text = deuda.IDEstudiante.ToString();
                    IDAsignaturaTextBox.Text = deuda.IDAsignatura.ToString();
                    CantidadTextBox.Text = deuda.Cantidad.ToString();
                    BalanceTextBox.Text = deuda.Balance.ToString();
                }
                else
                {
                    MessageBox.Show("El ID es incorrecto o no existe.", "Mensaje de Control App.");
                    Nuevo();
                }
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int IDDeuda = 0;
            int.TryParse(IDTextBox.Text, out IDDeuda);

            if(IDDeuda != 0)
            {
                deuda.Eliminar(IDDeuda);
                MessageBox.Show("Los datos se han eliminado con éxito.", "Mensaje de Control App");
                Nuevo();
            }
            else
                MessageBox.Show("El ID es incorrecto o no existe.", "Mensaje de Control App.");
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public void Nuevo()
        {
            IDTextBox.Clear();
            FechaDateTimePicker.ResetText();
            VenceDateTimePicker.ResetText();
            IDEstudianteTextBox.Clear();
            IDAsignaturaTextBox.Clear();
            CantidadTextBox.Clear();
            BalanceTextBox.Clear();
        }

        private void CantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true) { }
            //Codigo Ascii para el Backspace
            else if (e.KeyChar == '\b') { }
            else
            {
                e.Handled = true;
                MessageBox.Show("Sólo se permiten números.", "Mensaje de Control App");
            }
        }

        private void IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true) { }
            //Codigo Ascii para el Backspace
            else if (e.KeyChar == '\b') { }
            else
            {
                e.Handled = true;
                MessageBox.Show("Sólo se permiten números.", "Mensaje de Control App");
            }
        }

        private void IDEstudianteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true) { }
            //Codigo Ascii para el Backspace
            else if (e.KeyChar == '\b') { }
            else
            {
                e.Handled = true;
                MessageBox.Show("Sólo se permiten números.", "Mensaje de Control App");
            }
        }

        private void IDAsignaturaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true) { }
            //Codigo Ascii para el Backspace
            else if (e.KeyChar == '\b') { }
            else
            {
                e.Handled = true;
                MessageBox.Show("Sólo se permiten números.", "Mensaje de Control App");
            }
        }

        private void IDEstudianteTextBox_Validated(object sender, EventArgs e)
        {
            int IdEstudiante = 0;
            int.TryParse(IDEstudianteTextBox.Text, out IdEstudiante);
            string Mensaje = "";

            if (estudiante.Buscar(IdEstudiante) == true)
                Mensaje = "";
            else
                Mensaje = "El ID es incorrecto o no existe.";
                ErrorProvider.SetError(IDEstudianteTextBox, Mensaje);
        }

        private void IDAsignaturaTextBox_Validated(object sender, EventArgs e)
        {
            int IdAsignatura = 0;
            int.TryParse(IDAsignaturaTextBox.Text, out IdAsignatura);
            string Mensaje = "";

            if (asignatura.Buscar(IdAsignatura) == true)
                Mensaje = "";
            else
                Mensaje = "El ID es incorrecto o no existe.";
                ErrorProvider.SetError(IDAsignaturaTextBox, Mensaje);
        }

        private void IDTextBox_Validated(object sender, EventArgs e)
        {

        }
    }
}
