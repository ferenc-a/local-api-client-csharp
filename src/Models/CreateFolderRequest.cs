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

    public partial class CreateFolderRequest
    {
        /// <summary>
        /// Initializes a new instance of the CreateFolderRequest class.
        /// </summary>
        public CreateFolderRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateFolderRequest class.
        /// </summary>
        /// <param name="name">Human readable name of the new folder.</param>
        public CreateFolderRequest(string name)
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets human readable name of the new folder.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Name != null)
            {
                if (Name.Length > 100)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 100);
                }
                if (Name.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 1);
                }
            }
        }
    }
}
