﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_CORE.Models {
    public class Produto {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual Categoria categoria { get; set; }
    }
}
