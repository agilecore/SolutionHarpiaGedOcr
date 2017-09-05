using System.Data.Entity;                                                               
using System.Data.Entity.ModelConfiguration.Conventions;                                
using HarpiaGedOcr.Common;                                                       
                                                                                        
namespace HarpiaGedOcr.Data                                                      
{                                                                                       
    public class HarpiaGedOcrContext : DbContext                         
    {                                                                                   
             public DbSet<ImageDto> Image { get; set; }
             public DbSet<ImageOcrDto> ImageOcr { get; set; }
                                                                                         
        static HarpiaGedOcrContext()                                      
        {                                                                                
             Database.SetInitializer<HarpiaGedOcrContext>(null);          
        }                                                                                
                                                                                         
        public HarpiaGedOcrContext() : base("Name = DefaultConnection") 
        {                                                                                
             this.Configuration.AutoDetectChangesEnabled = true;                         
             this.Configuration.ValidateOnSaveEnabled = false;                           
             this.Configuration.LazyLoadingEnabled = false;                              
             this.Configuration.ProxyCreationEnabled = false;                            
             this.Configuration.UseDatabaseNullSemantics = true;                         
        }                                                                                
                                                                                         
        protected override void OnModelCreating(DbModelBuilder ModelBuilder)             
        {                                                                                
             ModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();          
        }                                                                                
    }                                                                                    
}                                                                                        

