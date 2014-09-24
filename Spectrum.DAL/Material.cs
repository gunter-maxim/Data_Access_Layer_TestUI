using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spectrum.DAL
{
    public static class Material
    {
        public static LU_Material GetAllMaterialProperies(int MaterialID)
        {
            using (var context = new SpectrumDBContext())
            {
                return (from m in context.LU_Material where m.MaterialID == MaterialID select m).SingleOrDefault();
            }
        }


        public static List<LU_Material> GetAllMaterials(int MaterialTypeID)
        {
            using (var context = new SpectrumDBContext())
            {
                return (from m in context.LU_Material where m.MaterialTypeID == MaterialTypeID select m).ToList();
            }

        }
    }
}
