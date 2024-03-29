﻿using System;
using System.Linq;

namespace Common
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var memberInfo = value.GetType().GetMember(value.ToString());
            if (memberInfo != null && memberInfo.Length > 0)
            {
                var _Attribs = memberInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                if (_Attribs != null && _Attribs.Count() > 0)
                    return ((System.ComponentModel.DescriptionAttribute)_Attribs.ElementAt(0)).Description;
            }
            return value.ToString();
        }
    }
}
