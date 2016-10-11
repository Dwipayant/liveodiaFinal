﻿using LiveOdiaGit.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LiveOdiaGit.Controllers
{
    public class homeController : ApiController
    {
        // GET: api/home
        public DataTable Get()
        {
            return dbutility.getAllTopStory();
        }

        public DataTable Get(int id)
        {
            return dbutility.getTopNewsById(id);
        }

        // GET: api/home/5
        // POST: api/home
        public bool Post(AdminModel value)
        {
            return dbutility.addNewCategory(value);
        }

        // DELETE: api/home/5
        public void Delete(int id)
        {
        }
    }
}
