using System;
using System.Collections.Generic;

namespace FirstDocker.API;

public partial class User
{
    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public int Id { get; set; }

    public string? Emailaddress { get; set; }
}
