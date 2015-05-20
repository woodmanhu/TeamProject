using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SEIS752Team1Project.Models
{
    public class SEIS752Team1ProjectContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SEIS752Team1ProjectContext() : base("name=SEIS752Team1ProjectContext")
        {
        }

        public System.Data.Entity.DbSet<SEIS752Team1Project.Models.Event> Events { get; set; }
    
    }
}
