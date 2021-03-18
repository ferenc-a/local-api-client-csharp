// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kameleo.LocalApiClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ProxyConnectionTypeServerMultiLevelChoice
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ProxyConnectionTypeServerMultiLevelChoice class.
        /// </summary>
        public ProxyConnectionTypeServerMultiLevelChoice()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ProxyConnectionTypeServerMultiLevelChoice class.
        /// </summary>
        /// <param name="value">Possible values include: 'none', 'http',
        /// 'socks5', 'ssh'</param>
        public ProxyConnectionTypeServerMultiLevelChoice(string value, Server extra = default(Server))
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
        /// Gets or sets possible values include: 'none', 'http', 'socks5',
        /// 'ssh'
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extra")]
        public Server Extra { get; set; }

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
            if (Extra != null)
            {
                Extra.Validate();
            }
        }
    }
}
