using System;
using System.Collections.Generic;
using System.Text;

namespace MyApi.Entity
{
    public class Person
    {
        private String _FirstName { get; set; }
        private String _LastName { get; set; }

        public String FirstName
        {
            get
            {
                return _FirstName == null ? "" : _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }

        public String LastName
        {
            get
            {
                return _LastName ?? _LastName;
            }
            set
            {
                _LastName = value;
            }
        }

        /// <summary>
        /// Get the person's full name, which is the combination of first name + last name
        /// </summary>
        public String FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
