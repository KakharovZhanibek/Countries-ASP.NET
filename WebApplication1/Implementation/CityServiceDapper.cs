using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1;
using WebApplication1.Interfaces;
using WebApplication1.Models;
using WebFormsEmpty.Interfaces;
using WebFormsEmpty.Models;

namespace WebApplication1.Implementation
{
    public class CityServiceDapper : GetConnection, IMultyService<City>, IMultyOther<City>
    {
        public void Add(City item)
        {
                db_con.Execute("Insert into City (Name, CountryId, Population) Values(@Name, @CountryId, @Population)", new { Name = item.Name, CountryId = item.CountryId, Population = item.Population } , commandType: CommandType.Text);
        }

        public void Delete(int Id)
        {
            db_con.Execute("Delete from City where Id = @Id", new { Id = Id }, commandType: CommandType.Text);
        }

        public IQueryable<City> GetAllById(int Id)
        {
            return db_con.Query<City>("Select * from City where Id = @CountryId", new { CountryId = Id }, commandType: CommandType.Text).ToList().AsQueryable();
        }

        public List<City> getAll_1()
        {            
                return db_con.Query<City>("Select * from City", commandType: CommandType.Text).ToList();   
        }

        public IEnumerable<City> getAll_2()
        {
            throw new NotImplementedException();
        }

        public City getById(int Id)
        {
            return db_con.Query<City>("Select * from City where Id = @Id", new { Id = Id }, commandType: CommandType.Text).FirstOrDefault();
        }

        public IEnumerable<City> getByName(string Name)
        {
            return db_con.Query<City>("Select * from City where Name = @Name", new { Name = Name }, commandType: CommandType.Text).ToList();
        }

        public void Update_1(City item)
        {
            db_con.Execute("Update City set Name = @Name, CountryId = @CountryId, Population = @Population where Id = @Id", new { Name = item.Name, CountryId = item.CountryId, Population = item.Population, Id = item.Id }, commandType: CommandType.Text);
        }

        public void Update_2(int Id, City item)
        {
            db_con.Execute("Update City set Name = @Name, CountryId = @CountryId, Population = @Population where Id = @Id", new { Name = item.Name, CountryId = item.CountryId, Population = item.Population, Id = Id }, commandType: CommandType.Text);
        }

        public void Update_3(City item)
        {
            throw new NotImplementedException();
        }
    }
}