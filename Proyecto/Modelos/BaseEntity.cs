﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Modelos
{
   public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DiaDeCreacion { get; set; }

        public BaseEntity()
        {
            this.DiaDeCreacion = DateTime.Now;
        }

    }
}
