//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WFNutritionFitnessManagement1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Daily
    {
        public int Id { get; set; }
        public string User { get; set; }
        public Nullable<decimal> CalorieBurn { get; set; }
        public string Food { get; set; }
        public Nullable<decimal> CalorieIntake { get; set; }
        public string BloodPressure { get; set; }
        public Nullable<int> RestingHR { get; set; }
        public Nullable<int> BloodSugar { get; set; }
        public Nullable<System.DateTime> SelectedDateTime { get; set; }
        public string SelectedActivity { get; set; }
    }
}
