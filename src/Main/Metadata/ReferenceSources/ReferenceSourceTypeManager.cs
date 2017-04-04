using System;
using System.Collections.Generic;
using System.Data;
using USC.GISResearchLab.Common.Utils.Strings;

namespace USC.GISResearchLab.Geocoding.Core.Metadata.ReferenceSources
{

	public enum ReferenceSourceType
	{
		Unknown,
		ESRIStreetMapNorthAmerica,
		Census2005TigerLines,
		Census2008TigerLines,
		Census2010TigerLines,
		Census2011TigerLines,
		Census2012TigerLines,
		Census2015TigerLines,
		Census2016TigerLines,
		Census2000Places,
		Census2000MinorCivilDivisions,
		Census2000ConsolidatedCities,
		Census2000ZCTAs,
		Census2000CountySubRegions,
		Census2000Counties,
		Census2000States,
		Census2008Places,
		Census2008ConsolidatedCities,
		Census2008ZCTAs,
		Census2008CountySubRegions,
		Census2008Counties,
		Census2008States,
		Census2010Places,
		Census2010ConsolidatedCities,
		Census2010ZCTAs,
		Census2010CountySubRegions,
		Census2010Counties,
		Census2010States,
		ParcelCentroids,
		CountyParcelData,
		BoundarySolutionsParcelCentroids,
		NavteqStreets2008,
		NavteqStreets2012,
        NavteqAddressPoints2016,
        NavteqAddressPoints2014,
        NavteqAddressPoints2013,
		NavteqAddressPoints2012,
		ParcelGeometries,
		USPSTigerZipPlus4,
		ZipCodeDownloadZips2013,
		Dynamic,
        OpenAddresses,
	}

	public class ReferenceSourceTypeManager
	{
		public List<ReferenceSourceType> AllReferenceSourceTypes { get; set; }
		public List<ReferenceSourceType> DefaultReferenceSourceTypes { get; set; }
		public List<ReferenceSourceType> DefaultOrderedReferenceSourceTypes { get; set; }

        public const string SOURCE_NAME_OPENADDRESSES = "SOURCE_OPENADDRESSES";
        public const string SOURCE_NAME_ESRI_STREETMAP_NORTHAMERICA = "SOURCE_ESRI_STREETMAP_NORTHAMERICA";
		public const string SOURCE_NAME_TIGERLINES = "SOURCE_CENSUS_TIGERLINES_2005";
		public const string SOURCE_NAME_TIGERLINES_2008 = "SOURCE_CENSUS_TIGERLINES_2008";
		public const string SOURCE_NAME_TIGERLINES_2010 = "SOURCE_CENSUS_TIGERLINES_2010";
		public const string SOURCE_NAME_TIGERLINES_2011 = "SOURCE_CENSUS_TIGERLINES_2011";
		public const string SOURCE_NAME_TIGERLINES_2012 = "SOURCE_CENSUS_TIGERLINES_2012";
		public const string SOURCE_NAME_TIGERLINES_2015 = "SOURCE_CENSUS_TIGERLINES_2015";
		public const string SOURCE_NAME_TIGERLINES_2016 = "SOURCE_CENSUS_TIGERLINES_2016";
		public const string SOURCE_NAME_NAVTEQ_STREETS_2008 = "SOURCE_NAVTEQ_STREETS_2008";
		public const string SOURCE_NAME_NAVTEQ_STREETS_2012 = "SOURCE_NAVTEQ_STREETS_2012";
		public const string SOURCE_NAME_NAVTEQ_ADDRESSPOINTS_2012 = "SOURCE_NAVTEQ_ADDRESSPOINTS_2012";
		public const string SOURCE_NAME_NAVTEQ_ADDRESSPOINTS_2013 = "SOURCE_NAVTEQ_ADDRESSPOINTS_2013";
        public const string SOURCE_NAME_NAVTEQ_ADDRESSPOINTS_2014 = "SOURCE_NAVTEQ_ADDRESSPOINTS_2014";
        public const string SOURCE_NAME_NAVTEQ_ADDRESSPOINTS_2016 = "SOURCE_NAVTEQ_ADDRESSPOINTS_2016";
        public const string SOURCE_NAME_CENSUS_2000_ZCTAS = "SOURCE_CENSUS_2000_ZCTAS";
		public const string SOURCE_NAME_CENSUS_2000_PLACES = "SOURCE_CENSUS_2000_PLACES";
		public const string SOURCE_NAME_CENSUS_2000_MINOR_CIVIL_DIVISIONS = "SOURCE_CENSUS_2000_MINOR_CIVIL_DIVISIONS";
		public const string SOURCE_NAME_CENSUS_2000_CONSOLIDATED_CITIES = "SOURCE_CENSUS_2000_CONSOLIDATED_CITY_CENTROIDS";
		public const string SOURCE_NAME_CENSUS_2000_COUNTY_SUBREGIONS = "SOURCE_CENSUS_2000_COUNTY_SUBREGIONS";
		public const string SOURCE_NAME_CENSUS_2000_COUNTIES = "SOURCE_CENSUS_2000_COUNTIES";
		public const string SOURCE_NAME_CENSUS_2000_STATES = "SOURCE_CENSUS_2000_STATES";
		public const string SOURCE_NAME_CENSUS_2008_ZCTAS = "SOURCE_CENSUS_2008_ZCTAS";
		public const string SOURCE_NAME_CENSUS_2008_COUNTIES = "SOURCE_CENSUS_2008_COUNTIES";
		public const string SOURCE_NAME_CENSUS_2008_PLACES = "SOURCE_CENSUS_2008_PLACES";
		public const string SOURCE_NAME_CENSUS_2008_COUNTY_SUBREGIONS = "SOURCE_CENSUS_2008_COUNTY_SUBREGIONS";
		public const string SOURCE_NAME_CENSUS_2008_CONSOLIDATED_CITIES = "SOURCE_CENSUS_2008_CONSOLIDATED_CITIES";
		public const string SOURCE_NAME_CENSUS_2008_STATES = "SOURCE_CENSUS_2008_STATES";

		public const string SOURCE_NAME_CENSUS_2010_ZCTAS = "SOURCE_CENSUS_2010_ZCTAS";
		public const string SOURCE_NAME_CENSUS_2010_COUNTIES = "SOURCE_CENSUS_2010_COUNTIES";
		public const string SOURCE_NAME_CENSUS_2010_PLACES = "SOURCE_CENSUS_2010_PLACES";
		public const string SOURCE_NAME_CENSUS_2010_COUNTY_SUBREGIONS = "SOURCE_CENSUS_2010_COUNTY_SUBREGIONS";
		public const string SOURCE_NAME_CENSUS_2010_CONSOLIDATED_CITIES = "SOURCE_CENSUS_2010_CONSOLIDATED_CITIES";
		public const string SOURCE_NAME_CENSUS_2010_STATES = "SOURCE_CENSUS_2010_STATES";

		public const string SOURCE_NAME_COUNTY_PARCEL_DATA = "SOURCE_COUNTY_PARCEL_DATA";
		public const string SOURCE_NAME_PARCEL_GEOMETRIES = "SOURCE_PARCEL_GEOMETRIES";
		public const string SOURCE_NAME_PARCEL_CENTROIDS = "SOURCE_PARCEL_CENTROIDS";
		public const string SOURCE_NAME_BOUNDARY_SOLUTIONS_PARCEL_CENTROIDS = "SOURCE_BOUNDARY_SOLUTIONS_PARCEL_CENTROIDS";
		public const string SOURCE_NAME_UNKNOWN = "SOURCE_UNKNOWN";
		public const string SOURCE_NAME_USPS_ZIP4TIGERLINES = "SOURCE_USPS_ZIP4TIGERLINES";
		public const string SOURCE_NAME_ZIPCODEDOWNLOAD_ZIPS2013 = "SOURCE_NAME_ZIPCODEDOWNLOAD_ZIPS2013";


