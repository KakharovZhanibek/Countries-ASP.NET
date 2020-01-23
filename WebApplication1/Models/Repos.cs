using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsEmpty.Models
{
    public class Repos
    {
        public static List<Country> Repo;
        public Repos()
        {
            Repo = new List<Country>()
            {
                new Country(){ Id=1, Name="Kazakhstan", Capital="Astana"},
                new Country(){ Id=2, Name="Russia", Capital="Moscow"},
                new Country(){ Id=3, Name="Italy", Capital="Roma"},
                new Country(){ Id=4, Name="Spain", Capital="Madrid"},
                new Country(){ Id=5, Name="Norway", Capital="Oslo"}
            };
        }
    }
}