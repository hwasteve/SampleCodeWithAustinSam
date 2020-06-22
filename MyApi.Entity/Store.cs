using System;

namespace MyApi.Entity
{
    public class Store
    {
        public Store()
        {
            ManagerName = new Person();
        }

        private String _TownName { get; set; }

        public String Name { get; set; }
        public String Street { get; set; }

        public Person ManagerName { get; set; }

        public String TownName
        {
            get
            {
                if (_TownName != null)
                    return _TownName;
                else
                    return "";
            }
            set
            {
                _TownName = value;
            }
        }
    }
}
