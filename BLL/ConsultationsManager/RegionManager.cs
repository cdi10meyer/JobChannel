﻿using BO;
using DAL;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RegionManager : ConsultationManager
    {
        public RegionManager()
        {
            Consultation = new Region();
            Request = new RestRequest("RetrieveAllRegions/{textItem}");
            //Id = "ID_REGION";
            //Nom = "NOM_REGION";
        }
        //public List<Region> RetrieveAllRegionsToutes()
        //{
        //    RegionDataAccess dataAccess = new RegionDataAccess();

        //    List<Region> regions = new List<Region>();

        //    DataTable schemaTable = dataAccess.SelectAllRegions();
        //    foreach (DataRow row in schemaTable.Rows)
        //    {
        //        Region region = new Region();
        //        region.IdRegion = Convert.ToInt32(row["ID_REGION"]);
        //        region.NomRegion = row["NOM_REGION"].ToString();
        //        regions.Add(region);

        //    }
        //    //regions.Sort();
        //    Region regionToutes = new Region();
        //    regionToutes.IdRegion = 0;
        //    regionToutes.NomRegion = "Toutes";
        //    regions.Insert(0,regionToutes);

        //    return regions;
        //}

        //public List<Region> RetrieveAllRegions()
        //{
        //    RegionDataAccess dataAccess = new RegionDataAccess();

        //    List<Region> regions = new List<Region>();

        //    DataTable schemaTable = dataAccess.SelectAllRegions();

        //    foreach (DataRow row in schemaTable.Rows)
        //    {
        //        Region region = new Region();
        //        region.IdRegion = Convert.ToInt32(row["ID_REGION"]);
        //        region.NomRegion = row["NOM_REGION"].ToString();

        //        regions.Add(region);

        //    }
        //    //regions.Sort();
        //    return regions;
        //}

        //public List<Region> RetrieveAll(string textItem)
        //{
        //    RegionDataAccess dataAccess = new RegionDataAccess();

        //    List<Region> regions = new List<Region>();

        //    DataTable schemaTable = dataAccess.SelectAll();

        //    foreach (DataRow row in schemaTable.Rows)
        //    {
        //        Region region = new Region();
        //        region.Id = Convert.ToInt32(row["ID_REGION"]);
        //        region.Nom = row["NOM_REGION"].ToString();

        //        regions.Add(region);

        //    }
        //    Region regionItem = new Region();
        //    regionItem.Id = 0;
        //    regionItem.Nom = textItem;
        //    regions.Insert(0, regionItem);
        //    return regions;
        //}

        //public List<Region> RetrieveAllTous()
        //{
        //    RegionDataAccess dataAccess = new RegionDataAccess();

        //    List<Region> regions = new List<Region>();

        //    DataTable schemaTable = dataAccess.SelectAllRegions();
        //    foreach (DataRow row in schemaTable.Rows)
        //    {
        //        Region region = new Region();
        //        region.IdRegion = Convert.ToInt32(row["ID_REGION"]);
        //        region.NomRegion = row["NOM_REGION"].ToString();
        //        regions.Add(region);

        //    }
        //    Region regionToutes = new Region();
        //    regionToutes.IdRegion = 0;
        //    regionToutes.NomRegion = "Toutes";
        //    regions.Insert(0, regionToutes);

        //    return regions;
        //}
    }
}
