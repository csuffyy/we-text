﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeText.Common.Services
{
    public abstract class Service : DisposableObject, IService
    {

        public abstract void Start(object[] args);
    }
}
