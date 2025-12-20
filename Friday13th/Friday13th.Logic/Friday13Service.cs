using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friday13th.Logic
{
    public class Friday13Service
    {
        public List<DateTime> Get13List(int years)
        {
            var result = new List<DateTime>();
            DateTime start = DateTime.Today;
            int startyear = start.Year;
            int endyear = startyear + years - 1;

            for (int year = startyear; year <= endyear; year++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    var date = new DateTime(year, month, 13);
                    if (date < start) continue;
                    result.Add(date);
                }
            }
            return result;
        }

        public List<DateTime> GetFriday13(IEnumerable<DateTime> dates) 
        {
            return dates.Where(d => d.DayOfWeek == DayOfWeek.Friday).ToList();
        }
           
    }
}
