// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Spice.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for GeneralYesNo.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GeneralYesNo
    {
        [EnumMember(Value = "Yes")]
        Yes,
        [EnumMember(Value = "No")]
        No
    }
    internal static class GeneralYesNoEnumExtension
    {
        internal static string ToSerializedValue(this GeneralYesNo? value)
        {
            return value == null ? null : ((GeneralYesNo)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this GeneralYesNo value)
        {
            switch( value )
            {
                case GeneralYesNo.Yes:
                    return "Yes";
                case GeneralYesNo.No:
                    return "No";
            }
            return null;
        }

        internal static GeneralYesNo? ParseGeneralYesNo(this string value)
        {
            switch( value )
            {
                case "Yes":
                    return GeneralYesNo.Yes;
                case "No":
                    return GeneralYesNo.No;
            }
            return null;
        }
    }
}