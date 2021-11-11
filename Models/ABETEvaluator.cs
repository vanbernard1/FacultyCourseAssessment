using System;
using System.ComponentModel.DataAnnotations;

namespace FacultyCourseAssessment.Models
{
    public class ABETEvaluator
    {
    public int EvaluatorID { get; set; }
    public string Title { get; set; }
    public string FirstName {get; set; }
    public string LastName {get; set; }
    
    }
}