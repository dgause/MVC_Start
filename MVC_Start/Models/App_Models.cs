using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Start.Models
{
    public class GuestFood
    {
        public string Name { get; set; }
        public string Food { get; set; }
        public string Drink { get; set; }
    }

    public class ChartModel
  {
    public string ChartType { get; set; }
    public string Labels { get; set; }
    public string Data { get; set; }
    public string Title { get; set; }
  }
}