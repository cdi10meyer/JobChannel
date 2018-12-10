using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RegionManager
    {
        public List<Region> RetrieveAllRegions()
        {
            RegionDataAccess dataAccess = new RegionDataAccess();

            List<Region> regions = new List<Region>();

            DataTable schemaTable = dataAccess.SelectAllRegions();

            foreach (DataRow row in schemaTable.Rows)
            {
                Region region = new Region();
                region.IdRegion = Convert.ToInt32(row["ID_REGION"]);
                region.NomRegion = row["NOM_REGION"].ToString();

                regions.Add(region);

            }
            return regions;
        }


    }
}
