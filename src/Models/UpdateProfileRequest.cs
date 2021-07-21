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

    public partial class UpdateProfileRequest
    {
        /// <summary>
        /// Initializes a new instance of the UpdateProfileRequest class.
        /// </summary>
        public UpdateProfileRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateProfileRequest class.
        /// </summary>
        /// <param name="canvas">Possible values include: 'intelligent',
        /// 'noise', 'block', 'off'</param>
        /// <param name="startPage">This website will be opened in the browser
        /// when the profile launches.</param>
        /// <param name="passwordManager">Possible values include: 'enabled',
        /// 'disabled'</param>
        /// <param name="extensions">A list of abolute paths from where the
        /// profile should load extensions or addons when starting the browser.
        /// For chrome and edge use CRX3 format extensions. For firefox use
        /// signed xpi format addons.</param>
        /// <param name="notes">A free text including any notes written by the
        /// user.</param>
        /// <param name="launcher">The mode how the profile should be launched.
        /// It determines which browser to launch. This cannot be modified
        /// after creation. Possible values are 'automatic', 'chrome',
        /// 'chromium', 'firefox', 'edge', 'external'</param>
        public UpdateProfileRequest(string canvas, WebglSpoofingTypeWebglSpoofingOptionsMultiLevelChoice webgl, TimezoneSpoofingTypeTimezoneMultiLevelChoice timezone, GeolocationSpoofingTypeGeolocationSpoofingOptionsMultiLevelChoice geolocation, ProxyConnectionTypeServerMultiLevelChoice proxy, WebRtcSpoofingTypeWebRtcSpoofingOptionsMultiLevelChoice webRtc, FontSpoofingTypeFontIListMultiLevelChoice fonts, PluginSpoofingTypePluginIListMultiLevelChoice plugins, ScreenSpoofingTypeScreenSizeMultiLevelChoice screen, string startPage, string passwordManager, IList<string> extensions = default(IList<string>), string notes = default(string), string launcher = default(string))
        {
            Canvas = canvas;
            Webgl = webgl;
            Timezone = timezone;
            Geolocation = geolocation;
            Proxy = proxy;
            WebRtc = webRtc;
            Fonts = fonts;
            Plugins = plugins;
            Screen = screen;
            StartPage = startPage;
            PasswordManager = passwordManager;
            Extensions = extensions;
            Notes = notes;
            Launcher = launcher;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'intelligent', 'noise',
        /// 'block', 'off'
        /// </summary>
        [JsonProperty(PropertyName = "canvas")]
        public string Canvas { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "webgl")]
        public WebglSpoofingTypeWebglSpoofingOptionsMultiLevelChoice Webgl { get; set; }

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
        [JsonProperty(PropertyName = "plugins")]
        public PluginSpoofingTypePluginIListMultiLevelChoice Plugins { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "screen")]
        public ScreenSpoofingTypeScreenSizeMultiLevelChoice Screen { get; set; }

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
        /// Gets or sets the mode how the profile should be launched. It
        /// determines which browser to launch. This cannot be modified after
        /// creation. Possible values are 'automatic', 'chrome', 'chromium',
        /// 'firefox', 'edge', 'external'
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
            if (Canvas == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Canvas");
            }
            if (Webgl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Webgl");
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
            if (Plugins == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Plugins");
            }
            if (Screen == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Screen");
            }
            if (StartPage == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StartPage");
            }
            if (PasswordManager == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PasswordManager");
            }
            if (Webgl != null)
            {
                Webgl.Validate();
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
            if (Plugins != null)
            {
                Plugins.Validate();
            }
            if (Screen != null)
            {
                Screen.Validate();
            }
        }
    }
}
