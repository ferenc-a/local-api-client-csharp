// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kameleo.LocalApiClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class PluginSpoofingTypePluginIListMultiLevelChoice
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PluginSpoofingTypePluginIListMultiLevelChoice class.
        /// </summary>
        public PluginSpoofingTypePluginIListMultiLevelChoice()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PluginSpoofingTypePluginIListMultiLevelChoice class.
        /// </summary>
        /// <param name="value">Possible values include: 'enabled',
        /// 'disabled'</param>
        public PluginSpoofingTypePluginIListMultiLevelChoice(string value, IList<string> extra = default(IList<string>))
        {
            Value = value;
            Extra = extra;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'enabled', 'disabled'
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extra")]
        public IList<string> Extra { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}
