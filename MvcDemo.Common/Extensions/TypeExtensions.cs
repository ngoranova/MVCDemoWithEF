﻿using System;

namespace MvcDemo.Common.Extensions
{
    public static class TypeExtensions
    {
        public static bool GenericEq(this Type type, Type toCompare)
        {
            return type.Namespace == toCompare.Namespace && type.Name == toCompare.Name;
        }
    }
}
