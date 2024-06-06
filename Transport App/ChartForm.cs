using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transport_App
{
    public partial class ChartForm : Form
    {
        private TransportContext _context;
        public ChartForm()
        {
            InitializeComponent();
            _context = new TransportContext();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                var transports = _context.Transports.ToList();
                var drivers = _context.Drivers.ToList();

                var driverTransports = drivers
                    .Select(driver => new
                    {
                        DriverName = $"{driver.FirstName} {driver.LastName}",
                        TransportCount = transports.Count(t => t.DriverId == driver.DriverId)
                    })
                    .OrderByDescending(dt => dt.TransportCount)
                    .ToList();

                Graphics g = e.Graphics;
                int barWidth = 40;
                int spacing = 50; // Increase the spacing between bars
                int startX = 10;
                int startY = 50;
                int maxHeight = 200;

                for (int i = 0; i < driverTransports.Count; i++)
                {
                    var driverTransport = driverTransports[i];
                    int barHeight = (int)((double)driverTransport.TransportCount / driverTransports.Max(dt => dt.TransportCount) * maxHeight);

                    // Draw the bar
                    g.FillRectangle(Brushes.Blue, startX + i * (barWidth + spacing), startY + (maxHeight - barHeight), barWidth, barHeight);

                    // Draw the driver name
                    var driverName = driverTransport.DriverName;
                    var driverNamePosition = new PointF(startX + i * (barWidth + spacing), startY + maxHeight + 10);

                    // Set up text format for centered text
                    StringFormat format = new StringFormat();
                    format.Alignment = StringAlignment.Center;

                    // Calculate position for each name line
                    float nameHeight = g.MeasureString(driverName, new Font("Arial", 8)).Height;
                    float totalNameHeight = nameHeight * driverName.Split(' ').Length;
                    float nameStartY = driverNamePosition.Y;

                    foreach (var namePart in driverName.Split(' '))
                    {
                        var namePosition = new PointF(driverNamePosition.X + (barWidth / 2), nameStartY);
                        g.DrawString(namePart, new Font("Arial", 8), Brushes.Black, namePosition, format);
                        nameStartY += nameHeight;
                    }

                    // Draw the transport count above the bar
                    var transportCount = driverTransport.TransportCount.ToString();
                    var transportCountPosition = new PointF(startX + i * (barWidth + spacing) + (barWidth / 2), startY + (maxHeight - barHeight) - 15);
                    g.DrawString(transportCount, new Font("Arial", 8), Brushes.Black, transportCountPosition, format);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
    
