using System;
using System.Collections.Generic;

namespace GasTrackerAPI.Models
{
    public partial class AltFuelStations
    {
        public string FuelTypeCode { get; set; }
        public string StationName { get; set; }
        public string StreetAddress { get; set; }
        public string IntersectionDirections { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Plus4 { get; set; }
        public string StationPhone { get; set; }
        public string StatusCode { get; set; }
        public string ExpectedDate { get; set; }
        public string GroupsWithAccessCode { get; set; }
        public string AccessDaysTime { get; set; }
        public string CardsAccepted { get; set; }
        public string BdBlends { get; set; }
        public string NgFillTypeCode { get; set; }
        public string NgPsi { get; set; }
        public string EvLevel1EvseNum { get; set; }
        public string EvLevel2EvseNum { get; set; }
        public string EvDcFastCount { get; set; }
        public string EvOtherInfo { get; set; }
        public string EvNetwork { get; set; }
        public string EvNetworkWeb { get; set; }
        public string GeocodeStatus { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string DateLastConfirmed { get; set; }
        public string Id { get; set; }
        public string UpdatedAt { get; set; }
        public string OwnerTypeCode { get; set; }
        public string FederalAgencyId { get; set; }
        public string FederalAgencyName { get; set; }
        public string OpenDate { get; set; }
        public string HydrogenStatusLink { get; set; }
        public string NgVehicleClass { get; set; }
        public string LpgPrimary { get; set; }
        public string E85BlenderPump { get; set; }
        public string EvConnectorTypes { get; set; }
    }
}
