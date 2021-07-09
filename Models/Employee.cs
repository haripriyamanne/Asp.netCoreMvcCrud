using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asp.netCoreMvcCrud.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "FirstName is mandatory")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "LastName is mandatory")]
        public string LastName { get; set; }
        //[RegularExpression("^[a-z0-9][@][g][m][a][i][l][.][c][o][m]$")]
        [Required(ErrorMessage = "Email is mandatory")]
        [Column(TypeName = "nvarchar(250)")]
        public string Email { get; set; }
        [Display(Name = "Phone Number")]
        [Column(TypeName = "nvarchar(10)")]
        //[RegularExpression("^[6-9]{1}[0-9]{9}$")]
        [Required(ErrorMessage = "Phone Number is mandatory")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Gender is mandatory")]
        [Column(TypeName = "nvarchar(10)")]
        public Gender Gender { get; set; }
        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "Company Name is mandatory")]
        [Column(TypeName = "nvarchar(250)")]
        public string CompanyName { get; set; }
        [Display(Name = "Company Type")]
        [Required(ErrorMessage = "Company Type is mandatory")]
        [Column(TypeName = "nvarchar(250)")]
        public CompanyType CompanyType { get; set; }
        [Display(Name = "Company Limited")]
        [Required(ErrorMessage = "Company Limited is mandatory")]
        [Column(TypeName = "nvarchar(250)")]
        public string CompanyLimited { get; set; }
        [Display(Name = "Company Website")]
        [Required(ErrorMessage = "Company Website is mandatory")]
        [Column(TypeName = "nvarchar(250)")]
        public string CompanyWebsite { get; set; }
        [Display(Name = "Please Describe Your Business")]
        [Required(ErrorMessage = "This field is mandatory")]
        [Column(TypeName = "nvarchar(250)")]
        public string Busineess { get; set; }
        [Display(Name = "Please Provide 3-7 Benefits that you offers to your Customers")]
        [Required(ErrorMessage = "This field is mandatory")]
        [Column(TypeName = "nvarchar(250)")]
        public string Benifits { get; set; }
        [Display(Name = "Please List the Products or Services you want to showcase your HomePage")]
        [Required(ErrorMessage = "This field is mandatory")]
        [Column(TypeName = "nvarchar(250)")]
        public string ListProducts { get; set; }
        [Display(Name = "Add 1-3 Trust Elements")]
        [Required(ErrorMessage = "This field is mandatory")]
        [Column(TypeName = "nvarchar(250)")]
        [StringLength(100, MinimumLength = 3)]
        public string TrustElements { get; set; }
        //[Display(Name = "List any Service areas you want to target")]
        //[Required(ErrorMessage = "This field is mandatory")]
        //[Column(TypeName = "nvarchar(250)")]
        //public List<CheckBoxModel> ServiceAreas { get; set; }
        [Display(Name = "List Anything else you would like to mention or feel is important")]
        [Required(ErrorMessage = "This field is mandatory")]
        [Column(TypeName = "nvarchar(250)")]
        public string ImportantAreas { get; set; }
        [Display(Name = "List one website example that you like and what you like about them ?")]
        [Required(ErrorMessage = "This field is mandatory")]
        [Column(TypeName = "nvarchar(250)")]
        public string WebsiteExample { get; set; }

    }
    public enum Gender
    {
        Male,
        Female
    }
    public enum CompanyType
    {
        Manfacturing,
        Industry,
        Software,
        NGO,
        OutSourcing
    }
    //public enum ServiceAreas
    //{
    //    Cleaning,
    //    Software,
    //    UserInterface,
    //    Product,
    //    Backend
    //}

}
