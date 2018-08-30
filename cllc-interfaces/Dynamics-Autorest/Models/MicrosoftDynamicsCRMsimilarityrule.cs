// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MicrosoftDynamicsCRMsimilarityrule
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsimilarityrule class.
        /// </summary>
        public MicrosoftDynamicsCRMsimilarityrule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsimilarityrule class.
        /// </summary>
        public MicrosoftDynamicsCRMsimilarityrule(object overriddencreatedon = default(object), string _modifiedonbehalfbyValue = default(string), string _transactioncurrencyidValue = default(string), string solutionid = default(string), int? statuscode = default(int?), object createdon = default(object), string _organizationidValue = default(string), string name = default(string), string similarityruleid = default(string), string _createdonbehalfbyValue = default(string), string matchingentityname = default(string), int? timezoneruleversionnumber = default(int?), int? componentstate = default(int?), int? statecode = default(int?), string introducedversion = default(string), string fetchxmllist = default(string), string activerulefetchxml = default(string), int? maxkeywords = default(int?), int? utcconversiontimezonecode = default(int?), int? baseentitytypecode = default(int?), int? importsequencenumber = default(int?), object overwritetime = default(object), string similarityruleidunique = default(string), object exchangerate = default(object), int? ngramsize = default(int?), string description = default(string), string baseentityname = default(string), object modifiedon = default(object), string versionnumber = default(string), int? matchingentitytypecode = default(int?), bool? excludeinactiverecords = default(bool?), string ruleconditionxml = default(string), bool? ismanaged = default(bool?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> similarityruleAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency))
        {
            Overriddencreatedon = overriddencreatedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Solutionid = solutionid;
            Statuscode = statuscode;
            Createdon = createdon;
            this._organizationidValue = _organizationidValue;
            Name = name;
            Similarityruleid = similarityruleid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Matchingentityname = matchingentityname;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Componentstate = componentstate;
            Statecode = statecode;
            Introducedversion = introducedversion;
            Fetchxmllist = fetchxmllist;
            Activerulefetchxml = activerulefetchxml;
            Maxkeywords = maxkeywords;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Baseentitytypecode = baseentitytypecode;
            Importsequencenumber = importsequencenumber;
            Overwritetime = overwritetime;
            Similarityruleidunique = similarityruleidunique;
            Exchangerate = exchangerate;
            Ngramsize = ngramsize;
            Description = description;
            Baseentityname = baseentityname;
            Modifiedon = modifiedon;
            Versionnumber = versionnumber;
            Matchingentitytypecode = matchingentitytypecode;
            Excludeinactiverecords = excludeinactiverecords;
            Ruleconditionxml = ruleconditionxml;
            Ismanaged = ismanaged;
            Createdonbehalfby = createdonbehalfby;
            Modifiedonbehalfby = modifiedonbehalfby;
            SimilarityruleAsyncOperations = similarityruleAsyncOperations;
            Organizationid = organizationid;
            Transactioncurrencyid = transactioncurrencyid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public object Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public object Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "similarityruleid")]
        public string Similarityruleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "matchingentityname")]
        public string Matchingentityname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fetchxmllist")]
        public string Fetchxmllist { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activerulefetchxml")]
        public string Activerulefetchxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maxkeywords")]
        public int? Maxkeywords { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseentitytypecode")]
        public int? Baseentitytypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public object Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "similarityruleidunique")]
        public string Similarityruleidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ngramsize")]
        public int? Ngramsize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseentityname")]
        public string Baseentityname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public object Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "matchingentitytypecode")]
        public int? Matchingentitytypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "excludeinactiverecords")]
        public bool? Excludeinactiverecords { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ruleconditionxml")]
        public string Ruleconditionxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "similarityrule_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SimilarityruleAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

    }
}
