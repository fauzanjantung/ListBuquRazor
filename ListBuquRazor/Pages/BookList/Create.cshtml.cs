﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListBuquRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ListBuquRazor
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public Book Book { get; set; }

        public void OnGet()
        {

        }
    }
}