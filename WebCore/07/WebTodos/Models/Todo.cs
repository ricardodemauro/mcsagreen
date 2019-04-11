﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTodos.Infra;

namespace WebTodos.Models
{
    public class Todo : IDbEntity
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; }

        public bool Done { get; set; }
    }
}
