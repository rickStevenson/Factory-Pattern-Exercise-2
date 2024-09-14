﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class MongoDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I'm reading data from Mongo database.");
            var productList = new List<Product>();
            return productList;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a Mongo database.");
        }
    }
}
