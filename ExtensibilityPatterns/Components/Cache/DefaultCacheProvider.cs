using System;
using System.Collections.Generic;
using System.Linq;
using ExtensibilityPatterns.Common.Interfaces;
using Microsoft.Framework.Caching.Memory;

namespace SearchEng.Extensions.Components.Cache
{
    public class DefaultCacheProvider : ICacheProvider
    {
      private  MemoryCache cache = new MemoryCache(new MemoryCacheOptions());

        public object Get(string key)
        {
            return cache.Get(key);
        }

        public void Set(string key, object data, int cacheTime)
        {
            cache.Set(key,data);
        }

        public bool IsSet(string key)
        {
            return (cache.Get(key) != null);
        }

        public void Invalidate(string key)
        {
            cache.Remove(key);
        }

    }
}