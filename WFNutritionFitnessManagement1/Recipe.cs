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
    
    public partial class Recipe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Recipe()
        {
            this.RecipeIngredients = new HashSet<RecipeIngredient>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int PrepTimeHour { get; set; }
        public int PrepTimeMinute { get; set; }
        public int CookTimeHour { get; set; }
        public int CookTimeMinute { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}