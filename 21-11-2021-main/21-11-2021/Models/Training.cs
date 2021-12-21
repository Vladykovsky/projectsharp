using System.ComponentModel.DataAnnotations;

namespace _21_11_2021.Models
{
    public class Training
    {
        public string Name { get; set; }
        public int Period { get; set; }

        public Status Status; 
    }

}
