// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kameleo.LocalApiClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// When the Geolocation spoofing is set to manual these extra settings
    /// will be used as well.
    /// </summary>
    public partial class GeolocationSpoofingOptions
    {
        /// <summary>
        /// Initializes a new instance of the GeolocationSpoofingOptions class.
        /// </summary>
        public GeolocationSpoofingOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GeolocationSpoofingOptions class.
        /// </summary>
        /// <param name="latitude">From -90 to 90</param>
        /// <param name="longitude">From -180 to 180</param>
        public GeolocationSpoofingOptions(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets from -90 to 90
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets from -180 to 180
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
