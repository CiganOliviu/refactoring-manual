using System;

namespace EndPoint
{

    class Organization
    {
        private string _name;
        private string _country;

        public void SetName(string name)
        {
            this._name = name;
        }

        public string GetName()
        {
            return this._name;
        }

        public void SetCountry(string country)
        {
            this._country = country;
        }

        public string GetCountry()
        {
            return this._country;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Organization organization = new Organization();
            
            organization.SetName("Cognizant Softvision");
            organization.SetCountry("Romania");
        }
    }
}