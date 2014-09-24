using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spectrum.DAL
{
    public static class MaterialTypes
    {
        public static List<LU_MaterialType> GetAllMaterialTypes()
        {
            using (var context = new SpectrumDBContext())
            {
                return context.LU_MaterialType.ToList();
            }
        }
    }
}
