using System;
namespace erpkmx.Model.Sales
{
    public class SalesModel
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }
        public string Departament { get; set; }
        public bool Finish { get; set; }
    }
}
