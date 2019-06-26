﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.DotNet.Tools.Uninstall.Shared.BundleInfo;

namespace Microsoft.DotNet.Tools.Uninstall.Shared.Filterers
{
    internal class AllBelowOptionFilterer : ArgFilterer<string>
    {
        public override IEnumerable<Bundle<TBundleVersion>> Filter<TBundleVersion>(string argValue, IEnumerable<Bundle<TBundleVersion>> bundles)
        {
            var specifiedVersion = BundleVersion.FromInput<TBundleVersion>(argValue) as TBundleVersion;

            return bundles
                .Where(bundle => bundle.Version.CompareTo(specifiedVersion) < 0);
        }
    }
}