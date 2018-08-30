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

    public partial class MicrosoftDynamicsCRMLookupAttributeMetadata : MicrosoftDynamicsCRMAttributeMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMLookupAttributeMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMLookupAttributeMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMLookupAttributeMetadata class.
        /// </summary>
        /// <param name="attributeType">Possible values include: 'Boolean',
        /// 'Customer', 'DateTime', 'Decimal', 'Double', 'Integer', 'Lookup',
        /// 'Memo', 'Money', 'Owner', 'PartyList', 'Picklist', 'State',
        /// 'Status', 'String', 'Uniqueidentifier', 'CalendarRules', 'Virtual',
        /// 'BigInt', 'ManagedProperty', 'EntityName'</param>
        public MicrosoftDynamicsCRMLookupAttributeMetadata(string metadataId = default(string), bool? hasChanged = default(bool?), string attributeOf = default(string), string attributeType = default(string), MicrosoftDynamicsCRMAttributeTypeDisplayName attributeTypeName = default(MicrosoftDynamicsCRMAttributeTypeDisplayName), int? columnNumber = default(int?), MicrosoftDynamicsCRMLabel description = default(MicrosoftDynamicsCRMLabel), MicrosoftDynamicsCRMLabel displayName = default(MicrosoftDynamicsCRMLabel), string deprecatedVersion = default(string), string introducedVersion = default(string), string entityLogicalName = default(string), MicrosoftDynamicsCRMBooleanManagedProperty isAuditEnabled = default(MicrosoftDynamicsCRMBooleanManagedProperty), bool? isCustomAttribute = default(bool?), bool? isPrimaryId = default(bool?), bool? isPrimaryName = default(bool?), bool? isValidForCreate = default(bool?), bool? isValidForRead = default(bool?), bool? isValidForUpdate = default(bool?), bool? canBeSecuredForRead = default(bool?), bool? canBeSecuredForCreate = default(bool?), bool? canBeSecuredForUpdate = default(bool?), bool? isSecured = default(bool?), bool? isRetrievable = default(bool?), bool? isFilterable = default(bool?), bool? isSearchable = default(bool?), bool? isManaged = default(bool?), MicrosoftDynamicsCRMBooleanManagedProperty isGlobalFilterEnabled = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty isSortableEnabled = default(MicrosoftDynamicsCRMBooleanManagedProperty), string linkedAttributeId = default(string), string logicalName = default(string), MicrosoftDynamicsCRMBooleanManagedProperty isCustomizable = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty isRenameable = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty isValidForAdvancedFind = default(MicrosoftDynamicsCRMBooleanManagedProperty), MicrosoftDynamicsCRMAttributeRequiredLevelManagedProperty requiredLevel = default(MicrosoftDynamicsCRMAttributeRequiredLevelManagedProperty), MicrosoftDynamicsCRMBooleanManagedProperty canModifyAdditionalSettings = default(MicrosoftDynamicsCRMBooleanManagedProperty), string schemaName = default(string), bool? isLogical = default(bool?), string inheritsFrom = default(string), int? sourceType = default(int?), IList<string> targets = default(IList<string>))
            : base(metadataId, hasChanged, attributeOf, attributeType, attributeTypeName, columnNumber, description, displayName, deprecatedVersion, introducedVersion, entityLogicalName, isAuditEnabled, isCustomAttribute, isPrimaryId, isPrimaryName, isValidForCreate, isValidForRead, isValidForUpdate, canBeSecuredForRead, canBeSecuredForCreate, canBeSecuredForUpdate, isSecured, isRetrievable, isFilterable, isSearchable, isManaged, isGlobalFilterEnabled, isSortableEnabled, linkedAttributeId, logicalName, isCustomizable, isRenameable, isValidForAdvancedFind, requiredLevel, canModifyAdditionalSettings, schemaName, isLogical, inheritsFrom, sourceType)
        {
            Targets = targets;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Targets")]
        public IList<string> Targets { get; set; }

    }
}
