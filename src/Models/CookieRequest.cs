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

    public partial class CookieRequest
    {
        /// <summary>
        /// Initializes a new instance of the CookieRequest class.
        /// </summary>
        public CookieRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CookieRequest class.
        /// </summary>
        /// <param name="domain">The domain attribute signifies the domain for
        /// which the cookie is valid and can be submitted with every request
        /// for this domain or its subdomains. If this attribute is not
        /// specified, then the hostname of the originating server is used as
        /// the default value.</param>
        /// <param name="name">The name for the Cookie.</param>
        /// <param name="path">The path attribute indicates a URL path that
        /// must exist in the requested URL in order to send the Cookie header.
        /// The %x2F ("/") character is considered a directory separator, and
        /// subdirectories match as well.</param>
        /// <param name="value">The value of the Cookie.</param>
        /// <param name="hostOnly">Host Only cookie means that the cookie
        /// should be handled by the browser to the server only to the same
        /// host/server that firstly sent it to the browser.</param>
        /// <param name="httpOnly">When this attribute is set, client-side
        /// scripts are not allowed to access the cookie.</param>
        /// <param name="secure">A cookie with the Secure attribute is sent to
        /// the server only with an encrypted request over the HTTPS protocol,
        /// never with unsecured HTTP, and therefore can't easily be accessed
        /// by a man-in-the-middle attacker. Insecure sites (with http: in the
        /// URL) can't set cookies with the Secure attribute.</param>
        /// <param name="sameSite">The sameSite attribute lets servers require
        /// that a cookie shouldn't be sent with cross-origin requests (where
        /// Site is defined by the registrable domain), which provides some
        /// protection against cross-site request forgery attacks (CSRF).
        /// It takes three possible values: Strict, Lax, and None.With Strict,
        /// the cookie is sent only to the same site as the one that originated
        /// it; Lax is similar, with an exception for when the user navigates
        /// to a URL from an external site, such as by following a link; None
        /// has no restrictions on cross-site requests.</param>
        /// <param name="expirationDate">This attribute is used to set
        /// persistent cookies. It signifies how long the browser should use
        /// the persistent cookie and when the cookie should be deleted.
        /// If this attribute is not specified, then the lifetime of the cookie
        /// is the same as that of browser session, i.e.it will be a
        /// non-persistent cookie.</param>
        public CookieRequest(string domain, string name, string path, string value, bool? hostOnly = default(bool?), bool? httpOnly = default(bool?), bool? secure = default(bool?), string sameSite = default(string), long? expirationDate = default(long?))
        {
            Domain = domain;
            Name = name;
            Path = path;
            Value = value;
            HostOnly = hostOnly;
            HttpOnly = httpOnly;
            Secure = secure;
            SameSite = sameSite;
            ExpirationDate = expirationDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the domain attribute signifies the domain for which
        /// the cookie is valid and can be submitted with every request for
        /// this domain or its subdomains. If this attribute is not specified,
        /// then the hostname of the originating server is used as the default
        /// value.
        /// </summary>
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Gets or sets the name for the Cookie.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the path attribute indicates a URL path that must
        /// exist in the requested URL in order to send the Cookie header. The
        /// %x2F ("/") character is considered a directory separator, and
        /// subdirectories match as well.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the value of the Cookie.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets host Only cookie means that the cookie should be
        /// handled by the browser to the server only to the same host/server
        /// that firstly sent it to the browser.
        /// </summary>
        [JsonProperty(PropertyName = "hostOnly")]
        public bool? HostOnly { get; set; }

        /// <summary>
        /// Gets or sets when this attribute is set, client-side scripts are
        /// not allowed to access the cookie.
        /// </summary>
        [JsonProperty(PropertyName = "httpOnly")]
        public bool? HttpOnly { get; set; }

        /// <summary>
        /// Gets or sets a cookie with the Secure attribute is sent to the
        /// server only with an encrypted request over the HTTPS protocol,
        /// never with unsecured HTTP, and therefore can't easily be accessed
        /// by a man-in-the-middle attacker. Insecure sites (with http: in the
        /// URL) can't set cookies with the Secure attribute.
        /// </summary>
        [JsonProperty(PropertyName = "secure")]
        public bool? Secure { get; set; }

        /// <summary>
        /// Gets or sets the sameSite attribute lets servers require that a
        /// cookie shouldn't be sent with cross-origin requests (where Site is
        /// defined by the registrable domain), which provides some protection
        /// against cross-site request forgery attacks (CSRF).
        /// It takes three possible values: Strict, Lax, and None.With Strict,
        /// the cookie is sent only to the same site as the one that originated
        /// it; Lax is similar, with an exception for when the user navigates
        /// to a URL from an external site, such as by following a link; None
        /// has no restrictions on cross-site requests.
        /// </summary>
        [JsonProperty(PropertyName = "sameSite")]
        public string SameSite { get; set; }

        /// <summary>
        /// Gets or sets this attribute is used to set persistent cookies. It
        /// signifies how long the browser should use the persistent cookie and
        /// when the cookie should be deleted.
        /// If this attribute is not specified, then the lifetime of the cookie
        /// is the same as that of browser session, i.e.it will be a
        /// non-persistent cookie.
        /// </summary>
        [JsonProperty(PropertyName = "expirationDate")]
        public long? ExpirationDate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Domain == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Domain");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Path == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Path");
            }
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}
