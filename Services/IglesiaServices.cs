using TareaIglesia.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TareaIglesia.Services
{
    public class IglesiaServices
    {
        #region Private members
        private ApplicationDbContext dbContext;
        #endregion

        #region Constructor
        public IglesiaServices(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// This method returns the list of product
        /// </summary>
        /// <returns></returns>
        public async Task<List<Iglesia>> GetHermanoAsync()
        {
            return await dbContext.iglesias.ToListAsync();
        }

        /// <summary>
        /// This method add a new product to the DbContext and saves it
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task<Iglesia> AddHermanoAsync(Iglesia hermano)
        {
            try
            {
                dbContext.iglesias.Add(hermano);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return hermano;
        }

        /// <summary>
        /// This method update and existing product and saves the changes
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task<Iglesia> UpdateHermanoAsync(Iglesia hermano)
        {
            try
            {
                var productExist = dbContext.iglesias.FirstOrDefault(p => p.HermanoID == hermano.HermanoID);
                if (productExist != null)
                {
                    dbContext.Update(hermano);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return hermano;
        }

        /// <summary>
        /// This method removes and existing product from the DbContext and saves it
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task DeleteHermanoAsync(Iglesia hermano)
        {
            try
            {
                dbContext.iglesias.Remove(hermano);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task ListarHermanosAsync(string Nombre)
        {
            await dbContext.iglesias.Where(s => s.Nombre == Nombre).FirstOrDefaultAsync();
            
        }

        #endregion
    }
}
