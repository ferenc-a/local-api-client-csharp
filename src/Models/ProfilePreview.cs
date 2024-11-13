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

    /// <summary>
    /// A preview about the profile with some of its properties.
    /// </summary>
    public partial class ProfilePreview
    {
        /// <summary>
        /// Initializes a new instance of the ProfilePreview class.
        /// </summary>
        public ProfilePreview()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProfilePreview class.
        /// </summary>
        /// <param name="id">A unique identifier of the profile</param>
        /// <param name="name">The name of the profile</param>
        /// <param name="tags">Profile tags</param>
        /// <param name="createdAt">Date when the profile was created.</param>
        /// <param name="language">Language of the profile. This is derived
        /// from the base profile. Using ISO 639-1 language codes.</param>
        /// <param name="launcher">This setting determines which browser engine
        /// is launched when a profile is started. This can be modified only
        /// before the first start. Possible values for Desktop profiles:
        /// 'automatic'. Possible values for Mobile profiles: 'chromium',
        /// 'external'.</param>
        /// <param name="folderId">A unique identifier of the containing
        /// folder, or null if not in a folder. This will always be null for
        /// locally stored profiles, as only cloud profiles can be added to
        /// folders.</param>
        /// <param name="storage">Possible values include: 'local',
        /// 'cloud'</param>
        public ProfilePreview(System.Guid id, string name, IList<string> tags, ProxyConnectionTypeServerMultiLevelChoice proxy, System.DateTime createdAt, Device device, Os os, Browser browser, string language, string launcher, StatusResponse status, System.Guid folderId, string storage = default(string))
        {
            Id = id;
            Name = name;
            Tags = tags;
            Proxy = proxy;
            CreatedAt = createdAt;
            Device = device;
            Os = os;
            Browser = browser;
            Language = language;
            Launcher = launcher;
            Status = status;
            Storage = storage;
            FolderId = folderId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a unique identifier of the profile
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the profile
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets profile tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "proxy")]
        public ProxyConnectionTypeServerMultiLevelChoice Proxy { get; set; }

        /// <summary>
        /// Gets or sets date when the profile was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "device")]
        public Device Device { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "os")]
        public Os Os { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "browser")]
        public Browser Browser { get; set; }

        /// <summary>
        /// Gets or sets language of the profile. This is derived from the base
        /// profile. Using ISO 639-1 language codes.
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets this setting determines which browser engine is
        /// launched when a profile is started. This can be modified only
        /// before the first start. Possible values for Desktop profiles:
        /// 'automatic'. Possible values for Mobile profiles: 'chromium',
        /// 'external'.
        /// </summary>
        [JsonProperty(PropertyName = "launcher")]
        public string Launcher { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public StatusResponse Status { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'local', 'cloud'
        /// </summary>
        [JsonProperty(PropertyName = "storage")]
        public string Storage { get; set; }

        /// <summary>
        /// Gets or sets a unique identifier of the containing folder, or null
        /// if not in a folder. This will always be null for locally stored
        /// profiles, as only cloud profiles can be added to folders.
        /// </summary>
        [JsonProperty(PropertyName = "folderId")]
        public System.Guid FolderId { get; set; }

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
            if (Tags == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Tags");
            }
            if (Proxy == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Proxy");
            }
            if (Device == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Device");
            }
            if (Os == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Os");
            }
            if (Browser == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Browser");
            }
            if (Language == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Language");
            }
            if (Launcher == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Launcher");
            }
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
            if (Proxy != null)
            {
                Proxy.Validate();
            }
            if (Device != null)
            {
                Device.Validate();
            }
            if (Os != null)
            {
                Os.Validate();
            }
            if (Browser != null)
            {
                Browser.Validate();
            }
            if (Status != null)
            {
                Status.Validate();
            }
        }
    }
}
