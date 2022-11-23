﻿using Homework_EfCore.Database;
using Homework_EfCore.Database.Entities;
using Homework_EfCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Homework_EfCore.Exceptions
{
    public class ObjectException : Exception
    {
        public ObjectException(string objectName) : base("The object hasn't been found")
        {

        }
    }
}
