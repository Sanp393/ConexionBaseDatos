using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBaseDatos
{
    internal class Location
    {
        private int id;
        private string street_adress;
        private string postal_code;
        private string city;
        private string state_province;
        private string country_id;

        public int Id { get { return id; } set {  id = value; } }
        public string Street_adress { get {  return street_adress; } set {  street_adress = value; } }
        public string Postal_code { get {  return postal_code; } set {  postal_code = value; } } 
        public string City { get { return city; } set { city = value; } }
        public string StateProvince { get { return state_province; } set { state_province = value; } }
        public string Country_id { get {  return country_id; } set {  country_id = value; } }

        public Location(int _id, string _streetadress, string _psotalcode,
           string _city, string _stateprovince, string _conutryid)
        {
            Id = _id;
            Street_adress = _streetadress;
            Postal_code = _psotalcode;
            City = _city;
            StateProvince = _stateprovince;
            Country_id = _conutryid;
        }

        public override string ToString()
        {
            return City;
        }
    }
}
