﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureArena.Data
{
    public class Settings
    {
        private static string _repoType;

        private static string _connectionString;

        public static string GetRepoType()
        {
            if (string.IsNullOrEmpty(_repoType))
            {
                _repoType = ConfigurationManager.AppSettings["RepoType"].ToString();
            }

            return _repoType;
        }

        public static string GetConnectionString()
        {
            if (string.IsNullOrEmpty(_connectionString))
            {
                _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            }

            return _connectionString;
        }
    }
}
