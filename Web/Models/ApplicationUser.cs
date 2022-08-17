using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class ApplicationUser
    {

        //UserName UserPhone UserCareer Useraddress UserCV Regdate
        //ApplicationUser테이블의 필드명을 정해주었다. 
        [Key]
        [Required(ErrorMessage="required")]
        public int UserId { get; set; }

        [Display(Name ="이름을 입력해주세요")]
        public string UserName { get; set; }

        [Display(Name = "연락처 입력해주세요")]
        public string UserPhone { get; set; }

        [Display(Name = "지원분야을 입력해주세요")]
        public string UserCareer { get; set; }

        [Display(Name = "주소를 입력해주세요")]
        public string Useraddress { get; set; }

        [Display(Name = "CV를 업로드 해주세요")]
        public string UserCV { get; set; }
        public DateTime Regdate { get; set; }

    }
}
