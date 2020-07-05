using OnlineGraphQLMicroservice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGraphQLMicroservice.Interfaces
{
    interface IEC3Service
    {
        List<Material> getMaterialList();
    }
}
