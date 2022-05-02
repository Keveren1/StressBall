using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


/*
namespace StressBall.Manager
{
    public class StressBallManager
    {
        private static int nextId = 1;

        private static List<StressBallData> stressData = new List<StressBallData>()
        {
            new StressBallData() {Id = nextId++, Acceleration = "", DateTime = DateTime.Now},
        };

        public List<StressBallData> GetAll(string? accelerationFilter, DateTime? dateTimeFilter)
        {
            List<StressBallData> result = new List<StressBallData>(stressData);
            if (!string.IsNullOrWhiteSpace(accelerationFilter))
            {
                result = result.FindAll(filterStressBall =>
                    filterStressBall.Acceleration.Contains(accelerationFilter, StringComparison.OrdinalIgnoreCase));
            }

            if (dateTimeFilter != null)
            {
                result = result.FindAll(filterStressBall => filterStressBall.DateTime <= dateTimeFilter);
            }
            
            return result;
        }

        public StressBallData GetById(int id)
        {
            return stressData.Find(stressBall => stressBall.Id == id);
        }

        public StressBallData PostStressBallData (StressBallData newStressBall)
        {
            newStressBall.Id = nextId++;
            stressData.Add(newStressBall);
            return newStressBall;
        }

        public StressBallData Delete(int id)
        {
            StressBallData stressBall = stressData.Find(stressBall => stressBall.Id == id);
            if (stressBall == null) return null;
            stressData.Remove(stressBall);
            return stressBall;
        }
    }
}
*/
