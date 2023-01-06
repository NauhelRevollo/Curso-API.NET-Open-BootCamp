using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackEnd.Models.DataModels
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public virtual Users Createdby { get; set; } = new Users();
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public virtual Users Updateby  { get; set; } =  new Users();
        public DateTime? UpdateAt { get; set; } 
        public virtual Users Deleteby  { get; set; } =  new Users();
        public DateTime? DeleteAt { get; set; }

        public bool IsDeleted { get; set; }

    }
}
