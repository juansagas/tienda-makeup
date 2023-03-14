﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Maquillaje.Entities.Entities
{
    public partial class tbVentas
    {
        public tbVentas()
        {
            tbVentasDetalle = new HashSet<tbVentasDetalle>();
        }

        public int ven_Id { get; set; }
        public int ven_Cliente { get; set; }
        public int ven_Empleado { get; set; }
        public DateTime? ven_Fecha { get; set; }
        public int ven_Sucursal { get; set; }
        public int ven_MetodoPago { get; set; }
        public int? ven_UsuCrea { get; set; }
        public DateTime? ven_FechaCrea { get; set; }
        public int? ven_UsuModi { get; set; }
        public DateTime? ven_FechaModi { get; set; }
        public bool? ven_Estado { get; set; }

        public virtual tbClientes ven_ClienteNavigation { get; set; }
        public virtual tbEmpleados ven_EmpleadoNavigation { get; set; }
        public virtual tbMetodoPago ven_MetodoPagoNavigation { get; set; }
        public virtual tbSucursales ven_SucursalNavigation { get; set; }
        public virtual tbUsuarios ven_UsuCreaNavigation { get; set; }
        public virtual tbUsuarios ven_UsuModiNavigation { get; set; }
        public virtual ICollection<tbVentasDetalle> tbVentasDetalle { get; set; }
    }
}