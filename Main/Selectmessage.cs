using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Analysis.Main
{
    [DefaultPropertyAttribute("Name")]
    public class Selectmessage
    {
        private string scheme;
        private string member;
        private string attribute;

        [CategoryAttribute("方案名"), DescriptionAttribute("选择方案的名字")]
        public string Scheme
        {
            get
            {
                return scheme;
            }
            set
            {
                scheme = value;
            }
        }
        [CategoryAttribute("成员"), DescriptionAttribute("选择成员的名字")]
            public string Member
        {
            get
            {
                return member;
            }
            set
            {
                member = value;
            }
        }
            [CategoryAttribute("属性"), DescriptionAttribute("选择属性的名字")]

        public string Attribute
        {
            get
            {
                return attribute;
            }
            set
            {
                attribute = value;
            }
        }


    }
}

