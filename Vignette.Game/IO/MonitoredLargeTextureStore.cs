// Copyright 2020 - 2021 Vignette Project
// Licensed under NPOSLv3. See LICENSE for details.

using System.Collections.Generic;
using System.Threading.Tasks;
using osu.Framework.Graphics.Textures;
using osu.Framework.Platform;

namespace Vignette.Game.IO
{
    public class MonitoredLargeTextureStore : MonitoredResourceStore
    {
        private LargeTextureStore largeTextureStore;

        public MonitoredLargeTextureStore(GameHost host, Storage underlyingStorage, IEnumerable<string> filters = null)
            : base(underlyingStorage, filters)
        {
            largeTextureStore = new LargeTextureStore(host.CreateTextureLoaderStore(UnderlyingStore));
        }

        public new Texture Get(string name)
            => largeTextureStore.Get(name);

        public new Task<Texture> GetAsync(string name)
            => largeTextureStore.GetAsync(name);
    }
}
