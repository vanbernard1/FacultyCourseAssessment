using System;
using System.ComponentModel.DataAnnotations;

namespace FacultyCourseAssessment.Models
{
    public class Dean
    {
    public int DeanID { get; set; }
    public string Title { get; set; }
    public string FirstName {get; set; }
    public string LastName {get; set; }
    
    }
}