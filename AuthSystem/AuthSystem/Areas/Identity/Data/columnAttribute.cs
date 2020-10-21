using System;

namespace AuthSystem.Areas.Identity.Data
{
    internal class columnAttribute : Attribute
    {
        public object TypeName { get; set; }
    }
}