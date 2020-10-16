using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab03.Models;

namespace Lab03.DAL
{
    public class CountryDAO
    {
        ModelCountry model = new ModelCountry();
        public List<Country> GetCountries()
        {
            var list = from c in model.Countries select c;
            return list.ToList();
        }
        public void AddCountry(Country country)
        {
            model.Countries.Add(country);
            model.SaveChanges();
        }
    }
}