﻿using Aguacongas.IdentityServer.Store.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Aguacongas.TheIdServer.BlazorApp.Components.ApiComponents
{
    public partial class ApiSecrets
    {
        private IEnumerable<ApiSecret> Secrets => Collection.Where(s => (s.Description != null && s.Description.Contains(HandleModificationState.FilterTerm)) || (s.Type != null && s.Type.Contains(HandleModificationState.FilterTerm)));
    }
}
