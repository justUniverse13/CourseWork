using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models {
    public class Order {

        [BindNever]
        public int id { get; set; }

        [Display(Name = "Name")]
        [StringLength(25)]
        [Required(ErrorMessage = "The length of the input data must be more than 5 characters")]
        public string name { get; set; }

        [Display(Name = "Surname")]
        [StringLength(25)]
        [Required(ErrorMessage = "The length of the input data must be more than 5 characters")]
        public string surname { get; set; }

        [Display(Name = "Address")]
        [StringLength(35)]
        [Required(ErrorMessage = "The length of the input data must be more than 5 characters")]
        public string adress { get; set; }

        [Display(Name = "Mobile number")]
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "The length of the input data must be more than 10 characters")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "The length of the input data must be more than 15 characters")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }

    }
}
