using System;
using System.Collections.Generic;
using System.Text;

namespace ADVC_01
{
    internal class Cache<Tkey, TValue> where Tkey : notnull
    {

        private class CacheItem
        {
            public TValue Value { get; set; }
            public DateTime ExpiresAt { get; set; }

            public CacheItem(TValue value, DateTime expiresAt)
            {
                Value = value;
                ExpiresAt = expiresAt;
            }
        }


        private readonly Dictionary<Tkey, CacheItem> _Cache = new();

        public void Add(Tkey key, TValue value, TimeSpan expiration)
        {

            DateTime expirationTime = DateTime.Now.Add(expiration);
            CacheItem item = new CacheItem(value, expirationTime);

            _Cache[key] = item;

        }

        public TValue Get(Tkey key)
        {
            if (!_Cache.TryGetValue(key, out CacheItem? item))
            {

                throw new KeyNotFoundException("Key was not found in the cache.");


            }
            if (DateTime.Now >= item.ExpiresAt)
            {
                _Cache.Remove(key);
                throw new KeyNotFoundException("The cache item has expired.");
            }

            return item.Value;
        }

        public bool Remove(Tkey key)
        {
            return _Cache.Remove(key);
        }

        public bool Contains(Tkey key)
        {
            if (!_Cache.TryGetValue(key, out CacheItem? item))
            {
                return false;
            }
            if (DateTime.Now >= item.ExpiresAt)
            {
                _Cache.Remove(key);
                return false;
            }
            return true;
        }



    }

}
