﻿using Dip.Model;
using System.Configuration;

namespace Dip.Factory
{
    class DbProductFactory
    {
        public static DbProduct Create()
        {

            if (ConfigurationManager.AppSettings["DB"] == "SQLSERVER")
            {
                return new SQLServerProduct();
            } else
            {
                return new MongoDBProduct();
            }

        }

    }
}
