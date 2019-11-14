// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Adoxiolicencetypesapplicationtypesset.
    /// </summary>
    public static partial class AdoxiolicencetypesapplicationtypessetExtensions
    {
            /// <summary>
            /// Get entities from adoxio_licencetypes_applicationtypesset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioLicencetypesApplicationtypesCollection Get(this IAdoxiolicencetypesapplicationtypesset operations, int? top = default(int?), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(top, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entities from adoxio_licencetypes_applicationtypesset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioLicencetypesApplicationtypesCollection> GetAsync(this IAdoxiolicencetypesapplicationtypesset operations, int? top = default(int?), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(top, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entities from adoxio_licencetypes_applicationtypesset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioLicencetypesApplicationtypesCollection> GetWithHttpMessages(this IAdoxiolicencetypesapplicationtypesset operations, int? top = default(int?), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(top, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to adoxio_licencetypes_applicationtypesset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            public static MicrosoftDynamicsCRMadoxioLicencetypesApplicationtypes Create(this IAdoxiolicencetypesapplicationtypesset operations, MicrosoftDynamicsCRMadoxioLicencetypesApplicationtypes body, string prefer = "return=representation")
            {
                return operations.CreateAsync(body, prefer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to adoxio_licencetypes_applicationtypesset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioLicencetypesApplicationtypes> CreateAsync(this IAdoxiolicencetypesapplicationtypesset operations, MicrosoftDynamicsCRMadoxioLicencetypesApplicationtypes body, string prefer = "return=representation", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(body, prefer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add new entity to adoxio_licencetypes_applicationtypesset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioLicencetypesApplicationtypes> CreateWithHttpMessages(this IAdoxiolicencetypesapplicationtypesset operations, MicrosoftDynamicsCRMadoxioLicencetypesApplicationtypes body, string prefer = "return=representation", Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CreateWithHttpMessagesAsync(body, prefer, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from adoxio_licencetypes_applicationtypesset by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioLicencetypesApplicationtypesid'>
            /// key: adoxio_licencetypes_applicationtypesid of
            /// adoxio_licencetypes_applicationtypes
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioLicencetypesApplicationtypes GetByKey(this IAdoxiolicencetypesapplicationtypesset operations, string adoxioLicencetypesApplicationtypesid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetByKeyAsync(adoxioLicencetypesApplicationtypesid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from adoxio_licencetypes_applicationtypesset by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioLicencetypesApplicationtypesid'>
            /// key: adoxio_licencetypes_applicationtypesid of
            /// adoxio_licencetypes_applicationtypes
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioLicencetypesApplicationtypes> GetByKeyAsync(this IAdoxiolicencetypesapplicationtypesset operations, string adoxioLicencetypesApplicationtypesid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByKeyWithHttpMessagesAsync(adoxioLicencetypesApplicationtypesid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entity from adoxio_licencetypes_applicationtypesset by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioLicencetypesApplicationtypesid'>
            /// key: adoxio_licencetypes_applicationtypesid of
            /// adoxio_licencetypes_applicationtypes
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioLicencetypesApplicationtypes> GetByKeyWithHttpMessages(this IAdoxiolicencetypesapplicationtypesset operations, string adoxioLicencetypesApplicationtypesid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetByKeyWithHttpMessagesAsync(adoxioLicencetypesApplicationtypesid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in adoxio_licencetypes_applicationtypesset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioLicencetypesApplicationtypesid'>
            /// key: adoxio_licencetypes_applicationtypesid of
            /// adoxio_licencetypes_applicationtypes
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            public static void Update(this IAdoxiolicencetypesapplicationtypesset operations, string adoxioLicencetypesApplicationtypesid, MicrosoftDynamicsCRMadoxioLicencetypesApplicationtypes body)
            {
                operations.UpdateAsync(adoxioLicencetypesApplicationtypesid, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in adoxio_licencetypes_applicationtypesset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioLicencetypesApplicationtypesid'>
            /// key: adoxio_licencetypes_applicationtypesid of
            /// adoxio_licencetypes_applicationtypes
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IAdoxiolicencetypesapplicationtypesset operations, string adoxioLicencetypesApplicationtypesid, MicrosoftDynamicsCRMadoxioLicencetypesApplicationtypes body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(adoxioLicencetypesApplicationtypesid, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update entity in adoxio_licencetypes_applicationtypesset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioLicencetypesApplicationtypesid'>
            /// key: adoxio_licencetypes_applicationtypesid of
            /// adoxio_licencetypes_applicationtypes
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse UpdateWithHttpMessages(this IAdoxiolicencetypesapplicationtypesset operations, string adoxioLicencetypesApplicationtypesid, MicrosoftDynamicsCRMadoxioLicencetypesApplicationtypes body, Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.UpdateWithHttpMessagesAsync(adoxioLicencetypesApplicationtypesid, body, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from adoxio_licencetypes_applicationtypesset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioLicencetypesApplicationtypesid'>
            /// key: adoxio_licencetypes_applicationtypesid of
            /// adoxio_licencetypes_applicationtypes
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            public static void Delete(this IAdoxiolicencetypesapplicationtypesset operations, string adoxioLicencetypesApplicationtypesid, string ifMatch = default(string))
            {
                operations.DeleteAsync(adoxioLicencetypesApplicationtypesid, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from adoxio_licencetypes_applicationtypesset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioLicencetypesApplicationtypesid'>
            /// key: adoxio_licencetypes_applicationtypesid of
            /// adoxio_licencetypes_applicationtypes
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAdoxiolicencetypesapplicationtypesset operations, string adoxioLicencetypesApplicationtypesid, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(adoxioLicencetypesApplicationtypesid, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete entity from adoxio_licencetypes_applicationtypesset
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioLicencetypesApplicationtypesid'>
            /// key: adoxio_licencetypes_applicationtypesid of
            /// adoxio_licencetypes_applicationtypes
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse DeleteWithHttpMessages(this IAdoxiolicencetypesapplicationtypesset operations, string adoxioLicencetypesApplicationtypesid, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.DeleteWithHttpMessagesAsync(adoxioLicencetypesApplicationtypesid, ifMatch, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}