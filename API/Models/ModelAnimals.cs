using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class ModelAnimals
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Kingdom { get; set; }
        public string Type { get; set; }
        public string Class { get; set; }
        public string Detachment { get; set; }
        public string Family { get; set; }
        public string Image { get; set; }

        public ModelAnimals (Animals animals)
        {
            ID = animals.ID;
            Title = animals.Title;
            Kingdom = animals.Kingdom;
            Type = animals.Type;
            Class = animals.Class;
            Detachment = animals.Detachment;
            Family = animals.Family;
            Image = animals.Image;
        }

    }
}