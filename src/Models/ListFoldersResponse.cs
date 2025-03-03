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

    public partial class ListFoldersResponse
    {
        /// <summary>
        /// Initializes a new instance of the ListFoldersResponse class.
        /// </summary>
        public ListFoldersResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ListFoldersResponse class.
        /// </summary>
        /// <param name="folders">List of top-level folders, each folder may
        /// contain nested folders and cloud profiles.</param>
        /// <param name="profiles">List of profiles not associated with any
        /// folder. This includes both cloud and local profiles.</param>
        public ListFoldersResponse(IList<FolderResponse> folders, IList<ProfilePreview> profiles)
        {
            Folders = folders;
            Profiles = profiles;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of top-level folders, each folder may contain
        /// nested folders and cloud profiles.
        /// </summary>
        [JsonProperty(PropertyName = "folders")]
        public IList<FolderResponse> Folders { get; set; }

        /// <summary>
        /// Gets or sets list of profiles not associated with any folder. This
        /// includes both cloud and local profiles.
        /// </summary>
        [JsonProperty(PropertyName = "profiles")]
        public IList<ProfilePreview> Profiles { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Folders == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Folders");
            }
            if (Profiles == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Profiles");
            }
            if (Folders != null)
            {
                foreach (var element in Folders)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Profiles != null)
            {
                foreach (var element1 in Profiles)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
