﻿using System;
using System.Collections.Generic;

namespace university.Models;

public partial class Teacher
{
    public int TeacherId { get; set; }

    public string Name { get; set; } = null!;

    public string Department { get; set; } = null!;

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
