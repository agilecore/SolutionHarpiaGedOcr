using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarpiaGedOcr.Data;

namespace HarpiaGedOcr.Data
{
    public class UnitOfWork                                                                                
    {                                                                                                      
        private HarpiaGedOcrContext _dbContext = new HarpiaGedOcrContext();  
        public Type _type { get; set; }                                                                    
        public Repository<TEntityType> GetRepository<TEntityType>() where TEntityType : class              
        {                                                                                                  
            return (new Repository<TEntityType>(this._dbContext));                                         
        }                                                                                                  
        public void SaveChage()                                                                            
        {                                                                                                  
            _dbContext.SaveChanges();                                                                      
        }                                                                                                  
        public void SaveChageAsync()                                                                       
        {                                                                                                  
            _dbContext.SaveChangesAsync();                                                                 
        }                                                                                                  
    }                                                                                                      
}                                                                                                          

