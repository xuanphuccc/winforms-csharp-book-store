using BTLCSharp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLCSharp.Controllers
{
    internal class ClientDAO
    {
        private static ClientDAO ?instance;

        public static ClientDAO Instance
        {
            get { if (instance == null) instance = new ClientDAO(); return instance; }
        }

        private ClientDAO() { }

        public List<Client> LoadClientList(string ?condition = null)
        {
            List<Client> clientList = new List<Client>();
            DataTable data;

            if (condition != null)
            {
                data = DataProvider.Instance.ReadTable("select * from KhachHang " + condition);
            } else
            {
                data = DataProvider.Instance.ReadTable("select * from KhachHang");
            }

            foreach (DataRow row in data.Rows)
            {
                Client client = new Client(row);
                clientList.Add(client);
            }

            return clientList;
        }

        public int DeleteClient(string? clientId)
        {
            if(clientId != null)
            {
                return DataProvider.Instance.ExecuteNonQuery($"delete KhachHang where MaKH = N'{clientId}'");
            }

            return 0;
        }

        public int CreateClient(Client client)
        {
            if(client != null)
            {
                return DataProvider.Instance.ExecuteNonQuery(
                    "insert KhachHang " + 
                    $"values (N'{client.Id}', N'{client.Name}', '{client.DateOfBirth}', N'{client.Gender}', N'{client.Location}')"
                    );
            }

            return 0;
        }

        public int UpdateClient(Client client)
        {
            if (client != null)
            {
                return DataProvider.Instance.ExecuteNonQuery(
                    "update KhachHang " +
                    $"set TenKH = N'{client.Name}', NgaySinh = '{client.DateOfBirth}', GioiTinh = N'{client.Gender}', DiaChi = N'{client.Location}' " +
                    $"where MaKH = N'{client.Id}'"
                    );
            }

            return 0;
        }

    }
}
