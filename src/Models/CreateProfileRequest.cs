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

    public partial class CreateProfileRequest
    {
        /// <summary>
        /// Initializes a new instance of the CreateProfileRequest class.
        /// </summary>
        public CreateProfileRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateProfileRequest class.
        /// </summary>
        /// <param name="baseProfileId">The unique identifier of the base
        /// profile. This references the base profile which should be used to
        /// build the new profile.</param>
        /// <param name="canvas">Possible values include: 'intelligent',
        /// 'noise', 'block', 'off'</param>
        /// <param name="webgl">Possible values include: 'noise', 'block',
        /// 'off'</param>
        /// <param name="audio">Possible values include: 'off', 'noise',
        /// 'block'</param>
        /// <param name="passwordManager">Possible values include: 'enabled',
        /// 'disabled'</param>
        /// <param name="name">Sets a human readable name for the profile. The
        /// value obtained by file name for existing profiles. For new profiles
        /// the value is generated by random.</param>
        /// <param name="tags">Use tags to categorize profiles by labeling them
        /// accordingly.</param>
        /// <param name="startPage">This website will be opened in the browser
        /// when the profile launches.</param>
        /// <param name="extensions">A list of abolute paths from where the
        /// profile should load extensions or addons when starting the browser.
        /// For chrome and edge use CRX3 format extensions. For firefox use
        /// signed xpi format addons.</param>
        /// <param name="notes">A free text including any notes written by the
        /// user.</param>
        /// <param name="storage">Possible values include: 'local',
        /// 'cloud'</param>
        /// <param name="launcher">This setting determines which browser engine
        /// is launched when a profile is started. This can be modified only
        /// before the first start. Possible values for Desktop profiles:
        /// 'automatic'. Possible values for Mobile profiles: 'chromium',
        /// 'external'.</param>
        public CreateProfileRequest(string baseProfileId, string canvas, string webgl, WebglMetaSpoofingTypeWebglMetaSpoofingOptionsMultiLevelChoice webglMeta, string audio, TimezoneSpoofingTypeTimezoneMultiLevelChoice timezone, GeolocationSpoofingTypeGeolocationSpoofingOptionsMultiLevelChoice geolocation, ProxyConnectionTypeServerMultiLevelChoice proxy, WebRtcSpoofingTypeWebRtcSpoofingOptionsMultiLevelChoice webRtc, FontSpoofingTypeFontIListMultiLevelChoice fonts, ScreenSpoofingTypeScreenSizeMultiLevelChoice screen, string passwordManager, string name = default(string), IList<string> tags = default(IList<string>), HardwareConcurrencySpoofingTypeInt32NullableMultiLevelChoice hardwareConcurrency = default(HardwareConcurrencySpoofingTypeInt32NullableMultiLevelChoice), DeviceMemorySpoofingTypeDoubleNullableMultiLevelChoice deviceMemory = default(DeviceMemorySpoofingTypeDoubleNullableMultiLevelChoice), string startPage = default(string), IList<string> extensions = default(IList<string>), string notes = default(string), string storage = default(string), string launcher = default(string))
        {
            BaseProfileId = baseProfileId;
            Name = name;
            Tags = tags;
            Canvas = canvas;
            Webgl = webgl;
            WebglMeta = webglMeta;
            Audio = audio;
            Timezone = timezone;
            Geolocation = geolocation;
            Proxy = proxy;
            WebRtc = webRtc;
            Fonts = fonts;
            Screen = screen;
            HardwareConcurrency = hardwareConcurrency;
            DeviceMemory = deviceMemory;
            StartPage = startPage;
            PasswordManager = passwordManager;
            Extensions = extensions;
            Notes = notes;
            Storage = storage;
            Launcher = launcher;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique identifier of the base profile. This
        /// references the base profile which should be used to build the new
        /// profile.
        /// </summary>
        [JsonProperty(PropertyName = "baseProfileId")]
        public string BaseProfileId { get; set; }

        /// <summary>
        /// Gets or sets sets a human readable name for the profile. The value
        /// obtained by file name for existing profiles. For new profiles the
        /// value is generated by random.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets use tags to categorize profiles by labeling them
        /// accordingly.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'intelligent', 'noise',
        /// 'block', 'off'
        /// </summary>
        [JsonProperty(PropertyName = "canvas")]
        public string Canvas { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'noise', 'block', 'off'
        /// </summary>
        [JsonProperty(PropertyName = "webgl")]
        public string Webgl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "webglMeta")]
        public WebglMetaSpoofingTypeWebglMetaSpoofingOptionsMultiLevelChoice WebglMeta { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'off', 'noise', 'block'
        /// </summary>
        [JsonProperty(PropertyName = "audio")]
        public string Audio { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezone")]
        public TimezoneSpoofingTypeTimezoneMultiLevelChoice Timezone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "geolocation")]
        public GeolocationSpoofingTypeGeolocationSpoofingOptionsMultiLevelChoice Geolocation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "proxy")]
        public ProxyConnectionTypeServerMultiLevelChoice Proxy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "webRtc")]
        public WebRtcSpoofingTypeWebRtcSpoofingOptionsMultiLevelChoice WebRtc { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fonts")]
        public FontSpoofingTypeFontIListMultiLevelChoice Fonts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "screen")]
        public ScreenSpoofingTypeScreenSizeMultiLevelChoice Screen { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hardwareConcurrency")]
        public HardwareConcurrencySpoofingTypeInt32NullableMultiLevelChoice HardwareConcurrency { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deviceMemory")]
        public DeviceMemorySpoofingTypeDoubleNullableMultiLevelChoice DeviceMemory { get; set; }

        /// <summary>
        /// Gets or sets this website will be opened in the browser when the
        /// profile launches.
        /// </summary>
        [JsonProperty(PropertyName = "startPage")]
        public string StartPage { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'enabled', 'disabled'
        /// </summary>
        [JsonProperty(PropertyName = "passwordManager")]
        public string PasswordManager { get; set; }

        /// <summary>
        /// Gets or sets a list of abolute paths from where the profile should
        /// load extensions or addons when starting the browser. For chrome and
        /// edge use CRX3 format extensions. For firefox use signed xpi format
        /// addons.
        /// </summary>
        [JsonProperty(PropertyName = "extensions")]
        public IList<string> Extensions { get; set; }

        /// <summary>
        /// Gets or sets a free text including any notes written by the user.
        /// </summary>
        [JsonProperty(PropertyName = "notes")]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'local', 'cloud'
        /// </summary>
        [JsonProperty(PropertyName = "storage")]
        public string Storage { get; set; }

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
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (BaseProfileId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BaseProfileId");
            }
            if (Canvas == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Canvas");
            }
            if (Webgl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Webgl");
            }
            if (WebglMeta == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WebglMeta");
            }
            if (Audio == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Audio");
            }
            if (Timezone == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Timezone");
            }
            if (Geolocation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Geolocation");
            }
            if (Proxy == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Proxy");
            }
            if (WebRtc == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WebRtc");
            }
            if (Fonts == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Fonts");
            }
            if (Screen == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Screen");
            }
            if (PasswordManager == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PasswordManager");
            }
            if (BaseProfileId != null)
            {
                if (BaseProfileId.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "BaseProfileId", 1);
                }
            }
            if (WebglMeta != null)
            {
                WebglMeta.Validate();
            }
            if (Timezone != null)
            {
                Timezone.Validate();
            }
            if (Geolocation != null)
            {
                Geolocation.Validate();
            }
            if (Proxy != null)
            {
                Proxy.Validate();
            }
            if (WebRtc != null)
            {
                WebRtc.Validate();
            }
            if (Fonts != null)
            {
                Fonts.Validate();
            }
            if (Screen != null)
            {
                Screen.Validate();
            }
            if (HardwareConcurrency != null)
            {
                HardwareConcurrency.Validate();
            }
            if (DeviceMemory != null)
            {
                DeviceMemory.Validate();
            }
        }
    }
}
