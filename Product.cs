using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionWork
{
    internal class Product
    {
        [Required(ErrorMessage = "Product ID is required!")]
        [Range(1, int.MaxValue, ErrorMessage = "Product ID should be a positive integer only!")]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Product Name is required!")]
        [StringLength(100, ErrorMessage = "Product Name can have a maximum of 100 characters!")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Quantity in Stock is required!")]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity in Stock must be a non-negative integer!")]
        public int QuantityInStock { get; set; }

        [Required(ErrorMessage = "Unit Price is required!")]
        [Range(0, int.MaxValue, ErrorMessage = "Unit Price must be a positive num!")]
        public int UnitPrice { get; set; }

        [Required(ErrorMessage = "Supplier Email is required!")]
        [EmailAddress(ErrorMessage = "Invalid email!")]
        public string SupplierEmail { get; set; }
    }
}