using System;
using System.Collections.Generic;

namespace SproutMethod
{
    public class LegacyClass
    {
        public void AppendDictionary<TKey, TValue>(Dictionary<TKey, TValue> fromDict, Dictionary<TKey, TValue> toDict)
        {
            foreach (var item in fromDict)
            {
                toDict.Add(item.Key, item.Value);
            }
        }
    }
}
