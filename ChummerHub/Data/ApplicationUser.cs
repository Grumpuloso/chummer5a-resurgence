using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Microsoft.AspNetCore.Identity
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'ApplicationUser'
    public class ApplicationUser : IdentityUser<Guid>
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'ApplicationUser'
    {
        /// <summary>
        /// A way for a GM to search for all the characters of "his" group
        /// </summary>
        [PersonalData]
        [Obsolete]
        //[NotMapped]
        [JsonIgnore]
        [XmlIgnore]
        public string Groupname { get; set; }

        private readonly Lazy<HashSet<Guid>> _FavoriteGroups = new Lazy<HashSet<Guid>>();

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'ApplicationUser.FavoriteGroups'
        public HashSet<Guid> FavoriteGroups
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'ApplicationUser.FavoriteGroups'
        => _FavoriteGroups.Value;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'ApplicationUser.ApplicationUser()'
        public ApplicationUser()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'ApplicationUser.ApplicationUser()'
        {
        }
    }
}
