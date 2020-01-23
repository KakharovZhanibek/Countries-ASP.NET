using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1;
using WebFormsEmpty.Interfaces;
using WebFormsEmpty.Models;

namespace WebApplication1.Implementation
{
    public class CountryServiceDapper : GetConnection, IMultyService<Country>
    {
        public void Add(Country country)
        {
            //using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString))
            {
                db_con.Execute("Insert into Country (Name, Capital) Values('" + country.Name + "', '" + country.Capital + "')", commandType: CommandType.Text);
                //db.Execute("Insert into Country (Name, Capital) Values(@Name, @Capital)", new { Name = country.Name, Capital = country.Capital} , commandType: CommandType.Text);
                //db.Execute("pCountryAdd", new { Name = country.Name, Capital = country.Capital }, commandType: CommandType.StoredProcedure);

            }
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Country> getAll_1()
        {            
                return db_con.Query<Country>("Select * from Country", commandType: CommandType.Text).ToList();   
        }

        public IEnumerable<Country> getAll_2()
        {
            throw new NotImplementedException();
        }

        public Country getById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Country> getByName(string Name)
        {
            throw new NotImplementedException();
        }

        public void Update_1(Country country)
        {
            db_con.Execute("Update Country set Name = @Name, Capital = @Capital where Id = @Id", new { Name = country.Name, Capital = country.Capital, Id = country.Id }, commandType: CommandType.Text);
        }

        public void Update_2(int Id, Country country)
        {
            throw new NotImplementedException();
        }

        public void Update_3(Country country)
        {
            throw new NotImplementedException();
        }
    }
}