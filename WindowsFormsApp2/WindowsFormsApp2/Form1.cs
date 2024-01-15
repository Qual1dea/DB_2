using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static WindowsFormsApp2.Form1;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initializeWork();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static class SuccsessfulWork
        {
            public static List<Client> ClientList { get; set; }
            public static List<Order> OrderList { get; set; }
        }

        public static void initializeWork()
        {
            SuccsessfulWork.ClientList = new List<Client>();
            SuccsessfulWork.OrderList  = new List<Order>();

            Client client1 = new Client { IdClient = 1, Name = "Alex", Adress = "Adress", Number = "890748454545", isActived = true, Orders = new List<int> { 100, 200 } };
            Client client2 = new Client { IdClient = 2, Name = "Rose", Adress = "Adress2", Number = "894444444545", isActived = false, Orders = new List<int> { 400, 800 } };
            Order order1 = new Order { IdOrder = 1, IdClient = 1, Weight = 50, ProductName = "book", IsDelivered = true, amount = new decimal[] { 100, 500 } };
            Order order2 = new Order { IdOrder = 2, IdClient = 2, Weight = 100, ProductName = "food", IsDelivered = false, amount = new decimal[] { 1000, 5000 } };

            SuccsessfulWork.ClientList.Add(client1);
            SuccsessfulWork.ClientList.Add(client2);
            SuccsessfulWork.OrderList.Add(order1);
            SuccsessfulWork.OrderList.Add(order2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Пример select
            var SelectName = SuccsessfulWork.ClientList.Cast<Client>()
                  .Select(a => $"{a.Name}, {a.Adress.ToUpper()}")
                .ToArray();
            label1.Text = string.Join("   ,", SelectName);

            var SelectName2 = new ArrayList();
            foreach (Client client in SuccsessfulWork.ClientList)
            {
                SelectName2.Add($"{client.Name}, {client.Adress.ToUpper()}");
            }
            label2.Text = string.Join("   ,", SelectName2.ToArray());
            
            var LastTry = new ArrayList();
            foreach (Order order in SuccsessfulWork.OrderList)
            {
                LastTry.Add($"{order.ProductName.Trim()},{order.IsDelivered},{order.ProductName.Length > 442}");
            }
            label4.Text = string.Join("  ,  ", LastTry.ToArray());

            var Viborka11 = SuccsessfulWork.OrderList.Cast<Order>()
                 .Select(order=>$"{order.ProductName.Trim()},{order.IsDelivered},{order.ProductName.Length > 442}");
            label3.Text = string.Join("  ,  ", Viborka11);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}



