﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFHomework11.Models;

public class Category : BaseEntity
{
    public string? Name { get; set; }


    // Navigation Property
    public List<Book>? Books { get; set; }
}
