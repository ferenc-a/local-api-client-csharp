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

    public partial class ShareAccess
    {
        /// <summary>
        /// Initializes a new instance of the ShareAccess class.
        /// </summary>
        public ShareAccess()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ShareAccess class.
        /// </summary>
        /// <param name="sharedAt">Timestamp when the acess was granted to the
        /// user.</param>
        public ShareAccess(User user, GroupRole role, System.DateTime sharedAt)
        {
            User = user;
            Role = role;
            SharedAt = sharedAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public User User { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public GroupRole Role { get; set; }

        /// <summary>
        /// Gets or sets timestamp when the acess was granted to the user.
        /// </summary>
        [JsonProperty(PropertyName = "sharedAt")]
        public System.DateTime SharedAt { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (User == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "User");
            }
            if (Role == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Role");
            }
            if (User != null)
            {
                User.Validate();
            }
            if (Role != null)
            {
                Role.Validate();
            }
        }
    }
}
