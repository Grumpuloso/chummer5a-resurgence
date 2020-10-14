using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace ChummerHub.Models.V1
{
    public class SINSearchGroupResult
    {
        public List<string> Roles { get; set; }

        public ChummerHubVersion Version { get; set; }

        public SINSearchGroupResult()
        {
            SINGroups = new List<SINnerSearchGroup>();
            Roles = new List<string>();
            Version = new ChummerHubVersion();
        }
        public List<SINnerSearchGroup> SINGroups { get; set; }

        public string ErrorText { get; set; }
    }

    public class SINnerSearchGroup : SINnerGroup
    {

        public List<SINnerSearchGroup> MySINSearchGroups { get; set; }
        public string ErrorText { get; set; }
        public List<SINnerSearchGroupMember> MyMembers { get; set; }
        public bool IsFavorite { get; set; }
        public SINnerSearchGroup()
        {
            MyMembers = new List<SINnerSearchGroupMember>();
            MyGroups = new List<SINnerGroup>();
            MySINSearchGroups = new List<SINnerSearchGroup>();
        }
        public SINnerSearchGroup(SINnerGroup groupbyname, ApplicationUser user)
        {
            MyParentGroupId = groupbyname?.MyParentGroupId;
            Id = groupbyname?.Id;
            if (groupbyname != null)
                IsPublic = groupbyname.IsPublic;
            Groupname = groupbyname?.Groupname;
            MyMembers = new List<SINnerSearchGroupMember>();
            MyGroups = new List<SINnerGroup>();
            MySINSearchGroups = new List<SINnerSearchGroup>();
            MyAdminIdentityRole = groupbyname?.MyAdminIdentityRole;
            Language = groupbyname?.Language;
            PasswordHash = groupbyname?.PasswordHash;
            MySettings = groupbyname?.MySettings;
            HasPassword = PasswordHash?.Length > 0;
            IsFavorite = user != null && Id != null && user.FavoriteGroups.Contains(Id.Value);
        }

    }

    public class SINnerSearchGroupMember
    {
        public SINner MySINner { get; set; }
        public string Username { get; set; }
        public bool IsFavorite { get; set; }

        public SINnerSearchGroupMember(ApplicationUser user, SINner member)
        {
            //if (user == null)
            //    throw new ArgumentNullException(nameof(user));
            Username = user?.UserName;
            MySINner = member ?? throw new ArgumentNullException(nameof(member));
            IsFavorite = user != null && MySINner.Id != null && user.FavoriteGroups.Contains(MySINner.Id.Value);
        }
        public SINnerSearchGroupMember()
        {
            MySINner = new SINner();
        }

    }

}

