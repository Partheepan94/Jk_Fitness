using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class MemberShip
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string NIC { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Email { get; set; }
        public string Branch { get; set; }
        public int Age { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public decimal BMI { get; set; }
        public string PhysicalCondition { get; set; }
        public string TrainingPurpose { get; set; }
        public int MemberPackage { get; set; }
        public decimal Payment { get; set; }
        public string EmergencyContactNo { get; set; }
        public string RelationShip { get; set; }
        public string IntroducedBy { get; set; }
        public bool Active { get; set; }
        public DateTime JoinDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

}
