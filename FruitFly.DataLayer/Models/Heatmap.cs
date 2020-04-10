using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FruitFly.Repository.Models
{
    public class Heatmap
    {
        public int HeatmapID { get; set; }

        //public float Strength { get; set; }
       
        [ForeignKey("Referencepoint")]
        public int ReferencepointId { get; set; }
        public Referencepoint Referencepoint { get; set; }
    }
}
