﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpirAtheneum.Interfaces
{
   public interface IDatabaseConnection
    {
        SQLite.SQLiteConnection DbConnection();
    }
}