        // short names
        public const string SOURCE_SHORT_NAME_OPENADDRESSES = "OpenAddresses";
        public const string SOURCE_SHORT_NAME_ESRI_STREETMAP_NORTHAMERICA = "esriStreetMapNA";
		public const string SOURCE_SHORT_NAME_TIGERLINES = "tiger2005";
		public const string SOURCE_SHORT_NAME_TIGERLINES_2008 = "tiger2008";
		public const string SOURCE_SHORT_NAME_TIGERLINES_2010 = "tiger2010";
		public const string SOURCE_SHORT_NAME_TIGERLINES_2011 = "tiger2011";
		public const string SOURCE_SHORT_NAME_TIGERLINES_2012 = "tiger2012";
		public const string SOURCE_SHORT_NAME_TIGERLINES_2015 = "tiger2015";
		public const string SOURCE_SHORT_NAME_TIGERLINES_2016 = "tiger2016";
		public const string SOURCE_SHORT_NAME_NAVTEQ_STREETS_2008 = "navteqStreets2008";
		public const string SOURCE_SHORT_NAME_NAVTEQ_STREETS_2012 = "navteqStreets2012";
		public const string SOURCE_SHORT_NAME_NAVTEQ_ADDRESSPOINTS_2012 = "navteqAddressPoints2012";
		public const string SOURCE_SHORT_NAME_NAVTEQ_ADDRESSPOINTS_2013 = "navteqAddressPoints2013";
        public const string SOURCE_SHORT_NAME_NAVTEQ_ADDRESSPOINTS_2014 = "navteqAddressPoints2014";
        public const string SOURCE_SHORT_NAME_NAVTEQ_ADDRESSPOINTS_2016 = "navteqAddressPoints2016";
        public const string SOURCE_SHORT_NAME_CENSUS_2000_ZCTAS = "census2000ZCTAs";
		public const string SOURCE_SHORT_NAME_CENSUS_2000_PLACES = "census2000Places";
		public const string SOURCE_SHORT_NAME_CENSUS_2000_MINOR_CIVIL_DIVISIONS = "census2000MCDs";
		public const string SOURCE_SHORT_NAME_CENSUS_2000_CONSOLIDATED_CITIES = "census2000ConsolidatedCities";
		public const string SOURCE_SHORT_NAME_CENSUS_2000_COUNTY_SUBREGIONS = "census2000CountySubRegions";
		public const string SOURCE_SHORT_NAME_CENSUS_2000_COUNTIES = "census2000Counties";
		public const string SOURCE_SHORT_NAME_CENSUS_2000_STATES = "census2000States";
		public const string SOURCE_SHORT_NAME_CENSUS_2008_ZCTAS = "census2008ZCTAs";
		public const string SOURCE_SHORT_NAME_CENSUS_2008_COUNTIES = "census2008Counties";
		public const string SOURCE_SHORT_NAME_CENSUS_2008_PLACES = "census2008Places";
		public const string SOURCE_SHORT_NAME_CENSUS_2008_COUNTY_SUBREGIONS = "census2008CountySubRegions";
		public const string SOURCE_SHORT_NAME_CENSUS_2008_CONSOLIDATED_CITIES = "census2008ConsolidatedCities";
		public const string SOURCE_SHORT_NAME_CENSUS_2008_STATES = "census2008States";

		public const string SOURCE_SHORT_NAME_CENSUS_2010_ZCTAS = "census2010ZCTAs";
		public const string SOURCE_SHORT_NAME_CENSUS_2010_COUNTIES = "census2010Counties";
		public const string SOURCE_SHORT_NAME_CENSUS_2010_PLACES = "census2010Places";
		public const string SOURCE_SHORT_NAME_CENSUS_2010_COUNTY_SUBREGIONS = "census2010CountySubRegions";
		public const string SOURCE_SHORT_NAME_CENSUS_2010_CONSOLIDATED_CITIES = "census2010ConsolidatedCities";
		public const string SOURCE_SHORT_NAME_CENSUS_2010_STATES = "census2010States";

		public const string SOURCE_SHORT_NAME_COUNTY_PARCELS = "countyParcelData";
		public const string SOURCE_SHORT_NAME_PARCELS = "parcelGeometries";
		public const string SOURCE_SHORT_NAME_PARCEL_CENTROIDS = "parcelCentroids";
		public const string SOURCE_SHORT_NAME_BOUNDARY_SOLUTIONS_PARCEL_CENTROIDS = "boundarySolutionsParcelCentroids";
		
		public const string SOURCE_SHORT_NAME_UNKNOWN = "unknown";
		public const string SOURCE_SHORT_NAME_USPS_ZIP4TIGERLINES = "zipPlus4";
		public const string SOURCE_SHORT_NAME_ZIPCODEDOWNLOAD_ZIPS2013 = "zcdZips2013";

        // descriptions
        public const string SOURCE_DESCRIPTION_OPENADDRESSES = "Open data from OpenAddresses";
        public const string SOURCE_DESCRIPTION_ESRI_STREETMAP_NORTHAMERICA = "ESRI Street Map North America";
		public const string SOURCE_DESCRIPTION_TIGERLINES = "US Census Bureau 2005 TIGER/Line Files edges";
		public const string SOURCE_DESCRIPTION_TIGERLINES_2008 = "US Census Bureau 2008 TIGER/Line Files edges";
		public const string SOURCE_DESCRIPTION_TIGERLINES_2010 = "US Census Bureau 2010 TIGER/Line Files edges";
		public const string SOURCE_DESCRIPTION_TIGERLINES_2011 = "US Census Bureau 2011 TIGER/Line Files edges";
		public const string SOURCE_DESCRIPTION_TIGERLINES_2012 = "US Census Bureau 2012 TIGER/Line Files edges";
		public const string SOURCE_DESCRIPTION_TIGERLINES_2015 = "US Census Bureau 2015 TIGER/Line Files edges";
		public const string SOURCE_DESCRIPTION_TIGERLINES_2016 = "US Census Bureau 2016 TIGER/Line Files edges";
		public const string SOURCE_DESCRIPTION_NAVTEQ_STREETS_2008 = "Navteq North American Street Files 2008";
		public const string SOURCE_DESCRIPTION_NAVTEQ_STREETS_2012 = "Navteq North American Street Files 2012";
		public const string SOURCE_DESCRIPTION_NAVTEQ_ADDRESSPOINTS_2012 = "Navteq North American Address Point Files 2012";
		public const string SOURCE_DESCRIPTION_NAVTEQ_ADDRESSPOINTS_2013 = "Navteq North American Address Point Files 2013";
        public const string SOURCE_DESCRIPTION_NAVTEQ_ADDRESSPOINTS_2014 = "Navteq North American Address Point Files 2014";
        public const string SOURCE_DESCRIPTION_NAVTEQ_ADDRESSPOINTS_2016 = "Navteq North American Address Point Files 2016";
        public const string SOURCE_DESCRIPTION_CENSUS_2000_ZCTAS = "US Census Bureau 2000 Catographic Boundary Files zip code tabulation areas";
		public const string SOURCE_DESCRIPTION_CENSUS_2000_PLACES = "US Census Bureau 2000 Catographic Boundary Files places";
		public const string SOURCE_DESCRIPTION_CENSUS_2000_MINOR_CIVIL_DIVISIONS = "US Census Bureau 2005 Catographic Boundary Files minor civil divisions";
		public const string SOURCE_DESCRIPTION_CENSUS_2000_CONSOLIDATED_CITIES = "US Census Bureau 2000 Catographic Boundary Files consolidated cities";
		public const string SOURCE_DESCRIPTION_CENSUS_2000_COUNTY_SUBREGIONS = "US Census Bureau 2000 Catographic Boundary Files county sub-regions";
		public const string SOURCE_DESCRIPTION_CENSUS_2000_COUNTIES = "US Census Bureau 2000 Catographic Boundary Files counties";
		public const string SOURCE_DESCRIPTION_CENSUS_2000_STATES = "US Census Bureau 2000 Catographic Boundary Files states";
		public const string SOURCE_DESCRIPTION_CENSUS_2008_ZCTAS = "US Census Bureau 2008 TIGER/Line Files zip code tabulation areas";
		public const string SOURCE_DESCRIPTION_CENSUS_2008_COUNTIES = "US Census Bureau 2008 TIGER/Line Files counties";
		public const string SOURCE_DESCRIPTION_CENSUS_2008_PLACES = "US Census Bureau 2008 TIGER/Line Files places";
		public const string SOURCE_DESCRIPTION_CENSUS_2008_COUNTY_SUBREGIONS = "US Census Bureau 2008 TIGER/Line Files county sub-regions";
		public const string SOURCE_DESCRIPTION_CENSUS_2008_CONSOLIDATED_CITIES = "US Census Bureau 2008 TIGER/Line Files consolidated cities";
		public const string SOURCE_DESCRIPTION_CENSUS_2008_STATES = "US Census Bureau 2008 TIGER/Line Files states";

		public const string SOURCE_DESCRIPTION_CENSUS_2010_ZCTAS = "US Census Bureau 2010 TIGER/Line Files zip code tabulation areas";
		public const string SOURCE_DESCRIPTION_CENSUS_2010_COUNTIES = "US Census Bureau 2010 TIGER/Line Files counties";
		public const string SOURCE_DESCRIPTION_CENSUS_2010_PLACES = "US Census Bureau 2010 TIGER/Line Files places";
		public const string SOURCE_DESCRIPTION_CENSUS_2010_COUNTY_SUBREGIONS = "US Census Bureau 2010 TIGER/Line Files county sub-regions";
		public const string SOURCE_DESCRIPTION_CENSUS_2010_CONSOLIDATED_CITIES = "US Census Bureau 2010 TIGER/Line Files consolidated cities";
		public const string SOURCE_DESCRIPTION_CENSUS_2010_STATES = "US Census Bureau 2010 TIGER/Line Files states";

