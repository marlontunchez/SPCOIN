﻿namespace SPCOIN.Models
{
    public class Producto
    {
        public string? CodigoProducto { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int Unidades { get; set; }
        public decimal Precio { get; set; }
        public decimal Costo { get; set; }
        public int Existencia  { get; set; }
        public bool VenderSinExistencia { get; set; }
    
    }
}
