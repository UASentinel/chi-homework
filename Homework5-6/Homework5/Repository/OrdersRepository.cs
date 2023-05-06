using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework5.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Homework5.Repository
{
    public class OrdersRepository : IOrdersRepository
    {
        private string ConnectionString { get; set; }
        public OrdersRepository()
        {
            ConnectionString = "Data Source=LAPTOP-R9DA3P1V\\SQLEXPRESS;Initial Catalog = CHI_HW56; Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;";
        }
        public OrdersRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public List<Order> Get(ADOMethod method)
        {
            using var connection = new SqlConnection(ConnectionString);
            using var command = connection.CreateCommand();

            command.CommandText = "SELECT * FROM Orders INNER JOIN Analyzes ON Analyzes.an_id = Orders.ord_an INNER JOIN GROUPS ON Groups.gr_id = Analyzes.an_group;";

            connection.Open();

            var orders = new List<Order>();

            switch (method)
            {
                case ADOMethod.DataReader:
                    orders = GetDataReader(command);
                    break;
                case ADOMethod.DataSet:
                    orders = GetDataSet(command);
                    break;
                default:
                    break;
            }

            connection.Close();

            return orders;
        }
        public Order GetById(int id, ADOMethod method)
        {
            using var connection = new SqlConnection(ConnectionString);
            using var command = connection.CreateCommand();

            command.CommandText = "SELECT * FROM Orders INNER JOIN Analyzes ON Analyzes.an_id = Orders.ord_an INNER JOIN GROUPS ON Groups.gr_id = Analyzes.an_group WHERE ord_id = @OrdId;";
            command.Parameters.Add(new SqlParameter("@OrdId", id));

            connection.Open();

            var order = new Order();

            switch (method)
            {
                case ADOMethod.DataReader:
                    order =  GetByIdDataReader(command);
                    break;
                case ADOMethod.DataSet:
                    order = GetByIdDataSet(command);
                    break;
                default:
                    break;
            }

            connection.Close();

            return order;
        }
        public int Add(Order entity)
        {
            using var connection = new SqlConnection(ConnectionString);
            using var command = connection.CreateCommand();

            command.CommandText = "INSERT INTO Orders (ord_datetime, ord_an) VALUES (@OrdDateTime, @OrdAn); SELECT SCOPE_IDENTITY();";
            command.Parameters.Add(new SqlParameter("@OrdDateTime", entity.OrdDateTime));
            command.Parameters.Add(new SqlParameter("@OrdAn", entity.OrdAn.AnId));

            connection.Open();

            var ordId = (int)(decimal)command.ExecuteScalar();

            connection.Close();

            return ordId;
        }
        public int Update(Order entity)
        {
            using var connection = new SqlConnection(ConnectionString);
            using var command = connection.CreateCommand();

            command.CommandText = "UPDATE Orders SET ord_datetime = @OrdDateTime, ord_an = @OrdAn WHERE ord_id = @OrdId;";
            command.Parameters.Add(new SqlParameter("@OrdId", entity.OrdId));
            command.Parameters.Add(new SqlParameter("@OrdDateTime", entity.OrdDateTime));
            command.Parameters.Add(new SqlParameter("@OrdAn", entity.OrdAn.AnId));

            connection.Open();

            var count = command.ExecuteNonQuery();

            connection.Close();

            return count;
        }
        public int Delete(int id)
        {
            using var connection = new SqlConnection(ConnectionString);
            using var command = connection.CreateCommand();

            command.CommandText = "DELETE FROM Orders WHERE ord_id = @OrdId;";
            command.Parameters.Add(new SqlParameter("@OrdId", id));

            connection.Open();

            var count = command.ExecuteNonQuery();

            connection.Close();

            return count;
        }
        public List<Order> GetByYear(int year, ADOMethod method)
        {
            using var connection = new SqlConnection(ConnectionString);
            using var command = connection.CreateCommand();

            command.CommandText = "SELECT * FROM Orders INNER JOIN Analyzes ON Analyzes.an_id = Orders.ord_an INNER JOIN GROUPS ON Groups.gr_id = Analyzes.an_group WHERE YEAR(ord_datetime) = YEAR(@OrdDateTime);";
            command.Parameters.Add(new SqlParameter("@OrdDatetime", new DateTime(year, 1, 1)));

            connection.Open();

            var orders = new List<Order>();

            switch (method)
            {
                case ADOMethod.DataReader:
                    orders = GetDataReader(command);
                    break;
                case ADOMethod.DataSet:
                    orders = GetDataSet(command);
                    break;
                default:
                    break;
            }

            connection.Close();

            return orders;
        }
        public List<Order> GetByLastYear(ADOMethod method)
        {
            using var connection = new SqlConnection(ConnectionString);
            using var command = connection.CreateCommand();

            command.CommandText = "SELECT * FROM Orders INNER JOIN Analyzes ON Analyzes.an_id = Orders.ord_an INNER JOIN GROUPS ON Groups.gr_id = Analyzes.an_group WHERE ord_datetime BETWEEN @OrdDateTime1 AND @OrdDateTime2;";
            command.Parameters.Add(new SqlParameter("@OrdDatetime1", DateTime.Now.AddYears(-1)));
            command.Parameters.Add(new SqlParameter("@OrdDatetime2", DateTime.Now));

            connection.Open();

            var orders = new List<Order>();

            switch (method)
            {
                case ADOMethod.DataReader:
                    orders = GetDataReader(command);
                    break;
                case ADOMethod.DataSet:
                    orders = GetDataSet(command);
                    break;
                default:
                    break;
            }

            connection.Close();

            return orders;
        }
        private Order GetByIdDataReader(SqlCommand command)
        {
            var reader = command.ExecuteReader();

            if (!reader.Read()) return new Order();

            var order = new Order(reader);

            return order;
        }
        private Order GetByIdDataSet(SqlCommand command)
        {
            var adapter = new SqlDataAdapter(command);
            var dataSet = new DataSet();

            adapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count == 0) return new Order();

            var row = dataSet.Tables[0].Rows[0];

            var order = new Order(row);

            return order;
        }
        private List<Order> GetDataReader(SqlCommand command)
        {
            var reader = command.ExecuteReader();
            var orders = new List<Order>();
            
            while (reader.Read())
            {
                var order = new Order(reader);
                orders.Add(order);
            }

            return orders;
        }
        private List<Order> GetDataSet(SqlCommand command)
        {
            var adapter = new SqlDataAdapter(command);
            var dataSet = new DataSet();
            var orders = new List<Order>();

            adapter.Fill(dataSet);

            for(int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                var row = dataSet.Tables[0].Rows[i];
                var order = new Order(row);
                orders.Add(order);
            }

            return orders;
        }
    }
}
