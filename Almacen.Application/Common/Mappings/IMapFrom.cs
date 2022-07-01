using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Application.Common.Mappings
{
    public interface IMapFrom<TO, TD>
    {
        void Mapping(MappingProfile profile) => profile.CreateMap(typeof(TO), typeof(TD));
    }
}
