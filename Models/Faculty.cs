using System;
using System.ComponentModel.DataAnnotations;

namespace FacultyCourseAssessment.Models
{
    public class Faculty
    {
    public int FacultyID { get; set; }
    public string Title { get; set; }
    public string FirstName {get; set; }
    public string LastName {get; set; }
    
    }
}