﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Maquillaje.Entities.Entities
{
    public partial class tbUsuarios
    {
        public tbUsuarios()
        {
            tbCategoriascat_UsuCreaNavigation = new HashSet<tbCategorias>();
            tbCategoriascat_UsuModiNavigation = new HashSet<tbCategorias>();
            tbClientescli_UsuarioCreaNavigation = new HashSet<tbClientes>();
            tbClientescli_UsuarioModiNavigation = new HashSet<tbClientes>();
            tbDepartamentosdep_UsuarioCreaNavigation = new HashSet<tbDepartamentos>();
            tbDepartamentosdep_UsuarioModiNavigation = new HashSet<tbDepartamentos>();
            tbEmpleadosemp_UsuarioCreaNavigation = new HashSet<tbEmpleados>();
            tbEmpleadosemp_UsuarioModiNavigation = new HashSet<tbEmpleados>();
            tbInventarioinv_UsuCreaNavigation = new HashSet<tbInventario>();
            tbInventarioinv_usuModiNavigation = new HashSet<tbInventario>();
            tbMetodoPagomet_UsuCreaNavigation = new HashSet<tbMetodoPago>();
            tbMetodoPagomet_usuModiNavigation = new HashSet<tbMetodoPago>();
            tbMunicipiosmun_UsuarioCreaNavigation = new HashSet<tbMunicipios>();
            tbMunicipiosmun_UsuarioModiNavigation = new HashSet<tbMunicipios>();
            tbProductospro_UsuModiNavigation = new HashSet<tbProductos>();
            tbProductospro_usuCreaNavigation = new HashSet<tbProductos>();
            tbProveedoresprv_UsuarioCreaNavigation = new HashSet<tbProveedores>();
            tbProveedoresprv_UsuarioModiNavigation = new HashSet<tbProveedores>();
            tbSucursalessuc_UsuCreaNavigation = new HashSet<tbSucursales>();
            tbSucursalessuc_usuModiNavigation = new HashSet<tbSucursales>();
            tbVentasDetallevde_UsuCreaNavigation = new HashSet<tbVentasDetalle>();
            tbVentasDetallevde_UsuModiNavigation = new HashSet<tbVentasDetalle>();
            tbVentasven_UsuCreaNavigation = new HashSet<tbVentas>();
            tbVentasven_UsuModiNavigation = new HashSet<tbVentas>();
        }

        public int usu_ID { get; set; }
        public string usu_Usuario { get; set; }
        public int usu_empID { get; set; }
        public string usu_Clave { get; set; }
        public bool usu_EsAdmin { get; set; }
        public int usu_UsuarioCrea { get; set; }
        public DateTime? usu_FechaCrea { get; set; }
        public int? usu_UsuarioModi { get; set; }
        public DateTime? usu_FechaModi { get; set; }
        public bool? usu_Estado { get; set; }

        public virtual tbEmpleados usu_emp { get; set; }
        public virtual ICollection<tbCategorias> tbCategoriascat_UsuCreaNavigation { get; set; }
        public virtual ICollection<tbCategorias> tbCategoriascat_UsuModiNavigation { get; set; }
        public virtual ICollection<tbClientes> tbClientescli_UsuarioCreaNavigation { get; set; }
        public virtual ICollection<tbClientes> tbClientescli_UsuarioModiNavigation { get; set; }
        public virtual ICollection<tbDepartamentos> tbDepartamentosdep_UsuarioCreaNavigation { get; set; }
        public virtual ICollection<tbDepartamentos> tbDepartamentosdep_UsuarioModiNavigation { get; set; }
        public virtual ICollection<tbEmpleados> tbEmpleadosemp_UsuarioCreaNavigation { get; set; }
        public virtual ICollection<tbEmpleados> tbEmpleadosemp_UsuarioModiNavigation { get; set; }
        public virtual ICollection<tbInventario> tbInventarioinv_UsuCreaNavigation { get; set; }
        public virtual ICollection<tbInventario> tbInventarioinv_usuModiNavigation { get; set; }
        public virtual ICollection<tbMetodoPago> tbMetodoPagomet_UsuCreaNavigation { get; set; }
        public virtual ICollection<tbMetodoPago> tbMetodoPagomet_usuModiNavigation { get; set; }
        public virtual ICollection<tbMunicipios> tbMunicipiosmun_UsuarioCreaNavigation { get; set; }
        public virtual ICollection<tbMunicipios> tbMunicipiosmun_UsuarioModiNavigation { get; set; }
        public virtual ICollection<tbProductos> tbProductospro_UsuModiNavigation { get; set; }
        public virtual ICollection<tbProductos> tbProductospro_usuCreaNavigation { get; set; }
        public virtual ICollection<tbProveedores> tbProveedoresprv_UsuarioCreaNavigation { get; set; }
        public virtual ICollection<tbProveedores> tbProveedoresprv_UsuarioModiNavigation { get; set; }
        public virtual ICollection<tbSucursales> tbSucursalessuc_UsuCreaNavigation { get; set; }
        public virtual ICollection<tbSucursales> tbSucursalessuc_usuModiNavigation { get; set; }
        public virtual ICollection<tbVentasDetalle> tbVentasDetallevde_UsuCreaNavigation { get; set; }
        public virtual ICollection<tbVentasDetalle> tbVentasDetallevde_UsuModiNavigation { get; set; }
        public virtual ICollection<tbVentas> tbVentasven_UsuCreaNavigation { get; set; }
        public virtual ICollection<tbVentas> tbVentasven_UsuModiNavigation { get; set; }
    }
}