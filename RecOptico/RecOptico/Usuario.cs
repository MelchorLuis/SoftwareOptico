﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RecOptico
{
    class Usuario
    {
        public static int CrearCuenta(String pNombre, String pApellido, String pFNac, String pSexo, String PCorreo, String pContraseña)
        {
            int resultado = 0;
            SqlConnection Con = DBComun.ObtenerConexion();
            SqlCommand Comando = new SqlCommand(string.Format("Insert Into Usuario (Nombre_Usuario, Apellido_Usuario, Sexo_Usuario, Nacimiento_Usuario, Correo_Usuario, Contrasena_Usuario) values ('{0}','{1}','{2}','{3}','{4}','{5}')", pNombre, pApellido, pSexo, pFNac, PCorreo, pContraseña), Con);
            resultado = Comando.ExecuteNonQuery();
            Con.Close();
            return resultado;
        }
        public static int DatosPaciente(String pNombres, String Apellidos, String Edad, String Telefono, String Correo, String Direccion)
        {
            int resultado = 0;
            SqlConnection Con = DBComun.ObtenerConexion();
            SqlCommand comando = new SqlCommand(string.Format("Insert into Pacientes (Nombre_Pacientes, Apellido_Pacientes, Edad_Pacientes, Telefono_Pacientes, Correo_Pacientes, Direccion) " +
                "values ('{0}', '{1}','{2}','{3}','{4}','{5}')", pNombres, Apellidos, Edad, Telefono, Correo, Direccion),Con);
            resultado = comando.ExecuteNonQuery();
            Con.Close();
            return resultado;
        }
        public static int Receta(String EsfeDerLejos, String CilDerLejos, String EjeDerLejos, String EsfeIzqLejos, String CilIzqLejos, String EjeIzqLejos,
            String EsfeDerCerca, String CilDerCerca, String EjeDerCerca, String EsfeIzqCerca, String CilIzqCerca, String EjeIzqCerca,
            String DIP, String Observaciones, String Telefono)
        {
            int resultado = 0;
            int resultado2 = 0;
            SqlConnection Con = DBComun.ObtenerConexion();
            SqlCommand select = new SqlCommand(string.Format("select max(ID_Pacientes) from Pacientes"),Con);
            resultado2 = select.ExecuteNonQuery();
            SqlCommand comando2 = new SqlCommand(string.Format("Insert into Examen (EsferaLejosDerecho, CilindroLejosDerecho, EjeLejosDerecho, EsferaLejosIzquierdo, CilindroLejosIzquierdo, EjeLejosIzquierdo, " +
                "EsferaCercaDerecho, CilindroCercaDerecho, EjeCercaDerecho, EsferaCercaIzquierdo, CilindroCercaIzquierda, EjeCercaIzquierdo, DIP, ID_Pacientes, Observaciones)" +
                "values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}', '{13}', '{14}')",
                EsfeDerLejos, CilDerLejos, EjeDerLejos, EsfeIzqLejos, CilIzqLejos, EjeIzqLejos,
                EsfeDerCerca, CilDerCerca, EjeDerCerca, EsfeIzqCerca, CilIzqCerca, EjeIzqCerca, DIP, resultado2, Observaciones),Con);
            resultado = comando2.ExecuteNonQuery();
            Con.Close();
            return resultado;
        }
        public static int Eliminar(int pFolio)
        {
            int resultado = 0;
            SqlConnection Con = DBComun.ObtenerConexion();
            SqlCommand Comando = new SqlCommand(string.Format("delete from Pacientes where ID_Pacientes = '{0}'", pFolio),Con);
            resultado = Comando.ExecuteNonQuery();
            Con.Close();
            return resultado;
        }
        public static int Buscar(int pFolio)
        {
            int resultado = 0;
            SqlConnection Con = DBComun.ObtenerConexion();
            SqlCommand Comando = new SqlCommand(string.Format("select * from Historial_Pagos where ID_Pacientes = '{0}'", pFolio), Con);
            resultado = Comando.ExecuteNonQuery();
            Con.Close();
            return resultado;
        }
        public static int Autentificar(string pUsuario, string pContraseña)
        {
            int resultado = -1;
            SqlConnection conexion = DBComun.ObtenerConexion();
            SqlCommand comando = new SqlCommand(string.Format(
                "select * from usuario where Correo_Usuario = '{0}' and Contrasena_Usuario = '{1}'", pUsuario, pContraseña), conexion);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                resultado = 50;
            }
            conexion.Close();
            return resultado;
        }
        public static string Existe(string pUsuario)
        {
            SqlCommand cmd;
            string us = "";
            SqlConnection conn = DBComun.ObtenerConexion();
            string query = "select IDUsuario from usuario where username = " + pUsuario;
            try
            {
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", pUsuario);
                conn.Open();
                us = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return us;
        }
        public static string ValidarCorreo(string Correo)
        {
            String Contrasena = "";
            SqlConnection Con = DBComun.ObtenerConexion();
            SqlCommand Comando = new SqlCommand(string.Format("select Contrasena_Usuario from Usuario where Correo_Usuario = " + Correo));
            Contrasena = Comando.ExecuteScalar().ToString();
            Con.Close();
            return Contrasena;
        }
    }
}