		public const string SOURCE_DESCRIPTION_PARCELS = "Parcel geometry files gathered from around the country";
		public const string SOURCE_DESCRIPTION_COUNTY_PARCELS = "Parcel geometry files gathered from counties around the country";
		public const string SOURCE_DESCRIPTION_PARCEL_CENTROIDS = "Parcel centroids files gathered from around the country";
		public const string SOURCE_DESCRIPTION_BOUNDARY_SOLUTIONS_PARCEL_CENTROIDS = "Parcel centroids files from Boundary Solutions Inc";
		public const string SOURCE_DESCRIPTION_UNKNOWN = "Unknown";
		public const string SOURCE_DESCRIPTION_USPS_ZIP4TIGERLINES = "USPS Tiger/ZIP+4";
		public const string SOURCE_DESCRIPTION_ZIPCODEDOWNLOAD_ZIPS2013 = "ZipCode Download Zips 2013";

        // creators
        public const string SOURCE_CREATOR_OPENADDRESSES = "User Contributed to OpenAddresses.io";
        public const string SOURCE_CREATOR_ESRI_STREETMAP_NORTHAMERICA = "US Census Bureau";
		public const string SOURCE_CREATOR_TIGERLINES = "US Census Bureau";
		public const string SOURCE_CREATOR_TIGERLINES_2008 = "US Census Bureau";
		public const string SOURCE_CREATOR_TIGERLINES_2010 = "US Census Bureau";
		public const string SOURCE_CREATOR_TIGERLINES_2011 = "US Census Bureau";
		public const string SOURCE_CREATOR_TIGERLINES_2012 = "US Census Bureau";
		public const string SOURCE_CREATOR_TIGERLINES_2015 = "US Census Bureau";
		public const string SOURCE_CREATOR_NAVTEQ_STREETS_2008 = "Navteq";
		public const string SOURCE_CREATOR_NAVTEQ_STREETS_2012 = "Navteq";
		public const string SOURCE_CREATOR_NAVTEQ_ADDRESSPOINTS_2012 = "Navteq";
		public const string SOURCE_CREATOR_CENSUS_2000_ZCTAS = "US Census Bureau";
		public const string SOURCE_CREATOR_CENSUS_2000_PLACES = "US Census Bureau";
		public const string SOURCE_CREATOR_CENSUS_2000_MINOR_CIVIL_DIVISIONS = "US Census Bureau";
		public const string SOURCE_CREATOR_CENSUS_2000_CONSOLIDATED_CITIES = "US Census Bureau";
		public const string SOURCE_CREATOR_CENSUS_2000_COUNTY_SUBREGIONS = "US Census Bureau";
		public const string SOURCE_CREATOR_CENSUS_2000_COUNTIES = "US Census Bureau";
		public const string SOURCE_CREATOR_CENSUS_2000_STATES = "US Census Bureau";
		public const string SOURCE_CREATOR_CENSUS_2008_ZCTAS = "US Census Bureau";
		public const string SOURCE_CREATOR_CENSUS_2008_COUNTIES = "US Census Bureau";
		public const string SOURCE_CREATOR_CENSUS_2008_PLACES = "US Census Bureau";
		public const string SOURCE_CREATOR_CENSUS_2008_COUNTY_SUBREGIONS = "US Census Bureau";
		public const string SOURCE_CREATOR_CENSUS_2008_CONSOLIDATED_CITIES = "US Census Bureau";
		public const string SOURCE_CREATOR_CENSUS_2008_STATES = "US Census Bureau";

		public const string SOURCE_CREATOR_CENSUS_2010_ZCTAS = "US Census Bureau";
		public const string SOURCE_CREATOR_CENSUS_2010_COUNTIES = "US Census Bureau";
		public const string SOURCE_CREATOR_CENSUS_2010_PLACES = "US Census Bureau";
		public const string SOURCE_CREATOR_CENSUS_2010_COUNTY_SUBREGIONS = "US Census Bureau";
		public const string SOURCE_CREATOR_CENSUS_2010_CONSOLIDATED_CITIES = "US Census Bureau";
		public const string SOURCE_CREATOR_CENSUS_2010_STATES = "US Census Bureau";

		public const string SOURCE_CREATOR_PARCELS = "Various Assessors around the US";
		public const string SOURCE_CREATOR_PARCEL_CENTROIDS = "Various Assessors around the US";
		public const string SOURCE_CREATOR_BOUNDARY_SOLUTIONS_PARCEL_CENTROIDS = "Boundary Solutions Inc";
		public const string SOURCE_CREATOR_UNKNOWN = "Unknown";
		public const string SOURCE_CREATOR_USPS_ZIP4TIGERLINES = "USPS";
		public const string SOURCE_CREATOR_ZIPCODEDOWNLOAD_ZIPS2013 = "ZipCodeDownload.com";

        // vintage
        public const string SOURCE_VINTAGE_OPENADDRESSES = "2017";
        public const string SOURCE_VINTAGE_ESRI_STREETMAP_NORTHAMERICA = "2009";
		public const string SOURCE_VINTAGE_TIGERLINES = "2005";
		public const string SOURCE_VINTAGE_TIGERLINES_2008 = "2008";
		public const string SOURCE_VINTAGE_TIGERLINES_2010 = "2010";
		public const string SOURCE_VINTAGE_TIGERLINES_2011 = "2011";
		public const string SOURCE_VINTAGE_TIGERLINES_2012 = "2012";
		public const string SOURCE_VINTAGE_TIGERLINES_2015 = "2015";
		public const string SOURCE_VINTAGE_TIGERLINES_2016 = "2016";
		public const string SOURCE_VINTAGE_NAVTEQ_STREETS_2008 = "2008";
		public const string SOURCE_VINTAGE_NAVTEQ_STREETS_2012 = "2012";
		public const string SOURCE_VINTAGE_NAVTEQ_ADDRESSPOINTS_2012 = "2012";
		public const string SOURCE_VINTAGE_NAVTEQ_ADDRESSPOINTS_2013 = "2013";
        public const string SOURCE_VINTAGE_NAVTEQ_ADDRESSPOINTS_2014 = "2014";
        public const string SOURCE_VINTAGE_NAVTEQ_ADDRESSPOINTS_2016 = "2016";
        public const string SOURCE_VINTAGE_CENSUS_2000_ZCTAS = "2000";
		public const string SOURCE_VINTAGE_CENSUS_2000_PLACES = "2000";
		public const string SOURCE_VINTAGE_CENSUS_2000_MINOR_CIVIL_DIVISIONS = "2000";
		public const string SOURCE_VINTAGE_CENSUS_2000_CONSOLIDATED_CITIES = "2000";
		public const string SOURCE_VINTAGE_CENSUS_2000_COUNTY_SUBREGIONS = "2000";
		public const string SOURCE_VINTAGE_CENSUS_2000_COUNTIES = "2000";
		public const string SOURCE_VINTAGE_CENSUS_2000_STATES = "2000";
		public const string SOURCE_VINTAGE_CENSUS_2008_ZCTAS = "2008";
		public const string SOURCE_VINTAGE_CENSUS_2008_COUNTIES = "2008";
		public const string SOURCE_VINTAGE_CENSUS_2008_PLACES = "2008";
		public const string SOURCE_VINTAGE_CENSUS_2008_COUNTY_SUBREGIONS = "2008";
		public const string SOURCE_VINTAGE_CENSUS_2008_CONSOLIDATED_CITIES = "2008";
		public const string SOURCE_VINTAGE_CENSUS_2008_STATES = "2008";

		public const string SOURCE_VINTAGE_CENSUS_2010_ZCTAS = "2010";
		public const string SOURCE_VINTAGE_CENSUS_2010_COUNTIES = "2010";
		public const string SOURCE_VINTAGE_CENSUS_2010_PLACES = "2010";
		public const string SOURCE_VINTAGE_CENSUS_2010_COUNTY_SUBREGIONS = "2010";
		public const string SOURCE_VINTAGE_CENSUS_2010_CONSOLIDATED_CITIES = "2010";
		public const string SOURCE_VINTAGE_CENSUS_2010_STATES = "2010";

		public const string SOURCE_VINTAGE_COUNTY_PARCELS = "Varies by dataset";
		public const string SOURCE_VINTAGE_PARCELS = "Varies by dataset";
		public const string SOURCE_VINTAGE_PARCEL_CENTROIDS = "Varies by dataset";
		public const string SOURCE_VINTAGE_BOUNDARY_SOLUTIONS_PARCEL_CENTROIDS = "2012";
		public const string SOURCE_VINTAGE_UNKNOWN = "Unknown";
		public const string SOURCE_VINTAGE_USPS_ZIP4TIGERLINES = "2007";
		public const string SOURCE_VINTAGE_ZIPCODEDOWNLOAD_ZIPS2013 = "2013";

		public DataTable GetAllReferenceSources()
		{
			DataTable ret = new DataTable();
			ret.Columns.Add(new DataColumn("id", typeof(int)));
			ret.Columns.Add(new DataColumn("name", typeof(string)));
			ret.Columns.Add(new DataColumn("description", typeof(string)));

			foreach (ReferenceSourceType item in Enum.GetValues(typeof(ReferenceSourceType)))
			{
				DataRow row = ret.NewRow();
				row["id"] = (int)item;
				row["name"] = GetReferenceSourceName(item);
				row["description"] = GetReferenceSourceDescription(item);
				ret.Rows.Add(row);
			}

			return ret;
		}

		public ReferenceSourceTypeManager()
		{
			SetAllReferenceSourceTypes();
			SetDefaultReferenceSourceTypes();
			SetDefaultOrderedReferenceSourceTypes();
		}

