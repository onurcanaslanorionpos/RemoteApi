using Domain.Entity;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sapp
{
    public partial class Form1 : Form
    {
        private readonly NorthwindContext _context;
        public Form1()
        {
            InitializeComponent();
            _context = new NorthwindContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbListView.Clear();

            var regions = _context.Regions.ToList();

            foreach (var region in regions)
            {
                dbListView.Items.Add(region.RegionDescription);
            }

            dbListView.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EstablishConnection();
        }

        private async void EstablishConnection()
        {
            try
            {
                //var connection = new HubConnection("http://localhost:29504/");
                //var sapphub = connection.CreateHubProxy("sapphub");

                var hubConnection = new HubConnectionBuilder()
                .WithUrl("http://localhost:29504/notify")
                .Build();

                hubConnection.On<string>("receiveMessage", update =>
                {
                    if (!string.IsNullOrEmpty(update))
                    {
                        remoteListView.Items.Add(update);
                    }
                });

                await hubConnection.StartAsync();
            }
            catch (Exception ex)
            {

            }

           
        }
    }
}
