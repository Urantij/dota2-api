using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dota2Api.ApiClasses
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Localized_name { get; set; }
    }
}
