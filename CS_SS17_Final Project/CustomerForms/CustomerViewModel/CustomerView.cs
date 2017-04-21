using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureData.Models;
using AdventureData.Utility;

namespace CS_SS17_Final_Project.CustomerForms.CustomerViewModel
{
    public class CustomerView
    {
        private Customer _CustomerUtility;
        public CustomerView(Customer item)
        {
            this._CustomerUtility = item;
        }

        public string FirstName
        {
            get { return _CustomerUtility.FirstName; }
        }

        public string MiddleName
        {
            get { return _CustomerUtility.MiddleName; }
        }

        public string LastName
        {
            get { return _CustomerUtility.LastName; }
        }
       
    }
}
