using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace WisejWebApplication3.Services
{
    public class StaffService
    {
        public static async Task<List<Staff>> GetStaffs(int orgId)
        {
            using (var context = new MyDbContext()) {
            
                return await context.Staffs
                    .Where(staff => staff.OrganizationId == orgId)
                    .ToListAsync();
            }
        }

        public static async Task AddStaff(Staff staff)
        {
            using (var context = new MyDbContext())
            {
                context.Staffs.Add(staff);
                await context.SaveChangesAsync();
            }
        }

        public static async Task RemoveStaff(int id)
        {
            using (var context = new MyDbContext())
            {
                Staff staff = await context.Staffs.FindAsync(id);
                if (staff == null)
                {
                    throw new ArgumentException($"Could not remove staff. Staff with ID {id} not found");
                }
                context.Staffs.Remove(staff);
                await context.SaveChangesAsync();
            }
        }

        public static async Task EditStaff(int id, Staff updatedStaff)
        {
            using (var context = new MyDbContext())
            {
                Staff staff = await context.Staffs.FindAsync(id);
                if (staff == null)
                {
                    throw new ArgumentException($"Could not edit staff. Staff with ID {id} not found");
                }
                // TODO: Figure out better way to update organization; this will not work if more fields are added
                staff.FirstName = updatedStaff.FirstName;
                staff.LastName = updatedStaff.LastName;
                staff.Title = updatedStaff.Title;
                staff.PhoneNumber = updatedStaff.PhoneNumber;
                staff.Email = updatedStaff.Email;
                await context.SaveChangesAsync();
    }
        }

    }
}
