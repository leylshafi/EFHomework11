using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EFHomework11.Models;

public class Faculty : BaseEntity
{
    public string? Name { get; set; }



    // Navigation Property
    public List<Group>? Groups { get; set; }
}