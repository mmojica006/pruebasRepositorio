using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EAlumnos
    {
        #region "Atributos"
        private int IdAlumno;
        private string Nombres;
        private string Apellidos;
        private string Cedula;
        private string Sexo;
        private DateTime FechaNac ;
	    private string NomPadre;
        private string NomMadre;
        private string NomApoderado;
        private string Telefono;
        private string Celular;
        private string Direccion;
        private byte[] Foto;
        private string Distrito;
        private string Estado;

        #endregion
        public EAlumnos ()
            {

            }

        public int idAlumno
        {
            get { return IdAlumno; }
            set { IdAlumno = value; }
        }
        public string nombres
        {
            get { return Nombres; }
            set { Nombres = value; }
        }
        public string npellidos
        {
            get { return Apellidos; }
            set { Apellidos = value; }
        }
        public string cedula
        {
            get { return Cedula; }
            set { Cedula = value; }
        }
        public string sexo
        {
            get { return Sexo; }
            set { Sexo = value; }
        }
        public DateTime fechaNac
	{
		get { return FechaNac; }
        set { FechaNac = value; }
	}
	    public string nomPadre
    {
        get { return NomPadre; }
        set { NomPadre = value; }
    }
    public string nomMadre
    {
        get { return NomMadre; }
        set { NomMadre = value; }
    }
    public string nomApoderado
    {
           get { return NomApoderado; }
        set { NomApoderado = value; }
    }
    public string telefono
    {
        get { return Telefono; }
        set { Telefono = value; }
    }
    public string celular
    {
        get { return Celular; }
        set { Celular = value; }
    }
    public string direccion
    {
        get { return Direccion; }
        set { Direccion = value; }
    }

        public byte[] foto
        {
         get { return Foto; }
            set { Foto = value; }
        }
    public string distrito
    {
        get { return Distrito; }
        set { Distrito = value; }
}
    public string dstado
    {
        get { return Estado; }
        set { Estado = value; }
    }


    }
}
