using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Models;

public class Task
{

    
    //ATTRIBUTES



    [Required]
    public int Id { get; set; }
    
    [Required]
    [Column("Title", TypeName = "VARCHAR(50)")]
    public string Title { get; set; }
    
    [Required]
    [Column ("Description", TypeName = "VARCHAR(200)")]
    public string Description { get; set; }
    
    [Required]
    [Column ("DueDate", TypeName = "VARCHAR(10)")]
    public string DueDate { get; set; }
    
    [Required]
    public int StatusID { get; set; }
    
    [NotMapped]
    public string? Status
    {
        get => ((Status)StatusID).ToString();
    }

    [DefaultValue(true)]
    [Column ("Active", TypeName = "bit")]
    public bool Active { get; set; }
    
 
    
}