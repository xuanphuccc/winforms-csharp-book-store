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
            get { if (instance == null) instance = new ClientDAO(); return ClientDAO.instance; }
        }

        private ClientDAO() { }

        public List<Client> LoadClientList(string ?condition = null)
        {
            List<Client> clientList = new List<Client>();

            DataTable data = DataProvider.Instance.ReadTable("select * from KhachHang" + condition);

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
                return DataProvider.Instance.ExecuteNonQuery("delete KhachHang where MaKH = N'" + clientId + "'");
            }

            return 0;
        }

    }
}
