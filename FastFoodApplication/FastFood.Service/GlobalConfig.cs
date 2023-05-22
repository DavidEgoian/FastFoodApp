﻿using FastFood.Models;
using FastFood.Service.Interfaces;

namespace FastFood.Service
{
    public static class GlobalConfig
    {
        public static string ConnectionString { get; } = @"Server=LAPTOP-H3GQK6GO\SQLEXPRESS;Database=FastFood;Trusted_Connection=True;TrustServerCertificate=true";

        public static IGeneralRepository GeneralRepository { get; private set; }
        public static IGeneralRepository ChooseDbType(DbType dbType)
        {
            switch (dbType)
            {
                case DbType.Sql:
                    GeneralRepository = new GeneralRepository();
                    break;
            }
            return GeneralRepository;
        }
    }
}
