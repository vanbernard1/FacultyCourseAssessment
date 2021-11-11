using System;
using System.ComponentModel.DataAnnotations;

namespace FacultyCourseAssessment.Models
{
    public class EvaluationForm
    {
    public int FormID { get; set; }
    public string Title { get; set; }
    public string FirstName {get; set; }
    public string LastName {get; set; }
    public string CLO { get; set; }
    public string Measures { get; set; }
    
    }
}