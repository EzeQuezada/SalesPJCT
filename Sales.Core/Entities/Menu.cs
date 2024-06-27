﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>

using Sales.Core.Core;


namespace Sales.Infraestructure.Entities;

public partial class Menu : BaseEntity
{
    public int Id { get; set; }

    public int? IdMenuPadre { get; set; }

    public string Icono { get; set; }

    public string Controlador { get; set; }

    public string PaginaAccion { get; set; }

    public virtual Menu IdMenuPadreNavigation { get; set; }

    public virtual ICollection<Menu> InverseIdMenuPadreNavigation { get; set; } = new List<Menu>();

    public virtual ICollection<RolMenu> RolMenus { get; set; } = new List<RolMenu>();
}