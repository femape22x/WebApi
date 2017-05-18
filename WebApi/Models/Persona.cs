using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApi.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Identificacion { get; set; }
        public String Direccion { get; set; }
        public String Correo { get; set; }
        public String Celular { get; set; }

        public Persona() { }

        public Persona(int id, String nombre, String apellido, String identificacion, String direccion, String correo, String celular)
        {
            this.Id = id;
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Identificacion = identificacion;
            this.Direccion = direccion;
            this.Correo = correo;
            this.Celular = celular;
        }
    }

    public class PersonaDbContext : DbContext
    {
        //public DbSet<Persona> Personas { get; set; }

        Persona[] personas = new Persona[]
        {
            new Persona{Id=1,Nombre="Felix",Apellido="Marrugo",Identificacion="1047408315",Direccion="Zaragocilla",Correo="femape22x@hotmail.con",Celular="3135944542"},
            new Persona{Id=2,Nombre="Sindy",Apellido="Palomino",Identificacion="1047312456",Direccion="Calamares",Correo="sindy22x@hotmail.con",Celular="3141234569"},
            new Persona{Id=3,Nombre="Oscar",Apellido="Rodriguez",Identificacion="1047442913",Direccion="Escallon Villa",Correo="oscar22x@hotmail.con",Celular="3157894562"}
        };

        public IEnumerable<Persona> Personas()
        {
            return personas;
        }
    }
}