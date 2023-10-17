using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Odontogest.Models
{

    
    public class filters
    {
        private odontogestContext _context;
        private void drownCategori(object selecCategory = null)
        {
            var categoria = from d in _context.Categories
                            orderby d.NameCategory
                            select d;

           var category = new SelectList(categoria.AsNoTracking(),
                nameof(Category.IdCategory),
                nameof(Category.NameCategory),
                selecCategory);
            
        }

        private void drownStore(object Selectstories = null)
        {
            var stories = from d in _context.Stores
                          orderby d.NameStore
                          select d;

            var store = new SelectList(stories.AsNoTracking(),
                nameof(Store.IdStore),
                nameof(Store.NameStore),
                Selectstories);
          
        }
    }
}
