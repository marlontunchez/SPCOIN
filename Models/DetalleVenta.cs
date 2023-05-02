﻿namespace SPCOIN.Models
{
    public class DetalleVenta
    {
        public int CodigoVenta { get; set; }
        public int CodigoDetalleVenta { get; set; }  
        public string? CodigoProducto { get; set; }  
        public string? Nombre { get; set; }
        public int Unidades { get; set; }   
        public decimal Precio { get; set; } 
        public decimal Total    { get; set; }
        public int CodigoAsignacionPermisos { get; set; }   
        public decimal Descuento { get; set; }      


    }
}
