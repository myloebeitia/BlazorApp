using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schiavello.Data
{
    public class ListServices
    {
        #region Private members
        private ListDbContext dbContext;
        #endregion

        #region Constructor
        public ListServices(ListDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// This method returns the list of List
        /// </summary>
        /// <returns></returns>
        public async Task<List<List>> GetListAsync()
        {
            return await dbContext.List.ToListAsync();
        }
        public async Task<List<List>> SortListAsync(Boolean sort)
        {
            if(sort == true)
            {
                return await dbContext.List.OrderByDescending(a => a.Status).ToListAsync();

            }
            else
            {
                return await dbContext.List.OrderBy(a => a.Status).ToListAsync();

            }
        }
        /// <summary>
        /// This method add a new List to the DbContext and saves it
        /// </summary>
        /// <param name="List"></param>
        /// <returns></returns>
        public async Task<List> AddListAsync(List List)
        {
            try
            {
                List.Status = "Active";
                dbContext.List.Add(List);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return List;
        }

        /// <summary>
        /// This method update and existing List and saves the changes
        /// </summary>
        /// <param name="List"></param>
        /// <returns></returns>
        public async Task<List> UpdateListAsync(List List)
        {
            try
            {
                var ListExist = dbContext.List.FirstOrDefault(p => p.Id == List.Id);
                if (ListExist != null)
                {
                    dbContext.Update(List);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return List;
        }

        /// <summary>
        /// This method removes and existing List from the DbContext and saves it
        /// </summary>
        /// <param name="List"></param>
        /// <returns></returns>
        public async Task DeleteListAsync(List List)
        {
            try
            {
                dbContext.List.Remove(List);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List> CompleteListAsync(List List)
        {
            try
            {
                var ListExist = dbContext.List.FirstOrDefault(p => p.Id == List.Id);
                if (ListExist != null)
                {
                    List.Status = "Completed";
                    dbContext.Update(List);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return List;
        }
        #endregion
    }
}
