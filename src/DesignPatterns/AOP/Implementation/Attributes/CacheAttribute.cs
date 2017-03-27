using System;

namespace DesignPatterns.AOP.Implementation.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class CacheAttribute : Attribute
    {
        public CacheAttribute()
        {

        }
    }
}
