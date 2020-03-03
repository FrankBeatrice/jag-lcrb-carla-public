using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace Gov.Lclb.Cllb.Public.ViewModels
{
    public enum LicenceEventStatus
    {
        [EnumMember(Value = "Draft")]
        Draft = 845280004,
        [EnumMember(Value = "In Review")]
        InReview = 1,
        [EnumMember(Value = "Approved")]
        Approved = 845280000,
        [EnumMember(Value = "Denied")]
        Denied = 845280001,
        [EnumMember(Value = "Terminated")]
        Terminated = 845280002,
        [EnumMember(Value = "Cancelled")]
        Cancelled = 845280003
    }
    public enum EventType
    {
        [EnumMember(Value = "Caterer's Staff / Customer Appreciation")]
        CaterersStaffCustomerAppreciation = 845280000,
        [EnumMember(Value = "Community")]
        Community = 845280001,
        [EnumMember(Value = "Corporate")]
        Corporate = 845280002,
        [EnumMember(Value = "Other")]
        Other = 845280003,
        [EnumMember(Value = "Personal")]
        Personal = 845280004
    }

    public enum SpecificLocation
    {
        [EnumMember(Value = "Indoors")]
        Indoors = 845280000,
        [EnumMember(Value = "Outdoors")]
        Outdoors = 845280001,
        [EnumMember(Value = "Both")]
        Both = 845280002
    }

    public enum EventClass
    {
        [EnumMember(Value = "Authorization")]
        Authorization = 845280000,
        [EnumMember(Value = "Notice")]
        Notice = 845280001
    }

    public enum FoodService
    {
        [EnumMember(Value = "Appetizers / Hors D'Oeuvres")]
        AppetizersHorsDOeuvres = 845280000,
        [EnumMember(Value = "Buffet")]
        Buffet = 845280001,
        [EnumMember(Value = "Full Service Meal")]
        FullServiceMeal = 845280002,
        [EnumMember(Value = "Other")]
        Other = 845280003
    }

    public enum Entertainment
    {
        [EnumMember(Value = "Adult Entertainment")]
        AdultEntertainment = 845280000,
        [EnumMember(Value = "Dance")]
        Dance = 845280001,
        [EnumMember(Value = "Gambling")]
        Gambling = 845280002,
        [EnumMember(Value = "Live Entertainment")]
        LiveEntertainment = 845280003,
        [EnumMember(Value = "Live Music")]
        LiveMusic = 845280004,
        [EnumMember(Value = "None")]
        None = 845280005,
        [EnumMember(Value = "Other")]
        Other = 845280006
    }

    public class LicenceEvent
    {
        // string form of the guid.
        public string Id { get; set; }
        public LicenceEventStatus? Status { get; set; }
        public string Name { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public string VenueDescription { get; set; }
        public string AdditionalLocationInformation { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FoodService? FoodService { get; set; }
        public string FoodServiceDescription { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Entertainment? Entertainment { get; set; }
        public string EntertainmentDescription { get; set; }
        public string ContactPhone { get; set; }
        public string ExternalId { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string EventNumber { get; set; }
        public string ClientHostname { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public EventType? EventType { get; set; }
        public string EventTypeDescription { get; set; }
        public int? ImportSequenceNumber { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public SpecificLocation? SpecificLocation { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public EventClass? EventClass { get; set; }
        public bool? MinorsAttending { get; set; }
        public int? MaxAttendance { get; set; }
        public int? MaxStaffAttendance { get; set; }
        public bool? CommunityApproval { get; set; }
        public bool? NotifyEventInspector { get; set; }
        public string LicenceId { get; set; }
        public string AccountId { get; set; }

        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }

        public List<LicenceEventSchedule> Schedules { get; set; }
    }
}
