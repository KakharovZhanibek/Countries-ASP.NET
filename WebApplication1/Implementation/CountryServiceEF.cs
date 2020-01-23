using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1;
using WebFormsEmpty.Interfaces;
using WebFormsEmpty.Models;

namespace WebFormsEmpty.Implementation
{
    public class CountryServiceEF : IMultyService<Country>
    {
        Context context;
        public CountryServiceEF()
        {
            context = new Context();
        }
        public void Add(Country country)
        {
            Repos.Repo.Add(country);
        }

        

        public void Delete(int Id)
        {
            Repos.Repo.Remove(getById(Id));
        }

        public List<Country> getAll_1()
        {
            return context.Country.ToList();
        }

        public IEnumerable<Country> getAll_2()
        {
            return Repos.Repo.ToList();
        }

        public Country getById(int Id)
        {
            return Repos.Repo.Where(z => z.Id == Id).FirstOrDefault();
        }

        public IEnumerable<Country> getByName(string Name)
        {
            return Repos.Repo.Where(z => z.Name == Name).ToList();
        }

        public void Update_1(Country country)
        {
            var c = Repos.Repo.Where(z => z.Id == country.Id).FirstOrDefault();
            if (c != null)
            {
                c.Name = country.Name;
                c.Capital = country.Capital;
            }
        }

        public void Update_2(int Id, Country country)
        {
            Country c = getById(Id);
            if (c != null)
            {
                c.Name = country.Name;
                c.Capital = country.Capital;
            }
        }

        public void Update_3(Country country)
        {
            var c = (from p in Repos.Repo
                    where p.Id == country.Id
                    select p).SingleOrDefault();
            if (c != null)
            {
                c.Name = country.Name;
                c.Capital = country.Capital;
            }
        }
    }
}