		public string GetDefaultReferenceSourceTypes()
		{
			string ret = "";
			foreach (ReferenceSourceType item in DefaultOrderedReferenceSourceTypes)
			{
				ret = StringUtils.ConcatCSV(ret, GetReferenceSourceShortName(item));
			}
			return ret;
		}

		public string GetDefaultReferenceSourceTypes2010()
		{
			string ret = "";

			List<ReferenceSourceType> ReferenceSourceTypes2010 = new List<ReferenceSourceType>();

            ReferenceSourceTypes2010.Add(ReferenceSourceType.OpenAddresses);
            ReferenceSourceTypes2010.Add(ReferenceSourceType.CountyParcelData);
            ReferenceSourceTypes2010.Add(ReferenceSourceType.Census2010ConsolidatedCities);
			ReferenceSourceTypes2010.Add(ReferenceSourceType.Census2010Counties);
			ReferenceSourceTypes2010.Add(ReferenceSourceType.Census2010CountySubRegions);
			ReferenceSourceTypes2010.Add(ReferenceSourceType.Census2010Places);
			ReferenceSourceTypes2010.Add(ReferenceSourceType.Census2010States);
			ReferenceSourceTypes2010.Add(ReferenceSourceType.Census2010TigerLines);
			ReferenceSourceTypes2010.Add(ReferenceSourceType.Census2010ZCTAs);
			ReferenceSourceTypes2010.Add(ReferenceSourceType.BoundarySolutionsParcelCentroids);
			ReferenceSourceTypes2010.Add(ReferenceSourceType.NavteqStreets2008);
			ReferenceSourceTypes2010.Add(ReferenceSourceType.NavteqStreets2012);
            ReferenceSourceTypes2010.Add(ReferenceSourceType.NavteqAddressPoints2016);
            ReferenceSourceTypes2010.Add(ReferenceSourceType.NavteqAddressPoints2014);
            ReferenceSourceTypes2010.Add(ReferenceSourceType.NavteqAddressPoints2013);
			ReferenceSourceTypes2010.Add(ReferenceSourceType.NavteqAddressPoints2012);            
			ReferenceSourceTypes2010.Add(ReferenceSourceType.USPSTigerZipPlus4);
			ReferenceSourceTypes2010.Add(ReferenceSourceType.ZipCodeDownloadZips2013);

			foreach (ReferenceSourceType item in ReferenceSourceTypes2010)
			{
				ret = StringUtils.ConcatCSV(ret, GetReferenceSourceShortName(item));
			}

			return ret;
		}

		public string GetDefaultReferenceSourceTypes2015()
		{
			string ret = "";

			List<ReferenceSourceType> ReferenceSourceTypes2015 = new List<ReferenceSourceType>();

            ReferenceSourceTypes2015.Add(ReferenceSourceType.OpenAddresses);
            ReferenceSourceTypes2015.Add(ReferenceSourceType.CountyParcelData);
            ReferenceSourceTypes2015.Add(ReferenceSourceType.Census2010ConsolidatedCities);
			ReferenceSourceTypes2015.Add(ReferenceSourceType.Census2010Counties);
			ReferenceSourceTypes2015.Add(ReferenceSourceType.Census2010CountySubRegions);
			ReferenceSourceTypes2015.Add(ReferenceSourceType.Census2010Places);
			ReferenceSourceTypes2015.Add(ReferenceSourceType.Census2010States);
			ReferenceSourceTypes2015.Add(ReferenceSourceType.Census2010TigerLines);
			ReferenceSourceTypes2015.Add(ReferenceSourceType.Census2015TigerLines);
			ReferenceSourceTypes2015.Add(ReferenceSourceType.Census2016TigerLines);
			ReferenceSourceTypes2015.Add(ReferenceSourceType.Census2010ZCTAs);
			ReferenceSourceTypes2015.Add(ReferenceSourceType.BoundarySolutionsParcelCentroids);
			ReferenceSourceTypes2015.Add(ReferenceSourceType.NavteqStreets2008);
			ReferenceSourceTypes2015.Add(ReferenceSourceType.NavteqStreets2012);
            ReferenceSourceTypes2015.Add(ReferenceSourceType.NavteqAddressPoints2016);
            ReferenceSourceTypes2015.Add(ReferenceSourceType.NavteqAddressPoints2013);
            ReferenceSourceTypes2015.Add(ReferenceSourceType.NavteqAddressPoints2014);
            ReferenceSourceTypes2015.Add(ReferenceSourceType.NavteqAddressPoints2012);
			ReferenceSourceTypes2015.Add(ReferenceSourceType.USPSTigerZipPlus4);
			ReferenceSourceTypes2015.Add(ReferenceSourceType.ZipCodeDownloadZips2013);

			foreach (ReferenceSourceType item in ReferenceSourceTypes2015)
			{
				ret = StringUtils.ConcatCSV(ret, GetReferenceSourceShortName(item));
			}

			return ret;
		}

		public string GetDefaultReferenceSourceTypes2016()
		{
			string ret = "";

			List<ReferenceSourceType> ReferenceSourceTypes2016 = new List<ReferenceSourceType>();

            ReferenceSourceTypes2016.Add(ReferenceSourceType.OpenAddresses);
            ReferenceSourceTypes2016.Add(ReferenceSourceType.CountyParcelData);
            ReferenceSourceTypes2016.Add(ReferenceSourceType.Census2010ConsolidatedCities);
			ReferenceSourceTypes2016.Add(ReferenceSourceType.Census2010Counties);
			ReferenceSourceTypes2016.Add(ReferenceSourceType.Census2010CountySubRegions);
			ReferenceSourceTypes2016.Add(ReferenceSourceType.Census2010Places);
			ReferenceSourceTypes2016.Add(ReferenceSourceType.Census2010States);
			ReferenceSourceTypes2016.Add(ReferenceSourceType.Census2010TigerLines);
			ReferenceSourceTypes2016.Add(ReferenceSourceType.Census2015TigerLines);
			ReferenceSourceTypes2016.Add(ReferenceSourceType.Census2016TigerLines);
			ReferenceSourceTypes2016.Add(ReferenceSourceType.Census2010ZCTAs);
			ReferenceSourceTypes2016.Add(ReferenceSourceType.BoundarySolutionsParcelCentroids);
			ReferenceSourceTypes2016.Add(ReferenceSourceType.NavteqStreets2008);
			ReferenceSourceTypes2016.Add(ReferenceSourceType.NavteqStreets2012);
            ReferenceSourceTypes2016.Add(ReferenceSourceType.NavteqAddressPoints2016);
            ReferenceSourceTypes2016.Add(ReferenceSourceType.NavteqAddressPoints2014);
            ReferenceSourceTypes2016.Add(ReferenceSourceType.NavteqAddressPoints2013);
			ReferenceSourceTypes2016.Add(ReferenceSourceType.NavteqAddressPoints2012);
			ReferenceSourceTypes2016.Add(ReferenceSourceType.USPSTigerZipPlus4);
			ReferenceSourceTypes2016.Add(ReferenceSourceType.ZipCodeDownloadZips2013);

			foreach (ReferenceSourceType item in ReferenceSourceTypes2016)
			{
				ret = StringUtils.ConcatCSV(ret, GetReferenceSourceShortName(item));
			}

			return ret;
		}



		public void SetAllReferenceSourceTypes()
		{
			AllReferenceSourceTypes = new List<ReferenceSourceType>();
			foreach (ReferenceSourceType item in Enum.GetValues(typeof(ReferenceSourceType)))
			{
				AllReferenceSourceTypes.Add(item);
			}
		}

