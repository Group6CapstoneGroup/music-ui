using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace MusicRecommendation.App.Components
{
    public partial class Login
    {
        protected string UserName { get; set; }

        protected string Password { get; set; }
    }
}
