namespace DefaultNamespace;

 public class Producto
    {
        public int ProductoID { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public int Stock { get; set; }
        public int StockApartado { get; set; }
        public int StockMinimo { get; set; }

        // Relaciones
        public ICollection<ProductoAtributo>? Atributos { get; set; }
        public ICollection<Movimiento>? Movimientos { get; set; }
        public ICollection<Reserva>? Reservas { get; set; }
    }