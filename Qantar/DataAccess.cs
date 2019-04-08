using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Qantar
{
    public class DataAccess
    {
        public List<KantarIn> ShowIn()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.Val("QantarDB")))
            {
                var output = connection.Query<KantarIn>($"select * from VehiclesIN").ToList();

                return output;
            }
        }
        public List<KantarOut> ShowOut()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.Val("QantarDB")))
            {
                var output = connection.Query<KantarOut>($"select * from VehiclesOUT").ToList();

                return output;
            }
        }
       
        public List<KantarOut> PlakaOFilter(string search)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.Val("QantarDB")))
            {
                var output = connection.Query<KantarOut>($"select * from VehiclesOUT where plate like '%{ search }%'").ToList();

                return output;
            }
        }
        public List<KantarOut> PDOFilter(string search, string search1)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.Val("QantarDB")))
            {
                var output = connection.Query<KantarOut>($"select * from VehiclesOUT where plate like '%{ search }%' and driver like '%{ search1 }%'").ToList();

                return output;
            }
        }
        public List<KantarIn> PDIFilter(string search, string search1)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.Val("QantarDB")))
            {
                var output = connection.Query<KantarIn>($"select * from VehiclesIN where plate like '%{ search }%' and driver like '%{ search1 }%'").ToList();

                return output;
            }
        }
        public List<KantarIn> PlakaIFilter(string search)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.Val("QantarDB")))
            {
                var output = connection.Query<KantarIn>($"select * from VehiclesIN where plate like '%{ search }%'").ToList();

                return output;
            }
        }
        public List<KantarOut> driverOFilter(string search)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.Val("QantarDB")))
            {
                var output = connection.Query<KantarOut>($"select * from VehiclesOUT where driver like '%{ search }%'").ToList();

                return output;
            }
        }
        public List<KantarIn> driverIFilter(string search)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.Val("QantarDB")))
            {
                var output = connection.Query<KantarIn>($"select * from VehiclesIN where driver like '%{ search }%'").ToList();

                return output;
            }
        }
        public List<KantarIn> weigthIFilter(string search)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.Val("QantarDB")))
            {
                var output = connection.Query<KantarIn>($"select * from VehiclesIN where weightI like '%{ search }%'").ToList();

                return output;
            }
        }
        public List<KantarIn> tarihIFilter(DateTime search , DateTime search1)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.Val("QantarDB")))
            {
                var output = connection.Query<KantarIn>($"select * from VehiclesIN where dateI between '{ search }' and '{ search1 }'").ToList();

                return output;
            }
        }
        public List<KantarOut> tarihOFilter(DateTime search , DateTime search1)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.Val("QantarDB")))
            {
                var output = connection.Query<KantarOut>($"select * from VehiclesOUT where dateO between '{ search }' and '{ search1 }'").ToList();

                return output;
            }
        }
        public List<KantarIn> GetUser(string search)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.Val("QantarDB")))
            {
                var output = connection.Query<KantarIn>($"select * from LoginCred where username = '{ search }'").ToList();

                return output;
            }
        }
    }
}
