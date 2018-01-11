using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using FamilyAssistant.Core.Models.Meal;
using FamilyAssistant.Core.Query;
using FamilyAssistant.Extensions;
using FamilyAssistant.Persistence.IRespository.Meal;
using Microsoft.EntityFrameworkCore;

namespace FamilyAssistant.Persistence.Repository.Meal {
    public class VegetableRepository : IVegetableRepository {
        private readonly FaDbContext _context;

        public VegetableRepository (FaDbContext context) {
            this._context = context;
        }

        public async Task<bool> IsDuplicateVegetable (string name) {
            return await _context.Vegetables.AnyAsync (v => v.Name == name);
        }

        public async Task<QueryResult<Vegetable>> GetVegetables (VegetableQuery queryObj) {
            var result = new QueryResult<Vegetable>();
            var query =  _context.Vegetables.AsQueryable();

/*             if (queryObj.VegetableId.HasValue)
                query = query.Where(vege => vege.Id == queryObj.VegetableId);

            if (queryObj.SortBy == "name")
                query = (queryObj.IsSortAscending) ? query.OrderBy(vege => vege.Name) : query.OrderByDescending(vege => vege.Name); */

            var columnsMap = new Dictionary<string, Expression<Func<Vegetable, object>>>()
            {
                ["name"] = v => v.Name,
                ["addedOn"] = v => v.AddedOn,
                ["updatedOn"] = v => v.LastUpdatedByOn
            };
            //columnsMap.Add("make", v => v.Model.Make.Name);
            //query = ApplyOrdering(queryObj, query, columnsMap);
            query = query.ApplyOrdering(queryObj, columnsMap);

            result.TotalItems = await query.CountAsync();

            //query = query.ApplyPaging(queryObj);

            //return await query.ToListAsync();
            result.Items = await query.ToListAsync();

            return result;
        }
        public async Task<Vegetable> GetVegetable (int id) {
            return await _context.Vegetables.SingleOrDefaultAsync (v => v.Id == id);
        }

        public void AddVegetable (Vegetable newVegetable) {
            _context.Add (newVegetable);
        }

        public void Remove (Vegetable existedVegetable) {
            _context.Remove (existedVegetable);
        }

        public async Task<int> GetNumberOfEntreesWithVege (int vegeId) {
            int numberOfEntreeWithVege = -1;

            await _context.LoadStoredProc ("dbo.GetNumberOfEntreeByVegeId")
                .WithSqlParam ("VegeId", vegeId)
                .ExecuteStoredProcAsync ((handler) => {
                    numberOfEntreeWithVege = handler.ReadToValue<int> () ?? default (int);;
                    // do something with your results.
                });

            /*  await _context.LoadSQLText ("SELECT COUNT(*) AS TotalEntrees FROM EntreeVegetable WHERE VegeId = " + vegeId.ToString ())
                 .ExecuteSQLTextAsync ((handler) => {
                     numberOfEntreeWithVege = handler.ReadToValue<int>() ?? default(int);;
                     // do something with your results.
                 }); */

            /*  
             var conn = _context.Database.GetDbConnection();
             await conn.OpenAsync();
             using (var command = conn.CreateCommand())
             {
                 string query = "SELECT COUNT(*) AS TotalEntrees FROM EntreeVegetable WHERE VegeId = " + vegeId.ToString();
                 command.CommandText = query;
                 System.Data.Common.DbDataReader reader = await command.ExecuteReaderAsync();

                 if (reader.HasRows)
                 {
                     while (await reader.ReadAsync())
                     {
                         numberOfEntreeWithVege = reader.GetInt32(0);
                     }
                 }
                 reader.Dispose();
             } 
             conn.Close(); */
            return numberOfEntreeWithVege;
        }
    }
}