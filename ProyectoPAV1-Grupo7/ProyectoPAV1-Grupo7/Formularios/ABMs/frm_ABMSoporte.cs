﻿using ProyectoPAV1_Grupo7.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV1_Grupo7.Formularios.ABMs
{

public partial class frm_ABMSoporte : Form
    {
        static class NombreTabla
        {
            public static string nombreTabla;
        }
        public frm_ABMSoporte(string nombre)
        {
            InitializeComponent();
            NombreTabla.nombreTabla = nombre;
        }

        private void CargarGrilla()
        {
            string tablaNom = NombreTabla.nombreTabla;

            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM " + tablaNom;
            DataTable tabla = conexion.ejecutar_consulta(sql);
            dgrSoporte.DataSource = tabla;
        }

        //Seleccion de item en grilla
        private void dgrSoporte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tablaNom = NombreTabla.nombreTabla;
            int indice = e.RowIndex;
            if (indice != -1)
            {
                LimpiarCampos();
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
                txtBoxNombre.Enabled = true;
                DataGridViewRow fila = dgrSoporte.Rows[indice];
                string id = fila.Cells["NUMERO DE IDENTIFFICACIONS"].Value.ToString();
                NivelUrgencia urgencia = ObtenerUrgencia("id" + tablaNom, int.Parse(id));
                CargarCampos(urgencia);
            }
        }

        //Obtener estacion de Base de datos
        private NivelUrgencia ObtenerUrgencia(string propiedad, int id )
        {
            string tablaNom = NombreTabla.nombreTabla;
            ConexionBD conexion = new ConexionBD();
            string sql = "SELECT * FROM " + tablaNom + " WHERE " + propiedad + " like '" + id + "'";
            DataTable tabla = conexion.ejecutar_consulta(sql);

            string nombre = tabla.Rows[0]["nombre"].ToString();
            int numeroID = int.Parse(tabla.Rows[0][propiedad].ToString());

            NivelUrgencia urgencia = new NivelUrgencia(numeroID, nombre);
            return urgencia;
        }

        //Cargar campos de TEXTO automaticamente.
        private void CargarCampos(NivelUrgencia urgencia)
        {
            txtBoxNombre.Text = urgencia.Nombre.ToString();
            txtCodigo.Text = urgencia.IdEstado.ToString();
        }

        //FUNCION LIMPIAR CAMPOS
        private void LimpiarCampos()
        {
            txtBoxNombre.Text = "";
            txtCodigo.Text = "";
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Borrar estacion de base de datos
        private bool BorrarEstacionBD(NivelUrgencia urgencia)
        {
            string nombreTabla = NombreTabla.nombreTabla;
            bool resultado = false;
            ConexionBD conexion = new ConexionBD();
            try
            {
                string sql = "DELETE FROM " + nombreTabla +" WHERE id" + nombreTabla + " = '" + urgencia.IdEstado + "'";

                conexion.borrar(sql);

                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar datos: Base de datos corrompida");
            }
            return resultado;
        }

        //Guardar en base de datos.
        private bool GuardarUrgenciaBD(NivelUrgencia urgencia)
        {
            bool resultado = false;
            string tabla = NombreTabla.nombreTabla;

            ConexionBD conexion = new ConexionBD();
            try
            {
                string sql = "INSERT INTO " + tabla + " VALUES ('" + urgencia.Nombre + "' )";

                conexion.insertar(sql);

                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar datos");
            }
            return resultado;
        }

        //Actualizar datos en bd 
        private bool ActualizarUrgenciaBD(NivelUrgencia urgencia)
        {
            bool resultado = false;
            ConexionBD conexion = new ConexionBD();
            string tabla = NombreTabla.nombreTabla;
            try
            {
                string sql = "UPDATE " + tabla + " SET nombre = ' " + urgencia.Nombre + "' WHERE id" + tabla + " = ' " + urgencia.IdEstado + " '";

                conexion.modificar(sql);

                resultado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error en cargar datos: Base de datos corrompida");
            }
            return resultado;
        }

        //Control De existencia de estacion.
        private bool ExisteUrgencia(int Criterio)
        {
            bool resultado = false;
            for (int i = 0; i < dgrSoporte.Rows.Count; i++)
            {
                if (dgrSoporte.Rows[i].Cells["ID"].Value.Equals(Criterio))
                {
                    resultado = true;
                    MessageBox.Show("Ya existe una urgencia con ese id");
                    break;

                }
            }
            return resultado;

        }

        //Valida datos obligatorios
        private bool CargoCampos(NivelUrgencia urgencia)
        {
            bool resultado = true;
            if (urgencia.Nombre.Equals(""))
            {
                resultado = false;
                MessageBox.Show("El nombre es obligatorio");

            }

            return resultado;
        }

        //OBTENER DATOS DE LOS CAMPOS DE TEXTO
        private NivelUrgencia ObtenerDatosUrgencia()
        {
            //VARIABLES DE CONTROL
            string nombre = txtBoxNombre.Text.Trim();

            NivelUrgencia urg = new NivelUrgencia(nombre);

            return urg;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreTabla = NombreTabla.nombreTabla;
            NivelUrgencia urgencia = ObtenerDatosUrgencia();
            if (CargoCampos(urgencia))
            {
                bool resultado = GuardarUrgenciaBD(urgencia);
                if (resultado)
                {
                    MessageBox.Show(nombreTabla + " cargada con exito!!");
                    LimpiarCampos();
                    CargarGrilla();
                    txtBoxNombre.Focus();
                }
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            NivelUrgencia urgencia = ObtenerDatosUrgencia();
            if (CargoCampos(urgencia))
            {
                urgencia.IdEstado = int.Parse(txtCodigo.Text);

                bool resultado = ActualizarUrgenciaBD(urgencia);
                if (resultado)
                {
                    MessageBox.Show("Urgencia Modificada con exito");
                    LimpiarCampos();
                    CargarGrilla();
                    txtBoxNombre.Focus();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombreTabla = NombreTabla.nombreTabla;
            NivelUrgencia urgencia = ObtenerDatosUrgencia();
            if (CargoCampos(urgencia))
            {
                urgencia.IdEstado = int.Parse(txtCodigo.Text);
                bool resultado = BorrarEstacionBD(urgencia);
                if (resultado)
                {
                    MessageBox.Show(nombreTabla + " eliminado con exito");
                    LimpiarCampos();
                    CargarGrilla();
                    txtBoxNombre.Focus();
                }
            }
        }

        private void frm_ABMSoporte_Load(object sender, EventArgs e)
        {
            string nombreTabla = NombreTabla.nombreTabla;
            lblTitulo.Text = nombreTabla;
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Numero Identificacion";
            column.DataPropertyName = "id" + nombreTabla;
            column.Name = "NUMERO DE IDENTIFFICACIONS";
            dgrSoporte.Columns.Add(column);
            txtCodigo.Enabled = false;
            CargarGrilla();
        }
    }
}