		public void SetDefaultOrderedReferenceSourceTypes()
		{
			DefaultOrderedReferenceSourceTypes = new List<ReferenceSourceType>();
            DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.OpenAddresses);
            DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.CountyParcelData);
            DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.NavteqAddressPoints2016);
            DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.NavteqAddressPoints2014);
            DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.NavteqAddressPoints2013);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.NavteqAddressPoints2012);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.ParcelCentroids);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.BoundarySolutionsParcelCentroids);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.ParcelGeometries);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.NavteqStreets2008);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.NavteqStreets2012);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.Census2010TigerLines);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.Census2010TigerLines);
			//DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.Census2008TigerLines);
			//DefaultOrderedReferenceSourceTypes[3] = ReferenceSourceType.Census2005TigerLines;
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.USPSTigerZipPlus4);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.Census2010Places);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.Census2008Places);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.Census2000Places);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.Census2010ConsolidatedCities);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.Census2008ConsolidatedCities);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.Census2000ConsolidatedCities);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.Census2000MinorCivilDivisions);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.Census2010ZCTAs);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.Census2008ZCTAs);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.Census2000ZCTAs);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.ZipCodeDownloadZips2013);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.Census2010CountySubRegions);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.Census2008CountySubRegions);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.Census2000CountySubRegions);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.Census2010Counties);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.Census2008Counties);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.Census2000Counties);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.Census2010States);
			DefaultOrderedReferenceSourceTypes.Add(ReferenceSourceType.Census2008States);
		}

		public void SetDefaultReferenceSourceTypes()
		{
			DefaultReferenceSourceTypes = new List<ReferenceSourceType>();
            DefaultReferenceSourceTypes.Add(ReferenceSourceType.OpenAddresses);
            DefaultReferenceSourceTypes.Add(ReferenceSourceType.Census2000ConsolidatedCities);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.Census2000Counties);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.Census2000CountySubRegions);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.Census2000MinorCivilDivisions);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.Census2000Places);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.Census2000ZCTAs);
			//DefaultReferenceSourceTypes.Add(ReferenceSourceType.Census2005TigerLines);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.Census2008ConsolidatedCities);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.Census2008Counties);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.Census2008CountySubRegions);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.Census2008Places);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.Census2008States);
			//DefaultReferenceSourceTypes.Add(ReferenceSourceType.Census2008TigerLines);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.Census2008ZCTAs);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.Census2010ConsolidatedCities);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.Census2010Counties);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.Census2010CountySubRegions);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.Census2010Places);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.Census2010States);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.Census2016TigerLines);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.Census2015TigerLines);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.Census2010TigerLines);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.Census2010ZCTAs);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.CountyParcelData);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.ParcelCentroids);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.ParcelGeometries);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.BoundarySolutionsParcelCentroids);
            DefaultReferenceSourceTypes.Add(ReferenceSourceType.NavteqAddressPoints2016);
            DefaultReferenceSourceTypes.Add(ReferenceSourceType.NavteqAddressPoints2014);
            DefaultReferenceSourceTypes.Add(ReferenceSourceType.NavteqAddressPoints2013);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.NavteqAddressPoints2012);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.NavteqStreets2008);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.NavteqStreets2012);  
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.USPSTigerZipPlus4);
			DefaultReferenceSourceTypes.Add(ReferenceSourceType.ZipCodeDownloadZips2013);
		}

		public ReferenceSourceType GetQualityTypeFromName(string name)
		{
			ReferenceSourceType ret = ReferenceSourceType.Unknown;

            if (String.Compare(name, SOURCE_NAME_CENSUS_2008_CONSOLIDATED_CITIES, true) == 0)
			{
				ret = ReferenceSourceType.Census2008ConsolidatedCities;
			}
			else if (String.Compare(name, SOURCE_NAME_CENSUS_2008_COUNTIES, true) == 0)
			{
				ret = ReferenceSourceType.Census2008Counties;
			}
			else if (String.Compare(name, SOURCE_NAME_CENSUS_2008_COUNTY_SUBREGIONS, true) == 0)
			{
				ret = ReferenceSourceType.Census2008CountySubRegions;
			}
			else if (String.Compare(name, SOURCE_NAME_CENSUS_2008_PLACES, true) == 0)
			{
				ret = ReferenceSourceType.Census2008Places;
			}
			else if (String.Compare(name, SOURCE_NAME_CENSUS_2008_STATES, true) == 0)
			{
				ret = ReferenceSourceType.Census2008States;
			}
			else if (String.Compare(name, SOURCE_NAME_CENSUS_2008_ZCTAS, true) == 0)
			{
				ret = ReferenceSourceType.Census2008ZCTAs;
			}

			else if (String.Compare(name, SOURCE_NAME_CENSUS_2010_CONSOLIDATED_CITIES, true) == 0)
			{
				ret = ReferenceSourceType.Census2010ConsolidatedCities;
			}
			else if (String.Compare(name, SOURCE_NAME_CENSUS_2010_COUNTIES, true) == 0)
			{
				ret = ReferenceSourceType.Census2010Counties;
			}
			else if (String.Compare(name, SOURCE_NAME_CENSUS_2010_COUNTY_SUBREGIONS, true) == 0)
			{
				ret = ReferenceSourceType.Census2010CountySubRegions;
			}
			else if (String.Compare(name, SOURCE_NAME_CENSUS_2010_PLACES, true) == 0)
			{
				ret = ReferenceSourceType.Census2010Places;
			}
			else if (String.Compare(name, SOURCE_NAME_CENSUS_2010_STATES, true) == 0)
			{
				ret = ReferenceSourceType.Census2010States;
			}
			else if (String.Compare(name, SOURCE_NAME_CENSUS_2010_ZCTAS, true) == 0)
			{
				ret = ReferenceSourceType.Census2008ZCTAs;
			}

			else if (String.Compare(name, SOURCE_NAME_CENSUS_2000_PLACES, true) == 0)
			{
				ret = ReferenceSourceType.Census2000Places;
			}
			else if (String.Compare(name, SOURCE_NAME_CENSUS_2000_CONSOLIDATED_CITIES, true) == 0)
			{
				ret = ReferenceSourceType.Census2000ConsolidatedCities;
			}
			else if (String.Compare(name, SOURCE_NAME_CENSUS_2000_MINOR_CIVIL_DIVISIONS, true) == 0)
			{
				ret = ReferenceSourceType.Census2000MinorCivilDivisions;
			}
			else if (String.Compare(name, SOURCE_NAME_CENSUS_2000_COUNTIES, true) == 0)
			{
				ret = ReferenceSourceType.Census2000Counties;
			}
			else if (String.Compare(name, SOURCE_NAME_CENSUS_2000_COUNTY_SUBREGIONS, true) == 0)
			{
				ret = ReferenceSourceType.Census2000CountySubRegions;
			}
			else if (String.Compare(name, SOURCE_NAME_ESRI_STREETMAP_NORTHAMERICA, true) == 0)
			{
				ret = ReferenceSourceType.ESRIStreetMapNorthAmerica;
			}
			else if (String.Compare(name, SOURCE_NAME_NAVTEQ_STREETS_2008, true) == 0)
			{
				ret = ReferenceSourceType.NavteqStreets2008;
			}
			else if (String.Compare(name, SOURCE_NAME_NAVTEQ_STREETS_2012, true) == 0)
			{
				ret = ReferenceSourceType.NavteqStreets2012;
			}
            else if (String.Compare(name, SOURCE_NAME_NAVTEQ_ADDRESSPOINTS_2016, true) == 0)
            {
                ret = ReferenceSourceType.NavteqAddressPoints2016;
            }
            else if (String.Compare(name, SOURCE_NAME_NAVTEQ_ADDRESSPOINTS_2014, true) == 0)
            {
                ret = ReferenceSourceType.NavteqAddressPoints2014;
            }
            else if (String.Compare(name, SOURCE_NAME_NAVTEQ_ADDRESSPOINTS_2013, true) == 0)
			{
				ret = ReferenceSourceType.NavteqAddressPoints2013;
			}
			else if (String.Compare(name, SOURCE_NAME_NAVTEQ_ADDRESSPOINTS_2012, true) == 0)
			{
				ret = ReferenceSourceType.NavteqAddressPoints2012;
			}            
			else if (String.Compare(name, SOURCE_NAME_PARCEL_CENTROIDS, true) == 0)
			{
				ret = ReferenceSourceType.ParcelCentroids;
			}
			else if (String.Compare(name, SOURCE_NAME_COUNTY_PARCEL_DATA, true) == 0)
			{
				ret = ReferenceSourceType.CountyParcelData;
			}
			else if (String.Compare(name, SOURCE_NAME_PARCEL_GEOMETRIES, true) == 0)
			{
				ret = ReferenceSourceType.ParcelGeometries;
			}
			else if (String.Compare(name, SOURCE_NAME_BOUNDARY_SOLUTIONS_PARCEL_CENTROIDS, true) == 0)
			{
				ret = ReferenceSourceType.BoundarySolutionsParcelCentroids;
			}
			else if (String.Compare(name, SOURCE_NAME_CENSUS_2000_STATES, true) == 0)
			{
				ret = ReferenceSourceType.Census2008States;
			}
			else if (String.Compare(name, SOURCE_NAME_TIGERLINES, true) == 0)
			{
				ret = ReferenceSourceType.Census2005TigerLines;
			}
			else if (String.Compare(name, SOURCE_NAME_TIGERLINES_2008, true) == 0)
			{
				ret = ReferenceSourceType.Census2008TigerLines;
			}
			else if (String.Compare(name, SOURCE_NAME_TIGERLINES_2010, true) == 0)
			{
				ret = ReferenceSourceType.Census2010TigerLines;
			}
			else if (String.Compare(name, SOURCE_NAME_TIGERLINES_2011, true) == 0)
			{
				ret = ReferenceSourceType.Census2011TigerLines;
			}
			else if (String.Compare(name, SOURCE_NAME_TIGERLINES_2012, true) == 0)
			{
				ret = ReferenceSourceType.Census2012TigerLines;
			}
			else if (String.Compare(name, SOURCE_NAME_TIGERLINES_2015, true) == 0)
			{
				ret = ReferenceSourceType.Census2015TigerLines;
			}
			else if (String.Compare(name, SOURCE_NAME_TIGERLINES_2016, true) == 0)
			{
				ret = ReferenceSourceType.Census2016TigerLines;
			}
			else if (String.Compare(name, SOURCE_NAME_UNKNOWN, true) == 0)
			{
				ret = ReferenceSourceType.Unknown;
			}
			else if (String.Compare(name, SOURCE_NAME_USPS_ZIP4TIGERLINES, true) == 0)
			{
				ret = ReferenceSourceType.USPSTigerZipPlus4;
			}
			else if (String.Compare(name, SOURCE_NAME_ZIPCODEDOWNLOAD_ZIPS2013, true) == 0)
			{
				ret = ReferenceSourceType.ZipCodeDownloadZips2013;
			}
			else if (String.Compare(name, SOURCE_NAME_CENSUS_2000_ZCTAS, true) == 0)
			{
				ret = ReferenceSourceType.Census2000ZCTAs;
			}
            if (String.Compare(name, SOURCE_NAME_OPENADDRESSES, true) == 0)
            {
                ret = ReferenceSourceType.OpenAddresses;
            }
            else
			{
				throw new Exception("Unexpected ReferenceSourceType: " + name);
			}
			return ret;
		}

		public string GetReferenceSourceName(ReferenceSourceType t)
		{
			string ret = "";
			switch (t)
			{
                case ReferenceSourceType.OpenAddresses:
                    ret = SOURCE_NAME_OPENADDRESSES;
                    break;
                case ReferenceSourceType.Census2000ConsolidatedCities:
					ret = SOURCE_NAME_CENSUS_2000_CONSOLIDATED_CITIES;
					break;
				case ReferenceSourceType.Census2000Counties:
					ret = SOURCE_NAME_CENSUS_2000_COUNTIES;
					break;
				case ReferenceSourceType.Census2000CountySubRegions:
					ret = SOURCE_NAME_CENSUS_2000_COUNTY_SUBREGIONS;
					break;
				case ReferenceSourceType.Census2000MinorCivilDivisions:
					ret = SOURCE_NAME_CENSUS_2000_MINOR_CIVIL_DIVISIONS;
					break;
				case ReferenceSourceType.Census2000Places:
					ret = SOURCE_NAME_CENSUS_2000_PLACES;
					break;
				case ReferenceSourceType.Census2000States:
					ret = SOURCE_NAME_CENSUS_2000_STATES;
					break;
				case ReferenceSourceType.Census2000ZCTAs:
					ret = SOURCE_NAME_CENSUS_2000_ZCTAS;
					break;
				case ReferenceSourceType.Census2005TigerLines:
					ret = SOURCE_NAME_TIGERLINES;
					break;
				case ReferenceSourceType.Census2008ConsolidatedCities:
					ret = SOURCE_NAME_CENSUS_2008_CONSOLIDATED_CITIES;
					break;
				case ReferenceSourceType.Census2008Counties:
					ret = SOURCE_NAME_CENSUS_2008_COUNTIES;
					break;
				case ReferenceSourceType.Census2008CountySubRegions:
					ret = SOURCE_NAME_CENSUS_2008_COUNTY_SUBREGIONS;
					break;
				case ReferenceSourceType.Census2008Places:
					ret = SOURCE_NAME_CENSUS_2008_PLACES;
					break;
				case ReferenceSourceType.Census2008States:
					ret = SOURCE_NAME_CENSUS_2008_STATES;
					break;
				case ReferenceSourceType.Census2008ZCTAs:
					ret = SOURCE_NAME_CENSUS_2008_ZCTAS;
					break;
				case ReferenceSourceType.Census2008TigerLines:
					ret = SOURCE_NAME_TIGERLINES_2008;
					break;
				case ReferenceSourceType.Census2010ConsolidatedCities:
					ret = SOURCE_NAME_CENSUS_2010_CONSOLIDATED_CITIES;
					break;
				case ReferenceSourceType.Census2010Counties:
					ret = SOURCE_NAME_CENSUS_2010_COUNTIES;
					break;
				case ReferenceSourceType.Census2010CountySubRegions:
					ret = SOURCE_NAME_CENSUS_2010_COUNTY_SUBREGIONS;
					break;
				case ReferenceSourceType.Census2010Places:
					ret = SOURCE_NAME_CENSUS_2010_PLACES;
					break;
				case ReferenceSourceType.Census2010States:
					ret = SOURCE_NAME_CENSUS_2010_STATES;
					break;
				case ReferenceSourceType.Census2010ZCTAs:
					ret = SOURCE_NAME_CENSUS_2010_ZCTAS;
					break;
				case ReferenceSourceType.Census2010TigerLines:
					ret = SOURCE_NAME_TIGERLINES_2010;
					break;
				case ReferenceSourceType.Census2011TigerLines:
					ret = SOURCE_NAME_TIGERLINES_2011;
					break;
				case ReferenceSourceType.Census2012TigerLines:
					ret = SOURCE_NAME_TIGERLINES_2012;
					break;
				case ReferenceSourceType.Census2016TigerLines:
					ret = SOURCE_NAME_TIGERLINES_2016;
					break;
				case ReferenceSourceType.Census2015TigerLines:
					ret = SOURCE_NAME_TIGERLINES_2015;
					break;
				case ReferenceSourceType.ESRIStreetMapNorthAmerica:
					ret = SOURCE_NAME_ESRI_STREETMAP_NORTHAMERICA;
					break;
				case ReferenceSourceType.NavteqStreets2008:
					ret = SOURCE_NAME_NAVTEQ_STREETS_2008;
					break;
				case ReferenceSourceType.NavteqStreets2012:
					ret = SOURCE_NAME_NAVTEQ_STREETS_2012;
					break;
                case ReferenceSourceType.NavteqAddressPoints2016:
                    ret = SOURCE_NAME_NAVTEQ_ADDRESSPOINTS_2016;
                    break;
                case ReferenceSourceType.NavteqAddressPoints2014:
                    ret = SOURCE_NAME_NAVTEQ_ADDRESSPOINTS_2014;
                    break;
                case ReferenceSourceType.NavteqAddressPoints2013:
					ret = SOURCE_NAME_NAVTEQ_ADDRESSPOINTS_2013;
					break;
				case ReferenceSourceType.NavteqAddressPoints2012:
					ret = SOURCE_NAME_NAVTEQ_ADDRESSPOINTS_2012;
					break;                
				case ReferenceSourceType.ParcelCentroids:
					ret = SOURCE_NAME_PARCEL_CENTROIDS;
					break;
				case ReferenceSourceType.CountyParcelData:
					ret = SOURCE_NAME_COUNTY_PARCEL_DATA;
					break;
				case ReferenceSourceType.ParcelGeometries:
					ret = SOURCE_NAME_PARCEL_GEOMETRIES;
					break;
				case ReferenceSourceType.BoundarySolutionsParcelCentroids:
					ret = SOURCE_NAME_BOUNDARY_SOLUTIONS_PARCEL_CENTROIDS;
					break;
				case ReferenceSourceType.Unknown:
					ret = SOURCE_NAME_UNKNOWN;
					break;
				case ReferenceSourceType.USPSTigerZipPlus4:
					ret = SOURCE_NAME_USPS_ZIP4TIGERLINES;
					break;
				case ReferenceSourceType.ZipCodeDownloadZips2013:
					ret = SOURCE_NAME_ZIPCODEDOWNLOAD_ZIPS2013;
					break;
				default:
					throw new Exception("Unexpected ReferenceSourceType: " + t);
			}
			return ret;
		}

		public string GetReferenceSourceShortName(ReferenceSourceType t)
		{
			string ret = "";
			switch (t)
			{
                case ReferenceSourceType.OpenAddresses:
                    ret = SOURCE_SHORT_NAME_OPENADDRESSES;
                    break;
                case ReferenceSourceType.Census2000ConsolidatedCities:
					ret = SOURCE_SHORT_NAME_CENSUS_2000_CONSOLIDATED_CITIES;
					break;
				case ReferenceSourceType.Census2000Counties:
					ret = SOURCE_SHORT_NAME_CENSUS_2000_COUNTIES;
					break;
				case ReferenceSourceType.Census2000CountySubRegions:
					ret = SOURCE_SHORT_NAME_CENSUS_2000_COUNTY_SUBREGIONS;
					break;
				case ReferenceSourceType.Census2000MinorCivilDivisions:
					ret = SOURCE_SHORT_NAME_CENSUS_2000_MINOR_CIVIL_DIVISIONS;
					break;
				case ReferenceSourceType.Census2000Places:
					ret = SOURCE_SHORT_NAME_CENSUS_2000_PLACES;
					break;
				case ReferenceSourceType.Census2000States:
					ret = SOURCE_SHORT_NAME_CENSUS_2000_STATES;
					break;
				case ReferenceSourceType.Census2000ZCTAs:
					ret = SOURCE_SHORT_NAME_CENSUS_2000_ZCTAS;
					break;
				case ReferenceSourceType.Census2005TigerLines:
					ret = SOURCE_SHORT_NAME_TIGERLINES;
					break;
				case ReferenceSourceType.Census2008ConsolidatedCities:
					ret = SOURCE_SHORT_NAME_CENSUS_2008_CONSOLIDATED_CITIES;
					break;
				case ReferenceSourceType.Census2008Counties:
					ret = SOURCE_SHORT_NAME_CENSUS_2008_COUNTIES;
					break;
				case ReferenceSourceType.Census2008CountySubRegions:
					ret = SOURCE_SHORT_NAME_CENSUS_2008_COUNTY_SUBREGIONS;
					break;
				case ReferenceSourceType.Census2008Places:
					ret = SOURCE_SHORT_NAME_CENSUS_2008_PLACES;
					break;
				case ReferenceSourceType.Census2008States:
					ret = SOURCE_SHORT_NAME_CENSUS_2008_STATES;
					break;
				case ReferenceSourceType.Census2008TigerLines:
					ret = SOURCE_SHORT_NAME_TIGERLINES_2008;
					break;
				case ReferenceSourceType.Census2008ZCTAs:
					ret = SOURCE_SHORT_NAME_CENSUS_2008_ZCTAS;
					break;
				case ReferenceSourceType.Census2010ConsolidatedCities:
					ret = SOURCE_SHORT_NAME_CENSUS_2010_CONSOLIDATED_CITIES;
					break;
				case ReferenceSourceType.Census2010Counties:
					ret = SOURCE_SHORT_NAME_CENSUS_2010_COUNTIES;
					break;
				case ReferenceSourceType.Census2010CountySubRegions:
					ret = SOURCE_SHORT_NAME_CENSUS_2010_COUNTY_SUBREGIONS;
					break;
				case ReferenceSourceType.Census2010Places:
					ret = SOURCE_SHORT_NAME_CENSUS_2010_PLACES;
					break;
				case ReferenceSourceType.Census2010States:
					ret = SOURCE_SHORT_NAME_CENSUS_2010_STATES;
					break;
				case ReferenceSourceType.Census2010ZCTAs:
					ret = SOURCE_SHORT_NAME_CENSUS_2010_ZCTAS;
					break;
				case ReferenceSourceType.Census2010TigerLines:
					ret = SOURCE_SHORT_NAME_TIGERLINES_2010;
					break;
				case ReferenceSourceType.Census2011TigerLines:
					ret = SOURCE_SHORT_NAME_TIGERLINES_2011;
					break;
				case ReferenceSourceType.Census2012TigerLines:
					ret = SOURCE_SHORT_NAME_TIGERLINES_2012;
					break;
				case ReferenceSourceType.Census2016TigerLines:
					ret = SOURCE_SHORT_NAME_TIGERLINES_2016;
					break;
				case ReferenceSourceType.Census2015TigerLines:
					ret = SOURCE_SHORT_NAME_TIGERLINES_2015;
					break;
				case ReferenceSourceType.ESRIStreetMapNorthAmerica:
					ret = SOURCE_SHORT_NAME_ESRI_STREETMAP_NORTHAMERICA;
					break;
				case ReferenceSourceType.NavteqStreets2008:
					ret = SOURCE_SHORT_NAME_NAVTEQ_STREETS_2008;
					break;
				case ReferenceSourceType.NavteqStreets2012:
					ret = SOURCE_SHORT_NAME_NAVTEQ_STREETS_2012;
					break;
                case ReferenceSourceType.NavteqAddressPoints2016:
                    ret = SOURCE_SHORT_NAME_NAVTEQ_ADDRESSPOINTS_2016;
                    break;
                case ReferenceSourceType.NavteqAddressPoints2013:
					ret = SOURCE_SHORT_NAME_NAVTEQ_ADDRESSPOINTS_2013;
					break;
                case ReferenceSourceType.NavteqAddressPoints2014:
                    ret = SOURCE_SHORT_NAME_NAVTEQ_ADDRESSPOINTS_2014;
                    break;
                case ReferenceSourceType.NavteqAddressPoints2012:
					ret = SOURCE_SHORT_NAME_NAVTEQ_ADDRESSPOINTS_2012;
					break;               
				case ReferenceSourceType.ParcelCentroids:
					ret = SOURCE_SHORT_NAME_PARCEL_CENTROIDS;
					break;
				case ReferenceSourceType.ParcelGeometries:
					ret = SOURCE_SHORT_NAME_PARCELS;
					break;
				case ReferenceSourceType.CountyParcelData:
					ret = SOURCE_SHORT_NAME_COUNTY_PARCELS;
					break;
				case ReferenceSourceType.BoundarySolutionsParcelCentroids:
					ret = SOURCE_SHORT_NAME_BOUNDARY_SOLUTIONS_PARCEL_CENTROIDS;
					break;
				case ReferenceSourceType.Unknown:
					ret = SOURCE_SHORT_NAME_UNKNOWN;
					break;
				case ReferenceSourceType.USPSTigerZipPlus4:
					ret = SOURCE_SHORT_NAME_USPS_ZIP4TIGERLINES;
					break;
				case ReferenceSourceType.ZipCodeDownloadZips2013:
					ret = SOURCE_SHORT_NAME_ZIPCODEDOWNLOAD_ZIPS2013;
					break;
				default:
					throw new Exception("Unexpected ReferenceSourceType: " + t);
			}
			return ret;
		}

		public string GetReferenceSourceDescription(ReferenceSourceType t)
		{
			string ret = "";
			switch (t)
			{
                case ReferenceSourceType.OpenAddresses:
                    ret = SOURCE_DESCRIPTION_OPENADDRESSES;
                    break;
                case ReferenceSourceType.Census2000ConsolidatedCities:
					ret = SOURCE_DESCRIPTION_CENSUS_2000_CONSOLIDATED_CITIES;
					break;
				case ReferenceSourceType.Census2000Counties:
					ret = SOURCE_DESCRIPTION_CENSUS_2000_COUNTIES;
					break;
				case ReferenceSourceType.Census2000CountySubRegions:
					ret = SOURCE_DESCRIPTION_CENSUS_2000_COUNTY_SUBREGIONS;
					break;
				case ReferenceSourceType.Census2000MinorCivilDivisions:
					ret = SOURCE_DESCRIPTION_CENSUS_2000_MINOR_CIVIL_DIVISIONS;
					break;
				case ReferenceSourceType.Census2000Places:
					ret = SOURCE_DESCRIPTION_CENSUS_2000_PLACES;
					break;
				case ReferenceSourceType.Census2000States:
					ret = SOURCE_DESCRIPTION_CENSUS_2000_STATES;
					break;
				case ReferenceSourceType.Census2000ZCTAs:
					ret = SOURCE_DESCRIPTION_CENSUS_2000_ZCTAS;
					break;
				case ReferenceSourceType.Census2005TigerLines:
					ret = SOURCE_DESCRIPTION_TIGERLINES;
					break;
				case ReferenceSourceType.Census2008ConsolidatedCities:
					ret = SOURCE_DESCRIPTION_CENSUS_2008_CONSOLIDATED_CITIES;
					break;
				case ReferenceSourceType.Census2008Counties:
					ret = SOURCE_DESCRIPTION_CENSUS_2008_COUNTIES;
					break;
				case ReferenceSourceType.Census2008CountySubRegions:
					ret = SOURCE_DESCRIPTION_CENSUS_2008_COUNTY_SUBREGIONS;
					break;
				case ReferenceSourceType.Census2008Places:
					ret = SOURCE_DESCRIPTION_CENSUS_2008_PLACES;
					break;
				case ReferenceSourceType.Census2008States:
					ret = SOURCE_DESCRIPTION_CENSUS_2008_STATES;
					break;
				case ReferenceSourceType.Census2008ZCTAs:
					ret = SOURCE_DESCRIPTION_CENSUS_2008_ZCTAS;
					break;
				case ReferenceSourceType.Census2008TigerLines:
					ret = SOURCE_DESCRIPTION_TIGERLINES_2008;
					break;
				case ReferenceSourceType.Census2010ConsolidatedCities:
					ret = SOURCE_DESCRIPTION_CENSUS_2010_CONSOLIDATED_CITIES;
					break;
				case ReferenceSourceType.Census2010Counties:
					ret = SOURCE_DESCRIPTION_CENSUS_2010_COUNTIES;
					break;
				case ReferenceSourceType.Census2010CountySubRegions:
					ret = SOURCE_DESCRIPTION_CENSUS_2010_COUNTY_SUBREGIONS;
					break;
				case ReferenceSourceType.Census2010Places:
					ret = SOURCE_DESCRIPTION_CENSUS_2010_PLACES;
					break;
				case ReferenceSourceType.Census2010ZCTAs:
					ret = SOURCE_DESCRIPTION_CENSUS_2010_ZCTAS;
					break;
				case ReferenceSourceType.Census2010States:
					ret = SOURCE_DESCRIPTION_CENSUS_2010_STATES;
					break;
				case ReferenceSourceType.Census2010TigerLines:
					ret = SOURCE_DESCRIPTION_TIGERLINES_2010;
					break;
				case ReferenceSourceType.Census2011TigerLines:
					ret = SOURCE_DESCRIPTION_TIGERLINES_2011;
					break;
				case ReferenceSourceType.Census2012TigerLines:
					ret = SOURCE_DESCRIPTION_TIGERLINES_2012;
					break;
				case ReferenceSourceType.Census2016TigerLines:
					ret = SOURCE_DESCRIPTION_TIGERLINES_2016;
					break;
				case ReferenceSourceType.Census2015TigerLines:
					ret = SOURCE_DESCRIPTION_TIGERLINES_2015;
					break;
				case ReferenceSourceType.ESRIStreetMapNorthAmerica:
					ret = SOURCE_DESCRIPTION_ESRI_STREETMAP_NORTHAMERICA;
					break;
				case ReferenceSourceType.NavteqStreets2008:
					ret = SOURCE_DESCRIPTION_NAVTEQ_STREETS_2008;
					break;
				case ReferenceSourceType.NavteqStreets2012:
					ret = SOURCE_DESCRIPTION_NAVTEQ_STREETS_2012;
					break;
                case ReferenceSourceType.NavteqAddressPoints2016:
                    ret = SOURCE_DESCRIPTION_NAVTEQ_ADDRESSPOINTS_2016;
                    break;
                case ReferenceSourceType.NavteqAddressPoints2014:
                    ret = SOURCE_DESCRIPTION_NAVTEQ_ADDRESSPOINTS_2014;
                    break;
                case ReferenceSourceType.NavteqAddressPoints2013:
					ret = SOURCE_DESCRIPTION_NAVTEQ_ADDRESSPOINTS_2013;
					break;
				case ReferenceSourceType.NavteqAddressPoints2012:
					ret = SOURCE_DESCRIPTION_NAVTEQ_ADDRESSPOINTS_2012;
					break;                
				case ReferenceSourceType.ParcelCentroids:
					ret = SOURCE_DESCRIPTION_PARCEL_CENTROIDS;
					break;
				case ReferenceSourceType.ParcelGeometries:
					ret = SOURCE_DESCRIPTION_PARCELS;
					break;
				case ReferenceSourceType.CountyParcelData:
					ret = SOURCE_DESCRIPTION_COUNTY_PARCELS;
					break;
				case ReferenceSourceType.BoundarySolutionsParcelCentroids:
					ret = SOURCE_DESCRIPTION_BOUNDARY_SOLUTIONS_PARCEL_CENTROIDS;
					break;
				case ReferenceSourceType.Unknown:
					ret = SOURCE_DESCRIPTION_UNKNOWN;
					break;
				case ReferenceSourceType.USPSTigerZipPlus4:
					ret = SOURCE_DESCRIPTION_USPS_ZIP4TIGERLINES;
					break;
				case ReferenceSourceType.ZipCodeDownloadZips2013:
					ret = SOURCE_DESCRIPTION_ZIPCODEDOWNLOAD_ZIPS2013;
					break;
				default:
					throw new Exception("Unexpected ReferenceSourceType: " + t);
			}
			return ret;
		}

		public string GetReferenceSourceVintage(ReferenceSourceType t)
		{
			string ret = "";
			switch (t)
			{
                case ReferenceSourceType.OpenAddresses:
                    ret = SOURCE_VINTAGE_OPENADDRESSES;
                    break;
                case ReferenceSourceType.Census2000ConsolidatedCities:
					ret = SOURCE_VINTAGE_CENSUS_2000_CONSOLIDATED_CITIES;
					break;
				case ReferenceSourceType.Census2000Counties:
					ret = SOURCE_VINTAGE_CENSUS_2000_COUNTIES;
					break;
				case ReferenceSourceType.Census2000CountySubRegions:
					ret = SOURCE_VINTAGE_CENSUS_2000_COUNTY_SUBREGIONS;
					break;
				case ReferenceSourceType.Census2000MinorCivilDivisions:
					ret = SOURCE_VINTAGE_CENSUS_2000_MINOR_CIVIL_DIVISIONS;
					break;
				case ReferenceSourceType.Census2000Places:
					ret = SOURCE_VINTAGE_CENSUS_2000_PLACES;
					break;
				case ReferenceSourceType.Census2000States:
					ret = SOURCE_VINTAGE_CENSUS_2000_STATES;
					break;
				case ReferenceSourceType.Census2000ZCTAs:
					ret = SOURCE_VINTAGE_CENSUS_2000_ZCTAS;
					break;
				case ReferenceSourceType.Census2005TigerLines:
					ret = SOURCE_VINTAGE_TIGERLINES;
					break;
				case ReferenceSourceType.Census2008ConsolidatedCities:
					ret = SOURCE_VINTAGE_CENSUS_2008_CONSOLIDATED_CITIES;
					break;
				case ReferenceSourceType.Census2008Counties:
					ret = SOURCE_VINTAGE_CENSUS_2008_COUNTIES;
					break;
				case ReferenceSourceType.Census2008CountySubRegions:
					ret = SOURCE_VINTAGE_CENSUS_2008_COUNTY_SUBREGIONS;
					break;
				case ReferenceSourceType.Census2008Places:
					ret = SOURCE_VINTAGE_CENSUS_2008_PLACES;
					break;
				case ReferenceSourceType.Census2008States:
					ret = SOURCE_VINTAGE_CENSUS_2008_STATES;
					break;
				case ReferenceSourceType.Census2008ZCTAs:
					ret = SOURCE_VINTAGE_CENSUS_2008_ZCTAS;
					break;
				case ReferenceSourceType.Census2008TigerLines:
					ret = SOURCE_VINTAGE_TIGERLINES_2008;
					break;

				case ReferenceSourceType.Census2010ConsolidatedCities:
					ret = SOURCE_VINTAGE_CENSUS_2010_CONSOLIDATED_CITIES;
					break;
				case ReferenceSourceType.Census2010Counties:
					ret = SOURCE_VINTAGE_CENSUS_2010_COUNTIES;
					break;
				case ReferenceSourceType.Census2010CountySubRegions:
					ret = SOURCE_VINTAGE_CENSUS_2010_COUNTY_SUBREGIONS;
					break;
				case ReferenceSourceType.Census2010Places:
					ret = SOURCE_VINTAGE_CENSUS_2010_PLACES;
					break;
				case ReferenceSourceType.Census2010States:
					ret = SOURCE_VINTAGE_CENSUS_2010_STATES;
					break;
				case ReferenceSourceType.Census2010ZCTAs:
					ret = SOURCE_VINTAGE_CENSUS_2010_ZCTAS;
					break;
				case ReferenceSourceType.Census2010TigerLines:
					ret = SOURCE_VINTAGE_TIGERLINES_2010;
					break;
				case ReferenceSourceType.Census2011TigerLines:
					ret = SOURCE_VINTAGE_TIGERLINES_2011;
					break;
				case ReferenceSourceType.Census2012TigerLines:
					ret = SOURCE_VINTAGE_TIGERLINES_2012;
					break;
				case ReferenceSourceType.Census2016TigerLines:
					ret = SOURCE_VINTAGE_TIGERLINES_2016;
					break;
				case ReferenceSourceType.Census2015TigerLines:
					ret = SOURCE_VINTAGE_TIGERLINES_2015;
					break;
				case ReferenceSourceType.ESRIStreetMapNorthAmerica:
					ret = SOURCE_VINTAGE_ESRI_STREETMAP_NORTHAMERICA;
					break;
				case ReferenceSourceType.NavteqStreets2008:
					ret = SOURCE_VINTAGE_NAVTEQ_STREETS_2008;
					break;
				case ReferenceSourceType.NavteqStreets2012:
					ret = SOURCE_VINTAGE_NAVTEQ_STREETS_2012;
					break;
                case ReferenceSourceType.NavteqAddressPoints2016:
                    ret = SOURCE_VINTAGE_NAVTEQ_ADDRESSPOINTS_2016;
                    break;
                case ReferenceSourceType.NavteqAddressPoints2014:
                    ret = SOURCE_VINTAGE_NAVTEQ_ADDRESSPOINTS_2014;
                    break;
                case ReferenceSourceType.NavteqAddressPoints2013:
					ret = SOURCE_VINTAGE_NAVTEQ_ADDRESSPOINTS_2013;
					break;
				case ReferenceSourceType.NavteqAddressPoints2012:
					ret = SOURCE_VINTAGE_NAVTEQ_ADDRESSPOINTS_2012;
					break;                
				case ReferenceSourceType.ParcelCentroids:
					ret = SOURCE_VINTAGE_PARCEL_CENTROIDS;
					break;
				case ReferenceSourceType.ParcelGeometries:
					ret = SOURCE_VINTAGE_PARCELS;
					break;
				case ReferenceSourceType.CountyParcelData:
					ret = SOURCE_VINTAGE_COUNTY_PARCELS;
					break;
				case ReferenceSourceType.BoundarySolutionsParcelCentroids:
					ret = SOURCE_VINTAGE_BOUNDARY_SOLUTIONS_PARCEL_CENTROIDS;
					break;
				case ReferenceSourceType.Unknown:
					ret = SOURCE_VINTAGE_UNKNOWN;
					break;
				case ReferenceSourceType.USPSTigerZipPlus4:
					ret = SOURCE_VINTAGE_USPS_ZIP4TIGERLINES;
					break;
				case ReferenceSourceType.ZipCodeDownloadZips2013:
					ret = SOURCE_VINTAGE_ZIPCODEDOWNLOAD_ZIPS2013;
					break;
				default:
					throw new Exception("Unexpected ReferenceSourceType: " + t);
			}
			return ret;
		}
	}
}
