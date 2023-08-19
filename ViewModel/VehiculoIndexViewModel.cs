using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Race_Track.Models;

namespace Race_Track.ViewModels;

public class VehiculoIndexViewModel{
public List<Vehiculo> vehiculos {get; set; } = new List<Vehiculo>();

        public String? NameFilter { get; set; }

        public int VehiculoId { get; set; }

        public string? VehiculoNombre {get; set;}

        public string? VehiculoApellido {get; set;}

        public string? VehiculoTipo {get; set;}

        public string? VehiculoMatricula {get; set;}

        public DateTime VehiculoFabricacion {get;set;}  
        public int AeronaveCosto {get; set;}
        public ICollection<Piloto> PilotoList { get; set; } = new List<Piloto>();  

}