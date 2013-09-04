﻿using System;
using System.Collections.Generic;

namespace RavenOverflow.Core.Entities
{
    public class User : RootAggregate
    {
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedOn { get; set; }
        public int Score { get; set; }
        public IList<OAuthData> OAuthData { get; set; }
        public IList<string> FavoriteTags { get; set; }
        public bool IsActive { get; set; }
    }
}