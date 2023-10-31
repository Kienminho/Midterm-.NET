using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entity
{
    public class Feature
    {
        public Guid FeatureId { get; set; }
        public string FeatureName { get; set; }
        public double FeaturePrice { get; set; }
    }
}
