﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShopApplication.Models
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}