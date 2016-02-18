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
    
    public partial class Ingredient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ingredient()
        {
            this.RecipeIngredients = new HashSet<RecipeIngredient>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal ServingSize { get; set; }
        public decimal Calories { get; set; }
        public decimal CaloriesFromFat { get; set; }
        public decimal TotalFat { get; set; }
        public decimal SatFat { get; set; }
        public decimal PolyUnSatFat { get; set; }
        public decimal MonoUnSatFat { get; set; }
        public decimal Potassium { get; set; }
        public decimal Carbohydrates { get; set; }
        public decimal DietaryFiber { get; set; }
        public decimal Sugar { get; set; }
        public decimal Protein { get; set; }
        public decimal VitaminA { get; set; }
        public decimal VitaminC { get; set; }
        public decimal Calcium { get; set; }
        public decimal Iron { get; set; }
        public decimal VitaminD { get; set; }
        public decimal VitaminB6 { get; set; }
        public decimal VitaminB12 { get; set; }
        public decimal Magnesium { get; set; }
        public bool GlutenFree { get; set; }
        public bool NightshadeFree { get; set; }
        public bool PeanutFree { get; set; }
        public bool TreeNutFree { get; set; }
        public bool DairyFree { get; set; }
        public bool EggFree { get; set; }
        public bool Vegetarian { get; set; }
        public bool Vegan { get; set; }
        public decimal Sodium { get; set; }
        public decimal Cholesterol { get; set; }
        public bool SoyFree { get; set; }
        public string ServingType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
